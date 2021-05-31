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
    public partial class AjoutOrdonnance : Form
    {
        private DispensaireReference.Personne patient;
        private DispensaireReference.Utilisateur res;
        private DispensaireReference.DispensaireSoapClient OrdClient = new DispensaireReference.DispensaireSoapClient();
        private DispensaireReference.Ordonnance ordonnance = new DispensaireReference.Ordonnance();
        private List<DispensaireReference.Medicament> Listemedoc = new List<DispensaireReference.Medicament>();

        public AjoutOrdonnance()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToShortDateString();
            var listeMedicament = getAllMedicament();
            foreach (var tmp in listeMedicament)
            {
                cbNomMedicament.Items.Add(tmp._medicament_nom);
            }
        }

        public AjoutOrdonnance(DispensaireReference.Personne patient, DispensaireReference.Utilisateur res)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.patient = patient;
            this.res = res;
            lblDate.Text = DateTime.Now.ToShortDateString();
            var listeMedicament = getAllMedicament();
            foreach (var tmp in listeMedicament)
            {
                cbNomMedicament.Items.Add(tmp._medicament_nom);
            }

        }

        private List<DispensaireReference.Medicament> getAllMedicament()
        {
            return OrdClient.getAllMedicament().ToList();
        }

        private void btAjouterMedicament_Click(object sender, EventArgs e)
        {
            if (dgvMedicament.Rows.Count > 0)
                dgvMedicament.Rows.Clear();

            DispensaireReference.Medicament medoc = new DispensaireReference.Medicament();
            medoc.quantite = new DispensaireReference.Quantite();


            medoc._medicament_id = getAllMedicament().First(x => x._medicament_nom.Equals(cbNomMedicament.Text))._medicament_id;
            medoc._medicament_nom = getAllMedicament().First(x => x._medicament_nom.Equals(cbNomMedicament.Text))._medicament_nom;

            medoc.quantite._quantite_id = getAllMedicament().First(x => x._medicament_nom.Equals(cbNomMedicament.Text)).quantite._quantite_id;
            medoc.quantite._nombre_total = getAllMedicament()
                .First(x => x._medicament_nom.Equals(cbNomMedicament.Text))
                .quantite._nombre_total - Convert.ToInt32(txtNombre.Text);
            medoc._description = txtForme.Text;
            medoc._quantite_acheter = Convert.ToInt32(txtNombre.Text);
            medoc._prix_acheter = Convert.ToInt32(txtNombre.Text) * getAllMedicament()
                .First(x => x._medicament_nom.Equals(cbNomMedicament.Text))
                .quantite._prix;
            medoc.categorie_medicament = new DispensaireReference.Parametre_Valeur();
            medoc.categorie_medicament._parametre_valeur_valeur =
                getAllMedicament()
                .First(x => x._medicament_nom.Equals(cbNomMedicament.Text))
                .categorie_medicament._parametre_valeur_valeur;
            Listemedoc.Add(medoc);
            foreach (var liste in Listemedoc)
            {
                dgvMedicament.Rows.Add(liste._medicament_nom, liste._description, liste._quantite_acheter, liste._prix_acheter);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ordonnance._date_ajout = Convert.ToDateTime(lblDate.Text);
            ordonnance._poids = txtPoids.Text == "" ? default(double) : Convert.ToDouble(txtPoids.Text);
            ordonnance._pouls = txtPouls.Text == "" ? default(double) : Convert.ToDouble(txtPouls.Text);
            ordonnance._tension = txtTemperature.Text == "" ? default(double) : Convert.ToDouble(txtTemperature.Text);
            ordonnance._taux_arterien = txtTensionArterien.Text == "" ? default(double) : Convert.ToDouble(txtTensionArterien.Text);
            ordonnance._symptome = txtSymptome.Text;
            ordonnance._prix_total = Listemedoc.Sum(x => x._prix_acheter);

            ordonnance.Patient = new DispensaireReference.Personne();
            ordonnance.Patient = patient;


            ordonnance.Medecin_Traitant = new DispensaireReference.Personne();
            ordonnance.Medecin_Traitant = res.personne;

            ordonnance.Pharmacien = new DispensaireReference.Personne();
            ordonnance.Caissier = new DispensaireReference.Personne();
            ordonnance.Infirmier = new DispensaireReference.Personne();

            ordonnance.medicament = new DispensaireReference.Medicament[Listemedoc.Count + 1];
            ordonnance.medicament = Listemedoc.ToArray();

            ordonnance._tache_en_cours = new DispensaireReference.Parametre_Valeur();
            ordonnance._tache_suivant_attendu = new DispensaireReference.Parametre_Valeur();
            if (!Listemedoc.Exists(x => x.categorie_medicament._parametre_valeur_valeur.Equals("Comprimé")))
            {
                var tache_en_cours = OrdClient.getParametreByNom("Soigner").parametre_valeur.Min(x => x._parametre_valeur_numero);
                ordonnance._tache_en_cours._parametre_valeur_id =
                    OrdClient.getParametreByNom("Soigner")
                    .parametre_valeur.First(x => x._parametre_valeur_numero.Equals(tache_en_cours))
                    ._parametre_valeur_id;

                var tache_suivant = OrdClient.getParametreByNom("Soigner")
                    .parametre_valeur.Where(x => x._parametre_valeur_numero > tache_en_cours)
                    .Min(x => x._parametre_valeur_numero);
                ordonnance._tache_suivant_attendu._parametre_valeur_id = OrdClient.getParametreByNom("Soigner")
                    .parametre_valeur.First(x => x._parametre_valeur_numero.Equals(tache_suivant))._parametre_valeur_id;

            }
            else
            {
                var tache_en_cours = OrdClient.getParametreByNom("Traitement").parametre_valeur.Min(x => x._parametre_valeur_numero);
                ordonnance._tache_en_cours._parametre_valeur_id =
                    OrdClient.getParametreByNom("Traitement")
                    .parametre_valeur.First(x => x._parametre_valeur_numero.Equals(tache_en_cours))
                    ._parametre_valeur_id;

                var tache_suivant = OrdClient.getParametreByNom("Traitement")
                    .parametre_valeur.Where(x => x._parametre_valeur_numero > tache_en_cours)
                    .Min(x => x._parametre_valeur_numero);
                ordonnance._tache_suivant_attendu._parametre_valeur_id = OrdClient.getParametreByNom("Traitement")
                    .parametre_valeur.First(x => x._parametre_valeur_numero.Equals(tache_suivant))._parametre_valeur_id;

            }
            OrdClient.addOrdonnance(ordonnance);
            AccueilDocteur adoc = new AccueilDocteur(res);
            this.Hide();
            adoc.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
