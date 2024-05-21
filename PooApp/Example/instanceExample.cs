namespace Example;

//Création d'une classe Joueur
class Joueur {
	//attributs
	string nom;
	int nbPoints;
	
	//constructeur
	public Joueur(string nom, int nbPoints) {
		this.nom = nom;
		this.nbPoints = nbPoints;
	}
	
	//méthode
	public void Afficher() {
		System.Console.WriteLine($"Nom du joueur: {nom} - Nombre de points: {nbPoints}");
	}
}

static class InstanceExample
{
	public static void Main()
	{
        //Création d'un objet Joueur
        Joueur toto = new Joueur("Toto", 25);
        toto.Afficher();
    }
}

