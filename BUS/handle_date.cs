using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace topic14.BUS
{
    public class handle_date
    {
        public static string formDate_yy_mm_dd(DateTimePicker obj)
        {
            if(obj.Value.Date != DateTime.Today )
            {
                string day = obj.Value.Day.ToString();
                string month = obj.Value.Month.ToString();
                string year = obj.Value.Year.ToString();
                string result = year + "-" + month + "-" + day;
                return result;
            }
            return null;
        }
    }
}
