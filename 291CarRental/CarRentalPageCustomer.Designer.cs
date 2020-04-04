namespace Car_Renting_Software
{
    partial class CarRentalPageCustomer
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
            this.ModelText = new System.Windows.Forms.Label();
            this.MakeText = new System.Windows.Forms.Label();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.makeBox = new System.Windows.Forms.TextBox();
            this.CarInfoBox = new System.Windows.Forms.RichTextBox();
            this.CarIDText = new System.Windows.Forms.Label();
            this.ColorText = new System.Windows.Forms.Label();
            this.TypeText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CarData = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.availableCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.carIDBox = new System.Windows.Forms.TextBox();
            this.colorBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this._291GroupProjectDataSetCar = new _291CarRental._291GroupProjectDataSetCar();
            this.groupProjectDataSetCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new _291CarRental._291GroupProjectDataSetCarTableAdapters.CarTableAdapter();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfVehicleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CarData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._291GroupProjectDataSetCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupProjectDataSetCarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ModelText
            // 
            this.ModelText.AutoSize = true;
            this.ModelText.Enabled = false;
            this.ModelText.ForeColor = System.Drawing.Color.White;
            this.ModelText.Location = new System.Drawing.Point(-106, 113);
            this.ModelText.Name = "ModelText";
            this.ModelText.Size = new System.Drawing.Size(36, 13);
            this.ModelText.TabIndex = 38;
            this.ModelText.Text = "Model";
            // 
            // MakeText
            // 
            this.MakeText.AutoSize = true;
            this.MakeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.MakeText.Enabled = false;
            this.MakeText.ForeColor = System.Drawing.Color.White;
            this.MakeText.Location = new System.Drawing.Point(-222, 113);
            this.MakeText.Name = "MakeText";
            this.MakeText.Size = new System.Drawing.Size(34, 13);
            this.MakeText.TabIndex = 37;
            this.MakeText.Text = "Make";
            // 
            // modelBox
            // 
            this.modelBox.Location = new System.Drawing.Point(-103, 131);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(100, 20);
            this.modelBox.TabIndex = 35;
            // 
            // makeBox
            // 
            this.makeBox.Location = new System.Drawing.Point(-222, 131);
            this.makeBox.Name = "makeBox";
            this.makeBox.Size = new System.Drawing.Size(113, 20);
            this.makeBox.TabIndex = 28;
            // 
            // CarInfoBox
            // 
            this.CarInfoBox.Location = new System.Drawing.Point(942, 239);
            this.CarInfoBox.Name = "CarInfoBox";
            this.CarInfoBox.ReadOnly = true;
            this.CarInfoBox.Size = new System.Drawing.Size(314, 331);
            this.CarInfoBox.TabIndex = 54;
            this.CarInfoBox.Text = "";
            this.CarInfoBox.TextChanged += new System.EventHandler(this.CarInfoBox_TextChanged);
            // 
            // CarIDText
            // 
            this.CarIDText.AutoSize = true;
            this.CarIDText.Enabled = false;
            this.CarIDText.ForeColor = System.Drawing.Color.White;
            this.CarIDText.Location = new System.Drawing.Point(446, 195);
            this.CarIDText.Name = "CarIDText";
            this.CarIDText.Size = new System.Drawing.Size(44, 13);
            this.CarIDText.TabIndex = 53;
            this.CarIDText.Text = "Car ID#";
            // 
            // ColorText
            // 
            this.ColorText.AutoSize = true;
            this.ColorText.Enabled = false;
            this.ColorText.ForeColor = System.Drawing.Color.White;
            this.ColorText.Location = new System.Drawing.Point(340, 195);
            this.ColorText.Name = "ColorText";
            this.ColorText.Size = new System.Drawing.Size(31, 13);
            this.ColorText.TabIndex = 52;
            this.ColorText.Text = "Color";
            // 
            // TypeText
            // 
            this.TypeText.AutoSize = true;
            this.TypeText.Enabled = false;
            this.TypeText.ForeColor = System.Drawing.Color.White;
            this.TypeText.Location = new System.Drawing.Point(234, 195);
            this.TypeText.Name = "TypeText";
            this.TypeText.Size = new System.Drawing.Size(31, 13);
            this.TypeText.TabIndex = 51;
            this.TypeText.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label2.Enabled = false;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Make";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CarData
            // 
            this.CarData.AutoGenerateColumns = false;
            this.CarData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleIDDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.makeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.typeOfVehicleDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.CarData.DataSource = this.carBindingSource;
            this.CarData.Location = new System.Drawing.Point(12, 239);
            this.CarData.Name = "CarData";
            this.CarData.ReadOnly = true;
            this.CarData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CarData.Size = new System.Drawing.Size(907, 368);
            this.CarData.TabIndex = 48;
            this.CarData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarData_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 213);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 47;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(237, 213);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(100, 20);
            this.typeBox.TabIndex = 46;
            this.typeBox.TextChanged += new System.EventHandler(this.typeBox_TextChanged_1);
            // 
            // availableCheckBox
            // 
            this.availableCheckBox.AutoSize = true;
            this.availableCheckBox.ForeColor = System.Drawing.Color.White;
            this.availableCheckBox.Location = new System.Drawing.Point(575, 217);
            this.availableCheckBox.Name = "availableCheckBox";
            this.availableCheckBox.Size = new System.Drawing.Size(93, 17);
            this.availableCheckBox.TabIndex = 45;
            this.availableCheckBox.Text = "Available Cars";
            this.availableCheckBox.UseVisualStyleBackColor = true;
            this.availableCheckBox.CheckedChanged += new System.EventHandler(this.availableCheckBox_CheckedChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_291CarRental.Properties.Resources.ildar_garifullin_KnDyg_Oiu_k_unsplash;
            this.pictureBox1.Location = new System.Drawing.Point(326, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(642, 154);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(674, 210);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(75, 23);
            this.filterButton.TabIndex = 43;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click_1);
            // 
            // carIDBox
            // 
            this.carIDBox.Location = new System.Drawing.Point(449, 214);
            this.carIDBox.Name = "carIDBox";
            this.carIDBox.Size = new System.Drawing.Size(120, 20);
            this.carIDBox.TabIndex = 42;
            this.carIDBox.TextChanged += new System.EventHandler(this.carIDBox_TextChanged_1);
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(343, 214);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(100, 20);
            this.colorBox.TabIndex = 41;
            this.colorBox.TextChanged += new System.EventHandler(this.colorBox_TextChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 213);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 20);
            this.textBox2.TabIndex = 40;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(546, 7);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(164, 22);
            this.textBox3.TabIndex = 39;
            this.textBox3.Text = "CAR SELECTION";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // _291GroupProjectDataSetCar
            // 
            this._291GroupProjectDataSetCar.DataSetName = "_291GroupProjectDataSetCar";
            this._291GroupProjectDataSetCar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupProjectDataSetCarBindingSource
            // 
            this.groupProjectDataSetCarBindingSource.DataSource = this._291GroupProjectDataSetCar;
            this.groupProjectDataSetCarBindingSource.Position = 0;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.groupProjectDataSetCarBindingSource;
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
            this.vehicleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // makeDataGridViewTextBoxColumn
            // 
            this.makeDataGridViewTextBoxColumn.DataPropertyName = "Make";
            this.makeDataGridViewTextBoxColumn.HeaderText = "Make";
            this.makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
            this.makeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeOfVehicleDataGridViewTextBoxColumn
            // 
            this.typeOfVehicleDataGridViewTextBoxColumn.DataPropertyName = "Type of Vehicle";
            this.typeOfVehicleDataGridViewTextBoxColumn.HeaderText = "Type of Vehicle";
            this.typeOfVehicleDataGridViewTextBoxColumn.Name = "typeOfVehicleDataGridViewTextBoxColumn";
            this.typeOfVehicleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(1156, 576);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(100, 31);
            this.confirmButton.TabIndex = 55;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click_1);
            // 
            // CarRentalPageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1268, 615);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.CarInfoBox);
            this.Controls.Add(this.CarIDText);
            this.Controls.Add(this.ColorText);
            this.Controls.Add(this.TypeText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CarData);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.availableCheckBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.carIDBox);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.ModelText);
            this.Controls.Add(this.MakeText);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.makeBox);
            this.Name = "CarRentalPageCustomer";
            this.Text = "CarRentalPageCustomer";
            this.Load += new System.EventHandler(this.CarRentalPageCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._291GroupProjectDataSetCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupProjectDataSetCarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ModelText;
        private System.Windows.Forms.Label MakeText;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.TextBox makeBox;
        private System.Windows.Forms.RichTextBox CarInfoBox;
        private System.Windows.Forms.Label CarIDText;
        private System.Windows.Forms.Label ColorText;
        private System.Windows.Forms.Label TypeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView CarData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.CheckBox availableCheckBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.TextBox carIDBox;
        private System.Windows.Forms.TextBox colorBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.BindingSource groupProjectDataSetCarBindingSource;
        private _291CarRental._291GroupProjectDataSetCar _291GroupProjectDataSetCar;
        private System.Windows.Forms.BindingSource carBindingSource;
        private _291CarRental._291GroupProjectDataSetCarTableAdapters.CarTableAdapter carTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfVehicleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button confirmButton;
    }
}