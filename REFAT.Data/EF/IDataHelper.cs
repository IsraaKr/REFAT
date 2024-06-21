using System;
using System.Collections.Generic;
using System.Text;

namespace REFAT.Data.EF
{
    //مساعد العمليات على الداتا بيز
   public interface IDataHelper<Table>
    {
        //Read {admin , user }
        List<Table> GetAllData();//admin
        List<Table> GetDataByUser( string UserId );//user
        List<Table> SearchAll(string searchItem);//admin
        List<Table> SearchByUser(string UserId, string searchItem);//user         
        Table Find(int Id);
        //Write
        string Add(Table table);//1==done , Errore
        string Edit(Table table);//1==done , Errore
        string Delete(int id);//1==done , Errore

        //other
        bool IsCanConnect();
    }
}
