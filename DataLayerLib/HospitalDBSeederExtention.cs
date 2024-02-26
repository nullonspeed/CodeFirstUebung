using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerLib
{
    public static class HospitalDBSeederExtention
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            Console.WriteLine($"DB seeding started");
            Patient p1 = new Patient { PatientId= 1, Firstname="Klausi", Lastname="bua" , SVNR=1235435754};
            Patient p2 = new Patient { PatientId = 2, Firstname = "Peter", Lastname = "Mon", SVNR = 1274435754 };
            Patient p3 = new Patient { PatientId = 3, Firstname = "Gustav", Lastname = "Verletzt", SVNR = 1254435754 };
            Patient p4 = new Patient { PatientId = 4, Firstname = "Kevin", Lastname = "Toibert", SVNR = 123535754 };
            Patient p5 = new Patient { PatientId = 5, Firstname = "Eppenstoner", Lastname = "Bistduhacke", SVNR = 123535554 };

            modelBuilder.Entity<Patient>().HasData(p1,p2, p3, p4, p5);
            
            Doctor d1 = new Doctor {DoctorId = 1, Firstname ="Simon", Lastname="bergarzt" };
            Doctor d2 = new Doctor { DoctorId = 2, Firstname = "Tobi", Lastname = "Taugtalsarzt" };
            Doctor d3 = new Doctor { DoctorId = 3, Firstname = "Derik", Lastname = "Dicht" };
            modelBuilder.Entity<Doctor>().HasData(d1,d2,d3);

            modelBuilder.Entity<Examination>().HasData(new Examination
            {
                ExaminationId=1,
                Description="Extraktion alkohol aus blut",
                PatientPatientId=1,
                // ExaminationPatient = p1; nein nein nein, nicht machen, gefährlich, böse, hackelt ned
                DoctorDoctorId=1,
                // ExaminationDoctor = d1; nein nein nein, nicht machen, gefährlich, böse, hackelt ned
            });


            Console.WriteLine($"DB seeding has been finished");
        }
    }
}
