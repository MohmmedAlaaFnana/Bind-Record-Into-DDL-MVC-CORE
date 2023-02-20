using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bind_Record_Into_DDL_MVC_CORE.Models
{
    public class CountryClass
    {
        [Key]
        public int Cid { get; set; }

        public string Cname { get; set; }


    }
}
