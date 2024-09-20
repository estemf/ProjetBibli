namespace Utilisateurs
{
    public class Utilisateurs
    {
        private
            char Nom;
            char Prénom;
            int Identifiant;
            string LivreEmprunter;
        public Utilisateurs(char Nom, char Prénom, int Identifiant, string LivreEmprunter)
        {
            this.Nom = Nom;
            this.Prénom = Prénom;
            this.Identifiant = Identifiant;
            this.LivreEmprunter = LivreEmprunter;
        }
    }
}
