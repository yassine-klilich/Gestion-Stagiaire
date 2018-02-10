using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Stagiaires
{
    public partial class frmMain : Form
    {
        DBGestionStagiaires dbGestionStagiaires = new DBGestionStagiaires();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            RechargeLesDonnees();
            RemplirDGVStagiaires();

            AddEvents();
            tmrHeure.Start();
        }

                             /*     Select & CRUD Methods     */
                            ///////////////////////////////////
        
        // GroupBox Gestion de Stagiaires :
        private void RemplirDGVStagiaires()
        {
            dgvStagiaires.DataSource = dbGestionStagiaires.GetStagiaires();
            ConfigurationDGVStagiaires();
        }
        
        private void RemplirCMBFormation()
        {
            cmbFormation.DataSource = dbGestionStagiaires.GetFormations();
            cmbFormation.DisplayMember = "Description";
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (ckbAjouterSansFormation.Checked)
                dbGestionStagiaires.AjouterStagiaire(txbNom.Text, txbPrenom.Text, dtpDateNaissance.Value);
            else
                dbGestionStagiaires.AjouterStagiairePourFormation(txbNom.Text, txbPrenom.Text, dtpDateNaissance.Value, ((Formation)cmbFormation.SelectedItem).IdFormation);
            
            RemplirDGVStagiaires();
            dgvStagiaires.Rows[dgvStagiaires.RowCount - 1].Selected = true;
        }
        
        private void btnModifier_Click(object sender, EventArgs e)
        {
            dbGestionStagiaires.ModifierStagiaire((int)dgvStagiaires.CurrentRow.Cells[0].Value , txbNom.Text, txbPrenom.Text, dtpDateNaissance.Value, ((Formation)cmbFormation.SelectedItem).IdFormation);
            LignePrecedent();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            dbGestionStagiaires.SupprimerStagiaire((int)dgvStagiaires.CurrentRow.Cells[0].Value);
            
            RemplirDGVStagiaires();
        }

        private void btnRetirer_Click(object sender, EventArgs e)
        {
            if (dgvStagiaires.CurrentRow.Cells[4].Value == null)
                MessageBox.Show("Ce stagiaire n'avoir aucun formation pour retirer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                dbGestionStagiaires.RetirerFormationStagiaire((int)dgvStagiaires.CurrentRow.Cells[4].Value, (int)dgvStagiaires.CurrentRow.Cells[0].Value);
                LignePrecedent();
            }
        }

        // GroupBox Gestion de Formations :
        private void RemplirCMBModeSelection()
        {
            cmbModeSelection.Items.Clear();
            cmbModeSelection.Items.Add("Tous");
            foreach (Formation description in cmbFormation.Items)
            {
                cmbModeSelection.Items.Add(description.Description);
            }
            cmbModeSelection.SelectedIndex = 0;
        }
        
        private void RemplirLSTVFormations()
        {
            lstvFormations.Items.Clear();
            for (int i = 0; i < cmbFormation.Items.Count; i++)
            {
                ListViewItem listitem = new ListViewItem(((Formation)(cmbFormation.Items[i])).IdFormation.ToString());
                listitem.SubItems.Add(((Formation)(cmbFormation.Items[i])).Description);
                lstvFormations.Items.Add(listitem);
            }
        }

        private void btnAjouterFormation_Click(object sender, EventArgs e)
        {
            if (TXBDescriptionFormationVide())
                return;
            if (!DescriptionFormationExiste(txbDescriptionFormation.Text.Trim()))
            {
                dbGestionStagiaires.AjouterFormation(txbDescriptionFormation.Text.Trim());
            }
            RechargeLesDonnees();
        }

        private void btnModifierFormation_Click(object sender, EventArgs e)
        {
            if (!UtilisateurSelectionerUneFormation())
                return;

            if (TXBDescriptionFormationVide())
                return;

            dbGestionStagiaires.ModifierFormation(int.Parse(lstvFormations.SelectedItems[0].SubItems[0].Text), txbDescriptionFormation.Text);
            RechargeLesDonnees();
        }

        private void btnSupprimerFormation_Click(object sender, EventArgs e)
        {
            if (!UtilisateurSelectionerUneFormation())
                return;

            dbGestionStagiaires.SupprimerFormation(int.Parse(lstvFormations.SelectedItems[0].SubItems[0].Text));
            txbDescriptionFormation.Text = String.Empty;
            RechargeLesDonnees();
        }
        
        ////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////

                                /*  Configuration of controles */
                                /////////////////////////////////
        private void ConfigurationDGVStagiaires()
        {
            dgvStagiaires.ReadOnly = true;
            dgvStagiaires.Columns[4].Visible = false;
            dgvStagiaires.Columns[5].Visible = false;
            dgvStagiaires.Columns[6].DefaultCellStyle.NullValue = "Ce stagiaire n'avoir aucun formation";
            ConfigurerNomDeColonnes();
        }

        private void ckbAjouter_CheckedChanged(object sender, EventArgs e)
        {
            btnModifier.Enabled = btnSupprimer.Enabled = btnRetirer.Enabled = cmbFormation.Enabled = !ckbAjouterSansFormation.Checked;
        }

        private void dgvStagiaires_SelectionChanged(object sender, EventArgs e)
        {
            txbNom.Text = dgvStagiaires.CurrentRow.Cells[1].Value.ToString();
            txbPrenom.Text = dgvStagiaires.CurrentRow.Cells[2].Value.ToString();
            dtpDateNaissance.Text = dgvStagiaires.CurrentRow.Cells[3].Value.ToString();
            cmbFormation.SelectedItem = (Formation)dgvStagiaires.CurrentRow.Cells[5].Value;
        }
        
        private void ConfigurerNomDeColonnes()
        {
            dgvStagiaires.Columns[0].HeaderText = "ID Stagiaire";
            dgvStagiaires.Columns[3].HeaderText = "Date de naissance";
            dgvStagiaires.Columns[6].HeaderText = "Formation";
        }

        private void LignePrecedent()
        {
            int selectedRow = dgvStagiaires.CurrentRow.Index;
            RemplirDGVStagiaires();
            dgvStagiaires.CurrentCell = dgvStagiaires.Rows[selectedRow].Cells[0];
            dgvStagiaires_SelectionChanged(null, null);
        }

        private void tmrHeure_Tick(object sender, EventArgs e)
        {
            lblHeure.Text = DateTime.Now.ToLongTimeString();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrHeure.Stop();
        }

        private void lstvFormations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvFormations.SelectedItems.Count == 1)
                txbDescriptionFormation.Text = lstvFormations.SelectedItems[0].SubItems[1].Text;
        }

        private void cmbModeSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModeSelection.SelectedItem.ToString() == "Tous")
                RemplirDGVStagiaires();
            else
                dgvStagiaires.DataSource = dbGestionStagiaires.GetStagiairesVersFormation(cmbModeSelection.SelectedItem.ToString());
        }
        
        private void txbChercherStagiaire_TextChanged(object sender, EventArgs e)
        {
            if (txbChercherStagiaire.Text.Trim() == String.Empty)
            {
                RemplirDGVStagiaires();
                return;
            }
            dgvStagiaires.DataSource = dbGestionStagiaires.GetStagiaireVersInformation(txbChercherStagiaire.Text);
        }
        
        private bool TXBDescriptionFormationVide()
        {
            if (txbDescriptionFormation.Text.Trim() == String.Empty)
            {
                MessageBox.Show("La zone de text est vide !", "Vérification de zone text", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        private bool DescriptionFormationExiste(string description)
        {
            foreach (ListViewItem item in lstvFormations.Items)
            {
                if (item.SubItems[1].Text == description)
                {
                    MessageBox.Show("Ce nom description de la formation est déja existe", "Description déja existe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        private bool UtilisateurSelectionerUneFormation()
        {
            if (lstvFormations.SelectedItems.Count != 1)
            {
                MessageBox.Show("Selectionner une formation qui vas supprimer");
                return false;
            }
            return true;
        }

        private void RechargeLesDonnees()
        {
            RemplirCMBFormation();
            RemplirCMBModeSelection();
            RemplirLSTVFormations();
        }

        // Configuration of events
        private void AddEvents()
        {
            // Add this event after filling 'cmbModeSelection'
            this.cmbModeSelection.SelectedIndexChanged += new System.EventHandler(this.cmbModeSelection_SelectedIndexChanged);
        }
        
    }
}
