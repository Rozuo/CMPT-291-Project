namespace SQLTest
{
    partial class Client
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.topText = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.clientTabs = new System.Windows.Forms.TabControl();
            this.viewClientTab = new System.Windows.Forms.TabPage();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._291GroupProjectDataSet = new SQLTest._291GroupProjectDataSet();
            this.registerTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.clientTableAdapter = new SQLTest._291GroupProjectDataSetTableAdapters.ClientTableAdapter();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditCardNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalYearRentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.topPanel.SuspendLayout();
            this.clientTabs.SuspendLayout();
            this.viewClientTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._291GroupProjectDataSet)).BeginInit();
            this.registerTab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Olive;
            this.topPanel.Controls.Add(this.exitButton);
            this.topPanel.Controls.Add(this.topText);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1456, 68);
            this.topPanel.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Brown;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(1222, 6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(222, 59);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // topText
            // 
            this.topText.AutoSize = true;
            this.topText.Dock = System.Windows.Forms.DockStyle.Top;
            this.topText.Font = new System.Drawing.Font("Century Schoolbook", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topText.Location = new System.Drawing.Point(0, 0);
            this.topText.Name = "topText";
            this.topText.Size = new System.Drawing.Size(254, 40);
            this.topText.TabIndex = 0;
            this.topText.Text = "Client Status";
            // 
            // searchPanel
            // 
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchPanel.Location = new System.Drawing.Point(0, 578);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1456, 105);
            this.searchPanel.TabIndex = 2;
            // 
            // clientTabs
            // 
            this.clientTabs.Controls.Add(this.viewClientTab);
            this.clientTabs.Controls.Add(this.registerTab);
            this.clientTabs.Location = new System.Drawing.Point(0, 74);
            this.clientTabs.Name = "clientTabs";
            this.clientTabs.SelectedIndex = 0;
            this.clientTabs.Size = new System.Drawing.Size(1456, 498);
            this.clientTabs.TabIndex = 3;
            // 
            // viewClientTab
            // 
            this.viewClientTab.BackColor = System.Drawing.Color.Gray;
            this.viewClientTab.Controls.Add(this.dataGridView1);
            this.viewClientTab.Location = new System.Drawing.Point(4, 22);
            this.viewClientTab.Name = "viewClientTab";
            this.viewClientTab.Padding = new System.Windows.Forms.Padding(3);
            this.viewClientTab.Size = new System.Drawing.Size(1448, 472);
            this.viewClientTab.TabIndex = 0;
            this.viewClientTab.Text = "View Client";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this._291GroupProjectDataSet;
            // 
            // _291GroupProjectDataSet
            // 
            this._291GroupProjectDataSet.DataSetName = "_291GroupProjectDataSet";
            this._291GroupProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registerTab
            // 
            this.registerTab.BackColor = System.Drawing.Color.Tan;
            this.registerTab.Controls.Add(this.label2);
            this.registerTab.Controls.Add(this.panel1);
            this.registerTab.Location = new System.Drawing.Point(4, 22);
            this.registerTab.Name = "registerTab";
            this.registerTab.Padding = new System.Windows.Forms.Padding(3);
            this.registerTab.Size = new System.Drawing.Size(1448, 472);
            this.registerTab.TabIndex = 1;
            this.registerTab.Text = "Register Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1442, 49);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(550, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Client";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // creditCardNumDataGridViewTextBoxColumn
            // 
            this.creditCardNumDataGridViewTextBoxColumn.DataPropertyName = "CreditCardNum";
            this.creditCardNumDataGridViewTextBoxColumn.HeaderText = "CreditCardNum";
            this.creditCardNumDataGridViewTextBoxColumn.Name = "creditCardNumDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // totalYearRentDataGridViewTextBoxColumn
            // 
            this.totalYearRentDataGridViewTextBoxColumn.DataPropertyName = "Total Year Rent";
            this.totalYearRentDataGridViewTextBoxColumn.HeaderText = "Total Year Rent";
            this.totalYearRentDataGridViewTextBoxColumn.Name = "totalYearRentDataGridViewTextBoxColumn";
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.totalYearRentDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.creditCardNumDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1442, 466);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1456, 683);
            this.Controls.Add(this.clientTabs);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.clientTabs.ResumeLayout(false);
            this.viewClientTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._291GroupProjectDataSet)).EndInit();
            this.registerTab.ResumeLayout(false);
            this.registerTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label topText;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TabControl clientTabs;
        private System.Windows.Forms.TabPage viewClientTab;
        private System.Windows.Forms.TabPage registerTab;
        private _291GroupProjectDataSet _291GroupProjectDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private _291GroupProjectDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalYearRentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditCardNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
    }
}