using BankAccountForm.Entities.Accounts;
using BankAccountForm.Extensions;
using BankAccountForm.Interfaces.Accounts;
using BankAccountForm.Managers.Accounts;

namespace BankAccountForm
{
    public partial class Form1 : Form
    {
        private readonly ICustomerManager _customerManeger;
        Customer editedCustomer = new Customer();
        public Form1()
        {
            InitializeComponent();
            _customerManeger = new CustomerManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void button4_Click(object sender, EventArgs e)
        {

        }

        private Customer InitCustomerForm()
        {
            if (txt_FirstName.IsNull() ||
                txt_lastName.IsNull() ||
                txt_company.IsNull() ||
                !txt_Salary.GreaterThan(250) ||
                !txt_Exp.GreaterThan(1))
            {
                MessageBox.Show("Invalid Form!");
                return null;
            }

            return new Customer
            {
                FirstName = txt_FirstName.Text,
                LastName = txt_lastName.Text,
                CustomerWorkDetail = new CustomerWorkDetail()
                {
                    CompanyName = txt_company.Text,
                    Salary = txt_Salary.ToInt(),
                    Experience = txt_Exp.ToInt()
                }
            };
        }

        private async void FillDataGrid()
        {
            dataGridView1.DataSource = await _customerManeger.GetCustomerWithDetail();
        }

        private async void button4_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private async void btn_Add_Click(object sender, EventArgs e)
        {
            var customer = InitCustomerForm();

            if (customer != null)
            {
                await _customerManeger.Add(customer);
                await _customerManeger.SaveChangesAsync();
                MessageBox.Show("Customer Data added succesfully");
                FillDataGrid();
            }

            ClearCustomerForm();
        }


        private void ClearCustomerForm()
        {
            txt_company.Text = string.Empty;
            txt_Salary.Text = string.Empty;
            txt_Exp.Text = string.Empty;
            txt_FirstName.Text = string.Empty;
            txt_lastName.Text = string.Empty;
        }

        private async void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var index = e.RowIndex;
            int id = (int)dataGridView1.Rows[index].Cells["Id"].Value; // Id

            editedCustomer = await _customerManeger.GetCustomerWithDetailById(id);

            if (editedCustomer != null)
            {
          
                txt_company.Text = editedCustomer.CustomerWorkDetail.CompanyName;
                txt_FirstName.Text = editedCustomer.FirstName;
                txt_lastName.Text = editedCustomer.LastName;
                txt_Salary.Text = editedCustomer.CustomerWorkDetail.Salary.ToString();
                txt_Exp.Text = editedCustomer.CustomerWorkDetail.Experience.ToString();
            }


        }

        private  async void btn_Update_Click(object sender, EventArgs e)
        {
            var customer = InitCustomerForm();

            if (customer != null)
            {
                editedCustomer.FirstName = customer.FirstName;
                editedCustomer.LastName = customer.LastName;
                editedCustomer.CustomerWorkDetail.CompanyName = customer.CustomerWorkDetail.CompanyName;
                editedCustomer.CustomerWorkDetail.Salary = customer.CustomerWorkDetail.Salary;
                editedCustomer.CustomerWorkDetail.Experience = customer.CustomerWorkDetail.Experience;
                await _customerManeger.SaveChangesAsync();
                FillDataGrid();
            }
           
        }
    }

}
