using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {
	public GameObject	end;
	public float activateTime = 5F;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other)
		{
			StartCoroutine(endcam(other));
		}
	
		IEnumerator endcam(Collider other)
		{
			end.active = true;
			yield return new WaitForSeconds(5);
			Application.LoadLevel("Credit");
		}
}
