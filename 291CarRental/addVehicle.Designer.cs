namespace _291CarRental
{
    partial class addVehicle
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.formTabs = new System.Windows.Forms.TabControl();
            this.vehicleTab = new System.Windows.Forms.TabPage();
            this.exitCurrent = new System.Windows.Forms.Button();
            this.addTab = new System.Windows.Forms.TabPage();
            this.exit = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.modelLabel = new System.Windows.Forms.Label();
            this.modelBox = new System.Windows.Forms.ComboBox();
            this.makerSelect = new System.Windows.Forms.ComboBox();
            this.colorSelect = new System.Windows.Forms.ComboBox();
            this.makeLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeSelect = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._291GroupProjectDataSet1 = new _291CarRental._291GroupProjectDataSet1();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new _291CarRental._291GroupProjectDataSet1TableAdapters.CarTableAdapter();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfVehicleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.formTabs.SuspendLayout();
            this.vehicleTab.SuspendLayout();
            this.addTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._291GroupProjectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1288, 100);
            this.panel1.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(290, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(667, 57);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "ADD VEHICLE TO DATABASE";
            // 
            // formTabs
            // 
            this.formTabs.Controls.Add(this.vehicleTab);
            this.formTabs.Controls.Add(this.addTab);
            this.formTabs.Location = new System.Drawing.Point(12, 133);
            this.formTabs.Name = "formTabs";
            this.formTabs.SelectedIndex = 0;
            this.formTabs.Size = new System.Drawing.Size(1264, 457);
            this.formTabs.TabIndex = 1;
            // 
            // vehicleTab
            // 
            this.vehicleTab.BackColor = System.Drawing.Color.Silver;
            this.vehicleTab.Controls.Add(this.dataGridView1);
            this.vehicleTab.Controls.Add(this.exitCurrent);
            this.vehicleTab.Location = new System.Drawing.Point(4, 22);
            this.vehicleTab.Name = "vehicleTab";
            this.vehicleTab.Padding = new System.Windows.Forms.Padding(3);
            this.vehicleTab.Size = new System.Drawing.Size(1256, 431);
            this.vehicleTab.TabIndex = 0;
            this.vehicleTab.Text = "Current Vehicles";
            // 
            // exitCurrent
            // 
            this.exitCurrent.BackColor = System.Drawing.Color.Brown;
            this.exitCurrent.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitCurrent.Location = new System.Drawing.Point(913, 250);
            this.exitCurrent.Name = "exitCurrent";
            this.exitCurrent.Size = new System.Drawing.Size(287, 75);
            this.exitCurrent.TabIndex = 10;
            this.exitCurrent.Text = "Exit";
            this.exitCurrent.UseVisualStyleBackColor = false;
            this.exitCurrent.Click += new System.EventHandler(this.exitCurrent_Click);
            // 
            // addTab
            // 
            this.addTab.BackColor = System.Drawing.Color.Tan;
            this.addTab.Controls.Add(this.exit);
            this.addTab.Controls.Add(this.submit);
            this.addTab.Controls.Add(this.modelLabel);
            this.addTab.Controls.Add(this.modelBox);
            this.addTab.Controls.Add(this.makerSelect);
            this.addTab.Controls.Add(this.colorSelect);
            this.addTab.Controls.Add(this.makeLabel);
            this.addTab.Controls.Add(this.colorLabel);
            this.addTab.Controls.Add(this.typeLabel);
            this.addTab.Controls.Add(this.typeSelect);
            this.addTab.Location = new System.Drawing.Point(4, 22);
            this.addTab.Name = "addTab";
            this.addTab.Padding = new System.Windows.Forms.Padding(3);
            this.addTab.Size = new System.Drawing.Size(1256, 431);
            this.addTab.TabIndex = 1;
            this.addTab.Text = "Add Vehicle";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Brown;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(855, 269);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(287, 75);
            this.exit.TabIndex = 9;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(855, 54);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(287, 75);
            this.submit.TabIndex = 8;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.Location = new System.Drawing.Point(53, 344);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(270, 38);
            this.modelLabel.TabIndex = 7;
            this.modelLabel.Text = "Model of Vehicle:";
            // 
            // modelBox
            // 
            this.modelBox.Font = new System.Drawing.Font("Century Schoolbook", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelBox.FormattingEnabled = true;
            this.modelBox.Location = new System.Drawing.Point(352, 333);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(431, 49);
            this.modelBox.TabIndex = 6;
            // 
            // makerSelect
            // 
            this.makerSelect.Font = new System.Drawing.Font("Century Schoolbook", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makerSelect.FormattingEnabled = true;
            this.makerSelect.Items.AddRange(new object[] {
            "Honda",
            "Toyota",
            "Ford",
            "Porsche",
            "Tesla",
            "Mitsubishi",
            "Audi",
            "BMW",
            "Bently"});
            this.makerSelect.Location = new System.Drawing.Point(352, 43);
            this.makerSelect.Name = "makerSelect";
            this.makerSelect.Size = new System.Drawing.Size(267, 49);
            this.makerSelect.TabIndex = 5;
            this.makerSelect.SelectedIndexChanged += new System.EventHandler(this.makerSelect_SelectedIndexChanged);
            // 
            // colorSelect
            // 
            this.colorSelect.Font = new System.Drawing.Font("Century Schoolbook", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorSelect.FormattingEnabled = true;
            this.colorSelect.Items.AddRange(new object[] {
            "red",
            "blue",
            "green",
            "black",
            "silver",
            "grey",
            "white",
            "brown"});
            this.colorSelect.Location = new System.Drawing.Point(352, 148);
            this.colorSelect.Name = "colorSelect";
            this.colorSelect.Size = new System.Drawing.Size(267, 49);
            this.colorSelect.TabIndex = 4;
            this.colorSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeLabel.Location = new System.Drawing.Point(53, 48);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(277, 38);
            this.makeLabel.TabIndex = 3;
            this.makeLabel.Text = "Maker of Vehicle:";
            this.makeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLabel.Location = new System.Drawing.Point(53, 153);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(259, 38);
            this.colorLabel.TabIndex = 2;
            this.colorLabel.Text = "Color of Vehicle:";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(53, 237);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(261, 38);
            this.typeLabel.TabIndex = 1;
            this.typeLabel.Text = "Type Of Vehicle:";
            // 
            // typeSelect
            // 
            this.typeSelect.Font = new System.Drawing.Font("Century Schoolbook", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeSelect.FormattingEnabled = true;
            this.typeSelect.Location = new System.Drawing.Point(352, 232);
            this.typeSelect.Name = "typeSelect";
            this.typeSelect.Size = new System.Drawing.Size(267, 49);
            this.typeSelect.TabIndex = 0;
            this.typeSelect.SelectedIndexChanged += new System.EventHandler(this.typeSelect_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleIDDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.makeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.typeOfVehicleDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(817, 305);
            this.dataGridView1.TabIndex = 11;
            // 
            // _291GroupProjectDataSet1
            // 
            this._291GroupProjectDataSet1.DataSetName = "_291GroupProjectDataSet1";
            this._291GroupProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this._291GroupProjectDataSet1;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // makeDataGridViewTextBoxColumn
            // 
            this.makeDataGridViewTextBoxColumn.DataPropertyName = "Make";
            this.makeDataGridViewTextBoxColumn.HeaderText = "Make";
            this.makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // typeOfVehicleDataGridViewTextBoxColumn
            // 
            this.typeOfVehicleDataGridViewTextBoxColumn.DataPropertyName = "Type of Vehicle";
            this.typeOfVehicleDataGridViewTextBoxColumn.HeaderText = "Type of Vehicle";
            this.typeOfVehicleDataGridViewTextBoxColumn.Name = "typeOfVehicleDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // addVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1288, 639);
            this.Controls.Add(this.formTabs);
            this.Controls.Add(this.panel1);
            this.Name = "addVehicle";
            this.Text = "Add Vehicle Form";
            this.Load += new System.EventHandler(this.addVehicle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.formTabs.ResumeLayout(false);
            this.vehicleTab.ResumeLayout(false);
            this.addTab.ResumeLayout(false);
            this.addTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._291GroupProjectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TabControl formTabs;
        private System.Windows.Forms.TabPage vehicleTab;
        private System.Windows.Forms.TabPage addTab;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox typeSelect;
        private System.Windows.Forms.ComboBox colorSelect;
        private System.Windows.Forms.ComboBox makerSelect;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.ComboBox modelBox;
        private System.Windows.Forms.Button exitCurrent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _291GroupProjectDataSet1 _291GroupProjectDataSet1;
        private System.Windows.Forms.BindingSource carBindingSource;
        private _291GroupProjectDataSet1TableAdapters.CarTableAdapter carTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfVehicleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
    }
}