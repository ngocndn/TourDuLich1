
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPricing = new System.Windows.Forms.Button();
            this.dpk2 = new System.Windows.Forms.DateTimePicker();
            this.dpk1 = new System.Windows.Forms.DateTimePicker();
            this.cbbhdv = new System.Windows.Forms.ComboBox();
            this.cbbtour = new System.Windows.Forms.ComboBox();
            this.txtTenDoan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 190);
            this.dataGridView1.TabIndex = 67;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(305, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 16);
            this.label10.TabIndex = 68;
            this.label10.Text = "DANH SÁCH HÀNH KHÁCH";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Tour.Properties.Resources.diskette;
            this.btnSave.Location = new System.Drawing.Point(617, 97);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(42, 42);
            this.btnSave.TabIndex = 64;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Tour.Properties.Resources.remove;
            this.btnClose.Location = new System.Drawing.Point(665, 97);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 42);
            this.btnClose.TabIndex = 65;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPricing
            // 
            this.btnPricing.Image = global::Tour.Properties.Resources.plus;
            this.btnPricing.Location = new System.Drawing.Point(569, 97);
            this.btnPricing.Name = "btnPricing";
            this.btnPricing.Size = new System.Drawing.Size(42, 42);
            this.btnPricing.TabIndex = 66;
            this.btnPricing.UseVisualStyleBackColor = true;
            this.btnPricing.Click += new System.EventHandler(this.btnPricing_Click);
            // 
            // dpk2
            // 
            this.dpk2.Location = new System.Drawing.Point(578, 57);
            this.dpk2.Name = "dpk2";
            this.dpk2.Size = new System.Drawing.Size(200, 20);
            this.dpk2.TabIndex = 78;
            // 
            // dpk1
            // 
            this.dpk1.Location = new System.Drawing.Point(578, 17);
            this.dpk1.Name = "dpk1";
            this.dpk1.Size = new System.Drawing.Size(200, 20);
            this.dpk1.TabIndex = 77;
            // 
            // cbbhdv
            // 
            this.cbbhdv.FormattingEnabled = true;
            this.cbbhdv.Location = new System.Drawing.Point(127, 97);
            this.cbbhdv.Name = "cbbhdv";
            this.cbbhdv.Size = new System.Drawing.Size(200, 21);
            this.cbbhdv.TabIndex = 76;
            // 
            // cbbtour
            // 
            this.cbbtour.FormattingEnabled = true;
            this.cbbtour.Location = new System.Drawing.Point(127, 56);
            this.cbbtour.Name = "cbbtour";
            this.cbbtour.Size = new System.Drawing.Size(200, 21);
            this.cbbtour.TabIndex = 75;
            // 
            // txtTenDoan
            // 
            this.txtTenDoan.Location = new System.Drawing.Point(127, 17);
            this.txtTenDoan.Name = "txtTenDoan";
            this.txtTenDoan.Size = new System.Drawing.Size(200, 20);
            this.txtTenDoan.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "HDV Phụ trách ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Ngày khởi hành";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Tour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Tên Đoàn";
            // 
            // frmEditDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 372);
            this.Controls.Add(this.dpk2);
            this.Controls.Add(this.dpk1);
            this.Controls.Add(this.cbbhdv);
            this.Controls.Add(this.cbbtour);
            this.Controls.Add(this.txtTenDoan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPricing);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Name = "frmEditDoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết đoàn";
            this.Load += new System.EventHandler(this.frmEditDoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPricing;
        private System.Windows.Forms.DateTimePicker dpk2;
        private System.Windows.Forms.DateTimePicker dpk1;
        private System.Windows.Forms.ComboBox cbbhdv;
        private System.Windows.Forms.ComboBox cbbtour;
        private System.Windows.Forms.TextBox txtTenDoan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}