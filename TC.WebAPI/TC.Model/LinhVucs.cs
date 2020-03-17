using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TC.Model
{
    public class LinhVucs
    {
        [Key]
        public int ID { get; set; }
        public string TenLinhVuc { get; set; }

    }
}
