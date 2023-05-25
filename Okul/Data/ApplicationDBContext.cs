using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Okul.Models;

namespace Okul.Data

{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options):base(options)

        {
            
        }
        public virtual DbSet<Ogretmen>Ogretmens { get; set; }
        public virtual DbSet<Ogrenci>Ogrencis { get; set; }
        public virtual DbSet<Ders> Derss {  get; set; }
    }
}
