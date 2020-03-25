using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Worker
    {
        public static int WorkerID { get; set; }
        public static string WorkerSurname { get; set; }
        public static string WorkerName { get; set; }
        public static string WorkerPatronymic { get; set; }
        public static int NumberOfWorkDays { get; set; }
        public static int CardNumber { get; set; }
        public static int PositionID { get; set; }
        public static double Rate { get; set; }
        public static double Experience { get; set; }
        public static double SickLeave { get; set; }
        public static double Premium { get; set; }
        public static double Tax { get; set; }

        public Worker(int workerID, string workerSurname, string workerName, string workerPatronymic, int numberOfWorkDays, int cardNumber, int positionID, double rate, double experience, double sickLeave, double premium, double tax)
        {
            WorkerID = workerID;
            WorkerSurname = workerSurname;
            WorkerName = workerName;
            WorkerPatronymic = workerPatronymic;
            NumberOfWorkDays = numberOfWorkDays;
            CardNumber = cardNumber;
            PositionID = positionID;
            Rate = rate;
            Experience = experience;
            SickLeave = sickLeave;
            Premium = premium;
            Tax = tax;
        }
    }
}
