using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploEnum.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValueperHour { get; set; }
        public int Hour { get; set; }

        public double TotalValue()
        {
            return ValueperHour * Hour;
        }
    }
}
