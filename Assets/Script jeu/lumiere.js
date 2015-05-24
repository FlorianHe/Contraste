var min = 0.25f;
var max = 0.5f;
var minr = 30;
var maxr = 90;
var mina = 45;
var maxa = 65;
var duration : float = 1.0;
var color0 : Color = Color.red;
var color1 : Color = Color.blue;
var color2 : Color = Color(0.5, 0, 0, 1);
var aleatoire;
var joueur : Transform;
var r = 1.0f;
 
private var random : float;
random = Random.Range(0.0f, 65535.0f);

function colere()
{
	GetComponent.<Light>().color = Color.red;
	color0 = Color.red;
	//color1 = color2;
}

function Update()
{
	aleatoire = Mathf.PerlinNoise(random, Time.time);
	GetComponent.<Light>().intensity = Mathf.Lerp(min, max, aleatoire);
	GetComponent.<Light>().range = Mathf.Lerp(minr, maxr, aleatoire);
	GetComponent.<Light>().spotAngle = Mathf.Lerp(mina, maxa, aleatoire);
	var t : float = Mathf.PingPong (Time.time, duration) / duration;
	GetComponent.<Light>().color = Color.Lerp (color0, color1, t);
	
//ici la condition pour changer la couleur pour l'instant c'est un cas de chute dans le vide	
	if (joueur.position.y < -3)
	{
		colere();
	}
}

