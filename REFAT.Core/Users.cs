using System;
using System.Collections.Generic;
using System.Text;

namespace REFAT.Core
{
    public class Users
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Role { get; set; }//الصلاحية العامة
        public bool IsSecondaryUser { get; set; }
        public string UserId { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime EditedDate { get; set; }

        //Navication

        public List<Roles> Roles { get; set; }
        public List<SystemRecords> SystemRecords { get; set; }

    }
}
