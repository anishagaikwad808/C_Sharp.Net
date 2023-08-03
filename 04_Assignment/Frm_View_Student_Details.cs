using System;
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
    public partial class Frm_View_Student_Details : Form
    {
        public Frm_View_Student_Details()
        {
            InitializeComponent();
        }

        private void Frm_View_Student_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Student_Management_System_DB_dboDataSet4.Students_Details' table. You can move, or remove it, as needed.
            this.students_DetailsTableAdapter2.Fill(this._Student_Management_System_DB_dboDataSet4.Students_Details);


        }
    }
}
