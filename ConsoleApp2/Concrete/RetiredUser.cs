using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Concrete
{
    public class RetiredUser : User
    {
        public RetiredUser(string name, string surname, string tcNumber, double credit) : base(name, surname, tcNumber, credit)
        {
        }

        public override void pay()
        {
            double retiredPrice= (Price * 50) / 100;
            if (Credit >= Price)
            {
                Credit = Credit - retiredPrice;
                Console.WriteLine("60 yaş üzeri tarifesi uygulandı...");
            }
            else
            {
                Console.WriteLine("Yeterli Bakiyeniz yoktur");
            }
        }
    }
}
