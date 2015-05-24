using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {
	public 	GameObject		menu;
	public	GameObject		repr;
	public	GameObject		lum;
	public	MonoBehaviour	AS;
	public	MonoBehaviour	light;
	public	MonoBehaviour	monstre;
	public	GameObject[]	text;
	int						i = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			repr.GetComponent<OnclickMenuPause>().go = false;
			Pause ();
		}
		if (repr.GetComponent<OnclickMenuPause>().go == true)
		{
			Go ();
		}
	}
	void		Pause()
	{
		i = 0;
		while (i < 13)
			{
				text[i].transform.localScale = new Vector3(0,0,0);
				i = i + 1;
			}
			this.GetComponent<MouseLook>().enabled = false;
			lum.GetComponent<MouseLook>().enabled = false;
			monstre.enabled = false;
			light.enabled = false;
			menu.active = true;
			AS.enabled = false;
	}
	void		Go()
		{
		i = 0;
		while (i < 13)
			{
				text[i].transform.localScale = new Vector3(1,1,1);
				i = i + 1;
			}
		this.GetComponent<MouseLook>().enabled = true;
		lum.GetComponent<MouseLook>().enabled = true;
		monstre.enabled = true;
		light.enabled = true;
		menu.active = false;
		AS.enabled = true;
	}
}
