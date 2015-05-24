using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {
	GameObject lum = null;
	void Update () {
		if (lum == null)
			lum = GameObject.Find("Light");
        if (Input.GetKeyDown(KeyCode.I))
           	lum.GetComponent<Light>().enabled = true;
        else if (Input.GetKeyDown(KeyCode.O))
            lum.GetComponent<Light>().enabled = false;
    }
}
