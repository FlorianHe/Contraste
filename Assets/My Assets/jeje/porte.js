#pragma strict
var joueur : Transform;
var scriptTarget:joueurcle;

function OnTriggerEnter(objetInfo : Collider)
{
    if (scriptTarget.cle == true)
    {
    	transform.position.y = 11;
	}
}