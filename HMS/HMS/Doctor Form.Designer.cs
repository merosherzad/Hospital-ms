namespace HMS
{
    partial class Doctor_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DocId = new System.Windows.Forms.TextBox();
            this.DocName = new System.Windows.Forms.TextBox();
            this.DocExp = new System.Windows.Forms.TextBox();
            this.DocPass = new System.Windows.Forms.TextBox();
            this.DoctorGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1817, 106);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(635, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "DOCTOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(506, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOSPITAL MANAGMENT SYSTEM ";
            // 
            // DocId
            // 
            this.DocId.BackColor = System.Drawing.SystemColors.Highlight;
            this.DocId.Location = new System.Drawing.Point(113, 273);
            this.DocId.Name = "DocId";
            this.DocId.Size = new System.Drawing.Size(123, 22);
            this.DocId.TabIndex = 1;
            this.DocId.Text = "Doctor ID";
            // 
            // DocName
            // 
            this.DocName.BackColor = System.Drawing.SystemColors.Highlight;
            this.DocName.Location = new System.Drawing.Point(113, 313);
            this.DocName.Name = "DocName";
            this.DocName.Size = new System.Drawing.Size(123, 22);
            this.DocName.TabIndex = 2;
            this.DocName.Text = "DoctorName ";
            this.DocName.TextChanged += new System.EventHandler(this.DocName_TextChanged);
            // 
            // DocExp
            // 
            this.DocExp.BackColor = System.Drawing.SystemColors.Highlight;
            this.DocExp.Location = new System.Drawing.Point(113, 357);
            this.DocExp.Name = "DocExp";
            this.DocExp.Size = new System.Drawing.Size(123, 22);
            this.DocExp.TabIndex = 3;
            this.DocExp.Text = "YearsOfexpirence";
            // 
            // DocPass
            // 
            this.DocPass.BackColor = System.Drawing.SystemColors.Highlight;
            this.DocPass.Location = new System.Drawing.Point(113, 397);
            this.DocPass.Name = "DocPass";
            this.DocPass.Size = new System.Drawing.Size(123, 22);
            this.DocPass.TabIndex = 4;
            this.DocPass.Text = "Password";
            // 
            // DoctorGV
            // 
            this.DoctorGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorGV.GridColor = System.Drawing.Color.Ivory;
            this.DoctorGV.Location = new System.Drawing.Point(790, 148);
            this.DoctorGV.Name = "DoctorGV";
            this.DoctorGV.RowHeadersWidth = 51;
            this.DoctorGV.RowTemplate.Height = 24;
            this.DoctorGV.Size = new System.Drawing.Size(638, 509);
            this.DoctorGV.TabIndex = 5;
            this.DoctorGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoctorGV_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(113, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(218, 586);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 55);
            this.button2.TabIndex = 7;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Location = new System.Drawing.Point(335, 586);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 55);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Location = new System.Drawing.Point(218, 672);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 55);
            this.button4.TabIndex = 9;
            this.button4.Text = "Home ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Doctor_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1817, 864);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DoctorGV);
            this.Controls.Add(this.DocPass);
            this.Controls.Add(this.DocExp);
            this.Controls.Add(this.DocName);
            this.Controls.Add(this.DocId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Doctor_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor_Form";
            this.Load += new System.EventHandler(this.Doctor_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DocId;
        private System.Windows.Forms.TextBox DocName;
        private System.Windows.Forms.TextBox DocExp;
        private System.Windows.Forms.TextBox DocPass;
        private System.Windows.Forms.DataGridView DoctorGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}