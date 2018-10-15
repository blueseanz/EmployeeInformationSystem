using BusinessObjectLayer;
using DataAccessLayer;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicLayer
{
    public class RoleBusinessLogic
    {
        private RoleDB objDB;

        public RoleBusinessLogic()
        {
            objDB = new RoleDB();
        }

        public IEnumerable<Role> GetALL()
        {
            return objDB.GetALL().ToList();
        }

        public Role GetByID(int Id)
        {
            return objDB.GetByID(Id);
        }

        public void Insert(Role role)
        {
            objDB.Insert(role);
        }

        public void Delete(int Id)
        {
            objDB.Delete(Id);
        }

        public void Update(Role role)
        {
            objDB.update(role);
        }
    }
}
