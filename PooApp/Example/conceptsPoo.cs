namespace Example;

public class Personne
{
    private string nom;
    private DateOnly dateDeNaissance;

    public Personne(string nom, DateOnly dateDeNaissance)
    {
        this.nom = nom;
        this.dateDeNaissance = dateDeNaissance;
    }

    public override string ToString()
    {
        return $"Nom: {nom} - Date de Naissance: {dateDeNaissance}";
    }

    public void Afficher()
    {
        Console.WriteLine(ToString());
    }
}

public class Eleve : Personne
{
    private string identifiantClasse;

    public Eleve(string name, DateOnly dateDeNaissance, string classId)
        : base(name, dateDeNaissance)
    {
        identifiantClasse = classId;
    }

    public override string ToString()
    {
        return $"Eleve: ({base.ToString()} - Classe: {identifiantClasse})";
    }
}

public class Professeur : Personne
{
    private string matiere;

    public Professeur(string name, DateOnly dateDeNaissance, string matiere)
            : base(name, dateDeNaissance)
    {
        this.matiere = matiere;
    }

    public override string ToString()
    {
        return $"Professeur: ({base.ToString()} - Matiere: {matiere})";
    }
}

static class ConceptPoo
{
    public static void Main()
    {
        List<Personne> personnes = [
            new Professeur("John", new DateOnly(1972, 1, 24), "Math"),
            new Professeur("Jane", new DateOnly(1982, 7, 7), "Anglais"),
            new Eleve("Toto", new DateOnly(2008, 1, 14), "3G2"),
            new Eleve("Titi", new DateOnly(2008, 9, 12), "3G2"),
        ];

        foreach (Personne personne in personnes)
        {
            personne.Afficher();
        }
    }
}
