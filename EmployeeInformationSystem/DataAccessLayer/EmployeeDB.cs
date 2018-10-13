using BusinessObjectLayer;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccessLayer
{
    public class EmployeeDB:DataAccessLayerBase
    {
        public IEnumerable<Employee> GetALL()
        {
            return db.Employees.ToList();
        }

        public Employee GetByID(int Id)
        {
            return db.Employees.Find(Id);
        }

        public void Insert(Employee employee)
        {
            db.Employees.Add(employee);
            Save();
        }

        public void Delete(int Id)
        {
            Employee employee = db.Employees.Find(Id);
            db.Employees.Remove(employee);
            Save();
        }

        public void update(Employee employee)
        {
            db.Entry(employee).State = EntityState.Modified;
            db.Configuration.ValidateOnSaveEnabled = false;
            Save();
            db.Configuration.ValidateOnSaveEnabled = true;
        }

        public Employee getEmployeeByEmail(string email)
        {
            return db.Employees.Where(x => x.Email == email).FirstOrDefault();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
