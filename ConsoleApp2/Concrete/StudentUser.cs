using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Concrete
{
    public class StudentUser:User
    {
        public StudentUser(string name, string surname, string tcNumber, double credit) : base(name, surname, tcNumber, credit)
        {
        }

        public override void pay()
        {
            double studentPrice = (Price * 50) / 100;
            if (Credit >= Price)
            {
                Credit = Credit - studentPrice;
                Console.WriteLine("öğrenci tarifesi uygulandı...");
            }
            else
            {
                Console.WriteLine("Yeterli Bakiyeniz yoktur");
            }
        }
    }
}
