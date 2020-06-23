using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiPetschka
{
    class Program
    {
        static void Main(string[] args)
        {
            backereiprodukte wiPetschka = new backereiprodukte("Пирожонное" , 5);

            wiPetschka.backereiprodukteMethod();


            Console.Read();
        }
    }

    class backereiprodukte
    {
        protected string Name { get; set; }
        protected int Preis { get; set; }

        public backereiprodukte(string name, int preis)
        {
            Name = name;
            Preis = preis;
            Console.WriteLine("Родительский класс создан");
        }

        public virtual void backereiprodukteMethod()
        {
            Console.WriteLine("Выпечка: {0} имеет срок годности"+" от 6 часов "+"до {1} суток ", Name, Preis);
        }


    }

    class WiPetschka : backereiprodukte
    {
        public WiPetschka(string name, int preis) : base(name, preis)
        {
            Name = name;
            Preis = preis;
            Console.WriteLine("Дочерний класс создан");
        }

        public override void backereiprodukteMethod()
        {
            Console.WriteLine("Бабочка {0} которая живёт {1} месяцев являеться самой долгожительной", Name, Preis);
        }
    }
}
