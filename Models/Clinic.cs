using System;
using System.Data.Entity;
using System.Linq;

namespace CliniSoft.Models
{
    public class Clinic : DbContext
    {
        public Clinic()
            : base("name=Clinic")
        {
        }
        public virtual DbSet<tbl_Children> Tbl_Childrens { get; set; }
    }

}