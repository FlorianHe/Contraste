using UnityEngine;
using System.Collections;

public class OnclickMenuPause : MonoBehaviour {
	public	bool		go = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void	OnMouseDown()
	{
		go = true;
	}
}
