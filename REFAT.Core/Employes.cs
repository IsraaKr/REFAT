using System;
using System.Collections.Generic;
using System.Text;

namespace REFAT.Core
{
  public  class Employes
    {
        public int Id { get; set; }
        //general data
        public string Name { get; set; }
        public string JobTittle { get; set; }
        public string EmpSate { get; set; }
        public DateTime LastPromotionDate { get; set; }
    //curent Bones
        public int CurrentDegree { get; set; }
        public int CurrentStage { get; set; }
        public float CurrentSalary { get; set; }
        public DateTime CurrentDate { get; set; }
        //next Bones
        public int NextDegree { get; set; }
        public int NextStage { get; set; }
        public float NextSalary { get; set; }
        public DateTime NextDate { get; set; }
//other data

        public string Notes { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime UpdateDate { get; set; }
       //reletion ship
        public string UserId { get; set; }

       
    }
}
