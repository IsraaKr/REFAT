using REFAT.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace REFAT.Data.EF
{
    public class EmployesEF : IDataHelper<Employes>
    {
        private DBContext db;
        private Employes Employes;
        public EmployesEF()
        {
            db = new DBContext();
            Employes = new Employes();
        }
        public string Add(Employes table)
        {
            try
            {
                db.Employes.Add(table);
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
                Employes = Find(id);
                db.Employes.Remove(Employes);
                db.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Edit(Employes table)
        {
            try
            {
                db = new DBContext();
                db.Employes.Update(table);
                db.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public Employes Find(int Id)
        {
            try
            {
                db = new DBContext();

                return db.Employes.Find(Id) ?? new Employes();//إذا كان فارغ رجع نيو
            }
            catch 
            {

                return new Employes();
            }
        }

        public List<Employes> GetAllData()
        {
            try
            {
                db = new DBContext();

                return db.Employes.OrderByDescending(l=>l.Id).ToList();
            }
            catch 
            {

                return new List<Employes>();
            }
        }

        public List<Employes> GetDataByUser(string UserId)
        {
            try
            {
                db = new DBContext();

                return db.Employes.Where(l=>l.UserId == UserId)
                    .OrderByDescending(l=>l.Id).ToList();
            }
            catch
            {

                return new List<Employes>();
            }
        }

        public bool IsCanConnect()
        {
             return db.Database.CanConnect();
        }

        public List<Employes> SearchAll(string searchItem)
        {
            try
            {
                return db.Employes.Where (l=> l.Id.ToString() == searchItem 
                 || l.UserId == searchItem

                 || l.Name.Contains( searchItem)
                 || l.JobTittle.Contains(searchItem)
                 || l.EmpSate.ToString() == searchItem
                 || l.LastPromotionDate.ToString() == searchItem

                 || l.CurrentDegree.ToString() == searchItem
                 || l.CurrentStage.ToString() == searchItem
                 || l.CurrentSalary.ToString() == searchItem
                 || l.CurrentDate.ToString() == searchItem

                 || l.NextDegree.ToString() == searchItem
                 || l.NextStage.ToString() == searchItem
                 || l.NextSalary.ToString() == searchItem
                 || l.NextDate.ToString() == searchItem

                 || l.Notes.Contains(searchItem)
                 || l.AddedDate.ToString() == searchItem
                 || l.UpdateDate.ToString() == searchItem

                 ).OrderByDescending(l => l.Id).ToList();
            }
            catch
            {

                return new List<Employes>();
            }
        }

        public List<Employes> SearchByUser(string UserId, string searchItem)
        {
            try
            {
                return db.Employes.Where(u=> u.UserId == UserId).Where(l => l.Id.ToString() == searchItem
                  || l.UserId == searchItem

                 || l.Name.Contains(searchItem)
                 || l.JobTittle.Contains(searchItem)
                 || l.EmpSate.ToString() == searchItem
                 || l.LastPromotionDate.ToString() == searchItem

                 || l.CurrentDegree.ToString() == searchItem
                 || l.CurrentStage.ToString() == searchItem
                 || l.CurrentSalary.ToString() == searchItem
                 || l.CurrentDate.ToString() == searchItem

                 || l.NextDegree.ToString() == searchItem
                 || l.NextStage.ToString() == searchItem
                 || l.NextSalary.ToString() == searchItem
                 || l.NextDate.ToString() == searchItem

                 || l.Notes.Contains(searchItem)
                 || l.AddedDate.ToString() == searchItem
                 || l.UpdateDate.ToString() == searchItem

                 ).OrderByDescending(l => l.Id).ToList();
                
            }
            catch
            {

                return new List<Employes>();
            }
        }
    }
}
