using REFAT.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace REFAT.Data.EF
{
    public class SalaryRateEF : IDataHelper<SalaryRate>
    {
        private DBContext db;
        private SalaryRate SalaryRate;
        public SalaryRateEF()
        {
            db = new DBContext();
            SalaryRate = new SalaryRate();
        }
        public string Add(SalaryRate table)
        {
            try
            {
                db.SalaryRate.Add(table);
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
                SalaryRate = Find(id);
                db.SalaryRate.Remove(SalaryRate);
                db.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Edit(SalaryRate table)
        {
            try
            {
                db = new DBContext();
                db.SalaryRate.Update(table);
                db.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public SalaryRate Find(int Id)
        {
            try
            {
                db = new DBContext();

                return db.SalaryRate.Find(Id) ?? new SalaryRate();//إذا كان فارغ رجع نيو
            }
            catch 
            {

                return new SalaryRate();
            }
        }

        public List<SalaryRate> GetAllData()
        {
            try
            {
                db = new DBContext();

                return db.SalaryRate.OrderByDescending(l=>l.Id).ToList();
            }
            catch 
            {

                return new List<SalaryRate>();
            }
        }

        public List<SalaryRate> GetDataByUser(string UserId)
        {
            try
            {
                db = new DBContext();

                return db.SalaryRate.Where(l=>l.UsersId == UserId)
                    .OrderByDescending(l=>l.Id).ToList();
            }
            catch
            {

                return new List<SalaryRate>();
            }
        }

        public bool IsCanConnect()
        {
             return db.Database.CanConnect();
        }

        public List<SalaryRate> SearchAll(string searchItem)
        {
            try
            {
                return db.SalaryRate.Where (l=> l.Id.ToString() == searchItem 
                 || l.UsersId == searchItem
                 || l.Degree.ToString() == searchItem
                 || l.Salary.ToString() == searchItem
                 || l.PromotionYear.ToString() == searchItem
                 || l.BonusYearRate.ToString() == searchItem
                 
                 ).OrderByDescending(l => l.Id).ToList();
            }
            catch
            {

                return new List<SalaryRate>();
            }
        }

        public List<SalaryRate> SearchByUser(string UserId, string searchItem)
        {
            try
            {
                return db.SalaryRate.Where(u=> u.UsersId == UserId).Where(l => l.Id.ToString() == searchItem
                     || l.UsersId == searchItem
                 || l.Degree.ToString() == searchItem
                 || l.Salary.ToString() == searchItem
                 || l.PromotionYear.ToString() == searchItem
                 || l.BonusYearRate.ToString() == searchItem

                 ).OrderByDescending(l => l.Id).ToList();
                
            }
            catch
            {

                return new List<SalaryRate>();
            }
        }
    }
}
