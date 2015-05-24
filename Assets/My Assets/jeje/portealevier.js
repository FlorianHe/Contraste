var scriptTarget1:levier;
var scriptTarget2:levier;
var scriptTarget3:levier;
var Text : GameObject;

function Update()
{
	if (scriptTarget1.position == true || scriptTarget2.position == true || scriptTarget3.position == true)
		Text.SetActive(false);
    if (scriptTarget1.position == true && scriptTarget2.position == true && scriptTarget3.position == true)
    {
    	transform.position.y = 11;
	}
}