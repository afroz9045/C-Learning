namespace AbstractionExample
{
    public class Abstraction
    {

        public int EmpId;
        public string EmpName;
        public double GrossPay;
        double TaxDedection = 0.1; //10%
        double netSalary;

        public Abstraction(int eid,String eName,double eGrossPay)
        {
            this.EmpId = eid;
            this.EmpName = eName;
            this.GrossPay = eGrossPay;
        }
        void CalculateSalary()
        {
            if (GrossPay >= 30000)
            {
                netSalary = GrossPay - (TaxDedection * GrossPay);
                Console.WriteLine($"Your net salary is: {netSalary}");
            }
            else
            {
                Console.WriteLine($"Your salary is: {GrossPay}"); 
            }
            
        }

        public void ShowEmployeeDetails()
        {
            this.CalculateSalary();
        }
    }
}