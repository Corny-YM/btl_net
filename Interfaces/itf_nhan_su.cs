using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic14.Interfaces
{
    interface itf_nhan_su
    {
        void insert(string id_phong_ban, string id_nhan_su,
                            string id_luong, string ho_ten,
                            string ngay_sinh, string gioi_tinh,
                            string tt_hon_nhan, string cmnd,
                            string vai_tro, string hop_dong,
                            string ngay_ky, string ngay_het_han);
        void update(string id_phong_ban, string id_nhan_su,
                            string id_luong, string ho_ten,
                            string ngay_sinh, string gioi_tinh,
                            string tt_hon_nhan, string cmnd,
                            string vai_tro, string hop_dong,
                            string ngay_ky, string ngay_het_han);
        void delete(string id);
    }
}
