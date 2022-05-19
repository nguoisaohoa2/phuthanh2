namespace PRN.SE623
{
    public class EmployeeBase
    {
        private int _id;
        private string _name;

        public double Salary { get; set; }
    
        public int id { get => _id; set => _id = value; }

        public String name { get => _name; set => _name = value; }
    
        public String NameofCompany { get => _name; }
    }
}