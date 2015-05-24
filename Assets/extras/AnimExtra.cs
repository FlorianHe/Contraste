using UnityEngine;
using System.Collections;

public class AnimExtra : MonoBehaviour {
	public Animation anim;
	public AudioSource audio;
	public float sleepVelocity = 0.4F;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKey == false){
			audio.mute = true;
			anim.Stop("Walk");
		}
		else{
			audio.mute = false;
			anim.Play("Walk");
		}
 	}
}
