namespace ConstructorLib
{
    public class ConstructorPractice
    {
        int EmpId;
        string EmpName;
        int EmpAge;
        public ConstructorPractice(int empId,string empName,int empAge)
        {
            this.EmpId = empId;
            this.EmpName = empName;
            this.EmpAge = empAge;
        }
        public int GetEmpId()
        {
            return this.EmpId;
        }
        public string GetEmpName()
        {
            return this.EmpName;
        }
        public int GetAge()
        {
            return this.EmpAge;
        }
    }
}