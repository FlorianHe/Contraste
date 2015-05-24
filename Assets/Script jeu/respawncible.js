var joueur : Transform;
var x1 = 0f;
var x2 = 0f;
var z1 = 0f;
var z2 = 0f;
var xrespawn = 0f;
var yrespawn = 0f;
var zrespawn = 0f;

function Start () {

}

function Update () 
{
	if ((joueur.position.z > z1) &&(joueur.position.z < z2) && (joueur.position.x > x1) && (joueur.position.x < x2))
	{
		transform.position = Vector3(xrespawn, yrespawn, zrespawn);
	}
}