using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day10HPM
{
    internal abstract class PatientDetails
    {
        public string PatientName { get; set; }
        //public int InPatientID;
        public int PatientAge { get; set; }
        public string PatientDob { get; set; }
        public string PatientAddress { get; set; }
        public string ReferringDoctor { get; set; }



        protected PatientDetails()
        {
            
        }


        public abstract void AddPatientDetails();

        public abstract void GetPatientDetails();
        public abstract void RemovePatientDetails();

    }
}
