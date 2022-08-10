using ConsoleApp2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Abstract
{
    public interface IUser
    {
        public void pay();
        public void load(int amount);
        public void write();
    }
}
