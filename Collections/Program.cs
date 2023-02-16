using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList
            //ArrayList sehirler1 = new ArrayList() { "İstanbul", 34, "Ankara", 06, "Aydın", 09 };
            //foreach (var i in sehirler1)
            //{
            //    Console.Write(i);
            //    Console.Write(" ");
            //}

            #endregion

            #region List

            //List<string> sehirler = new List<string>() { "Adıyaman", "Malatya", "Kahramanmaraş" };

            //foreach (var sehir in sehirler)
            //{
            //    Console.WriteLine(sehir);
            //}

            ////

            //List<Customers> musteriler = new List<Customers>();
            //musteriler.Add(new Customers { id=1,name="rüveyda"});
            //musteriler.Add(new Customers { id = 2, name = "Efe" });
            //foreach (var musteri in musteriler)
            //{
            //    Console.Write(" ");
            //    Console.Write(musteri.id);
            //    Console.Write(" ");
            //    Console.Write(musteri.name);

            //}
            #endregion,

            #region Dictionary

            Dictionary <string,string> kelimeler= new Dictionary<string, string> ();
            kelimeler.Add("Book","Kitap");
            kelimeler.Add("Comp", "Bilgisayar");
            kelimeler.Add("Table", "Tablo");
            kelimeler.Add("Look", "Bak");
            foreach (var item in kelimeler)
            {
                Console.WriteLine(item.Key);
               // Console.WriteLine(item.Value);
            }
            Console.WriteLine("Count: {0}",kelimeler.Count());
            
            #endregion


            Console.ReadLine();
        }

    }

    class Customers
    {
        public int id;
        public string name;
    }
}
