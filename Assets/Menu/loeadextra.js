#pragma strict

function OnMouseEnter()
{
	GetComponent.<AudioSource>().Play();
}

function OnMouseDown()
{
Application.LoadLevel("extra");
}