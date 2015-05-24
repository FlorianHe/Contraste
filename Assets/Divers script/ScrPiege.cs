using UnityEngine;
using System.Collections;

public class ScrPiege : MonoBehaviour {
	public GameObject	trap;
	public GameObject	target;
	public GameObject	collide;
	public float activateTime = 0.2F;
	private int kin;
	// Use this for initialization
	void Update ()
	{
		if (trap.transform.position.y <= -3.5){
			trap.GetComponent<Rigidbody>().isKinematic = true;
			collide.active = true;
			
		}
	}
		void OnTriggerEnter(Collider other)
		{
			StartCoroutine(activategrav(other));
		}
	
		IEnumerator activategrav(Collider other)
		{
			trap.GetComponent<Rigidbody>().useGravity = true;
			yield return new WaitForSeconds(activateTime);
		}
}