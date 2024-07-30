namespace BankApplicationForUniser
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel9 = new Panel();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            label7 = new Label();
            panel11 = new Panel();
            panel10 = new Panel();
            txt_salary = new TextBox();
            txt_Experience = new TextBox();
            btn_Update = new Button();
            btn_Add = new Button();
            label4 = new Label();
            panel6 = new Panel();
            txt_company = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel5 = new Panel();
            txt_lastName = new TextBox();
            panel4 = new Panel();
            txt_FirstName = new TextBox();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel9
            // 
            panel9.Controls.Add(dataGridView1);
            panel9.Location = new Point(560, 494);
            panel9.Name = "panel9";
            panel9.Size = new Size(1205, 300);
            panel9.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Montserrat SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 56;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(12);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 200;
            dataGridView1.RowTemplate.DividerHeight = 1;
            dataGridView1.RowTemplate.Height = 56;
            dataGridView1.Size = new Size(1205, 300);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Montserrat Medium", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(677, 169);
            label8.Name = "label8";
            label8.Size = new Size(123, 44);
            label8.TabIndex = 13;
            label8.Text = "Salary";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Montserrat Medium", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(927, 36);
            label7.Name = "label7";
            label7.Size = new Size(212, 44);
            label7.TabIndex = 18;
            label7.Text = "Experience";
            // 
            // panel11
            // 
            panel11.BackColor = Color.IndianRed;
            panel11.Location = new Point(678, 261);
            panel11.Name = "panel11";
            panel11.Size = new Size(204, 5);
            panel11.TabIndex = 12;
            // 
            // panel10
            // 
            panel10.BackColor = Color.IndianRed;
            panel10.Location = new Point(928, 128);
            panel10.Name = "panel10";
            panel10.Size = new Size(222, 5);
            panel10.TabIndex = 17;
            // 
            // txt_salary
            // 
            txt_salary.BorderStyle = BorderStyle.None;
            txt_salary.Font = new Font("Montserrat SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_salary.Location = new Point(677, 216);
            txt_salary.Name = "txt_salary";
            txt_salary.Size = new Size(202, 40);
            txt_salary.TabIndex = 11;
            // 
            // txt_Experience
            // 
            txt_Experience.BorderStyle = BorderStyle.None;
            txt_Experience.Font = new Font("Montserrat SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Experience.Location = new Point(927, 83);
            txt_Experience.Name = "txt_Experience";
            txt_Experience.Size = new Size(220, 40);
            txt_Experience.TabIndex = 16;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.IndianRed;
            btn_Update.Font = new Font("Montserrat SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Update.ForeColor = Color.White;
            btn_Update.Location = new Point(353, 216);
            btn_Update.Name = "btn_Update";
            btn_Update.RightToLeft = RightToLeft.No;
            btn_Update.Size = new Size(258, 72);
            btn_Update.TabIndex = 15;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.IndianRed;
            btn_Add.Font = new Font("Montserrat SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Add.ForeColor = Color.White;
            btn_Add.Location = new Point(37, 216);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(258, 72);
            btn_Add.TabIndex = 14;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat Medium", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(666, 36);
            label4.Name = "label4";
            label4.Size = new Size(183, 44);
            label4.TabIndex = 7;
            label4.Text = "Company";
            // 
            // panel6
            // 
            panel6.BackColor = Color.IndianRed;
            panel6.Location = new Point(677, 128);
            panel6.Name = "panel6";
            panel6.Size = new Size(222, 5);
            panel6.TabIndex = 6;
            // 
            // txt_company
            // 
            txt_company.BorderStyle = BorderStyle.None;
            txt_company.Font = new Font("Montserrat SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_company.Location = new Point(676, 83);
            txt_company.Name = "txt_company";
            txt_company.Size = new Size(220, 40);
            txt_company.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat Medium", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(362, 36);
            label3.Name = "label3";
            label3.Size = new Size(203, 44);
            label3.TabIndex = 4;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat Medium", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(23, 36);
            label2.Name = "label2";
            label2.Size = new Size(208, 44);
            label2.TabIndex = 2;
            label2.Text = "First Name";
            // 
            // panel5
            // 
            panel5.BackColor = Color.IndianRed;
            panel5.Location = new Point(373, 128);
            panel5.Name = "panel5";
            panel5.Size = new Size(241, 5);
            panel5.TabIndex = 3;
            // 
            // txt_lastName
            // 
            txt_lastName.BorderStyle = BorderStyle.None;
            txt_lastName.Font = new Font("Montserrat SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_lastName.Location = new Point(372, 83);
            txt_lastName.Name = "txt_lastName";
            txt_lastName.Size = new Size(239, 40);
            txt_lastName.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.IndianRed;
            panel4.Location = new Point(38, 128);
            panel4.Name = "panel4";
            panel4.Size = new Size(257, 5);
            panel4.TabIndex = 1;
            // 
            // txt_FirstName
            // 
            txt_FirstName.BorderStyle = BorderStyle.None;
            txt_FirstName.Font = new Font("Montserrat SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_FirstName.Location = new Point(37, 83);
            txt_FirstName.Name = "txt_FirstName";
            txt_FirstName.Size = new Size(255, 40);
            txt_FirstName.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.ForeColor = Color.Transparent;
            panel2.Location = new Point(1, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(514, 1400);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // button3
            // 
            button3.BackColor = Color.LightCoral;
            button3.Enabled = false;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Montserrat SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(-3, 398);
            button3.Name = "button3";
            button3.Size = new Size(517, 87);
            button3.TabIndex = 5;
            button3.Text = "Bank Card";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.Enabled = false;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Montserrat SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(-3, 292);
            button2.Name = "button2";
            button2.Size = new Size(517, 87);
            button2.TabIndex = 4;
            button2.Text = "Credits";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Montserrat SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(-3, 184);
            button1.Name = "button1";
            button1.Size = new Size(517, 87);
            button1.TabIndex = 3;
            button1.Text = "Customers";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1815, 109);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat SemiBold", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1140, 24);
            label1.Name = "label1";
            label1.Size = new Size(455, 66);
            label1.TabIndex = 1;
            label1.Text = "Boolean Banking";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(panel11);
            panel3.Controls.Add(panel10);
            panel3.Controls.Add(txt_salary);
            panel3.Controls.Add(txt_Experience);
            panel3.Controls.Add(btn_Update);
            panel3.Controls.Add(btn_Add);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(txt_company);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(txt_lastName);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(txt_FirstName);
            panel3.Location = new Point(560, 152);
            panel3.Name = "panel3";
            panel3.Size = new Size(1205, 319);
            panel3.TabIndex = 9;
            panel3.Paint += panel3_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1815, 779);
            Controls.Add(panel9);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_2;
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel9;
        private Button btn_Update;
        private Button btn_Add;
        private Label label4;
        private Panel panel6;
        private TextBox txt_company;
        private Label label3;
        private Label label2;
        private Panel panel5;
        private TextBox txt_lastName;
        private Panel panel4;
        private TextBox txt_FirstName;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label7;
        private Panel panel10;
        private TextBox txt_Experience;
        private Label label8;
        private Panel panel11;
        private TextBox txt_salary;
        private Panel panel3;
    }
}
