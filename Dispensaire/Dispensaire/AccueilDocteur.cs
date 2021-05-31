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
    public partial class AccueilDocteur : Form
    {
        private DispensaireReference.Utilisateur res;
        private DispensaireReference.Personne PatientTraiter;
        private DispensaireReference.DispensaireSoapClient
            patientClient = new DispensaireReference.DispensaireSoapClient();

        public AccueilDocteur()
        {
            InitializeComponent();
        }
        public AccueilDocteur(DispensaireReference.Utilisateur res)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.res = res;

        }

        private void btRechercherPatient_Click(object sender, EventArgs e)
        {
            if (dgvResultatRecherche.Rows.Count > 0)
                dgvResultatRecherche.Rows.Clear();
            var prenom = txtRecherchePrenom.Text + "%";//txtRecherchePrenom.Text == "" ? "" : txtRecherchePrenom.Text + "%";
            var nom = txtRechercheNom.Text + "%";//txtRechercheNom.Text == "" ? "" : txtRechercheNom.Text + "%";
            List<DispensaireReference.Personne> patient = new List<DispensaireReference.Personne>();
            patient = patientClient.RechercherPatient(nom, prenom).ToList();

            foreach (var p in patient)
            {
                dgvResultatRecherche.Rows.Add(p._personne_id, p._personne_adresse, p._personne_age, p._personne_telephone,
                    p._allergie, p._asthme, p.antecedent._hospitaliser, p.antecedent._chirurgie, p.antecedent._diabete,
                    p.antecedent._hta, p.antecedent._allergie_medicament, p.antecedent._diagnostique, p.antecedent._dureeT,
                    p.antecedent._traitement_anterieur, p.antecedent._drvdsp, p._personne_nom, p._personne_prenom, p.sexe._parametre_valeur_valeur);
            }
        }

        private void dgvResultatRecherche_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            chkAllergie.Checked = false;
            chkAsthme.Checked = false;

            chkF.Checked = false;
            chkM.Checked = false;

            chkDiabete.Checked = false;
            chkHosp.Checked = false;
            chkHta.Checked = false;
            chkChirurgie.Checked = false;

            txtNom.Text = dgvResultatRecherche.Rows[e.RowIndex].Cells["_personne_nom"].FormattedValue.ToString();
            txtPrenom.Text = dgvResultatRecherche.Rows[e.RowIndex].Cells["_personne_prenom"].FormattedValue.ToString();
            txtAdr.Text = dgvResultatRecherche.Rows[e.RowIndex].Cells["_personne_adresse"].FormattedValue.ToString();
            txtAge.Text = dgvResultatRecherche.Rows[e.RowIndex].Cells["_personne_age"].FormattedValue.ToString();
            txtTel.Text = dgvResultatRecherche.Rows[e.RowIndex].Cells["_personne_telephone"].FormattedValue.ToString();
            if (Convert.ToBoolean(dgvResultatRecherche.Rows[e.RowIndex].Cells["_allergie"].FormattedValue.ToString()))
            {
                chkAllergie.Checked = true;
            }

            if (Convert.ToBoolean(dgvResultatRecherche.Rows[e.RowIndex].Cells["_asthme"].FormattedValue.ToString()))
            {
                chkAsthme.Checked = true;
            }
            if (dgvResultatRecherche.Rows[e.RowIndex].Cells["sexe"].FormattedValue.ToString() == "M")
                chkM.Checked = true;
            else
                chkF.Checked = true;
            if (Convert.ToBoolean(dgvResultatRecherche.Rows[e.RowIndex].Cells["_chirurgie"].FormattedValue.ToString()))
                chkChirurgie.Checked = true;
            if (Convert.ToBoolean(dgvResultatRecherche.Rows[e.RowIndex].Cells["_diabete"].FormattedValue.ToString()))
                chkDiabete.Checked = true;
            if (Convert.ToBoolean(dgvResultatRecherche.Rows[e.RowIndex].Cells["_hta"].FormattedValue.ToString()))
                chkHta.Checked = true;
            if (Convert.ToBoolean(dgvResultatRecherche.Rows[e.RowIndex].Cells["_hospitaliser"].FormattedValue.ToString()))
                chkHosp.Checked = true;
            txtAllergMed.Text = dgvResultatRecherche.Rows[e.RowIndex].Cells["_allergie_medicament"].FormattedValue.ToString();
            txtDrvTdsp.Text = dgvResultatRecherche.Rows[e.RowIndex].Cells["_drvdsp"].FormattedValue.ToString();

            PatientTraiter = new DispensaireReference.Personne();
            PatientTraiter._personne_id = Convert.ToInt32(dgvResultatRecherche.Rows[e.RowIndex].Cells["_personne_id"].FormattedValue.ToString());
            PatientTraiter._personne_nom = dgvResultatRecherche.Rows[e.RowIndex].Cells["_personne_nom"].FormattedValue.ToString();
            PatientTraiter._personne_prenom = dgvResultatRecherche.Rows[e.RowIndex].Cells["_personne_prenom"].FormattedValue.ToString();
        }

        private void btNouveau_Click(object sender, EventArgs e)
        {
            NouveauPatient np = new NouveauPatient(res);
            this.Hide();
            np.Show();
        }

        private void btOrdonnance_Click(object sender, EventArgs e)
        {
            AjoutOrdonnance addOrd = new AjoutOrdonnance(PatientTraiter, res);
            this.Hide();
            addOrd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btDetail_Click(object sender, EventArgs e)
        {

        }
    }
}
