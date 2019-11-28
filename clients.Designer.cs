namespace WindowsFormsApp2
{
    partial class clients
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
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label townLabel;
            System.Windows.Forms.Label streetLabel;
            System.Windows.Forms.Label houseLabel;
            System.Windows.Forms.Label localLabel;
            System.Windows.Forms.Label postcodeLabel;
            System.Windows.Forms.Label tUser_mailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clients));
            this.final1DataSet6 = new WindowsFormsApp2.final1DataSet6();
            this.tAddressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAddressTableAdapter = new WindowsFormsApp2.final1DataSet6TableAdapters.TAddressTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.final1DataSet6TableAdapters.TableAdapterManager();
            this.tAddressBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tAddressBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tAddressDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.townTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.houseTextBox = new System.Windows.Forms.TextBox();
            this.localTextBox = new System.Windows.Forms.TextBox();
            this.postcodeTextBox = new System.Windows.Forms.TextBox();
            this.tUser_mailTextBox = new System.Windows.Forms.TextBox();
            countryLabel = new System.Windows.Forms.Label();
            townLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            houseLabel = new System.Windows.Forms.Label();
            localLabel = new System.Windows.Forms.Label();
            postcodeLabel = new System.Windows.Forms.Label();
            tUser_mailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.final1DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAddressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAddressBindingNavigator)).BeginInit();
            this.tAddressBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAddressDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(15, 80);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(46, 13);
            countryLabel.TabIndex = 17;
            countryLabel.Text = "Country:";
            // 
            // townLabel
            // 
            townLabel.AutoSize = true;
            townLabel.Location = new System.Drawing.Point(15, 111);
            townLabel.Name = "townLabel";
            townLabel.Size = new System.Drawing.Size(27, 13);
            townLabel.TabIndex = 18;
            townLabel.Text = "City:";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new System.Drawing.Point(15, 145);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(38, 13);
            streetLabel.TabIndex = 19;
            streetLabel.Text = "Street:";
            // 
            // houseLabel
            // 
            houseLabel.AutoSize = true;
            houseLabel.Location = new System.Drawing.Point(15, 181);
            houseLabel.Name = "houseLabel";
            houseLabel.Size = new System.Drawing.Size(41, 13);
            houseLabel.TabIndex = 20;
            houseLabel.Text = "House:";
            // 
            // localLabel
            // 
            localLabel.AutoSize = true;
            localLabel.Location = new System.Drawing.Point(15, 215);
            localLabel.Name = "localLabel";
            localLabel.Size = new System.Drawing.Size(36, 13);
            localLabel.TabIndex = 21;
            localLabel.Text = "Local:";
            // 
            // postcodeLabel
            // 
            postcodeLabel.AutoSize = true;
            postcodeLabel.Location = new System.Drawing.Point(15, 251);
            postcodeLabel.Name = "postcodeLabel";
            postcodeLabel.Size = new System.Drawing.Size(55, 13);
            postcodeLabel.TabIndex = 22;
            postcodeLabel.Text = "Postcode:";
            // 
            // tUser_mailLabel
            // 
            tUser_mailLabel.AutoSize = true;
            tUser_mailLabel.Location = new System.Drawing.Point(16, 41);
            tUser_mailLabel.Name = "tUser_mailLabel";
            tUser_mailLabel.Size = new System.Drawing.Size(59, 13);
            tUser_mailLabel.TabIndex = 23;
            tUser_mailLabel.Text = "User email:";
            // 
            // final1DataSet6
            // 
            this.final1DataSet6.DataSetName = "final1DataSet6";
            this.final1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAddressBindingSource
            // 
            this.tAddressBindingSource.DataMember = "TAddress";
            this.tAddressBindingSource.DataSource = this.final1DataSet6;
            // 
            // tAddressTableAdapter
            // 
            this.tAddressTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TAddressTableAdapter = this.tAddressTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.final1DataSet6TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tAddressBindingNavigator
            // 
            this.tAddressBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tAddressBindingNavigator.BindingSource = this.tAddressBindingSource;
            this.tAddressBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tAddressBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tAddressBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tAddressBindingNavigatorSaveItem});
            this.tAddressBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tAddressBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tAddressBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tAddressBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tAddressBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tAddressBindingNavigator.Name = "tAddressBindingNavigator";
            this.tAddressBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tAddressBindingNavigator.Size = new System.Drawing.Size(808, 25);
            this.tAddressBindingNavigator.TabIndex = 0;
            this.tAddressBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tAddressBindingNavigatorSaveItem
            // 
            this.tAddressBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tAddressBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tAddressBindingNavigatorSaveItem.Image")));
            this.tAddressBindingNavigatorSaveItem.Name = "tAddressBindingNavigatorSaveItem";
            this.tAddressBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tAddressBindingNavigatorSaveItem.Text = "Save Data";
            this.tAddressBindingNavigatorSaveItem.Click += new System.EventHandler(this.tAddressBindingNavigatorSaveItem_Click);
            // 
            // tAddressDataGridView
            // 
            this.tAddressDataGridView.AutoGenerateColumns = false;
            this.tAddressDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAddressDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.tAddressDataGridView.DataSource = this.tAddressBindingSource;
            this.tAddressDataGridView.Location = new System.Drawing.Point(294, 28);
            this.tAddressDataGridView.Name = "tAddressDataGridView";
            this.tAddressDataGridView.Size = new System.Drawing.Size(494, 303);
            this.tAddressDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idAddress";
            this.dataGridViewTextBoxColumn1.HeaderText = "idAddress";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TUser_mail";
            this.dataGridViewTextBoxColumn2.HeaderText = "TUser_mail";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "country";
            this.dataGridViewTextBoxColumn3.HeaderText = "country";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "town";
            this.dataGridViewTextBoxColumn4.HeaderText = "town";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "street";
            this.dataGridViewTextBoxColumn5.HeaderText = "street";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "house";
            this.dataGridViewTextBoxColumn6.HeaderText = "house";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "local";
            this.dataGridViewTextBoxColumn7.HeaderText = "local";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "postcode";
            this.dataGridViewTextBoxColumn8.HeaderText = "postcode";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(196, 310);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Previous";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(103, 310);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Next";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 310);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(196, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAddressBindingSource, "country", true));
            this.countryTextBox.Location = new System.Drawing.Point(82, 73);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(186, 20);
            this.countryTextBox.TabIndex = 18;
            // 
            // townTextBox
            // 
            this.townTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAddressBindingSource, "town", true));
            this.townTextBox.Location = new System.Drawing.Point(82, 104);
            this.townTextBox.Name = "townTextBox";
            this.townTextBox.Size = new System.Drawing.Size(186, 20);
            this.townTextBox.TabIndex = 19;
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAddressBindingSource, "street", true));
            this.streetTextBox.Location = new System.Drawing.Point(82, 138);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(186, 20);
            this.streetTextBox.TabIndex = 20;
            // 
            // houseTextBox
            // 
            this.houseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAddressBindingSource, "house", true));
            this.houseTextBox.Location = new System.Drawing.Point(82, 174);
            this.houseTextBox.Name = "houseTextBox";
            this.houseTextBox.Size = new System.Drawing.Size(186, 20);
            this.houseTextBox.TabIndex = 21;
            // 
            // localTextBox
            // 
            this.localTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAddressBindingSource, "local", true));
            this.localTextBox.Location = new System.Drawing.Point(82, 208);
            this.localTextBox.Name = "localTextBox";
            this.localTextBox.Size = new System.Drawing.Size(186, 20);
            this.localTextBox.TabIndex = 22;
            // 
            // postcodeTextBox
            // 
            this.postcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAddressBindingSource, "postcode", true));
            this.postcodeTextBox.Location = new System.Drawing.Point(82, 244);
            this.postcodeTextBox.Name = "postcodeTextBox";
            this.postcodeTextBox.Size = new System.Drawing.Size(186, 20);
            this.postcodeTextBox.TabIndex = 23;
            // 
            // tUser_mailTextBox
            // 
            this.tUser_mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAddressBindingSource, "TUser_mail", true));
            this.tUser_mailTextBox.Location = new System.Drawing.Point(82, 38);
            this.tUser_mailTextBox.Name = "tUser_mailTextBox";
            this.tUser_mailTextBox.Size = new System.Drawing.Size(186, 20);
            this.tUser_mailTextBox.TabIndex = 24;
            // 
            // clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 343);
            this.Controls.Add(tUser_mailLabel);
            this.Controls.Add(this.tUser_mailTextBox);
            this.Controls.Add(postcodeLabel);
            this.Controls.Add(this.postcodeTextBox);
            this.Controls.Add(localLabel);
            this.Controls.Add(this.localTextBox);
            this.Controls.Add(houseLabel);
            this.Controls.Add(this.houseTextBox);
            this.Controls.Add(streetLabel);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(townLabel);
            this.Controls.Add(this.townTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tAddressDataGridView);
            this.Controls.Add(this.tAddressBindingNavigator);
            this.Name = "clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "clients";
            this.Load += new System.EventHandler(this.clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.final1DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAddressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAddressBindingNavigator)).EndInit();
            this.tAddressBindingNavigator.ResumeLayout(false);
            this.tAddressBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAddressDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private final1DataSet6 final1DataSet6;
        private System.Windows.Forms.BindingSource tAddressBindingSource;
        private final1DataSet6TableAdapters.TAddressTableAdapter tAddressTableAdapter;
        private final1DataSet6TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tAddressBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tAddressBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tAddressDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox townTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox houseTextBox;
        private System.Windows.Forms.TextBox localTextBox;
        private System.Windows.Forms.TextBox postcodeTextBox;
        private System.Windows.Forms.TextBox tUser_mailTextBox;
    }
}