using BankApplicationForUniser.Entities;
using BankApplicationForUniser.Extensions;
using BankApplicationForUniser.Interfaces;
using BankApplicationForUniser.Managers;
using BankApplicationForUniser.Models;
using System.Xml.Linq;

namespace BankApplicationForUniser
{
    public partial class Form1 : Form
    {

        private readonly ICustomerManager _customerManager;
        Customer editedCustomer = new Customer();
        public Form1()
        {
            _customerManager = new CustomerManager();
            FillDataGrid();
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;

            int id = (int)dataGridView1.Rows[index].Cells["Id"].Value;

            editedCustomer = await _customerManager.GetCustomerWithWorkDetailById(id);

            if (editedCustomer != null)
            {

                txt_company.Text = editedCustomer.CustomerWorkDetail.CompanyName;
                txt_FirstName.Text = editedCustomer.FirstName;
                txt_lastName.Text = editedCustomer.LastName;
                txt_salary.Text = editedCustomer.CustomerWorkDetail.Salary.ToString();
                txt_Experience.Text = editedCustomer.CustomerWorkDetail.Experience.ToString();
            }

        }



        private async void btn_Add_Click(object sender, EventArgs e)
        {

            ValidationForCustomer();
            Customer customer = new Customer
            {
                FirstName = txt_FirstName.Text,
                LastName = txt_lastName.Text,
                CustomerWorkDetail = new CustomerWorkDetail
                {
                    Experience = txt_Experience.Text.ToInt(),
                    Salary = txt_salary.Text.ToInt(),
                    CompanyName = txt_company.Text
                }
            };

            await _customerManager.AddAsync(customer);

            await _customerManager.SaveChangesAsync();

            MessageBox.Show("Customer added Successfully");
            ResetForm();
            FillDataGrid();
        }

        private async void FillDataGrid()
        {
            var customers = await _customerManager.GetCustomersWithWorkDetail();

            List<CustomerViewModel> customerViewModels = new List<CustomerViewModel>();
            foreach (var cust in customers)
            {
                customerViewModels.Add(new CustomerViewModel
                {
                    Id = cust.Id,
                    FullName = cust.FullName,
                    Company = cust.CustomerWorkDetail.CompanyName,
                    Experience = cust.CustomerWorkDetail.Experience,
                    Salary = cust.CustomerWorkDetail.Salary,
                });
            }
            dataGridView1.DataSource = customerViewModels;
        }

        private void ResetForm()
        {
            txt_company.Text = "";
            txt_Experience.Text = "";
            txt_FirstName.Text = "";
            txt_lastName.Text = "";
            txt_salary.Text = "";

        }

        private void ValidationForCustomer()
        {
            if (txt_company.Text.IsNull())
            {
                throw new Exception("Company is invalid");
            }

            if (txt_FirstName.Text.IsNull())
            {
                throw new Exception("First Name is invalid");
            }

            if (txt_FirstName.Text.IsNull())
            {
                throw new Exception("Last Name is Invalid");
            }

            if (txt_Experience.Text.ToInt() < 1)
            {
                throw new Exception("Experience must be greater than 1");
            }

            if (txt_salary.Text.ToInt() < 250)
            {
                throw new Exception("Salary must be greater than 250");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load_2(object sender, EventArgs e)
        {

        }

        private async void btn_Update_Click(object sender, EventArgs e)
        {
            ValidationForCustomer();

            if (editedCustomer is not null)
            {

                editedCustomer.FirstName = txt_FirstName.Text;
                editedCustomer.LastName = txt_lastName.Text;
                editedCustomer.CustomerWorkDetail.CompanyName = txt_company.Text;
                editedCustomer.CustomerWorkDetail.Salary = txt_salary.Text.ToInt();
                editedCustomer.CustomerWorkDetail.Experience = txt_Experience.Text.ToInt();
                await _customerManager.SaveChangesAsync();
                ResetForm();
                FillDataGrid();
            }


        }
    }
}
