using UnityEngine;
using System.Collections;

public class CrazyGirl : MonoBehaviour {
	public GameObject	light;
	public GameObject	target;
	public GameObject	target2;
	public GameObject	text;
	public GameObject	text2;
	public AudioSource	coeur;
	public float activateTime = 0.2F;
	int i;
	public float x;
	public float z;
	public int range;
	// Use this for initialization
	void Start () {
		x = light.transform.position.x - target.transform.position.x;
		z = light.transform.position.z - target.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		x = light.transform.position.x - target.transform.position.x;
		z = light.transform.position.z - target.transform.position.z;
		if (x <= 0)
			x = x * -1;
		if (z <= 0)
			z = z * -1;
		if (z >= range || x >= range) {
			if (i == 0) {
				text.active = true;
				i = 1;
			}
			else
				text2.active = true;
			coeur.mute = false;
			target.GetComponent<GirlLoose>().enabled = true;
			target.GetComponent<GirlBotAI>().enabled = false;
			target.GetComponent<GirlLoose>().target = target2.transform;
			target.GetComponent<GirlLoose>().canSearch = true;
			target.GetComponent<GirlBotAI>().target = null;
		}
		else
		{
			text.active = false;
			text2.active = false;
			coeur.mute = true;
			target.GetComponent<GirlLoose>().enabled = false;
			target.GetComponent<GirlBotAI>().enabled = true;
			target.GetComponent<GirlLoose>().target = null;
			target.GetComponent<GirlBotAI>().target = light.transform;
			target.GetComponent<GirlBotAI>().canSearch = true;
		}
	}
}
