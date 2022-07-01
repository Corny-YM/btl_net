using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic14.Interfaces
{
    interface itf_thong_tin
    {
        void insert(string id_thong_tin, string id_nhan_su,
                                string noi_sinh, string que_quan,
                                string dan_toc, string ton_giao,
                                string quoc_tich, string hoc_van,
                                string sdt, string status);
        void update(string id_thong_tin, string id_nhan_su,
                                string noi_sinh, string que_quan,
                                string dan_toc, string ton_giao,
                                string quoc_tich, string hoc_van,
                                string sdt, string status);
        void delete(string id);
    }
}
