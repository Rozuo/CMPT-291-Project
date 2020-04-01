namespace Car_Renting_Software
{
    partial class Form4
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.makeBox = new System.Windows.Forms.TextBox();
            this.colorBox = new System.Windows.Forms.TextBox();
            this.carIDBox = new System.Windows.Forms.TextBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.availableCheckBox = new System.Windows.Forms.CheckBox();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.CarData = new System.Windows.Forms.DataGridView();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfVehicleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._291GroupProjectDataSetCar = new _291CarRental._291GroupProjectDataSetCar();
            this.carTableAdapter = new _291CarRental._291GroupProjectDataSetCarTableAdapters.CarTableAdapter();
            this.MakeText = new System.Windows.Forms.Label();
            this.ModelText = new System.Windows.Forms.Label();
            this.TypeText = new System.Windows.Forms.Label();
            this.ColorText = new System.Windows.Forms.Label();
            this.CarIDText = new System.Windows.Forms.Label();
            this.CarInfoBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._291GroupProjectDataSetCar)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(546, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(164, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "CAR SELECTION";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(1156, 572);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(100, 31);
            this.confirmButton.TabIndex = 2;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(922, 235);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 368);
            this.vScrollBar1.TabIndex = 3;
            // 
            // makeBox
            // 
            this.makeBox.Location = new System.Drawing.Point(12, 209);
            this.makeBox.Name = "makeBox";
            this.makeBox.Size = new System.Drawing.Size(113, 20);
            this.makeBox.TabIndex = 5;
            this.makeBox.TextChanged += new System.EventHandler(this.makeBox_TextChanged);
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(343, 210);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(100, 20);
            this.colorBox.TabIndex = 7;
            this.colorBox.TextChanged += new System.EventHandler(this.colorBox_TextChanged);
            // 
            // carIDBox
            // 
            this.carIDBox.Location = new System.Drawing.Point(449, 210);
            this.carIDBox.Name = "carIDBox";
            this.carIDBox.Size = new System.Drawing.Size(120, 20);
            this.carIDBox.TabIndex = 9;
            this.carIDBox.TextChanged += new System.EventHandler(this.carIDBox_TextChanged);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(674, 206);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(75, 23);
            this.filterButton.TabIndex = 12;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_291CarRental.Properties.Resources.ildar_garifullin_KnDyg_Oiu_k_unsplash;
            this.pictureBox1.Location = new System.Drawing.Point(326, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(642, 154);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // availableCheckBox
            // 
            this.availableCheckBox.AutoSize = true;
            this.availableCheckBox.Location = new System.Drawing.Point(575, 213);
            this.availableCheckBox.Name = "availableCheckBox";
            this.availableCheckBox.Size = new System.Drawing.Size(93, 17);
            this.availableCheckBox.TabIndex = 15;
            this.availableCheckBox.Text = "Available Cars";
            this.availableCheckBox.UseVisualStyleBackColor = true;
            this.availableCheckBox.CheckedChanged += new System.EventHandler(this.availableCheckBox_CheckedChanged);
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(237, 209);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(100, 20);
            this.typeBox.TabIndex = 18;
            this.typeBox.TextChanged += new System.EventHandler(this.typeBox_TextChanged);
            // 
            // modelBox
            // 
            this.modelBox.Location = new System.Drawing.Point(131, 209);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(100, 20);
            this.modelBox.TabIndex = 19;
            this.modelBox.TextChanged += new System.EventHandler(this.modelBox_TextChanged);
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
            this.CarData.Location = new System.Drawing.Point(12, 235);
            this.CarData.Name = "CarData";
            this.CarData.ReadOnly = true;
            this.CarData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CarData.Size = new System.Drawing.Size(907, 368);
            this.CarData.TabIndex = 20;
            this.CarData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarData_CellContentClick_2);
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
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this._291GroupProjectDataSetCar;
            // 
            // _291GroupProjectDataSetCar
            // 
            this._291GroupProjectDataSetCar.DataSetName = "_291GroupProjectDataSetCar";
            this._291GroupProjectDataSetCar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // MakeText
            // 
            this.MakeText.AutoSize = true;
            this.MakeText.Enabled = false;
            this.MakeText.Location = new System.Drawing.Point(12, 191);
            this.MakeText.Name = "MakeText";
            this.MakeText.Size = new System.Drawing.Size(34, 13);
            this.MakeText.TabIndex = 21;
            this.MakeText.Text = "Make";
            // 
            // ModelText
            // 
            this.ModelText.AutoSize = true;
            this.ModelText.Enabled = false;
            this.ModelText.Location = new System.Drawing.Point(128, 191);
            this.ModelText.Name = "ModelText";
            this.ModelText.Size = new System.Drawing.Size(36, 13);
            this.ModelText.TabIndex = 22;
            this.ModelText.Text = "Model";
            // 
            // TypeText
            // 
            this.TypeText.AutoSize = true;
            this.TypeText.Enabled = false;
            this.TypeText.Location = new System.Drawing.Point(234, 191);
            this.TypeText.Name = "TypeText";
            this.TypeText.Size = new System.Drawing.Size(31, 13);
            this.TypeText.TabIndex = 23;
            this.TypeText.Text = "Type";
            this.TypeText.Click += new System.EventHandler(this.TypeText_Click);
            // 
            // ColorText
            // 
            this.ColorText.AutoSize = true;
            this.ColorText.Enabled = false;
            this.ColorText.Location = new System.Drawing.Point(340, 191);
            this.ColorText.Name = "ColorText";
            this.ColorText.Size = new System.Drawing.Size(31, 13);
            this.ColorText.TabIndex = 24;
            this.ColorText.Text = "Color";
            // 
            // CarIDText
            // 
            this.CarIDText.AutoSize = true;
            this.CarIDText.Enabled = false;
            this.CarIDText.Location = new System.Drawing.Point(446, 191);
            this.CarIDText.Name = "CarIDText";
            this.CarIDText.Size = new System.Drawing.Size(44, 13);
            this.CarIDText.TabIndex = 25;
            this.CarIDText.Text = "Car ID#";
            // 
            // CarInfoBox
            // 
            this.CarInfoBox.Location = new System.Drawing.Point(942, 235);
            this.CarInfoBox.Name = "CarInfoBox";
            this.CarInfoBox.ReadOnly = true;
            this.CarInfoBox.Size = new System.Drawing.Size(314, 331);
            this.CarInfoBox.TabIndex = 26;
            this.CarInfoBox.Text = "";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 615);
            this.Controls.Add(this.CarInfoBox);
            this.Controls.Add(this.CarIDText);
            this.Controls.Add(this.ColorText);
            this.Controls.Add(this.TypeText);
            this.Controls.Add(this.ModelText);
            this.Controls.Add(this.MakeText);
            this.Controls.Add(this.CarData);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.availableCheckBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.carIDBox);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.makeBox);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.textBox1);
            this.Name = "Form4";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._291GroupProjectDataSetCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.TextBox makeBox;
        private System.Windows.Forms.TextBox colorBox;
        private System.Windows.Forms.TextBox carIDBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox availableCheckBox;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.DataGridView CarData;
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
        private System.Windows.Forms.Label MakeText;
        private System.Windows.Forms.Label ModelText;
        private System.Windows.Forms.Label TypeText;
        private System.Windows.Forms.Label ColorText;
        private System.Windows.Forms.Label CarIDText;
        private System.Windows.Forms.RichTextBox CarInfoBox;
    }
}

