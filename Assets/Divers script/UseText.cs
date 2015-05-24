using UnityEngine;
using System.Collections;

public class UseText : MonoBehaviour {
	public GameObject	Text1;
	public int			i;
	int j = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other)
		{
			StartCoroutine(lumtuto(other));
		}
	
		IEnumerator lumtuto(Collider other)
		{
		if (i == 0) {
			Text1.active = false;
		}
		else if (i == 1 && j == 0){
			Text1.active = true;
			j = 1;
		}
			yield return new WaitForSeconds(0.2F);
		}
}
