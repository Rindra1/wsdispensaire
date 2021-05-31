using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using Dispensaire.BusinessObjects;
using Dispensaire.BLL;

namespace Dispensaire.WS
{
    /// <summary>
    /// Summary description for Dispensaire
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Dispensaire : System.Web.Services.WebService
    {
        
        [WebMethod]
        public Ordonnance addOrdonnance(Ordonnance ord)
        {
            return OrdonnanceManager.Instance.AddOrdonnance(ord);
        }

        [WebMethod]
        public Personne AddPersonne(Personne pers)
        {
            return PersonneManager.Instance.AddPatient(pers);
        }

        [WebMethod]
        public Ordonnance DetailMedicamentOrdonnance(Ordonnance ord)
        {
            return OrdonnanceManager.Instance.getOrdonnanceMedicament(ord);
        }

        [WebMethod]
        public Utilisateur doLogin(Utilisateur user)
        {
            UtilisateurManager umUser = new UtilisateurManager();
            return  umUser.DoLogin(user);
        }

        [WebMethod]
        public List<Medicament> getAllMedicament()
        {
            return MedicamentManager.Instance.getAllMedicament();
        }

        [WebMethod]
        public List<Ordonnance> getAllOrdonnance(Personne pers)
        {
            return OrdonnanceManager.Instance.ListeOrdonnance(pers);
        }

        [WebMethod]
        public List<Personne> getAllPatient()
        {
            return PersonneManager.Instance.getAllPatient();
        }

        [WebMethod]
        public Parametre getParametreByNom(string nom)
        {
            return ParametreManager.Instance.getParametreByNom(nom);
        }

        [WebMethod]
        public Ordonnance Prescrire(Ordonnance ord)
        {
            return MedicamentManager.Instance.AddOrdonnance(ord);
        }

        [WebMethod]
        public List<Personne> RechercherPatient(string nom, string prenom)
        {
            return PersonneManager.Instance.RechercherPatient(nom, prenom);
        }

        [WebMethod]
        public List<Ordonnance> getNotification(string status_suivant)
        {
            return OrdonnanceManager.Instance.getNotification(status_suivant);
        }

        [WebMethod]
        public void updateTache(Ordonnance ord)
        {
            OrdonnanceManager.Instance.updateTache(ord);
        }
    }
}
