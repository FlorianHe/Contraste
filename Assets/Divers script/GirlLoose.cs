using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Seeker))]
public class GirlLoose : AIPath {

	/** Animation component.
	 * Should hold animations "awake" and "forward"
	 */
	public Animation anim;
		
	/** Minimum velocity for moving */
	public float sleepVelocity = 0.4F;
	
	/** Speed relative to velocity with which to play animations */
	public float animationSpeed = 0.2F;
	
	/** Effect which will be instantiated when end of path is reached.
	 * \see OnTargetReached */
	public GameObject endOfPathEffect;
	
	public new void Start () {
		
		//Prioritize the walking animation
		anim["Walk"].layer = 10;
		
		//Play all animations
		//anim.Play ("awake");
		anim.Play ("Walk");
		GetComponent<AudioSource>().Play ();
		
		//Setup awake animations properties
		//anim["awake"].wrapMode = WrapMode.Clamp;
		//anim["awake"].speed = 0;
		//anim["awake"].normalizedTime = 1F;
		
		//Call Start in base script (AIPath)
		base.Start ();
	}
	
	/** Point for the last spawn of #endOfPathEffect */
	protected Vector3 lastTarget;
	
	/**
	 * Called when the end of path has been reached.
	 * An effect (#endOfPathEffect) is spawned when this function is called
	 * However, since paths are recalculated quite often, we only spawn the effect
	 * when the current position is some distance away from the previous spawn-point
	*/
	public override void OnTargetReached () {
		
		if (endOfPathEffect != null && Vector3.Distance (tr.position, lastTarget) > 1) {
			GameObject.Instantiate (endOfPathEffect,tr.position,tr.rotation);
			lastTarget = tr.position;
		}
	}
	
	public override Vector3 GetFeetPosition ()
	{
		return tr.position;
	}
	
	protected new void Update () {
		
		//Get velocity in world-space
		Vector3 velocity;
		if (canMove) {
		
			//Calculate desired velocity
			Vector3 dir = CalculateVelocity (GetFeetPosition());
			//transform.rotation.y = transform.rotation.y - 180;
			//Rotate towards targetDirection (filled in by CalculateVelocity)
			if (targetDirection != Vector3.zero) {
				RotateTowards (targetDirection);
			}
			
			if (dir.sqrMagnitude > sleepVelocity*sleepVelocity) {
				//If the velocity is large enough, move
			} else {
				//Otherwise, just stand still (this ensures gravity is applied)
				dir = Vector3.zero / 2;
			}
			
			if (navController != null)
				navController.SimpleMove (GetFeetPosition(), dir);
			else if (controller != null)
				controller.SimpleMove (dir);
			else
				Debug.LogWarning ("No NavmeshController or CharacterController attached to GameObject");
			
			velocity = controller.velocity;
		} else {
			velocity = Vector3.zero;
		}
		
		
		//Animation
		
		//Calculate the velocity relative to this transform's orientation
		Vector3 relVelocity = tr.InverseTransformDirection (velocity);
		
		if (velocity.sqrMagnitude <= sleepVelocity*sleepVelocity) {
			//Fade out walking animation
			anim.Blend ("Walk",0,0.2F);
			GetComponent<AudioSource>().mute = true;
		} else {
			//Fade in walking animation
			anim.Blend ("Walk",1,0.2F);
			GetComponent<AudioSource>().mute = false;
			
			//Modify animation speed to match velocity
			AnimationState state = anim["Walk"];
			
			float speed = relVelocity.z;
			state.speed = speed*animationSpeed;
		}
	}
}
