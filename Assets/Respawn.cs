using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour
{
	public	Transform	girl;
	public	Transform	light;

	void OnTriggerEnter(Collider other)
			{
		if (other.tag == "Player")
			StartCoroutine(respa(other));
			}
		IEnumerator respa(Collider other)
			{
				yield return new WaitForSeconds(0.5F);
				girl.position = new Vector3(110.5F,-2.8F,86);
				light.position = new Vector3(110.5F,0,86);
				yield return new WaitForSeconds(0.2F);
			}
}
