using REFAT.Code.Models;
using REFAT.Core;
using REFAT.Data.EF;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace REFAT.Code.Helpers
{
   public static class SystemRecordHelper
    {
        public static void Add(string title , string desecription)
        {
            IDataHelper<SystemRecords> dataHelper = new SystemRecordsEF();
            SystemRecords systemRecords = new SystemRecords
            {
                CreatedDate = DateTime.Now,
                Desiccation = desecription,
                Title = title,
                DeviceName = Environment.UserName,
                FullName = LocalUser.FullName,
                UsersId = LocalUser.Id,
                MachinId = getMachinId()

            };
            dataHelper.Add(systemRecords);
        }
        private static string getMachinId()
        {
            var networkingInterface =  NetworkInterface.GetAllNetworkInterfaces();
            string machin_id = string.Empty ;
            foreach (var item in networkingInterface)
            {
                if (item.OperationalStatus==OperationalStatus.Up 
                    && item.NetworkInterfaceType !=NetworkInterfaceType.Tunnel
                   && item.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                {
                    machin_id = item.GetPhysicalAddress().ToString();
                }
                if (machin_id == string.Empty)
                {
                    machin_id = "null";
                }
            }
            return machin_id ;
        }
    }
}
