using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOop02
{
    internal class HiringDate
    {

        #region porperties
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        #endregion
   
        #region constructor
        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        #endregion

        #region method
        public void PrintHiringDate()
        {
            Console.WriteLine($"hiring date: {Day}/{Month}/{Year}");
        } 
        #endregion
    }
}
