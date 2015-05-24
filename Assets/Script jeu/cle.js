#pragma strict
var joueur : Transform;
var scriptTarget:joueurcle;
var p1 : GameObject;
var p2 : GameObject;
var p3 : GameObject;
function OnTriggerEnter(objetInfo : Collider)
{
    scriptTarget.cle = true;
    Destroy(gameObject);
    p1.active = true;
    p2.active = true;
    p3.active = true;
}