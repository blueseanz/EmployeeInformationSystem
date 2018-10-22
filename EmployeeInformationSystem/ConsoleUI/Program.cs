using BusinessObjectLayer;
using BusinessLogicLayer;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            RoleBusinessLogic R = new RoleBusinessLogic();
            R.Insert(new Role() { RoleName = "Admin", RoleCode = "A" });
            R.Insert(new Role() { RoleName = "User", RoleCode = "U" });
        }
    }
}
