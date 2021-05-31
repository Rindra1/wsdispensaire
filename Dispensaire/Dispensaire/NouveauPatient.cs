using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dispensaire
{
    public partial class NouveauPatient : Form
    {
        private DispensaireReference.Utilisateur res;
        private DispensaireReference.DispensaireSoapClient nouvPatient = new DispensaireReference.DispensaireSoapClient();
        private DispensaireReference.Personne patient = new DispensaireReference.Personne();

        public NouveauPatient()
        {
            InitializeComponent();
        }

        public NouveauPatient(DispensaireReference.Utilisateur res)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.res = res;
        }

        private void btEnregistrer_Click(object sender, EventArgs e)
        {
            patient._allergie = chkAllergie.Checked;
            patient._asthme = chkAsthme.Checked;
            patient._personne_nom = txtNom.Text;
            patient._personne_prenom = txtPrenom.Text;
            patient._personne_adresse = txtAdr.Text;
            patient._personne_age = txtAge.Text == null ? default(int) : Convert.ToInt32(txtAge.Text);
            patient._personne_telephone = txtTel.Text;

            patient.type_personne = new DispensaireReference.Parametre_Valeur();
            patient.type_personne._parametre_valeur_id = nouvPatient.getParametreByNom("Type Personne")
                .parametre_valeur.First(x => x._parametre_valeur_valeur.Equals("patient"))
                ._parametre_valeur_id;

            patient.sexe = new DispensaireReference.Parametre_Valeur();
            if (chkF.Checked)
                patient.sexe._parametre_valeur_id =
                    nouvPatient.getParametreByNom("sexe")
                    .parametre_valeur.First(x => x._parametre_valeur_valeur.Equals("F"))
                    ._parametre_valeur_id;
            else
                patient.sexe._parametre_valeur_id =
                    nouvPatient.getParametreByNom("sexe")
                    .parametre_valeur.First(x => x._parametre_valeur_valeur.Equals("M"))
                    ._parametre_valeur_id;

            patient.antecedent = new DispensaireReference.Antecedent();
            patient.antecedent._chirurgie = chkChirurgie.Checked;
            patient.antecedent._diabete = chkDiabete.Checked;
            patient.antecedent._hta = chkHta.Checked;
            patient.antecedent._hospitaliser = chkHosp.Checked;
            patient.antecedent._allergie_medicament = txtAllergMed.Text;
            patient.antecedent._diagnostique = txtDiagnostic.Text;
            patient.antecedent._dureeT = txtDureeT.Text == "" ? default(int) : Convert.ToInt32(txtDureeT.Text);
            patient.antecedent._traitement_anterieur = txtTraitementAnt.Text;
            patient.antecedent._drvdsp = txtDrvtdsp.Text;
            patient = nouvPatient.AddPersonne(patient);
            AjoutOrdonnance AddOrd = new AjoutOrdonnance(patient, res);
            this.Hide();
            AddOrd.Show();
        }
    }
}
