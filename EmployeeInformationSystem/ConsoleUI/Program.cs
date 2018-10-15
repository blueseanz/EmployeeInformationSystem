using BusinessObjectLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            RoleDB R = new RoleDB();
            R.Insert(new Role() { RoleName = "Manager", RoleCode = "M" });
            R.Save();            
        }
    }
}
