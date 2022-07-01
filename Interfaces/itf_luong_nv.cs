using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic14.Interfaces
{
    interface itf_luong_nv
    {
        void insert(string id_nhan_su, string id_luong,
                                string thuong, string ki_luat,
                                string thang, string status);
        void update(string stt, string id_nhan_su, string id_luong,
                                string thuong, string ki_luat,
                                string thang, string status);
        void delete(string id);
    }
}
