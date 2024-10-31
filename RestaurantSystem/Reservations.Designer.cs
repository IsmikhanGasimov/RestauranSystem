namespace RestaurantSystem
{
    partial class Reservations
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
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            txtReservationDate = new TextBox();
            txtNumGuests = new TextBox();
            btnEdit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            panel2 = new Panel();
            cmbCustomer = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 192);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 610);
            panel1.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(40, 492);
            label8.Name = "label8";
            label8.Size = new Size(110, 38);
            label8.TabIndex = 20;
            label8.Text = "Logout";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(41, 308);
            label7.Name = "label7";
            label7.Size = new Size(159, 38);
            label7.TabIndex = 19;
            label7.Text = "Dashboard";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(41, 546);
            label6.Name = "label6";
            label6.Size = new Size(66, 38);
            label6.TabIndex = 18;
            label6.Text = "Exit";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(40, 237);
            label5.Name = "label5";
            label5.Size = new Size(171, 38);
            label5.TabIndex = 17;
            label5.Text = "Reservation";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(41, 174);
            label4.Name = "label4";
            label4.Size = new Size(92, 38);
            label4.TabIndex = 16;
            label4.Text = "Order";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(41, 104);
            label3.Name = "label3";
            label3.Size = new Size(143, 38);
            label3.TabIndex = 15;
            label3.Text = "Customer";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(41, 44);
            label2.Name = "label2";
            label2.Size = new Size(93, 38);
            label2.TabIndex = 14;
            label2.Text = "Menu";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(284, 77);
            label1.Name = "label1";
            label1.Size = new Size(269, 38);
            label1.TabIndex = 22;
            label1.Text = "Reservation Details";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(561, 217);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(761, 344);
            dataGridView1.TabIndex = 21;
            // 
            // txtReservationDate
            // 
            txtReservationDate.BorderStyle = BorderStyle.None;
            txtReservationDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtReservationDate.Location = new Point(638, 130);
            txtReservationDate.Name = "txtReservationDate";
            txtReservationDate.PlaceholderText = "Reservation Date";
            txtReservationDate.Size = new Size(284, 31);
            txtReservationDate.TabIndex = 20;
            // 
            // txtNumGuests
            // 
            txtNumGuests.BorderStyle = BorderStyle.None;
            txtNumGuests.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtNumGuests.Location = new Point(993, 130);
            txtNumGuests.Name = "txtNumGuests";
            txtNumGuests.PlaceholderText = "Guest number";
            txtNumGuests.Size = new Size(284, 31);
            txtNumGuests.TabIndex = 19;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.YellowGreen;
            btnEdit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnEdit.Location = new Point(325, 360);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(137, 54);
            btnEdit.TabIndex = 17;
            btnEdit.Text = "Update";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnDelete.Location = new Point(325, 456);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 54);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnAdd.Location = new Point(325, 256);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 54);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1106, 58);
            panel2.TabIndex = 23;
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(284, 133);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(284, 28);
            cmbCustomer.TabIndex = 24;
            // 
            // Reservations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1356, 610);
            Controls.Add(cmbCustomer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(txtReservationDate);
            Controls.Add(txtNumGuests);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Name = "Reservations";
            Text = "Reservation";
            Load += Reservation_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtReservationDate;
        private TextBox txtNumGuests;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private ComboBox cmbCustomer;
    }
}