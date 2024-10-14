using System.Numerics;

namespace Unit5_AdapterPatternPatient_Blazor.InsuranceSystem {
    class OutNetworkAdapter : InsuranceInterface
    {
        readonly OutNetworkPatient patient;
        public OutNetworkAdapter(string newName, string newPolicyNumber){
            patient = new OutNetworkPatient(newName, int.Parse(newPolicyNumber));
        }

        public decimal CoverageAmount(int ProcedureID, decimal ProcedureCost)
        {
            return patient.CoveragePercent(ProcedureCost) * ProcedureCost;
        }

        public string getPatientName()
        {
            return patient.getPatientName();
        }

        public string getPolicyNumber()
        {
            return patient.PolicyNumber.ToString();
        }

        public bool IsCovered(string patientName, string policyNumber)
        {
            return patient.IsCovered(patientName, int.Parse(policyNumber)).Equals("yes");
        }
    }
}