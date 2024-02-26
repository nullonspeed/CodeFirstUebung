using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerLib
{
    public class HospitalContext :DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Examination> Examinations { get; set; }
        public HospitalContext(){}
        public HospitalContext(DbContextOptions<HospitalContext> options) :base(options){}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);
            Console.WriteLine($"DB OnConfiguring: IsConfigured ={optionsBuilder.IsConfigured}");

            if(optionsBuilder != null && !optionsBuilder.IsConfigured)
            {
                string conStr = @"server=(LocalDB)\mssqllocaldb;attachdbfilename=
                    C:\Users\basti\Desktop\schule\5KL\Programmieren\EntityCodefirst\CodeFirstUebung\DataLayerLib\HosDBGrpB.mdf; 
                    database=HosDBGRpB;integrated security=True;MultipleActiveResultSets=True;";
           
                Console.WriteLine($"Using ConnStr = {conStr}");
                optionsBuilder.UseSqlServer( conStr );
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
