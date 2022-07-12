namespace SOFOS2_Migration_Tool
{
    partial class frmMain
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pcbMembers = new System.Windows.Forms.PictureBox();
            this.btnDummyRR = new System.Windows.Forms.Button();
            this.dtpDateParam = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.pcbMembers);
            this.groupBox2.Controls.Add(this.btnDummyRR);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(27, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modules";
            // 
            // pcbMembers
            // 
            this.pcbMembers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbMembers.BackColor = System.Drawing.Color.Transparent;
            this.pcbMembers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbMembers.Location = new System.Drawing.Point(234, 48);
            this.pcbMembers.Name = "pcbMembers";
            this.pcbMembers.Size = new System.Drawing.Size(39, 39);
            this.pcbMembers.TabIndex = 18;
            this.pcbMembers.TabStop = false;
            // 
            // btnDummyRR
            // 
            this.btnDummyRR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDummyRR.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDummyRR.Location = new System.Drawing.Point(64, 48);
            this.btnDummyRR.Name = "btnDummyRR";
            this.btnDummyRR.Size = new System.Drawing.Size(164, 39);
            this.btnDummyRR.TabIndex = 1;
            this.btnDummyRR.Text = "DummyRR";
            this.btnDummyRR.UseVisualStyleBackColor = true;
            this.btnDummyRR.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // dtpDateParam
            // 
            this.dtpDateParam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDateParam.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateParam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateParam.Location = new System.Drawing.Point(226, 28);
            this.dtpDateParam.Name = "dtpDateParam";
            this.dtpDateParam.Size = new System.Drawing.Size(117, 25);
            this.dtpDateParam.TabIndex = 1;
            this.dtpDateParam.ValueChanged += new System.EventHandler(this.dtpDateParam_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Date :";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 189);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDateParam);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Migration Tool v.0.0.1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpDateParam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbMembers;
        private System.Windows.Forms.Button btnDummyRR;
    }
}

