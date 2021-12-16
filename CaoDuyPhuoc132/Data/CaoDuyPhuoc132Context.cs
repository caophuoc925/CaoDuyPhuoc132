using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CaoDuyPhuoc132.Models;

namespace CaoDuyPhuoc132.Data
{
    public class CaoDuyPhuoc132Context : DbContext
    {
        public CaoDuyPhuoc132Context (DbContextOptions<CaoDuyPhuoc132Context> options)
            : base(options)
        {
        }

        public DbSet<CaoDuyPhuoc132.Models.UniversityCDP132> UniversityCDP132 { get; set; }
    }
}
