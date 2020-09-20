using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApplicationCommon.Models
{
    public class MobileContext: DbContext
    {
        public MobileContext() : base(@"Data Source=.\SQLSERVER;Initial Catalog=mobiledb;Integrated Security=True")
        {

        }
        public DbSet<Phone> Phones { get; set; }
    }
}
