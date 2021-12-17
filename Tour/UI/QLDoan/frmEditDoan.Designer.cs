
namespace Tour.UI.QLDoan
{
    partial class frmEditDoan
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
            this.cbbHDV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerKT = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerKH = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbTour = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenDoan = new System.Windows.Forms.TextBox();
            this.t = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbHDV
            // 
            this.cbbHDV.FormattingEnabled = true;
            this.cbbHDV.Location = new System.Drawing.Point(466, 57);
            this.cbbHDV.Name = "cbbHDV";
            this.cbbHDV.Size = new System.Drawing.Size(199, 21);
            this.cbbHDV.TabIndex = 20;
            this.cbbHDV.SelectedIndexChanged += new System.EventHandler(this.cbbHDV_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Hướng dẫn viên";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dateTimePickerKT
            // 
            this.dateTimePickerKT.Location = new System.Drawing.Point(111, 103);
            this.dateTimePickerKT.Name = "dateTimePickerKT";
            this.dateTimePickerKT.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerKT.TabIndex = 18;
            // 
            // dateTimePickerKH
            // 
            this.dateTimePickerKH.Location = new System.Drawing.Point(110, 60);
            this.dateTimePickerKH.Name = "dateTimePickerKH";
            this.dateTimePickerKH.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerKH.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ngày khởi hành";
            // 
            // cbbTour
            // 
            this.cbbTour.FormattingEnabled = true;
            this.cbbTour.Location = new System.Drawing.Point(466, 11);
            this.cbbTour.Name = "cbbTour";
            this.cbbTour.Size = new System.Drawing.Size(199, 21);
            this.cbbTour.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tour";
            // 
            // txtTenDoan
            // 
            this.txtTenDoan.Location = new System.Drawing.Point(111, 12);
            this.txtTenDoan.Name = "txtTenDoan";
            this.txtTenDoan.Size = new System.Drawing.Size(199, 20);
            this.txtTenDoan.TabIndex = 12;
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(23, 19);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(55, 13);
            this.t.TabIndex = 11;
            this.t.Text = "Tên Đoàn";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Tour.Properties.Resources.remove;
            this.btnClose.Location = new System.Drawing.Point(341, 150);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 42);
            this.btnClose.TabIndex = 22;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Tour.Properties.Resources.diskette;
            this.btnSave.Location = new System.Drawing.Point(293, 150);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(42, 42);
            this.btnSave.TabIndex = 21;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmEditDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 202);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbbHDV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerKT);
            this.Controls.Add(this.dateTimePickerKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbTour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenDoan);
            this.Controls.Add(this.t);
            this.Name = "frmEditDoan";
            this.Text = "Chi Tiet Doan";
            this.Load += new System.EventHandler(this.frmEditDoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbHDV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerKT;
        private System.Windows.Forms.DateTimePicker dateTimePickerKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbTour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenDoan;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}