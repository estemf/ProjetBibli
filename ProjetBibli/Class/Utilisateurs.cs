using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBibli.Class
{
    public class Utilisateurs
        {
        //Déclaration des variables
            private
            string Nom;
            string Prénom;
            int Identifiant;
            List<Livre> LivreEmprunter = new List<Livre>();

        //Constructeur
         public Utilisateurs(string Nom, string Prénom, int Identifiant,List <Livre>LivreEmprunter)
            {
                this.Nom = Nom;
                this.Prénom = Prénom;
                this.Identifiant = Identifiant;
                this.LivreEmprunter = LivreEmprunter;
            }

        }
    
}
