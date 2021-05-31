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
    public partial class AccueilCaissier : Form
    {
        private DispensaireReference.DispensaireSoapClient caissier;
        private DispensaireReference.Utilisateur res;
        private List<DispensaireReference.Ordonnance> listeOrd = new List<DispensaireReference.Ordonnance>();
        private DispensaireReference.Ordonnance patientOrd = new DispensaireReference.Ordonnance();

        public AccueilCaissier()
        {
            InitializeComponent();
        }

        public AccueilCaissier(DispensaireReference.Utilisateur res)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.res = res;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            if (dataGridView2.Rows.Count == 0)
                btEnregistrer.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            //TimeSpan tms = new TimeSpan(1000000);
            /*timer1.Interval++;
            
            if (timer1.Interval == 150)
            {
                
                    MessageBox.Show("arret");
                    timer1.Enabled = false;
                    timer2.Interval = 100;
                    timer2.Tick += new EventHandler(timer2_Tick);
                timer2.Enabled = true;
                
            }*/

            

            caissier = new DispensaireReference.DispensaireSoapClient();
            if (listeOrd.Count > 0)
                listeOrd.Clear();

            if (res.role._parametre_valeur_valeur.Equals("Caissier"))
                listeOrd = caissier.getNotification("Reglement").ToList();
            if (res.role._parametre_valeur_valeur.Equals("Pharmacien"))
                listeOrd = caissier.getNotification("livraison").ToList();
            if (res.role._parametre_valeur_valeur.Equals("Infirmier"))
                listeOrd = caissier.getNotification("soin").ToList();
           
            if (listeOrd.Count > 0)
            {
                if (dataGridView1.Rows.Count > 0)
                    dataGridView1.Rows.Clear();
                foreach (var l in listeOrd)
                {
                    dataGridView1.Rows.Add(l._ordonnance_id, l.Patient._personne_nom + " " + l.Patient._personne_prenom, l._date_ajout.ToShortDateString(), l._prix_total);
                }
                timer1.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblNom.Text = dataGridView1.Rows[e.RowIndex].Cells["_nom"].FormattedValue.ToString();
            patientOrd = listeOrd.First(x => x._ordonnance_id == Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["_ordonnance_id"].FormattedValue.ToString()));
            patientOrd.medicament = caissier.DetailMedicamentOrdonnance(patientOrd).medicament;

            lblTotal.Text = patientOrd.medicament.Sum(x => x._prix_acheter).ToString();
            if (dataGridView2.Rows.Count > 0)
                dataGridView2.Rows.Clear();

            foreach (var med in patientOrd.medicament)
            {
                dataGridView2.Rows.Add(med._medicament_nom, med._description, med._quantite_acheter, med._prix_acheter);
            }
            btEnregistrer.Enabled = true;
        }

        private void btEnregistrer_Click(object sender, EventArgs e)
        {
            patientOrd.Caissier = new DispensaireReference.Personne();
            patientOrd.Pharmacien = new DispensaireReference.Personne();
            patientOrd.Infirmier = new DispensaireReference.Personne();
            if (res.role._parametre_valeur_valeur.Equals("Caissier"))
                patientOrd.Caissier._personne_id = res.personne._personne_id;
            if (res.role._parametre_valeur_valeur.Equals("Pharmacien"))
                patientOrd.Pharmacien._personne_id = res.personne._personne_id;
            if (res.role._parametre_valeur_valeur.Equals("Infirmier"))
                patientOrd.Infirmier._personne_id = res.personne._personne_id;
            caissier.updateTache(patientOrd);
            dataGridView2.Rows.Clear();
            dataGridView1.Rows.Clear();
            lblNom.Text = "";
            lblTotal.Text = "";
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            btEnregistrer.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval++;
            //MessageBox.Show("timer2");
            if (timer2.Interval == 150)
            {
                    MessageBox.Show("marche");
                    timer2.Enabled = false;
                    timer1.Interval = 100;
                    timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Enabled = true;
            }
        }
    }
}
