using ConsoleApp2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Concrete
{
    public class User : IUser
    {
        public User(string name, string surname, string tcNumber, double credit)
        {
            Random rnd = new Random();   
            UserID =rnd.Next(100);
            Name = name;
            Surname = surname;
            TcNumber = tcNumber;
            CardNumber1 = rnd.Next(10000000);
            CardNumber2 = rnd.Next(10000000);
            CardNumber = CardNumber1.ToString()+"-"+CardNumber2.ToString(); 
            Price = 4.0;
            Credit = credit;
        }
        
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TcNumber { get; set; }
        public string CardNumber { get; set; }
        public int CardNumber1 { get; set; }
        public int CardNumber2 { get; set; }
        public double Price { get; set; }
        public double Credit { get; set; }

        public void load(int amount)
        {
            Credit = Credit + amount;
            Console.WriteLine("Yükleme İşlemi tamamlandı");
        }
        public virtual void pay()
        {
            if (Credit >= Price)
            {
                Credit = Credit - Price;
                Console.WriteLine("60 yaş üzeri tarifesi uygulandı...");
            }
            else
            {
                Console.WriteLine("Yeterli Bakiyeniz yoktur");
            }
        }

        public void write()
        {
            Console.WriteLine("UserID: "+this.UserID);
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("TCNumber: " + TcNumber);
            Console.WriteLine("CardNumber: " + this.CardNumber);
            Console.WriteLine("Price: " + this.Price);
            Console.WriteLine("Credit: " + this.Credit);
            //Console.WriteLine("cardnumber1: " + this.CardNumber1);
            //Console.WriteLine("cardnumber2: " + this.CardNumber2);

        }

       
    }
}
