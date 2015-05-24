var x1 = 0f;
var x2 = 0f;
var z1 = 0f;
var z2 = 0f;
var AGirl : Transform;

function Update () 
{
	if ((AGirl.position.z > z1) &&(AGirl.position.z < z2) && (AGirl.position.x > x1) && (AGirl.position.x < x2))
	{
		transform.position.y = -21;
	}
}