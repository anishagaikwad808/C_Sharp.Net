
namespace _01_Employee_Management_System
{
    partial class frm_View_Employee_List
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Employee_Details_List = new System.Windows.Forms.Label();
            this.dgv_Employee_List = new System.Windows.Forms.DataGridView();
            this.employeesDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Add_New_Employee = new System.Windows.Forms.Button();
            this.employee_App_DBDataSet1 = new _01_Employee_Management_System.Employee_App_DBDataSet1();
            this.employeesDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employees_DetailsTableAdapter = new _01_Employee_Management_System.Employee_App_DBDataSet1TableAdapters.Employees_DetailsTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_App_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDetailsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Employee_Details_List
            // 
            this.lbl_Employee_Details_List.AutoSize = true;
            this.lbl_Employee_Details_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Employee_Details_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Details_List.Location = new System.Drawing.Point(174, 18);
            this.lbl_Employee_Details_List.Name = "lbl_Employee_Details_List";
            this.lbl_Employee_Details_List.Size = new System.Drawing.Size(606, 69);
            this.lbl_Employee_Details_List.TabIndex = 0;
            this.lbl_Employee_Details_List.Text = "Employee Details List";
            // 
            // dgv_Employee_List
            // 
            this.dgv_Employee_List.AutoGenerateColumns = false;
            this.dgv_Employee_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Employee_List.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Employee_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Employee_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employee_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgv_Employee_List.DataSource = this.employeesDetailsBindingSource1;
            this.dgv_Employee_List.Location = new System.Drawing.Point(2, 103);
            this.dgv_Employee_List.Name = "dgv_Employee_List";
            this.dgv_Employee_List.RowHeadersWidth = 62;
            this.dgv_Employee_List.RowTemplate.Height = 28;
            this.dgv_Employee_List.Size = new System.Drawing.Size(975, 486);
            this.dgv_Employee_List.TabIndex = 1;
            // 
            // employeesDetailsBindingSource
            // 
            this.employeesDetailsBindingSource.DataMember = "Employees_Details";
            // 
            // btn_Add_New_Employee
            // 
            this.btn_Add_New_Employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Add_New_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Add_New_Employee.Location = new System.Drawing.Point(307, 595);
            this.btn_Add_New_Employee.Name = "btn_Add_New_Employee";
            this.btn_Add_New_Employee.Size = new System.Drawing.Size(319, 46);
            this.btn_Add_New_Employee.TabIndex = 2;
            this.btn_Add_New_Employee.Text = "Add New Employee";
            this.btn_Add_New_Employee.UseVisualStyleBackColor = false;
            // 
            // employee_App_DBDataSet1
            // 
            this.employee_App_DBDataSet1.DataSetName = "Employee_App_DBDataSet1";
            this.employee_App_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesDetailsBindingSource1
            // 
            this.employeesDetailsBindingSource1.DataMember = "Employees_Details";
            this.employeesDetailsBindingSource1.DataSource = this.employee_App_DBDataSet1;
            // 
            // employees_DetailsTableAdapter
            // 
            this.employees_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Mobile_No";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mobile_No";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "D_O_B";
            this.dataGridViewTextBoxColumn4.HeaderText = "D_O_B";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Designation";
            this.dataGridViewTextBoxColumn5.HeaderText = "Designation";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // frm_View_Employee_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.btn_Add_New_Employee);
            this.Controls.Add(this.dgv_Employee_List);
            this.Controls.Add(this.lbl_Employee_Details_List);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Employee_List";
            this.Text = "View Employee List";
            this.Load += new System.EventHandler(this.Frm_View_Employee_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_App_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDetailsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Employee_Details_List;
        private System.Windows.Forms.DataGridView dgv_Employee_List;
        private System.Windows.Forms.BindingSource employeesDetailsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Add_New_Employee;
        private Employee_App_DBDataSet1 employee_App_DBDataSet1;
        private System.Windows.Forms.BindingSource employeesDetailsBindingSource1;
        private Employee_App_DBDataSet1TableAdapters.Employees_DetailsTableAdapter employees_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}