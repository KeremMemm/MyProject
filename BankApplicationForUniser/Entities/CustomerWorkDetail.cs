namespace BankApplicationForUniser.Entities
{
    public class CustomerWorkDetail
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        private  int salary;

        public int Salary
        {
            get { return salary; }
            set
            {
                if (value < 250)
                {
                    throw new Exception("Salary must greater than 250!");
                }
                salary = value;
            }
        }


        public int Experience { get; set; }

        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
