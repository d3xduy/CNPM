namespace WindowsFormsApp2
{
    partial class order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(order));
            System.Windows.Forms.Label tUser_mailLabel;
            System.Windows.Forms.Label tAddress_idAddressLabel;
            System.Windows.Forms.Label tStatus_idStatusLabel;
            System.Windows.Forms.Label dateLabel;
            this.final1DataSet9 = new WindowsFormsApp2.final1DataSet9();
            this.tOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tOrderTableAdapter = new WindowsFormsApp2.final1DataSet9TableAdapters.TOrderTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.final1DataSet9TableAdapters.TableAdapterManager();
            this.tOrderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.tOrderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tUser_mailTextBox = new System.Windows.Forms.TextBox();
            this.tAddress_idAddressTextBox = new System.Windows.Forms.TextBox();
            this.tStatus_idStatusTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            tUser_mailLabel = new System.Windows.Forms.Label();
            tAddress_idAddressLabel = new System.Windows.Forms.Label();
            tStatus_idStatusLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.final1DataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOrderBindingNavigator)).BeginInit();
            this.tOrderBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tOrderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // final1DataSet9
            // 
            this.final1DataSet9.DataSetName = "final1DataSet9";
            this.final1DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tOrderBindingSource
            // 
            this.tOrderBindingSource.DataMember = "TOrder";
            this.tOrderBindingSource.DataSource = this.final1DataSet9;
            // 
            // tOrderTableAdapter
            // 
            this.tOrderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TOrderTableAdapter = this.tOrderTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.final1DataSet9TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tOrderBindingNavigator
            // 
            this.tOrderBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tOrderBindingNavigator.BindingSource = this.tOrderBindingSource;
            this.tOrderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tOrderBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tOrderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tOrderBindingNavigatorSaveItem});
            this.tOrderBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tOrderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tOrderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tOrderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tOrderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tOrderBindingNavigator.Name = "tOrderBindingNavigator";
            this.tOrderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tOrderBindingNavigator.Size = new System.Drawing.Size(891, 25);
            this.tOrderBindingNavigator.TabIndex = 0;
            this.tOrderBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tOrderDataGridView
            // 
            this.tOrderDataGridView.AutoGenerateColumns = false;
            this.tOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tOrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tOrderDataGridView.DataSource = this.tOrderBindingSource;
            this.tOrderDataGridView.Location = new System.Drawing.Point(325, 28);
            this.tOrderDataGridView.Name = "tOrderDataGridView";
            this.tOrderDataGridView.Size = new System.Drawing.Size(546, 220);
            this.tOrderDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idOrder";
            this.dataGridViewTextBoxColumn1.HeaderText = "idOrder";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TAddress_idAddress";
            this.dataGridViewTextBoxColumn3.HeaderText = "TAddress_idAddress";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TStatus_idStatus";
            this.dataGridViewTextBoxColumn4.HeaderText = "TStatus_idStatus";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn5.HeaderText = "date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
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
            // tOrderBindingNavigatorSaveItem
            // 
            this.tOrderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tOrderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tOrderBindingNavigatorSaveItem.Image")));
            this.tOrderBindingNavigatorSaveItem.Name = "tOrderBindingNavigatorSaveItem";
            this.tOrderBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tOrderBindingNavigatorSaveItem.Text = "Save Data";
            this.tOrderBindingNavigatorSaveItem.Click += new System.EventHandler(this.tOrderBindingNavigatorSaveItem_Click);
            // 
            // tUser_mailLabel
            // 
            tUser_mailLabel.AutoSize = true;
            tUser_mailLabel.Location = new System.Drawing.Point(12, 51);
            tUser_mailLabel.Name = "tUser_mailLabel";
            tUser_mailLabel.Size = new System.Drawing.Size(60, 13);
            tUser_mailLabel.TabIndex = 2;
            tUser_mailLabel.Text = "TUser mail:";
            // 
            // tUser_mailTextBox
            // 
            this.tUser_mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOrderBindingSource, "TUser_mail", true));
            this.tUser_mailTextBox.Location = new System.Drawing.Point(125, 51);
            this.tUser_mailTextBox.Name = "tUser_mailTextBox";
            this.tUser_mailTextBox.Size = new System.Drawing.Size(100, 20);
            this.tUser_mailTextBox.TabIndex = 3;
            // 
            // tAddress_idAddressLabel
            // 
            tAddress_idAddressLabel.AutoSize = true;
            tAddress_idAddressLabel.Location = new System.Drawing.Point(12, 85);
            tAddress_idAddressLabel.Name = "tAddress_idAddressLabel";
            tAddress_idAddressLabel.Size = new System.Drawing.Size(107, 13);
            tAddress_idAddressLabel.TabIndex = 4;
            tAddress_idAddressLabel.Text = "TAddress id Address:";
            // 
            // tAddress_idAddressTextBox
            // 
            this.tAddress_idAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOrderBindingSource, "TAddress_idAddress", true));
            this.tAddress_idAddressTextBox.Location = new System.Drawing.Point(125, 82);
            this.tAddress_idAddressTextBox.Name = "tAddress_idAddressTextBox";
            this.tAddress_idAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.tAddress_idAddressTextBox.TabIndex = 5;
            // 
            // tStatus_idStatusLabel
            // 
            tStatus_idStatusLabel.AutoSize = true;
            tStatus_idStatusLabel.Location = new System.Drawing.Point(12, 116);
            tStatus_idStatusLabel.Name = "tStatus_idStatusLabel";
            tStatus_idStatusLabel.Size = new System.Drawing.Size(91, 13);
            tStatus_idStatusLabel.TabIndex = 6;
            tStatus_idStatusLabel.Text = "TStatus id Status:";
            // 
            // tStatus_idStatusTextBox
            // 
            this.tStatus_idStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tOrderBindingSource, "TStatus_idStatus", true));
            this.tStatus_idStatusTextBox.Location = new System.Drawing.Point(125, 116);
            this.tStatus_idStatusTextBox.Name = "tStatus_idStatusTextBox";
            this.tStatus_idStatusTextBox.Size = new System.Drawing.Size(100, 20);
            this.tStatus_idStatusTextBox.TabIndex = 7;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(12, 147);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(31, 13);
            dateLabel.TabIndex = 8;
            dateLabel.Text = "date:";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tOrderBindingSource, "date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(65, 147);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(212, 224);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 35;
            this.button4.Text = "Previous";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(119, 224);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 34;
            this.button5.Text = "Next";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(28, 224);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 33;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(212, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(119, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(tStatus_idStatusLabel);
            this.Controls.Add(this.tStatus_idStatusTextBox);
            this.Controls.Add(tAddress_idAddressLabel);
            this.Controls.Add(this.tAddress_idAddressTextBox);
            this.Controls.Add(tUser_mailLabel);
            this.Controls.Add(this.tUser_mailTextBox);
            this.Controls.Add(this.tOrderDataGridView);
            this.Controls.Add(this.tOrderBindingNavigator);
            this.Name = "order";
            this.Text = "order";
            this.Load += new System.EventHandler(this.order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.final1DataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOrderBindingNavigator)).EndInit();
            this.tOrderBindingNavigator.ResumeLayout(false);
            this.tOrderBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tOrderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private final1DataSet9 final1DataSet9;
        private System.Windows.Forms.BindingSource tOrderBindingSource;
        private final1DataSet9TableAdapters.TOrderTableAdapter tOrderTableAdapter;
        private final1DataSet9TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tOrderBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tOrderBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tOrderDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox tUser_mailTextBox;
        private System.Windows.Forms.TextBox tAddress_idAddressTextBox;
        private System.Windows.Forms.TextBox tStatus_idStatusTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}