﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Student_Management_System
{
    public partial class Frm_Course_List : Form
    {
        public Frm_Course_List()
        {
            InitializeComponent();
        }

        private void Frm_Course_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Student_Management_System_DB_dboDataSet1.Course_Details' table. You can move, or remove it, as needed.
            this.course_DetailsTableAdapter.Fill(this._Student_Management_System_DB_dboDataSet1.Course_Details);

        }
    }
}
