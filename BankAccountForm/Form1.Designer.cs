namespace BankAccountForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            btn_Update = new Button();
            btn_Add = new Button();
            label6 = new Label();
            panel8 = new Panel();
            txt_Exp = new TextBox();
            label5 = new Label();
            panel7 = new Panel();
            txt_Salary = new TextBox();
            label4 = new Label();
            panel6 = new Panel();
            txt_company = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel5 = new Panel();
            txt_lastName = new TextBox();
            panel4 = new Panel();
            txt_FirstName = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dataGridView1 = new DataGridView();
            panel9 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1604, 109);
            panel1.TabIndex = 0;
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
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.ForeColor = Color.Transparent;
            panel2.Location = new Point(0, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(514, 1400);
            panel2.TabIndex = 2;
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
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btn_Update);
            panel3.Controls.Add(btn_Add);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(txt_Exp);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(txt_Salary);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(txt_company);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(txt_lastName);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(txt_FirstName);
            panel3.Location = new Point(559, 154);
            panel3.Name = "panel3";
            panel3.Size = new Size(1014, 319);
            panel3.TabIndex = 3;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.IndianRed;
            btn_Update.Font = new Font("Montserrat SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Update.ForeColor = Color.White;
            btn_Update.Location = new Point(358, 232);
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
            btn_Add.Location = new Point(42, 232);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(258, 72);
            btn_Add.TabIndex = 14;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat Medium", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(1497, 52);
            label6.Name = "label6";
            label6.Size = new Size(191, 44);
            label6.TabIndex = 13;
            label6.Text = "Exprience";
            // 
            // panel8
            // 
            panel8.BackColor = Color.IndianRed;
            panel8.Location = new Point(1498, 144);
            panel8.Name = "panel8";
            panel8.Size = new Size(204, 5);
            panel8.TabIndex = 12;
            // 
            // txt_Exp
            // 
            txt_Exp.BorderStyle = BorderStyle.None;
            txt_Exp.Font = new Font("Montserrat SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Exp.Location = new Point(1497, 99);
            txt_Exp.Name = "txt_Exp";
            txt_Exp.Size = new Size(202, 40);
            txt_Exp.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat Medium", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(1258, 52);
            label5.Name = "label5";
            label5.Size = new Size(123, 44);
            label5.TabIndex = 10;
            label5.Text = "Salary";
            label5.Click += label5_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.IndianRed;
            panel7.Location = new Point(1259, 144);
            panel7.Name = "panel7";
            panel7.Size = new Size(204, 5);
            panel7.TabIndex = 9;
            // 
            // txt_Salary
            // 
            txt_Salary.BorderStyle = BorderStyle.None;
            txt_Salary.Font = new Font("Montserrat SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Salary.Location = new Point(1258, 99);
            txt_Salary.Name = "txt_Salary";
            txt_Salary.Size = new Size(202, 40);
            txt_Salary.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat Medium", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(853, 52);
            label4.Name = "label4";
            label4.Size = new Size(183, 44);
            label4.TabIndex = 7;
            label4.Text = "Company";
            // 
            // panel6
            // 
            panel6.BackColor = Color.IndianRed;
            panel6.Location = new Point(854, 144);
            panel6.Name = "panel6";
            panel6.Size = new Size(372, 5);
            panel6.TabIndex = 6;
            // 
            // txt_company
            // 
            txt_company.BorderStyle = BorderStyle.None;
            txt_company.Font = new Font("Montserrat SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_company.Location = new Point(853, 99);
            txt_company.Name = "txt_company";
            txt_company.Size = new Size(370, 40);
            txt_company.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat Medium", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(449, 52);
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
            label2.Location = new Point(42, 52);
            label2.Name = "label2";
            label2.Size = new Size(208, 44);
            label2.TabIndex = 2;
            label2.Text = "First Name";
            // 
            // panel5
            // 
            panel5.BackColor = Color.IndianRed;
            panel5.Location = new Point(450, 144);
            panel5.Name = "panel5";
            panel5.Size = new Size(372, 5);
            panel5.TabIndex = 3;
            // 
            // txt_lastName
            // 
            txt_lastName.BorderStyle = BorderStyle.None;
            txt_lastName.Font = new Font("Montserrat SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_lastName.Location = new Point(449, 99);
            txt_lastName.Name = "txt_lastName";
            txt_lastName.Size = new Size(370, 40);
            txt_lastName.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.IndianRed;
            panel4.Location = new Point(43, 144);
            panel4.Name = "panel4";
            panel4.Size = new Size(372, 5);
            panel4.TabIndex = 1;
            // 
            // txt_FirstName
            // 
            txt_FirstName.BorderStyle = BorderStyle.None;
            txt_FirstName.Font = new Font("Montserrat SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_FirstName.Location = new Point(42, 99);
            txt_FirstName.Name = "txt_FirstName";
            txt_FirstName.Size = new Size(370, 40);
            txt_FirstName.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
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
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
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
            dataGridView1.Size = new Size(1924, 682);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // panel9
            // 
            panel9.Controls.Add(dataGridView1);
            panel9.Location = new Point(569, 570);
            panel9.Name = "panel9";
            panel9.Size = new Size(1924, 682);
            panel9.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1604, 1050);
            Controls.Add(panel9);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MouseClick += button4_MouseClick;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel9.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button button1;
        private Button button3;
        private Button button2;
        private Panel panel3;
        private TextBox txt_FirstName;
        private Panel panel4;
        private Label label2;
        private Panel panel5;
        private TextBox txt_lastName;
        private Label label4;
        private Panel panel6;
        private TextBox txt_company;
        private Label label3;
        private Label label5;
        private Panel panel7;
        private TextBox txt_Salary;
        private ContextMenuStrip contextMenuStrip1;
        private Label label6;
        private Panel panel8;
        private TextBox txt_Exp;
        private DataGridView dataGridView1;
        private Panel panel9;
        private Button btn_Add;
        private Button btn_Update;
    }
}
