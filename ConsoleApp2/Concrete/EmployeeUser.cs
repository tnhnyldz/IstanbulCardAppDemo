using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Concrete
{
    public class EmployeeUser :User
    {
        public EmployeeUser(string name, string surname, string tcNumber, double credit) : base(name, surname, tcNumber, credit)
        {
        }

        public override void pay()
        {
            double employeePrice = (Price * 75) / 100;
            if (Credit >= Price)
            {
                Credit = Credit - employeePrice;
                Console.WriteLine("Çalışan tarifesi uygulandı...");
            }
            else
            {
                Console.WriteLine("Yeterli Bakiyeniz yoktur");
            }
        }
    }
}
