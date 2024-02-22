namespace CorrectifExoRecapBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour, Bienvenue chez Yvan du reve");
            Console.WriteLine("------------------------------------");

            Magasin.StoreInitialize();

            bool continueShopping = true;
            while (continueShopping)
            {
                int choix = Magasin.ShowItems();

                switch (choix)
                {
                    case 1: Magasin.Purchase("Coca");
                        break;
                    case 2: Magasin.Purchase("Sandwich");
                        break;
                    case 3: Magasin.Purchase("Porte");
                        break;
                    case 4:
                        Magasin.Purchase("Boule de cristal");
                        break;
                    case 5: continueShopping = false;
                        break;
                    default:
                        Console.WriteLine("Tu sais pas lire un menu ?");
                        break;

                }
            }

            Console.WriteLine($"Le total de vos achats est de {Magasin.GetTotal()}");
            Console.WriteLine("Merci de votre visite ! A ciao bon dimanche");
        }
    }
}
