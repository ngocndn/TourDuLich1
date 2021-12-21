
namespace Tour.UI.QLDiemDen
{
    partial class frmEditDD
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
            this.txtTenDD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDD
            // 
            this.txtDD.Location = new System.Drawing.Point(89, 68);
            this.txtDD.Multiline = true;
            this.txtDD.Name = "txtDD";
            this.txtDD.Size = new System.Drawing.Size(184, 53);
            this.txtDD.TabIndex = 24;
            // 
            // txtTenDD
            // 
            this.txtTenDD.Location = new System.Drawing.Point(89, 12);
            this.txtTenDD.Name = "txtTenDD";
            this.txtTenDD.Size = new System.Drawing.Size(184, 20);
            this.txtTenDD.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Đặc Điểm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Điểm Đến";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Tour.Properties.Resources.remove;
            this.btnClose.Location = new System.Drawing.Point(156, 127);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 42);
            this.btnClose.TabIndex = 26;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Tour.Properties.Resources.diskette;
            this.btnSave.Location = new System.Drawing.Point(108, 127);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(42, 42);
            this.btnSave.TabIndex = 25;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmEditDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 179);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDD);
            this.Controls.Add(this.txtTenDD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEditDD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Điểm Đến";
            this.Load += new System.EventHandler(this.frmEditDD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDD;
        private System.Windows.Forms.TextBox txtTenDD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}