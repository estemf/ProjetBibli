using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBibli.Class
{
    public class Livre
    {
        private
        string Titre;
        string Auteur;
        int AnnéePublication;
        int ISBN;

        public Livre(string Titre, string Auteur, int AnnéePublication, int ISBN)
        {
            this.Titre = Titre;
            this.Auteur = Auteur;
            this.AnnéePublication = AnnéePublication;
            this.ISBN = ISBN;
        }
    }

    public class Bibliotèque
    {
        private List<Livre> livres = new List<Livre>();

       

}

}
