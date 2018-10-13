using BusinessObjectLayer;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccessLayer
{
    public class RoleDB:DataAccessLayerBase
    {
        public IEnumerable<Role> GetALL()
        {
            return db.Roles.ToList();
        }

        public Role GetByID(int Id)
        {
            return db.Roles.Find(Id);
        }

        public void Insert(Role role)
        {
            db.Roles.Add(role);
            Save();
        }

        public void Delete(int Id)
        {
            Role role = db.Roles.Find(Id);
            db.Roles.Remove(role);
            Save();
        }

        public void update(Role role)
        {
            db.Entry(role).State = EntityState.Modified;
            db.Configuration.ValidateOnSaveEnabled = false;
            Save();
            db.Configuration.ValidateOnSaveEnabled = true;
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
