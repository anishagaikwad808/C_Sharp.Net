
namespace Employee_Management_System
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
            this.lbl_LogOut = new System.Windows.Forms.Label();
            this.btn_Add_New_Employee = new System.Windows.Forms.Button();
            this.dgv_Employee_List = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_App_DBDataSet1 = new Employee_Management_System.Employee_App_DBDataSet1();
            this.employee_DetailsTableAdapter = new Employee_Management_System.Employee_App_DBDataSet1TableAdapters.Employee_DetailsTableAdapter();
            this.lbl_Username = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_App_DBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Employee_Details_List
            // 
            this.lbl_Employee_Details_List.AutoSize = true;
            this.lbl_Employee_Details_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_Employee_Details_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Details_List.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Employee_Details_List.Location = new System.Drawing.Point(282, 21);
            this.lbl_Employee_Details_List.Name = "lbl_Employee_Details_List";
            this.lbl_Employee_Details_List.Size = new System.Drawing.Size(522, 59);
            this.lbl_Employee_Details_List.TabIndex = 1;
            this.lbl_Employee_Details_List.Text = "Employee Details List";
            // 
            // lbl_LogOut
            // 
            this.lbl_LogOut.AutoSize = true;
            this.lbl_LogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LogOut.ForeColor = System.Drawing.Color.Aqua;
            this.lbl_LogOut.Location = new System.Drawing.Point(997, 21);
            this.lbl_LogOut.Name = "lbl_LogOut";
            this.lbl_LogOut.Size = new System.Drawing.Size(92, 29);
            this.lbl_LogOut.TabIndex = 2;
            this.lbl_LogOut.Text = "LogOut";
            this.lbl_LogOut.Click += new System.EventHandler(this.lbl_LogOut_Click);
            // 
            // btn_Add_New_Employee
            // 
            this.btn_Add_New_Employee.BackColor = System.Drawing.Color.Silver;
            this.btn_Add_New_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Add_New_Employee.Location = new System.Drawing.Point(347, 620);
            this.btn_Add_New_Employee.Name = "btn_Add_New_Employee";
            this.btn_Add_New_Employee.Size = new System.Drawing.Size(351, 52);
            this.btn_Add_New_Employee.TabIndex = 3;
            this.btn_Add_New_Employee.Text = "Add New Employee";
            this.btn_Add_New_Employee.UseVisualStyleBackColor = false;
            this.btn_Add_New_Employee.Click += new System.EventHandler(this.btn_Add_New_Employee_Click);
            // 
            // dgv_Employee_List
            // 
            this.dgv_Employee_List.AutoGenerateColumns = false;
            this.dgv_Employee_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Employee_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Employee_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employee_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn});
            this.dgv_Employee_List.DataSource = this.employeeDetailsBindingSource;
            this.dgv_Employee_List.Location = new System.Drawing.Point(95, 114);
            this.dgv_Employee_List.Name = "dgv_Employee_List";
            this.dgv_Employee_List.RowHeadersWidth = 62;
            this.dgv_Employee_List.RowTemplate.Height = 28;
            this.dgv_Employee_List.Size = new System.Drawing.Size(929, 474);
            this.dgv_Employee_List.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "D_O_B";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "D_O_B";
            this.dOBDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            // 
            // employeeDetailsBindingSource
            // 
            this.employeeDetailsBindingSource.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource.DataSource = this.employee_App_DBDataSet1;
            // 
            // employee_App_DBDataSet1
            // 
            this.employee_App_DBDataSet1.DataSetName = "Employee_App_DBDataSet1";
            this.employee_App_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employee_DetailsTableAdapter
            // 
            this.employee_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_Username
            // 
            this.lbl_Username.BackColor = System.Drawing.Color.Turquoise;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.Black;
            this.lbl_Username.Location = new System.Drawing.Point(12, 9);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(151, 41);
            this.lbl_Username.TabIndex = 5;
            this.lbl_Username.Text = "Username";
            // 
            // frm_View_Employee_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1110, 712);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.dgv_Employee_List);
            this.Controls.Add(this.btn_Add_New_Employee);
            this.Controls.Add(this.lbl_LogOut);
            this.Controls.Add(this.lbl_Employee_Details_List);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "frm_View_Employee_List";
            this.Text = "View_Employee_List";
            this.Load += new System.EventHandler(this.frm_View_Employee_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_App_DBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Employee_Details_List;
        private System.Windows.Forms.Label lbl_LogOut;
        private System.Windows.Forms.Button btn_Add_New_Employee;
        private System.Windows.Forms.DataGridView dgv_Employee_List;
        private Employee_App_DBDataSet1 employee_App_DBDataSet1;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource;
        private Employee_App_DBDataSet1TableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_Username;
    }
}