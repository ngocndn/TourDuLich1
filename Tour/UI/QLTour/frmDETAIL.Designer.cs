
namespace Tour.UI.QLTour
{
    partial class frmDETAIL
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
            this.comboBox_DiaDiem = new System.Windows.Forms.ComboBox();
            this.comboBox_LoaiHinh = new System.Windows.Forms.ComboBox();
            this.txtDD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenTour = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPricing = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // comboBox_DiaDiem
            // 
            this.comboBox_DiaDiem.FormattingEnabled = true;
            this.comboBox_DiaDiem.Location = new System.Drawing.Point(84, 91);
            this.comboBox_DiaDiem.Name = "comboBox_DiaDiem";
            this.comboBox_DiaDiem.Size = new System.Drawing.Size(167, 21);
            this.comboBox_DiaDiem.TabIndex = 60;
            // 
            // comboBox_LoaiHinh
            // 
            this.comboBox_LoaiHinh.FormattingEnabled = true;
            this.comboBox_LoaiHinh.Location = new System.Drawing.Point(117, 49);
            this.comboBox_LoaiHinh.Name = "comboBox_LoaiHinh";
            this.comboBox_LoaiHinh.Size = new System.Drawing.Size(134, 21);
            this.comboBox_LoaiHinh.TabIndex = 59;
            // 
            // txtDD
            // 
            this.txtDD.Location = new System.Drawing.Point(406, 11);
            this.txtDD.Multiline = true;
            this.txtDD.Name = "txtDD";
            this.txtDD.Size = new System.Drawing.Size(164, 61);
            this.txtDD.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Beige;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(336, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 57;
            this.label5.Text = "Đặc Điểm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Beige;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 54;
            this.label3.Text = "Điểm Đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Beige;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 53;
            this.label2.Text = "Loại hình Tour";
            // 
            // txtTenTour
            // 
            this.txtTenTour.Location = new System.Drawing.Point(84, 11);
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.Size = new System.Drawing.Size(167, 20);
            this.txtTenTour.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Beige;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 51;
            this.label1.Text = "Tên Tour";
            // 
            // btnPricing
            // 
            this.btnPricing.Image = global::Tour.Properties.Resources.istockphoto_1226810736_170667a1;
            this.btnPricing.Location = new System.Drawing.Point(432, 79);
            this.btnPricing.Name = "btnPricing";
            this.btnPricing.Size = new System.Drawing.Size(42, 42);
            this.btnPricing.TabIndex = 63;
            this.btnPricing.UseVisualStyleBackColor = true;
            this.btnPricing.Click += new System.EventHandler(this.btnPricing_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Tour.Properties.Resources.remove;
            this.btnClose.Location = new System.Drawing.Point(528, 79);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 42);
            this.btnClose.TabIndex = 62;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Tour.Properties.Resources.diskette;
            this.btnSave.Location = new System.Drawing.Point(480, 79);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(42, 42);
            this.btnSave.TabIndex = 61;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 136);
            this.panel1.TabIndex = 64;
            // 
            // frmDETAIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 133);
            this.Controls.Add(this.btnPricing);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboBox_DiaDiem);
            this.Controls.Add(this.comboBox_LoaiHinh);
            this.Controls.Add(this.txtDD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenTour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDETAIL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật Tour";
            this.Load += new System.EventHandler(this.frmDETAIL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboBox_DiaDiem;
        private System.Windows.Forms.ComboBox comboBox_LoaiHinh;
        private System.Windows.Forms.TextBox txtDD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenTour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPricing;
        private System.Windows.Forms.Panel panel1;
    }
}