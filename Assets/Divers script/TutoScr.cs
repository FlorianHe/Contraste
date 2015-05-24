using UnityEngine;
using System.Collections;

public class TutoScr : MonoBehaviour {
	public GameObject	tuto;
	public GameObject	text1;
	public GameObject	text2;
	public GameObject	text3;
	public GameObject	text4;
	public GameObject	text5;
	public int			i;
	public float activateTime = 0.2F;
	public Color 		gr = Color.green;
	private int kin = 0;
	// Use this for initialization
	void change_col()
	{
		this.GetComponent<Light>().color = Color.green;
	}
	
	void Update ()
	{
		
	}
		void OnTriggerEnter(Collider other)
		{
			StartCoroutine(lumtuto(other));
		}
	
		IEnumerator lumtuto(Collider other)
		{
			change_col();
			if (i == 0 && kin == 0){
				tuto.active = true;
				text1.active = false;
				text2.active = false;
				text3.active = false;
				text4.active = false;
				text5.active = true;
				kin = 1;
		}
			else if (i == 1 && kin == 0){
				tuto.active = false;
				text1.active = false;
				text2.active = true;
				kin = 1;
		}
			yield return new WaitForSeconds(activateTime);
		}
}
