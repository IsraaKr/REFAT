using System;
using System.Collections.Generic;
using System.Text;

namespace REFAT.Core
{
    public class SalaryRate
    {
        public int Id { get; set; }
        public int Degree { get; set; }
        public float Salary { get; set; }
        public float BonusYearRate { get; set; }
        public int PromotionYear { get; set; }

       public string UsersId { get; set; }
    }
}
