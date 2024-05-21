#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct
{
  char idCompte[11];
  long montantEnCentimes;
} Compte;

Compte *creerCompte(char idCompte[11], long montantEnCentimes)
{
  Compte *compte = malloc(sizeof(Compte));
  strncpy(compte->idCompte, idCompte, 11);
  compte->montantEnCentimes = montantEnCentimes;
  return compte;
}

void ajouterMontant(Compte *compte, long montantEnCentimes)
{
  compte->montantEnCentimes += montantEnCentimes;
}

void deduireMontant(Compte *compte, long montantEnCentimes)
{
  compte->montantEnCentimes -= montantEnCentimes;
}

void afficherCompte(Compte *compte)
{
  printf("Compte id: %s - Montant: %ld\n", compte->idCompte, compte->montantEnCentimes);
}

int main()
{
  Compte *cpt = creerCompte("ABCDE67890", 50000);
  ajouterMontant(cpt, 12000);
  afficherCompte(cpt);
  deduireMontant(cpt, 7000);
  afficherCompte(cpt);

  free(cpt);
  return 0;
}
