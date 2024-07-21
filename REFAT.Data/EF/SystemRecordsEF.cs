using REFAT.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace REFAT.Data.EF
{
    public class SystemRecordsEF : IDataHelper<SystemRecords>
    {
        private DBContext db;
        private SystemRecords systemRecords;
        public SystemRecordsEF()
        {
            db = new DBContext();
            systemRecords = new SystemRecords();
        }
        public string Add(SystemRecords table)
        {
            try
            {
                db.SystemRecords.Add(table);
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
                systemRecords = Find(id);
                db.SystemRecords.Remove(systemRecords);
                db.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Edit(SystemRecords table)
        {
            try
            {
                db = new DBContext();

                db.SystemRecords.Update(table);
                db.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public SystemRecords Find(int Id)
        {
            try
            {
                db = new DBContext();

                return db.SystemRecords.Find(Id) ?? new SystemRecords();//إذا كان فارغ رجع نيو
            }
            catch 
            {

                return new SystemRecords();
            }
        }

        public List<SystemRecords> GetAllData()
        {
            try
            {
                db = new DBContext();

                return db.SystemRecords.OrderByDescending(l => l.Id).ToList();
            }
            catch 
            {

                return new List<SystemRecords>();
            }
        }

        public List<SystemRecords> GetDataByUser(string UserId)
        {
            try
            {
                db = new DBContext();

                return db.SystemRecords.Where(l=>l.UsersId.ToString() == UserId).OrderByDescending(l => l.Id).ToList();
            }
            catch
            {

                return new List<SystemRecords>();
            }
        }

        public bool IsCanConnect()
        {
             return db.Database.CanConnect();
        }

        public List<SystemRecords> SearchAll(string searchItem)
        {
            try
            {
                return db.SystemRecords.Where (l=> l.Id.ToString() == searchItem 
                 || l.UsersId.ToString() == searchItem
                 || l.FullName.Contains ( searchItem)
                 || l.MachinId.Contains(searchItem)
                 || l.Title.Contains(searchItem)
                 || l.Desiccation.Contains(searchItem)
                 || l.CreatedDate.ToString().Contains(searchItem)
                 ).OrderByDescending(l => l.Id).ToList();
            }
            catch
            {

                return new List<SystemRecords>();
            }
        }

        public List<SystemRecords> SearchByUser(string UserId, string searchItem)
        {
            try
            {
                return db.SystemRecords.Where(u=> u.UsersId.ToString() == UserId).Where(l => l.Id.ToString() == searchItem
                 || l.UsersId.ToString() == searchItem
                 || l.FullName.Contains(searchItem)
                 || l.MachinId.Contains(searchItem)
                 || l.Title.Contains(searchItem)
                 || l.Desiccation.Contains(searchItem)
            || l.CreatedDate.ToString().Contains(searchItem)
                 ).OrderByDescending(l => l.Id).ToList();
            }
            catch
            {

                return new List<SystemRecords>();
            }
        }
    }
}
