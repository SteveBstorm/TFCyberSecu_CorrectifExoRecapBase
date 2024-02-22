using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectifExoRecapBase
{
    public static class Magasin
    {
        static Dictionary<string, int> ShopStore;
        static Dictionary<string, int> ShoppingList;

        public static void StoreInitialize()
        {
            ShopStore = new Dictionary<string, int>();
            ShopStore.Add("Coca", 4);
            ShopStore.Add("Sandwich", 2);
            ShopStore.Add("Porte", 3);
            ShopStore.Add("Boule de cristal", 7);

            ShoppingList = new Dictionary<string, int>();
        }

        public static void Purchase(string article)
        {
            //Vérification du stock actuel
            if (ShopStore[article] > 0)
            {
                ShopStore[article] -= 1;
                //Si l'élément se trouve déjà dans mon panier
                if(ShoppingList.ContainsKey(article))
                {
                    //J'incrémente le nombre s'y trouvant
                    ShoppingList[article]++;
                }
                else
                {
                    //Sinon je le crée dans mon panier
                    ShoppingList.Add(article, 1);
                }
            } else Console.WriteLine($"{article} n'est plus en stock");
        }

        public static int GetTotal()
        {
            int total = 0;
            foreach (KeyValuePair<string, int> item in ShoppingList)
            {
                if (item.Key == "Coca") total += item.Value * 1;
                if (item.Key == "Sandwich") total += item.Value * 5;
                if (item.Key == "Porte") total += item.Value * 200;
                if (item.Key == "Boule de cristal") 
                {
                    if (item.Value == 7) Console.WriteLine("Pour krilin on peut plus rien faire");
                    total += item.Value * 2000;
                        }
                
            }
            return total;
        }

        public static int ShowItems()
        {
            Console.WriteLine("Faites votre choix : ");
            Console.WriteLine();

            int counter = 1;
            foreach(KeyValuePair<string, int> item in ShopStore)
            {
                Console.WriteLine($"{counter} : {item.Key} ({item.Value} en stock)");
                counter++;
            }

            Console.WriteLine($"{counter} pour Quitter");

            int choix = int.Parse(Console.ReadLine());

            return choix;
        }
    }
}
