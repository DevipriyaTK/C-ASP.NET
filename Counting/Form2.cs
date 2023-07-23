using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counting
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<int> numberList = new List<int>();
        List<string> textList = new List<string>();
        List<Employee> employeeList = new List<Employee>();

        public List<Employee> fillList()
        {
            employeeList.Clear();
            Employee employee1 = new Employee();
            employee1.Id = 1;
            employee1.Name = "John";
            employee1.Age = 27;
            employeeList.Add(employee1);
            Employee employee2 = new Employee();
            employee2.Id = 2;
            employee2.Name = "Sam";
            employee2.Age = 30;
            employeeList.Add(employee2);
            Employee employee3 = new Employee();
            employee3.Id = 3;
            employee3.Name = "Charles";
            employee3.Age = 35;
            employeeList.Add(employee3);
            return employeeList;

        }

        List<Days> daysList = new List<Days>();

        private void btnFillList_Click(object sender, EventArgs e)
        {
            fillList();
            foreach (var item in employeeList)
            {
                txtNumberList.Text += item.Id + " " + item.Name.ToString() + " " + item.Age + Environment.NewLine;
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            daysList.Clear();
            Days day1 = new Days();
            day1.Id = 1;
            day1.Day = "Sunday";
            daysList.Add(day1);
            Days day2 = new Days();
            day2.Id = 2;
            day2.Day = "Monday";
            daysList.Add(day2);
            Days day3 = new Days();
            day3.Id = 3;
            day3.Day = "Tuesday";
            daysList.Add(day3);
            Days day4 = new Days();
            day4.Id = 4;
            day4.Day = "Wednesday";
            daysList.Add(day4);
            Days day5 = new Days();
            day5.Id = 5;
            day5.Day = "Thursday";
            daysList.Add(day5);
            Days day6 = new Days();
            day6.Id = 6;
            day6.Day = "Friday";
            daysList.Add(day6);
            Days day7 = new Days();
            day7.Id = 7;
            day7.Day = "Saturday";
            daysList.Add(day7);
            cmbDaysList.DataSource = daysList;
            cmbDaysList.ValueMember = "Id";
            cmbDaysList.DisplayMember = "Day";
            gvDays.DataSource = daysList;
        }

        private void cmbDaysList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbDaysList.SelectedValue.ToString());
        }
    }
}
