using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace topic14.BUS
{
    public class Clear_comboBox
    {
        public static void clear(ComboBox[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i].Text = "";
            }
        }
    }
}
