var cible : Transform;

function Start () {

}

function Update () 
{
	if ((transform.position.y < -5))
	{
		transform.position = cible.position;
	}
}
