namespace ClassLivre
{
    public class Livre
    {
        private
        char Titre;
        char Auteur;
        int AnnéePublication;
        int ISBN;

        public Livre(char Titre, char Auteur, int AnnéePublication, int ISBN)
        {
            this.Titre = Titre;
            this.Auteur = Auteur;
            this.AnnéePublication = AnnéePublication;
            this.ISBN = ISBN;
        }
    }
    

}
