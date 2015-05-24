#pragma strict

var pathPoint : Transform[];	var speed : int;
var pos : int;
var zone : int;
private var moveDirection : Vector3;
private var dirToMain : Vector3;
private var posgirl : Vector3;
private var currentPathPoint : int;
private var test = 1;
function Awake()
	{ pathPoint[0] = transform;}
function Update()
{
	if(currentPathPoint < pathPoint.length)
		{
			dirToMain = GameObject.Find("AGirl").transform.position - transform.position;			
			posgirl = dirToMain;
			var chemin : Vector3 = pathPoint[currentPathPoint].position;
			var movingTo : Vector3 = chemin - transform.position;
			var velocity = GetComponent.<Rigidbody>().velocity;

		if (dirToMain.magnitude < zone)
			{
				if (dirToMain.magnitude > pos)
				{ 
					movingTo = dirToMain * 0.5;
					transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.LookRotation(dirToMain), 10);
					speed = 20;
				}
			}
		if (movingTo.magnitude < 1)
			{currentPathPoint++;}
		else 
			{ velocity = movingTo.normalized * speed;}
		}
	else
		{
		if (test == 1)
			{currentPathPoint = 0;}
		else
			velocity = Vector3.zero;
		}
	GetComponent.<Rigidbody>().velocity = velocity; transform.LookAt(chemin);
}