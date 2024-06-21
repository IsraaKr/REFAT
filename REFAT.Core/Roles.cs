using System;
using System.Collections.Generic;
using System.Text;

namespace REFAT.Core
{
    public class Roles
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public bool Value { get; set; }

        //Navication
        public int UsersId { get; set; }//تسمية متعارف عليها  نفس اسم الكلاس و ثم اسم الحقل

        public Users Users { get; set; }

    }
}
