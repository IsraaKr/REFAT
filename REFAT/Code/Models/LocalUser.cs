﻿using REFAT.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace REFAT.Code.Models
{
  internal static  class LocalUser
    {
        public static int Id { get; set; }
        public static string FullName { get; set; }
        public static string UserName { get; set; }
        public static string PassWord { get; set; }
        public static string Role { get; set; }//الصلاحية العامة
        public static bool IsSecondaryUser { get; set; }
        public static string UserId { get; set; }
        public static string? Phone { get; set; }
        public static string? Address { get; set; }
        public static string? Email { get; set; }
        public static DateTime CreatedDate { get; set; }
        public static DateTime EditedDate { get; set; }

        //Navication

        public static List<Roles> Roles { get; set; }
        public static List<SystemRecords> SystemRecords { get; set; }

    }
}
