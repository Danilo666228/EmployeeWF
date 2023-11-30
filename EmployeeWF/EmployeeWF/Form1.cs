using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        public class Employee
        {
            public int EmployeeId { get; }
            public int DepartmentNumber { get; }
            public decimal Salary { get; }

            public Employee(int employeeId, int departmentNumber, decimal salary)
            {
                EmployeeId = employeeId;
                DepartmentNumber = departmentNumber;
                Salary = salary;
            }

            public override string ToString()
            {
                return $"Табельный номер: {EmployeeId}, Номер подразделения: {DepartmentNumber}, Оклад: {Salary}";
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            // Получение данных из TextBox-ов
            int employeeId = int.Parse(textBox1.Text);
            int departmentNumber = int.Parse(textBox2.Text);
            decimal salary = decimal.Parse(textBox3.Text);

            // Создание нового экземпляра класса "Служащий"
            Employee employee = new Employee(employeeId, departmentNumber, salary);

            // Добавление служащего и вывод информации
            employeeListBox.Items.Add(employee);
            MessageBox.Show("Служащий успешно добавлен!");
            
        }
    }
}
