using Bind_Record_Into_DDL_MVC_CORE.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bind_Record_Into_DDL_MVC_CORE.Data
{
      public class ApplicationDbContext : IdentityDbContext
    {
        internal object country;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CountryClass> CountryClasses { get; set; }
    }
}
