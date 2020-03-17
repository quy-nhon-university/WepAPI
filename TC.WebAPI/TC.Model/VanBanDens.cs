using System;
using System.ComponentModel.DataAnnotations;

namespace TC.Model
{
    public class VanBanDens
    {
        [Key]
        public int ID { get; set; }
        
        public string MaVanBan { get; set; }
        public string SoVanBan { get; set; }
        public string KyHieu { get; set; }
        public string TrichYeu { get; set; }
        public DateTime NgayKy { get; set; }
        public string NguoiKy { get; set; }
        public int  LinhVucID { get; set; }
        public int DoQuanTrongID { get; set; }
        public int DoMatID { get; set; }
        public int DoKhanID { get; set; }
        public string KhoiBanHanh { get; set; }
        public DateTime NgayDen { get; set; }
        public string NoiBanHanh { get; set; }
        public string NoiGoi { get; set; }
        public DoKhans DoKhans { get; set; }
        public DoMats DoMats { get; set; }
        public DoQuanTrongs DoQuanTrongs { get; set; }
        public LinhVucs LinhVucs { get; set; }

    }
}
