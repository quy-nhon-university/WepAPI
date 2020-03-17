using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TC.Model
{
    public class FileDinhKems
    {
        [Key]
        public int ID{ get; set; }
        public string FilePath { get; set; }
        public int VanBanDenId { get; set; }
        public string TenFile { get; set; }
        public VanBanDens VanBanDens { get; set; }
    }
}
