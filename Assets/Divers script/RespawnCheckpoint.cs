using UnityEngine;
using System.Collections;

public class RespawnCheckpoint : MonoBehaviour {
	public GameObject	checkpt;
	public GameObject	checkpt2;
	public GameObject	girl;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
			StartCoroutine(checkpts(other));
		}
	IEnumerator checkpts(Collider other){
				checkpt.GetComponent<Light>().enabled = false;
				checkpt2.GetComponent<Light>().enabled = true;
				girl.GetComponent<CrazyGirl>().target2 = checkpt2;
			yield return new WaitForSeconds(0.2F);
		}
}
