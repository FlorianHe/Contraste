#pragma strict

var pathPoint : Transform[];	private var speed = 5;
private var currentPathPoint : int;

function Awake(){ pathPoint[0] = transform;}
function Update(){

if(currentPathPoint < pathPoint.length){

var chemin : Vector3 = pathPoint[currentPathPoint].position;
var movingTo : Vector3 = chemin - transform.position;
var velocity = GetComponent.<Rigidbody>().velocity;

if(movingTo.magnitude < 1){currentPathPoint++;}
else { velocity = movingTo.normalized * speed;}
}
else {velocity = Vector3.zero;}
GetComponent.<Rigidbody>().velocity = velocity; transform.LookAt(chemin);
}