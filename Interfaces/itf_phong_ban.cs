using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic14.Interfaces
{
    interface itf_phong_ban
    {
        void insert(string id_phong_ban, string ten,
                                  string ngay_thanh_lap, string status);
        void update(string id_phong_ban, string ten,
                                  string ngay_thanh_lap, string status);
        void delete(string id);
    }
}
