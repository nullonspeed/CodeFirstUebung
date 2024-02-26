using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerLib
{
    public class Examination
    {
        public int ExaminationId { get; set; }
        public string? Description { get; set; }

        public int PatientPatientId { get; set; }
        public Patient? ExaminationPatient { get; set; }
        public int DoctorDoctorId { get; set; }
        public Doctor? ExaminationDoctor { get; set; }
    }
}
