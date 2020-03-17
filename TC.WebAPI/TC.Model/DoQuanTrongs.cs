using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TC.Model
{
    public class DoQuanTrongs
    {
        [Key]
        public int ID { get; set; }
        public string TenMucDo { get; set; }

    }
}
