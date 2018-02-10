using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Gestion_Stagiaires
{
    class DBGestionStagiaires
    {
        GestionStagiairesContextContainer dbContext;

        public DBGestionStagiaires()
        {
            dbContext = new GestionStagiairesContextContainer();
        }

        public void AjouterStagiaire(string nomStagiaire, string prenomStagiaire, DateTime dateNaissance)
        {
            if (MessageBox.Show("Pour confirmer l'ajoute, \nclick sur la boutton 'OK'", "Confirmation de l'ajouter", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                Stagiaire nouveauStagiaire = new Stagiaire { Nom = nomStagiaire, Prenom = prenomStagiaire, DateNaissance = dateNaissance };
                dbContext.Stagiaires.Add(nouveauStagiaire);
                dbContext.SaveChanges();
            }
        }

        public void AjouterFormation(string description)
        {
            Formation nouveauFormation = new Formation { Description = description };
            dbContext.Formations.Add(nouveauFormation);
            dbContext.SaveChanges();
        }

        public void AjouterStagiairePourFormation(string nomStagiaire, string prenomStagiaire, DateTime dateNaissance, int IdFormartion)
        {
            if (MessageBox.Show("Pour confirmer l'ajoute, \nclick sur la boutton 'OK'", "Confirmation de l'ajouter", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                Stagiaire nouveauStagiaire = new Stagiaire
                {
                    Nom = nomStagiaire,
                    Prenom = prenomStagiaire,
                    DateNaissance = dateNaissance,
                    IdFormation = IdFormartion
                };
                dbContext.Stagiaires.Add(nouveauStagiaire);
                dbContext.SaveChanges();
            }
        }
        
        public void SupprimerStagiaire(int IdStagiaire)
        {
            dbContext.Stagiaires.Remove(dbContext.Stagiaires.Find(IdStagiaire));

            dbContext.SaveChanges();
        }

        public void SupprimerFormation(int IdFormation)
        {
            dbContext.Formations.Remove(dbContext.Formations.Find(IdFormation));

            dbContext.SaveChanges();
        }

        public void ModifierStagiaire(int IdStagiaire, string nomStagiaire, string prenomStagiaire, DateTime dateNaissance, int IdFormartion)
        {
            Stagiaire stagiaireSelectionner = dbContext.Stagiaires.Find(IdStagiaire);

            stagiaireSelectionner.Nom = nomStagiaire;
            stagiaireSelectionner.Prenom = prenomStagiaire;
            stagiaireSelectionner.DateNaissance = dateNaissance;
            stagiaireSelectionner.IdFormation = IdFormartion;

            dbContext.SaveChanges();
        }

        public void ModifierFormation(int IdFormation, string description)
        {
            Formation formation = dbContext.Formations.Find(IdFormation);

            formation.Description = description;

            dbContext.SaveChanges();
        }

        public void RetirerFormationStagiaire(int IdFormation, int IdStagiaire)
        {
            Formation formationSelectionner = dbContext.Formations.Find(IdFormation);
            formationSelectionner.Stagiaire.Remove(formationSelectionner.Stagiaire.First(stagiaire => stagiaire.IdStagiaire == IdStagiaire));

            dbContext.SaveChanges();
        }
        
        public IEnumerable<Stagiaire> GetStagiaires()
        {
            return dbContext.Stagiaires.ToList();
        }

        public IEnumerable<Formation> GetFormations()
        {
            return dbContext.Formations.ToList();
        }

        public IEnumerable<Stagiaire> GetStagiairesVersFormation(string description)
        {
            return dbContext.Stagiaires.Where(stagiaire => stagiaire.Formation.Description == description).ToList();
        }

        public IEnumerable<Stagiaire> GetStagiaireVersInformation(string information)
        {
            return dbContext.Stagiaires.Where(stagiaire => (stagiaire.Nom + stagiaire.Prenom + stagiaire.IdStagiaire.ToString()).Contains(information)).ToList();
        }
        
    }
}
