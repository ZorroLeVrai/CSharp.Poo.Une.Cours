type Compte = {
  idCompte: string;
  montantEnCentimes: number;
};

function ajouterMontant(compte: Compte, montantEnCentimes: number) {
  compte.montantEnCentimes += montantEnCentimes;
}

function deduireMontant(compte: Compte, montantEnCentimes: number) {
  compte.montantEnCentimes -= montantEnCentimes;
}

function afficherCompte(compte: Compte) {
  console.log(`Compte id: ${compte.idCompte} - Montant: ${compte.montantEnCentimes}`);
}

const compte: Compte = {
  idCompte: "ABCDE67890",
  montantEnCentimes: 50000
};

ajouterMontant(compte, 12000);
afficherCompte(compte);
deduireMontant(compte, 7000);
afficherCompte(compte);
