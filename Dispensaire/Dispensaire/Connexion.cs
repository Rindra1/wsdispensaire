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
    public partial class Connexion : Form
    {
        private DispensaireReference.DispensaireSoapClient dsc = new DispensaireReference.DispensaireSoapClient();
        private DispensaireReference.Utilisateur user = new DispensaireReference.Utilisateur();

        public Connexion()
        {
            InitializeComponent();
        }

        private void btConnexion_Click(object sender, EventArgs e)
        {
            if (txtPseudo.Text == "" || txtPassword.Text == "")
            {
                if (txtPseudo.Text == "")
                    MessageBox.Show("Pseudo obligatoire");
                else if (txtPassword.Text == "")
                    MessageBox.Show("Mot de Passe obligatoire");
            }
            else
            {
                user._pseudo = txtPseudo.Text;
                user._password = txtPassword.Text;
                var res = dsc.doLogin(user);
                if (res._pseudo == null)
                    MessageBox.Show("Pseudo ou Mot de Passe incorrect");
                else
                {
                    if (res.role._parametre_valeur_valeur == "Medecin")
                    {
                        AccueilDocteur ad = new AccueilDocteur(res);
                        this.Hide();
                        ad.Show();
                    }
                    else if (res.role._parametre_valeur_valeur == "Caissier"
                        || res.role._parametre_valeur_valeur == "Pharmacien"
                        || res.role._parametre_valeur_valeur == "Infirmier")
                    {
                        AccueilCaissier ac = new AccueilCaissier(res);
                        this.Hide();
                        ac.Show();
                    }
                }
            }
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
