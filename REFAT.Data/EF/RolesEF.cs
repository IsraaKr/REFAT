using REFAT.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace REFAT.Data.EF
{
    public class RolesEF : IDataHelper<Roles>
    {
        private DBContext db;
        private Roles roles;
        public RolesEF()
        {
            db = new DBContext();
            roles = new Roles();
        }
        public string Add(Roles table)
        {
            try
            {
                db.Roles.Add(table);
             db.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Delete(int id)
        {
            try
            {
                roles = Find(id);
                db.Roles.Remove(roles);
                db.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Edit(Roles table)
        {
            try
            {
                db = new DBContext();

                db.Roles.Update(table);
                //        db.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public Roles Find(int Id)
        {
            try
            {
                db = new DBContext();

                return db.Roles.Find(Id) ?? new Roles();//إذا كان فارغ رجع نيو
            }
            catch 
            {

                return new Roles();
            }
        }

        public List<Roles> GetAllData()
        {
            try
            {
                db = new DBContext();

                return db.Roles.ToList();
            }
            catch 
            {

                return new List<Roles>();
            }
        }

        public List<Roles> GetDataByUser(string UserId)
        {
            try
            {
                db = new DBContext();

                return db.Roles.Where(l=>l.UsersId.ToString() == UserId).ToList();
            }
            catch
            {

                return new List<Roles>();
            }
        }

        public bool IsCanConnect()
        {
             return db.Database.CanConnect();
        }

        public List<Roles> SearchAll(string searchItem)
        {
            try
            {
                return db.Roles.Where (l=> l.Id.ToString() == searchItem 
                 )  .ToList();
            }
            catch
            {

                return new List<Roles>();
            }
        }

        public List<Roles> SearchByUser(string UserId, string searchItem)
        {
            try
            {
                return db.Roles.Where(u=> u.UsersId.ToString() == UserId).Where(l => l.Id.ToString() == searchItem    ) .ToList();
            }
            catch
            {

                return new List<Roles>();
            }
        }
    }
}
