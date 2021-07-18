using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CliniSoft.Models
{
    public class tbl_Children
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Boolean IsSelected { get; set; }

    }
}