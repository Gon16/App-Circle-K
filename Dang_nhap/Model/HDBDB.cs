using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Dang_nhap.Model
{
    public partial class HDBDB : DbContext
    {
        public HDBDB()
            : base("name=HDBDB")
        {
        }

        public virtual DbSet<Hoadon> Hoadon { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
