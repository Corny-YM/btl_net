using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic14.Interfaces
{
    interface itf_cham_cong
    {
        void insert(string id_nhan_su, string thang, string ngay_cong);

        void update(string id_nhan_su, string thang, string ngay_cong);

        void delete(string id_nhan_su, string thang);

        DataTable find(string id);
    }
}
