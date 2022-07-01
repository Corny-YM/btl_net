using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic14.Interfaces
{
    interface itf_bang_luong
    {
        void insert(string id_luong, string luong_co_ban,
                                  string ngay_nhap, string status);
        void update(string id_luong, string luong_co_ban,
                                  string ngay_nhap, string status);
        void delete(string id);
    }
}
