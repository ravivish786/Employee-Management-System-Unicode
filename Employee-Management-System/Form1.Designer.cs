namespace Employee_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EmployeeID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            EmailID = new TextBox();
            label3 = new Label();
            EmployeeName = new TextBox();
            label4 = new Label();
            Designation = new TextBox();
            label5 = new Label();
            Department = new TextBox();
            label6 = new Label();
            PhoneNumber = new TextBox();
            label7 = new Label();
            JoiningDate = new DateTimePicker();
            AddEmployee = new Button();
            UpdateEmployee = new Button();
            DeleteEmployee = new Button();
            label8 = new Label();
            Search = new TextBox();
            label9 = new Label();
            label10 = new Label();
            FilterBy = new ComboBox();
            OrderBy = new ComboBox();
            label11 = new Label();
            Refresh = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // EmployeeID
            // 
            EmployeeID.Location = new Point(56, 61);
            EmployeeID.Name = "EmployeeID";
            EmployeeID.Size = new Size(237, 27);
            EmployeeID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 28);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 1;
            label1.Text = "EmployeeID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(331, 28);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 3;
            label2.Text = "EmailID";
            // 
            // EmailID
            // 
            EmailID.Location = new Point(331, 61);
            EmailID.Name = "EmailID";
            EmailID.Size = new Size(237, 27);
            EmailID.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 112);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 5;
            label3.Text = "Employee Name";
            // 
            // EmployeeName
            // 
            EmployeeName.Location = new Point(56, 145);
            EmployeeName.Name = "EmployeeName";
            EmployeeName.Size = new Size(512, 27);
            EmployeeName.TabIndex = 4;
            EmployeeName.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 199);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 7;
            label4.Text = "Designation";
            // 
            // Designation
            // 
            Designation.Location = new Point(56, 232);
            Designation.Name = "Designation";
            Designation.Size = new Size(237, 27);
            Designation.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(331, 199);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 9;
            label5.Text = "Departmennt";
            // 
            // Department
            // 
            Department.Location = new Point(331, 232);
            Department.Name = "Department";
            Department.Size = new Size(237, 27);
            Department.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 293);
            label6.Name = "label6";
            label6.Size = new Size(108, 20);
            label6.TabIndex = 11;
            label6.Text = "Phone Number";
            // 
            // PhoneNumber
            // 
            PhoneNumber.Location = new Point(56, 326);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(237, 27);
            PhoneNumber.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(331, 293);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 13;
            label7.Text = "Joining Date";
            // 
            // JoiningDate
            // 
            JoiningDate.Location = new Point(331, 326);
            JoiningDate.Name = "JoiningDate";
            JoiningDate.Size = new Size(237, 27);
            JoiningDate.TabIndex = 14;
            // 
            // AddEmployee
            // 
            AddEmployee.Location = new Point(56, 449);
            AddEmployee.Name = "AddEmployee";
            AddEmployee.Size = new Size(94, 29);
            AddEmployee.TabIndex = 16;
            AddEmployee.Text = "Add";
            AddEmployee.UseVisualStyleBackColor = true;
            AddEmployee.Click += AddEmployee_Click;
            // 
            // UpdateEmployee
            // 
            UpdateEmployee.Location = new Point(199, 449);
            UpdateEmployee.Name = "UpdateEmployee";
            UpdateEmployee.Size = new Size(94, 29);
            UpdateEmployee.TabIndex = 17;
            UpdateEmployee.Text = "Update";
            UpdateEmployee.UseVisualStyleBackColor = true;
            UpdateEmployee.Click += UpdateEmployee_Click;
            // 
            // DeleteEmployee
            // 
            DeleteEmployee.Location = new Point(331, 449);
            DeleteEmployee.Name = "DeleteEmployee";
            DeleteEmployee.Size = new Size(94, 29);
            DeleteEmployee.TabIndex = 18;
            DeleteEmployee.Text = "Delete";
            DeleteEmployee.UseVisualStyleBackColor = true;
            DeleteEmployee.Click += DeleteEmployee_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(605, 28);
            label8.Name = "label8";
            label8.Size = new Size(135, 20);
            label8.TabIndex = 21;
            label8.Text = "Employee DtaView";
            // 
            // Search
            // 
            Search.Location = new Point(664, 89);
            Search.Name = "Search";
            Search.Size = new Size(125, 27);
            Search.TabIndex = 22;
            Search.TextChanged += Search_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(605, 92);
            label9.Name = "label9";
            label9.Size = new Size(53, 20);
            label9.TabIndex = 23;
            label9.Text = "Search";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(815, 92);
            label10.Name = "label10";
            label10.Size = new Size(59, 20);
            label10.TabIndex = 24;
            label10.Text = "Shot By";
            // 
            // FilterBy
            // 
            FilterBy.FormattingEnabled = true;
            FilterBy.Items.AddRange(new object[] { "EmployeeID", "Name", "Designation", "Department", "Email", "Phone", "JoiningDate" });
            FilterBy.Location = new Point(893, 89);
            FilterBy.Name = "FilterBy";
            FilterBy.Size = new Size(151, 28);
            FilterBy.TabIndex = 25;
            FilterBy.SelectedIndexChanged += FilterBy_SelectedIndexChanged;
            // 
            // OrderBy
            // 
            OrderBy.FormattingEnabled = true;
            OrderBy.Items.AddRange(new object[] { "Asc", "Desc" });
            OrderBy.Location = new Point(893, 123);
            OrderBy.Name = "OrderBy";
            OrderBy.Size = new Size(151, 28);
            OrderBy.TabIndex = 27;
            OrderBy.SelectedIndexChanged += OrderBy_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(815, 126);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 26;
            label11.Text = "Order By";
            // 
            // Refresh
            // 
            Refresh.Cursor = Cursors.SizeWE;
            Refresh.Location = new Point(1083, 89);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(144, 29);
            Refresh.TabIndex = 28;
            Refresh.Text = "Refresh Grid";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += Refresh_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(605, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(649, 461);
            dataGridView1.TabIndex = 29;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 678);
            Controls.Add(dataGridView1);
            Controls.Add(Refresh);
            Controls.Add(OrderBy);
            Controls.Add(label11);
            Controls.Add(FilterBy);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(Search);
            Controls.Add(label8);
            Controls.Add(DeleteEmployee);
            Controls.Add(UpdateEmployee);
            Controls.Add(AddEmployee);
            Controls.Add(JoiningDate);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(PhoneNumber);
            Controls.Add(label5);
            Controls.Add(Department);
            Controls.Add(label4);
            Controls.Add(Designation);
            Controls.Add(label3);
            Controls.Add(EmployeeName);
            Controls.Add(label2);
            Controls.Add(EmailID);
            Controls.Add(label1);
            Controls.Add(EmployeeID);
            Name = "Form1";
            Text = "Employee Management System";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EmployeeID;
        private Label label1;
        private Label label2;
        private TextBox EmailID;
        private Label label3;
        private TextBox EmployeeName;
        private Label label4;
        private TextBox Designation;
        private Label label5;
        private TextBox Department;
        private Label label6;
        private TextBox PhoneNumber;
        private Label label7;
        private DateTimePicker JoiningDate;
        private Label label8;
        private Button DeleteEmployee;
        private Button UpdateEmployee;
        private Button AddEmployee;
 
        private ComboBox FilterBy;
        private Label label10;
        private Label label9;
        private TextBox Search;
        private ComboBox OrderBy;
        private Label label11;
        private Button Refresh;
        private DataGridView dataGridView1;
    }
}
