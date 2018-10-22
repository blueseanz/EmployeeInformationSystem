using BusinessObjectLayer;
using DataAccessLayer;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicLayer
{
    public class EmployeeBusinessLogic
    {
        private EmployeeDB objDB;

        public List<string> Errors = new List<string>();

        public EmployeeBusinessLogic()
        {
            objDB = new EmployeeDB();
        }

        public IEnumerable<Employee> GetALL()
        {
            return objDB.GetALL();
        }

        public Employee GetByID(string Id)
        {
            return objDB.GetByID(Id);
        }

        public bool Insert(Employee emp)
        {
            if(IsValidOnInsert(emp))
            {
                objDB.Insert(emp);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Delete(string Id)
        {
            objDB.Delete(Id);
        }

        public bool Update(Employee emp)
        {
            if(IsValidOnUpdate(emp))
            {
                objDB.update(emp);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Employee GetByEmail(string email)
        {
            var emp = objDB.getEmployeeByEmail(email);
            return emp;
        }

        public bool IsValidOnInsert(Employee emp)
        {
            return true;
        }

        public bool IsValidOnUpdate(Employee emp)
        {
            return true;
        }
    }
}
