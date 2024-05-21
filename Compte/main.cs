using System;

Compte cpt = new Compte("ABCDE67890", 50000);
cpt.AjouterMontant(12000);
cpt.AfficherCompte();
cpt.DeduireMontant(7000);
cpt.AfficherCompte();

class Compte
{
  string idCompte;
  long montantEnCentimes;

  public Compte(string idCompte, long montantEnCentimes)
  {
    this.idCompte = idCompte;
    this.montantEnCentimes = montantEnCentimes;
  }

  public void AjouterMontant(long montantEnCentimes)
  {
    this.montantEnCentimes += montantEnCentimes;
  }

  public void DeduireMontant(long montantEnCentimes)
  {
    this.montantEnCentimes -= montantEnCentimes;
  }

  public void AfficherCompte()
  {
    Console.WriteLine($"Compte id: {idCompte} - Montant: {montantEnCentimes}");
  }
}
