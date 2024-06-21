using REFAT.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace REFAT.Data.EF
{
    public class UsersEF : IDataHelper<Users>
    {
        private DBContext db;
        private Users users;
        public UsersEF()
        {
            db = new DBContext();
            users = new Users();
        }
        public string Add(Users table)
        {
            try
            {
                db.Users.Add(table);
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
                users = Find(id);
                db.Users.Remove(users);
                db.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Edit(Users table)
        {
            try
            {
                db = new DBContext();
                db.Users.Update(table);
                db.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public Users Find(int Id)
        {
            try
            {
                db = new DBContext();

                return db.Users.Find(Id) ?? new Users();//إذا كان فارغ رجع نيو
            }
            catch 
            {

                return new Users();
            }
        }

        public List<Users> GetAllData()
        {
            try
            {
                db = new DBContext();

                return db.Users.ToList();
            }
            catch 
            {

                return new List<Users>();
            }
        }

        public List<Users> GetDataByUser(string UserId)
        {
            try
            {
                db = new DBContext();

                return db.Users.Where(l=>l.UserId == UserId).ToList();
            }
            catch
            {

                return new List<Users>();
            }
        }

        public bool IsCanConnect()
        {
             return db.Database.CanConnect();
        }

        public List<Users> SearchAll(string searchItem)
        {
            try
            {
                return db.Users.Where (l=> l.Id.ToString() == searchItem 
                 || l.UserId == searchItem
                 || l.Address.Contains ( searchItem)
                 || l.Email.Contains(searchItem)
                 || l.Phone.Contains(searchItem)
                 || l.FullName.Contains(searchItem)
                 || l.UserName.Contains(searchItem)
                 || l.CreatedDate.ToShortDateString().Contains(searchItem)
                 || l.EditedDate.ToShortDateString().Contains(searchItem)
                 ).ToList();
            }
            catch
            {

                return new List<Users>();
            }
        }

        public List<Users> SearchByUser(string UserId, string searchItem)
        {
            try
            {
                return db.Users.Where(u=> u.UserId == UserId).Where(l => l.Id.ToString() == searchItem
                || l.UserId == searchItem
                || l.Address.Contains(searchItem)
                || l.Email.Contains(searchItem)
                || l.Phone.Contains(searchItem)
                || l.FullName.Contains(searchItem)
                || l.UserName.Contains(searchItem)
                || l.CreatedDate.ToShortDateString().Contains(searchItem)
                || l.EditedDate.ToShortDateString().Contains(searchItem)
                 ).ToList();
            }
            catch
            {

                return new List<Users>();
            }
        }
    }
}
