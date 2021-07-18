using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CliniSoft.Models
{
    public class ChildrenViewModel
    {
        public List<tbl_Children> SelectedChildrens { get; set; }
        public List<tbl_Children> UnSelectedChildrens { get; set; }
    }
}