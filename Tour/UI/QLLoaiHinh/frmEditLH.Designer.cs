
namespace Tour.UI.QLLoaiHinh
{
    partial class frmEditLH
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtDD
            // 
            this.txtDD.Location = new System.Drawing.Point(107, 67);
            this.txtDD.Multiline = true;
            this.txtDD.Name = "txtDD";
            this.txtDD.Size = new System.Drawing.Size(184, 53);
            this.txtDD.TabIndex = 18;
            // 
            // txtTenLH
            // 
            this.txtTenLH.Location = new System.Drawing.Point(107, 9);
            this.txtTenLH.Name = "txtTenLH";
            this.txtTenLH.Size = new System.Drawing.Size(184, 20);
            this.txtTenLH.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Beige;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Đặc Điểm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Beige;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tên Loại Hình";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Tour.Properties.Resources.remove;
            this.btnClose.Location = new System.Drawing.Point(155, 126);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 42);
            this.btnClose.TabIndex = 20;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Tour.Properties.Resources.diskette;
            this.btnSave.Location = new System.Drawing.Point(107, 126);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(42, 42);
            this.btnSave.TabIndex = 19;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Location = new System.Drawing.Point(-3, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 190);
            this.panel1.TabIndex = 25;
            // 
            // frmEditLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 179);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDD);
            this.Controls.Add(this.txtTenLH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmEditLH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Loại Hình";
            this.Load += new System.EventHandler(this.frmEditLH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDD;
        private System.Windows.Forms.TextBox txtTenLH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}