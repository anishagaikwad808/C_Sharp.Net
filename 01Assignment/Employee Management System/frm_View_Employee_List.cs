﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Employee_Management_System
{
    public partial class frm_View_Employee_List : Form
    {
        public frm_View_Employee_List()
        {
            InitializeComponent();
        }

        private void btn_Add_New_Employee_Click_1(object sender, EventArgs e)
        {
            Frm_Add_New_Employee obj = new Frm_Add_New_Employee();
            obj.Show();
            this.Hide();
        }
       
        private void Frm_View_Employee_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee_App_DBDataSet1.Employees_Details' table. You can move, or remove it, as needed.
            this.employees_DetailsTableAdapter.Fill(this.employee_App_DBDataSet1.Employees_Details);

        }

      
    }
}
