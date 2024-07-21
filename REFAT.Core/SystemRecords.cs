using System;
using System.Collections.Generic;
using System.Text;

namespace REFAT.Core
{
    public class SystemRecords
    {
        public int Id { get; set; }
        public string FullName { get; set; }
   
        public string DeviceName { get; set; }
        public string MachinId { get; set; }
        public string Title { get; set; }

        public string Desiccation { get; set; }
        public DateTime CreatedDate { get; set; }
        //Navication
        public int UsersId { get; set; }//تسمية متعارف عليها  نفس اسم الكلاس و ثم اسم الحقل

   //     public Users Users { get; set; }
    }
}
