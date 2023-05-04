namespace Project1
{
    partial class editTour
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editTour));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddNewTour = new System.Windows.Forms.Button();
            this.dtgvTour = new System.Windows.Forms.DataGridView();
            this.travelANDtourDataSet = new Project1.travelANDtourDataSet();
            this.tbltourBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_tourTableAdapter = new Project1.travelANDtourDataSetTableAdapters.tbl_tourTableAdapter();
            this.tourIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accomodationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelANDtourDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltourBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 11);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 568);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(975, 11);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.flowLayoutPanel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 557);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel3.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel3.Location = new System.Drawing.Point(11, 88);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(963, 464);
            this.flowLayoutPanel3.TabIndex = 5;
            this.flowLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel3_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(840, 0);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(964, 11);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(11, 557);
            this.flowLayoutPanel2.TabIndex = 3;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(59)))), ((int)(((byte)(102)))));
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnAddNewTour);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(11, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(953, 94);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(213, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "Edit Tour";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(727, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 32);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(632, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(418, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete Tour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddNewTour
            // 
            this.btnAddNewTour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddNewTour.FlatAppearance.BorderSize = 0;
            this.btnAddNewTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewTour.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewTour.ForeColor = System.Drawing.Color.White;
            this.btnAddNewTour.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewTour.Image")));
            this.btnAddNewTour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewTour.Location = new System.Drawing.Point(0, 16);
            this.btnAddNewTour.Name = "btnAddNewTour";
            this.btnAddNewTour.Size = new System.Drawing.Size(197, 60);
            this.btnAddNewTour.TabIndex = 1;
            this.btnAddNewTour.Text = "Add New Tour";
            this.btnAddNewTour.UseVisualStyleBackColor = true;
            this.btnAddNewTour.Click += new System.EventHandler(this.btnAddNewTour_Click);
            // 
            // dtgvTour
            // 
            this.dtgvTour.AutoGenerateColumns = false;
            this.dtgvTour.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tourIDDataGridViewTextBoxColumn,
            this.tourNameDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.accomodationDataGridViewTextBoxColumn,
            this.transportationDataGridViewTextBoxColumn,
            this.costsDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.imageNameDataGridViewTextBoxColumn});
            this.dtgvTour.DataSource = this.tbltourBindingSource;
            this.dtgvTour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTour.Location = new System.Drawing.Point(11, 105);
            this.dtgvTour.Name = "dtgvTour";
            this.dtgvTour.RowHeadersWidth = 51;
            this.dtgvTour.RowTemplate.Height = 24;
            this.dtgvTour.Size = new System.Drawing.Size(953, 463);
            this.dtgvTour.TabIndex = 5;
            this.dtgvTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTour_CellClick);
            this.dtgvTour.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTour_CellContentClick);
            this.dtgvTour.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTour_CellContentDoubleClick);
            this.dtgvTour.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvTour_RowHeaderMouseClick);
            // 
            // travelANDtourDataSet
            // 
            this.travelANDtourDataSet.DataSetName = "travelANDtourDataSet";
            this.travelANDtourDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbltourBindingSource
            // 
            this.tbltourBindingSource.DataMember = "tbl_tour";
            this.tbltourBindingSource.DataSource = this.travelANDtourDataSet;
            this.tbltourBindingSource.CurrentChanged += new System.EventHandler(this.tbltourBindingSource_CurrentChanged);
            // 
            // tbl_tourTableAdapter
            // 
            this.tbl_tourTableAdapter.ClearBeforeFill = true;
            // 
            // tourIDDataGridViewTextBoxColumn
            // 
            this.tourIDDataGridViewTextBoxColumn.DataPropertyName = "TourID";
            this.tourIDDataGridViewTextBoxColumn.HeaderText = "TourID";
            this.tourIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tourIDDataGridViewTextBoxColumn.Name = "tourIDDataGridViewTextBoxColumn";
            this.tourIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tourIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // tourNameDataGridViewTextBoxColumn
            // 
            this.tourNameDataGridViewTextBoxColumn.DataPropertyName = "TourName";
            this.tourNameDataGridViewTextBoxColumn.HeaderText = "TourName";
            this.tourNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tourNameDataGridViewTextBoxColumn.Name = "tourNameDataGridViewTextBoxColumn";
            this.tourNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.Width = 150;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            // 
            // accomodationDataGridViewTextBoxColumn
            // 
            this.accomodationDataGridViewTextBoxColumn.DataPropertyName = "Accomodation";
            this.accomodationDataGridViewTextBoxColumn.HeaderText = "Accomodation";
            this.accomodationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accomodationDataGridViewTextBoxColumn.Name = "accomodationDataGridViewTextBoxColumn";
            this.accomodationDataGridViewTextBoxColumn.Width = 150;
            // 
            // transportationDataGridViewTextBoxColumn
            // 
            this.transportationDataGridViewTextBoxColumn.DataPropertyName = "Transportation";
            this.transportationDataGridViewTextBoxColumn.HeaderText = "Transportation";
            this.transportationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transportationDataGridViewTextBoxColumn.Name = "transportationDataGridViewTextBoxColumn";
            this.transportationDataGridViewTextBoxColumn.Width = 150;
            // 
            // costsDataGridViewTextBoxColumn
            // 
            this.costsDataGridViewTextBoxColumn.DataPropertyName = "Costs";
            this.costsDataGridViewTextBoxColumn.HeaderText = "Costs";
            this.costsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costsDataGridViewTextBoxColumn.Name = "costsDataGridViewTextBoxColumn";
            this.costsDataGridViewTextBoxColumn.Width = 90;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 300;
            // 
            // imageNameDataGridViewTextBoxColumn
            // 
            this.imageNameDataGridViewTextBoxColumn.DataPropertyName = "ImageName";
            this.imageNameDataGridViewTextBoxColumn.HeaderText = "ImageName";
            this.imageNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imageNameDataGridViewTextBoxColumn.Name = "imageNameDataGridViewTextBoxColumn";
            this.imageNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // editTour
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dtgvTour);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "editTour";
            this.Size = new System.Drawing.Size(975, 579);
            this.Load += new System.EventHandler(this.editTour_Load);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelANDtourDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltourBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dtgvTour;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnAddNewTour;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.BindingSource tbltourBindingSource;
        public travelANDtourDataSet travelANDtourDataSet;
        public travelANDtourDataSetTableAdapters.tbl_tourTableAdapter tbl_tourTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn tourIDDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn tourNameDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn accomodationDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn transportationDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn costsDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn imageNameDataGridViewTextBoxColumn;
    }
}
