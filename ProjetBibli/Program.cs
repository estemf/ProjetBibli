using ProjetBibli.Class;

namespace Biblioteque
{
    class Program
    {
        static void Main(string[] args)
        {
            Livre livre1 = new Livre("pirate", "jack", 2020, 1111);
            Livre livre2 = new Livre("bateau", "jean", 2020, 1212);
            List<Livre> listlivre = new List<Livre>();
            listlivre.Add(livre1);
            listlivre.Add(livre2);
            Utilisateurs jojo = new Utilisateurs("Jojo", "J", 0001,listlivre );
           

        }
    }
}
