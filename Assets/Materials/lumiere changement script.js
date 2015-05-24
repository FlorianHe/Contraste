var min = 0.35f;
var max = 0.6f;
var minr = 50;
var maxr = 150;
var mina = 50;
var maxa = 70;
var aleatoire;
  
private var random : float;
random = Random.Range(0.0f, 65535.0f);

function Update()
	{
     aleatoire = Mathf.PerlinNoise(random, Time.time);
     GetComponent.<Light>().intensity = Mathf.Lerp(min, max, aleatoire);
     GetComponent.<Light>().range = Mathf.Lerp(minr, maxr, aleatoire);
     GetComponent.<Light>().spotAngle = Mathf.Lerp(mina, maxa, aleatoire);
 	}