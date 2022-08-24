
namespace QuanLyDiem
{
    partial class inLop
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_in = new System.Windows.Forms.Button();
            this.txt_lop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.viewLop = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_in);
            this.groupBox1.Controls.Add(this.txt_lop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // bt_in
            // 
            this.bt_in.Location = new System.Drawing.Point(328, 12);
            this.bt_in.Name = "bt_in";
            this.bt_in.Size = new System.Drawing.Size(75, 23);
            this.bt_in.TabIndex = 2;
            this.bt_in.Text = "In";
            this.bt_in.UseVisualStyleBackColor = true;
            this.bt_in.Click += new System.EventHandler(this.bt_in_Click);
            // 
            // txt_lop
            // 
            this.txt_lop.Location = new System.Drawing.Point(211, 12);
            this.txt_lop.Name = "txt_lop";
            this.txt_lop.Size = new System.Drawing.Size(100, 20);
            this.txt_lop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Tìm Kiếm:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.viewLop);
            this.groupBox2.Location = new System.Drawing.Point(12, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 365);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // viewLop
            // 
            this.viewLop.ActiveViewIndex = -1;
            this.viewLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewLop.Cursor = System.Windows.Forms.Cursors.Default;
            this.viewLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewLop.Location = new System.Drawing.Point(3, 16);
            this.viewLop.Name = "viewLop";
            this.viewLop.Size = new System.Drawing.Size(770, 346);
            this.viewLop.TabIndex = 0;
            // 
            // inLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "inLop";
            this.Text = "inLop";
            this.Load += new System.EventHandler(this.inLop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_in;
        private System.Windows.Forms.TextBox txt_lop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer viewLop;
    }
}