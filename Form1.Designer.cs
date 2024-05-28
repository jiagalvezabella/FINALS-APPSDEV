namespace ParkingSystemManagement
{
    partial class Form1
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
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            lblPlateNumber = new Label();
            txtFee = new TextBox();
            lblFee = new Label();
            txtPlateNumber = new TextBox();
            lblVehicleBrand = new Label();
            txtVehicleBrand = new TextBox();
            btnCalculateFee = new Button();
            lblVehicleType = new Label();
            txtColor = new TextBox();
            txtVehicleType = new TextBox();
            lblColor = new Label();
            btnExitVehicle = new Button();
            btnParkVehicle = new Button();
            dataGridView1 = new DataGridView();
            btnDeleteVehicle = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Location = new Point(-1, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(119, 600);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 255);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(118, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(817, 30);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(7, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 14);
            label1.TabIndex = 0;
            label1.Text = "Parking Management";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Cyan;
            panel3.Controls.Add(lblPlateNumber);
            panel3.Controls.Add(txtFee);
            panel3.Controls.Add(lblFee);
            panel3.Controls.Add(txtPlateNumber);
            panel3.Controls.Add(lblVehicleBrand);
            panel3.Controls.Add(txtVehicleBrand);
            panel3.Controls.Add(btnCalculateFee);
            panel3.Controls.Add(lblVehicleType);
            panel3.Controls.Add(txtColor);
            panel3.Controls.Add(txtVehicleType);
            panel3.Controls.Add(lblColor);
            panel3.Location = new Point(118, 30);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(817, 81);
            panel3.TabIndex = 3;
            // 
            // lblPlateNumber
            // 
            lblPlateNumber.AutoSize = true;
            lblPlateNumber.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlateNumber.Location = new Point(27, 8);
            lblPlateNumber.Margin = new Padding(4, 0, 4, 0);
            lblPlateNumber.Name = "lblPlateNumber";
            lblPlateNumber.Size = new Size(97, 14);
            lblPlateNumber.TabIndex = 5;
            lblPlateNumber.Text = "Plate Number";
            // 
            // txtFee
            // 
            txtFee.Location = new Point(539, 45);
            txtFee.Margin = new Padding(4, 3, 4, 3);
            txtFee.Name = "txtFee";
            txtFee.ReadOnly = true;
            txtFee.Size = new Size(116, 23);
            txtFee.TabIndex = 15;
            // 
            // lblFee
            // 
            lblFee.AutoSize = true;
            lblFee.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFee.Location = new Point(490, 50);
            lblFee.Margin = new Padding(4, 0, 4, 0);
            lblFee.Name = "lblFee";
            lblFee.Size = new Size(36, 14);
            lblFee.TabIndex = 14;
            lblFee.Text = "Fee:";
            // 
            // txtPlateNumber
            // 
            txtPlateNumber.Location = new Point(147, 5);
            txtPlateNumber.Margin = new Padding(4, 3, 4, 3);
            txtPlateNumber.Name = "txtPlateNumber";
            txtPlateNumber.Size = new Size(116, 23);
            txtPlateNumber.TabIndex = 6;
            // 
            // lblVehicleBrand
            // 
            lblVehicleBrand.AutoSize = true;
            lblVehicleBrand.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVehicleBrand.Location = new Point(294, 7);
            lblVehicleBrand.Margin = new Padding(4, 0, 4, 0);
            lblVehicleBrand.Name = "lblVehicleBrand";
            lblVehicleBrand.Size = new Size(98, 14);
            lblVehicleBrand.TabIndex = 7;
            lblVehicleBrand.Text = "Vehicle Brand";
            // 
            // txtVehicleBrand
            // 
            txtVehicleBrand.Location = new Point(415, 5);
            txtVehicleBrand.Margin = new Padding(4, 3, 4, 3);
            txtVehicleBrand.Name = "txtVehicleBrand";
            txtVehicleBrand.Size = new Size(116, 23);
            txtVehicleBrand.TabIndex = 8;
            // 
            // btnCalculateFee
            // 
            btnCalculateFee.Location = new Point(351, 45);
            btnCalculateFee.Margin = new Padding(4, 3, 4, 3);
            btnCalculateFee.Name = "btnCalculateFee";
            btnCalculateFee.Size = new Size(117, 27);
            btnCalculateFee.TabIndex = 13;
            btnCalculateFee.Text = "Calculate Fee";
            btnCalculateFee.UseVisualStyleBackColor = true;
            btnCalculateFee.Click += btnCalculateFee_Click;
            // 
            // lblVehicleType
            // 
            lblVehicleType.AutoSize = true;
            lblVehicleType.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVehicleType.Location = new Point(561, 8);
            lblVehicleType.Margin = new Padding(4, 0, 4, 0);
            lblVehicleType.Name = "lblVehicleType";
            lblVehicleType.Size = new Size(91, 14);
            lblVehicleType.TabIndex = 9;
            lblVehicleType.Text = "Vehicle Type";
            // 
            // txtColor
            // 
            txtColor.Location = new Point(204, 45);
            txtColor.Margin = new Padding(4, 3, 4, 3);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(116, 23);
            txtColor.TabIndex = 12;
            // 
            // txtVehicleType
            // 
            txtVehicleType.Location = new Point(674, 3);
            txtVehicleType.Margin = new Padding(4, 3, 4, 3);
            txtVehicleType.Name = "txtVehicleType";
            txtVehicleType.Size = new Size(116, 23);
            txtVehicleType.TabIndex = 10;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColor.Location = new Point(148, 50);
            lblColor.Margin = new Padding(4, 0, 4, 0);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(42, 14);
            lblColor.TabIndex = 11;
            lblColor.Text = "Color";
            // 
            // btnExitVehicle
            // 
            btnExitVehicle.BackColor = Color.Red;
            btnExitVehicle.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExitVehicle.Location = new Point(322, 480);
            btnExitVehicle.Margin = new Padding(4, 3, 4, 3);
            btnExitVehicle.Name = "btnExitVehicle";
            btnExitVehicle.Size = new Size(103, 43);
            btnExitVehicle.TabIndex = 1;
            btnExitVehicle.Text = "Exit Vehicle";
            btnExitVehicle.UseVisualStyleBackColor = false;
            btnExitVehicle.Click += btnExitVehicle_Click;
            // 
            // btnParkVehicle
            // 
            btnParkVehicle.BackColor = Color.Lime;
            btnParkVehicle.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnParkVehicle.ForeColor = SystemColors.ControlText;
            btnParkVehicle.Location = new Point(200, 480);
            btnParkVehicle.Margin = new Padding(4, 3, 4, 3);
            btnParkVehicle.Name = "btnParkVehicle";
            btnParkVehicle.Size = new Size(103, 43);
            btnParkVehicle.TabIndex = 0;
            btnParkVehicle.Text = "Park Vehicle";
            btnParkVehicle.UseVisualStyleBackColor = false;
            btnParkVehicle.Click += btnParkVehicle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(200, 147);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(640, 327);
            dataGridView1.TabIndex = 4;
            // 
            // btnDeleteVehicle
            // 
            btnDeleteVehicle.BackColor = Color.FromArgb(255, 128, 0);
            btnDeleteVehicle.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteVehicle.Location = new Point(444, 480);
            btnDeleteVehicle.Margin = new Padding(4, 3, 4, 3);
            btnDeleteVehicle.Name = "btnDeleteVehicle";
            btnDeleteVehicle.Size = new Size(127, 43);
            btnDeleteVehicle.TabIndex = 5;
            btnDeleteVehicle.Text = "Delete Vehicle";
            btnDeleteVehicle.UseVisualStyleBackColor = false;
            btnDeleteVehicle.Click += btnDeleteVehicle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 600);
            Controls.Add(btnDeleteVehicle);
            Controls.Add(btnExitVehicle);
            Controls.Add(panel3);
            Controls.Add(dataGridView1);
            Controls.Add(btnParkVehicle);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parking System Management";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPlateNumber;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.TextBox txtPlateNumber;
        private System.Windows.Forms.Label lblVehicleBrand;
        private System.Windows.Forms.TextBox txtVehicleBrand;
        private System.Windows.Forms.Button btnCalculateFee;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtVehicleType;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnExitVehicle;
        private System.Windows.Forms.Button btnParkVehicle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDeleteVehicle;
    }
}