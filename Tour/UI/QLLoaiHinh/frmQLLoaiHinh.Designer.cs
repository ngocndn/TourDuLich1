
namespace Tour.UI.QLLoaiHinh
{
    partial class frmQLLoaiHinh
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
            this.txtDD = new System.Windows.Forms.TextBox();
            this.txtTenLH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_LoaiHinh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LoaiHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDD
            // 
            this.txtDD.Location = new System.Drawing.Point(109, 101);
            this.txtDD.Multiline = true;
            this.txtDD.Name = "txtDD";
            this.txtDD.Size = new System.Drawing.Size(161, 53);
            this.txtDD.TabIndex = 12;
            // 
            // txtTenLH
            // 
            this.txtTenLH.Location = new System.Drawing.Point(109, 45);
            this.txtTenLH.Name = "txtTenLH";
            this.txtTenLH.Size = new System.Drawing.Size(161, 20);
            this.txtTenLH.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Đặc Điểm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên Loại Hình";
            // 
            // dataGridView_LoaiHinh
            // 
            this.dataGridView_LoaiHinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_LoaiHinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LoaiHinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView_LoaiHinh.Location = new System.Drawing.Point(276, 32);
            this.dataGridView_LoaiHinh.Name = "dataGridView_LoaiHinh";
            this.dataGridView_LoaiHinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_LoaiHinh.Size = new System.Drawing.Size(519, 406);
            this.dataGridView_LoaiHinh.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaLoaiHinh";
            this.Column1.HeaderText = "Mã Loại Hình";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenLoaiHinh";
            this.Column2.HeaderText = "Tên Loại Hình";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "LH_MoTa";
            this.Column3.HeaderText = "Mô Tả";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Tour.Properties.Resources.delete__2_;
            this.btnDelete.Location = new System.Drawing.Point(169, 210);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(42, 42);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Image = global::Tour.Properties.Resources.edit__1_;
            this.btnDetail.Location = new System.Drawing.Point(121, 210);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(42, 42);
            this.btnDetail.TabIndex = 14;
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::Tour.Properties.Resources.plus;
            this.btnAdd.Location = new System.Drawing.Point(73, 210);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(42, 42);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(464, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 16);
            this.label10.TabIndex = 70;
            this.label10.Text = "DANH SÁCH LOẠI HÌNH";
            // 
            // frmQLLoaiHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDD);
            this.Controls.Add(this.txtTenLH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_LoaiHinh);
            this.Name = "frmQLLoaiHinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loai Hinh";
            this.Load += new System.EventHandler(this.frmQLLoaiHinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LoaiHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDD;
        private System.Windows.Forms.TextBox txtTenLH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_LoaiHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label10;
    }
}