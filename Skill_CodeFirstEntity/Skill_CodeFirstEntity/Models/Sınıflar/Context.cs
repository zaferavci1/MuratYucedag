using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Skill_CodeFirstEntity.Models.Sınıflar
{
    public class Context : DbContext
    {
        public DbSet<Yetenekler> YETENEKLERS { get; set; }
    }
}