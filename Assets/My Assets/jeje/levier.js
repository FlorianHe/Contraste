#pragma strict
var position = false;
var anim : Animation;

function OnTriggerStay(objetInfo : Collider)
{
	if (Input.GetKeyDown(KeyCode.Mouse0) && position == false)
	{
		position = true;
		GetComponent.<Animation>().Play("levier");
	}
}