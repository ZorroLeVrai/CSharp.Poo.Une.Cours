from dataclasses import dataclass

@dataclass
class Compte:
    idCompte: str
    montantEnCentimes: int

def ajouterMontant(compte: Compte, montantEnCentimes: int):
    compte.montantEnCentimes += montantEnCentimes

def deduireMontant(compte: Compte, montantEnCentimes: int):
    compte.montantEnCentimes -= montantEnCentimes

def afficherCompte(compte: Compte):
    print(f"Compte id: {compte.idCompte} - Montant: {compte.montantEnCentimes}")

compte = Compte("ABCDE67890", 50000)
ajouterMontant(compte, 12000)
afficherCompte(compte)
deduireMontant(compte, 7000)
afficherCompte(compte)
