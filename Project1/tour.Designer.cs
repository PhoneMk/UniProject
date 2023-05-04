namespace Project1
{
    partial class tour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tour));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIcon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSst = new System.Windows.Forms.Button();
            this.btnPt = new System.Windows.Forms.Button();
            this.btnCt = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Button();
            this.btnMini = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.btnMini);
            this.panel1.Controls.Add(this.X);
            this.panel1.Controls.Add(this.btnIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1362, 106);
            this.panel1.TabIndex = 0;
            // 
            // btnIcon
            // 
            this.btnIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIcon.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnIcon.Image = ((System.Drawing.Image)(resources.GetObject("btnIcon.Image")));
            this.btnIcon.Location = new System.Drawing.Point(29, 12);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(239, 91);
            this.btnIcon.TabIndex = 4;
            this.btnIcon.UseVisualStyleBackColor = true;
            this.btnIcon.Click += new System.EventHandler(this.btnIcon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(12, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(807, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "ARE YOU READY TO MAKE NEW MEMORIES?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(14, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "CHOOSE ONE!";
            // 
            // btnSst
            // 
            this.btnSst.Image = ((System.Drawing.Image)(resources.GetObject("btnSst.Image")));
            this.btnSst.Location = new System.Drawing.Point(68, 408);
            this.btnSst.Name = "btnSst";
            this.btnSst.Size = new System.Drawing.Size(250, 231);
            this.btnSst.TabIndex = 3;
            this.btnSst.UseVisualStyleBackColor = true;
            // 
            // btnPt
            // 
            this.btnPt.Image = ((System.Drawing.Image)(resources.GetObject("btnPt.Image")));
            this.btnPt.Location = new System.Drawing.Point(559, 408);
            this.btnPt.Name = "btnPt";
            this.btnPt.Size = new System.Drawing.Size(251, 231);
            this.btnPt.TabIndex = 4;
            this.btnPt.UseVisualStyleBackColor = true;
            // 
            // btnCt
            // 
            this.btnCt.Image = ((System.Drawing.Image)(resources.GetObject("btnCt.Image")));
            this.btnCt.Location = new System.Drawing.Point(1038, 408);
            this.btnCt.Name = "btnCt";
            this.btnCt.Size = new System.Drawing.Size(230, 231);
            this.btnCt.TabIndex = 5;
            this.btnCt.UseVisualStyleBackColor = true;
            // 
            // X
            // 
            this.X.FlatAppearance.BorderSize = 0;
            this.X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.ForeColor = System.Drawing.Color.White;
            this.X.Location = new System.Drawing.Point(1316, 0);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(46, 43);
            this.X.TabIndex = 6;
            this.X.Text = "x";
            this.X.UseVisualStyleBackColor = true;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // btnMini
            // 
            this.btnMini.FlatAppearance.BorderSize = 0;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMini.ForeColor = System.Drawing.Color.White;
            this.btnMini.Location = new System.Drawing.Point(1264, 0);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(46, 43);
            this.btnMini.TabIndex = 7;
            this.btnMini.Text = " -";
            this.btnMini.UseVisualStyleBackColor = true;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // tour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1362, 832);
            this.Controls.Add(this.btnCt);
            this.Controls.Add(this.btnPt);
            this.Controls.Add(this.btnSst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tour";
            this.Text = "TOUR";
            this.Load += new System.EventHandler(this.tour_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSst;
        private System.Windows.Forms.Button btnPt;
        private System.Windows.Forms.Button btnCt;
        private System.Windows.Forms.Button btnIcon;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Button X;
    }
}