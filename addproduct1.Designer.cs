namespace WindowsFormsApp2
{
    partial class addproduct1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addproduct1));
            this.label6 = new System.Windows.Forms.Label();
            this.final1DataSet11 = new WindowsFormsApp2.final1DataSet11();
            this.tProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tProductTableAdapter = new WindowsFormsApp2.final1DataSet11TableAdapters.TProductTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.final1DataSet11TableAdapters.TableAdapterManager();
            this.tCategoryTableAdapter = new WindowsFormsApp2.final1DataSet11TableAdapters.TCategoryTableAdapter();
            this.tProductBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tProductBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tProductDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tProducentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tProducentTableAdapter = new WindowsFormsApp2.final1DataSet11TableAdapters.TProducentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.final1DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProductBindingNavigator)).BeginInit();
            this.tProductBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tProductDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProducentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(11, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(974, 56);
            this.label6.TabIndex = 15;
            this.label6.Text = "Product Management";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // final1DataSet11
            // 
            this.final1DataSet11.DataSetName = "final1DataSet11";
            this.final1DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tProductBindingSource
            // 
            this.tProductBindingSource.DataMember = "TProduct";
            this.tProductBindingSource.DataSource = this.final1DataSet11;
            // 
            // tProductTableAdapter
            // 
            this.tProductTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TCategoryTableAdapter = this.tCategoryTableAdapter;
            this.tableAdapterManager.TProducentTableAdapter = null;
            this.tableAdapterManager.TProductTableAdapter = this.tProductTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.final1DataSet11TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tCategoryTableAdapter
            // 
            this.tCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // tProductBindingNavigator
            // 
            this.tProductBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tProductBindingNavigator.BindingSource = this.tProductBindingSource;
            this.tProductBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tProductBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tProductBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tProductBindingNavigatorSaveItem});
            this.tProductBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tProductBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tProductBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tProductBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tProductBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tProductBindingNavigator.Name = "tProductBindingNavigator";
            this.tProductBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tProductBindingNavigator.Size = new System.Drawing.Size(1005, 25);
            this.tProductBindingNavigator.TabIndex = 16;
            this.tProductBindingNavigator.Text = "bindingNavigator1";
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
            // tProductBindingNavigatorSaveItem
            // 
            this.tProductBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tProductBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tProductBindingNavigatorSaveItem.Image")));
            this.tProductBindingNavigatorSaveItem.Name = "tProductBindingNavigatorSaveItem";
            this.tProductBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tProductBindingNavigatorSaveItem.Text = "Save Data";
            this.tProductBindingNavigatorSaveItem.Click += new System.EventHandler(this.tProductBindingNavigatorSaveItem_Click);
            // 
            // tProductDataGridView
            // 
            this.tProductDataGridView.AutoGenerateColumns = false;
            this.tProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tProductDataGridView.DataSource = this.tProductBindingSource;
            this.tProductDataGridView.Location = new System.Drawing.Point(334, 84);
            this.tProductDataGridView.Name = "tProductDataGridView";
            this.tProductDataGridView.Size = new System.Drawing.Size(651, 257);
            this.tProductDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idProduct";
            this.dataGridViewTextBoxColumn1.HeaderText = "idProduct";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TCategory_idCategory";
            this.dataGridViewTextBoxColumn2.HeaderText = "TCategory_idCategory";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TProducent_idProducent";
            this.dataGridViewTextBoxColumn3.HeaderText = "TProducent_idProducent";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn4.HeaderText = "price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn5.HeaderText = "name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn6.HeaderText = "description";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(231, 193);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 65);
            this.button4.TabIndex = 41;
            this.button4.Text = "Previous";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(118, 193);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 65);
            this.button5.TabIndex = 40;
            this.button5.Text = "Next";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(0, 193);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(97, 65);
            this.button6.TabIndex = 39;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(231, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 65);
            this.button3.TabIndex = 38;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 65);
            this.button2.TabIndex = 37;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 65);
            this.button1.TabIndex = 36;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tCategoryBindingSource
            // 
            this.tCategoryBindingSource.DataMember = "TCategory";
            this.tCategoryBindingSource.DataSource = this.final1DataSet11;
            // 
            // tProducentBindingSource
            // 
            this.tProducentBindingSource.DataMember = "TProducent";
            this.tProducentBindingSource.DataSource = this.final1DataSet11;
            // 
            // tProducentTableAdapter
            // 
            this.tProducentTableAdapter.ClearBeforeFill = true;
            // 
            // addproduct1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 353);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tProductDataGridView);
            this.Controls.Add(this.tProductBindingNavigator);
            this.Controls.Add(this.label6);
            this.Name = "addproduct1";
            this.Text = "addproduct1";
            this.Load += new System.EventHandler(this.addproduct1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.final1DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProductBindingNavigator)).EndInit();
            this.tProductBindingNavigator.ResumeLayout(false);
            this.tProductBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tProductDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProducentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private final1DataSet11 final1DataSet11;
        private System.Windows.Forms.BindingSource tProductBindingSource;
        private final1DataSet11TableAdapters.TProductTableAdapter tProductTableAdapter;
        private final1DataSet11TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tProductBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tProductBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tProductDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private final1DataSet11TableAdapters.TCategoryTableAdapter tCategoryTableAdapter;
        private System.Windows.Forms.BindingSource tCategoryBindingSource;
        private System.Windows.Forms.BindingSource tProducentBindingSource;
        private final1DataSet11TableAdapters.TProducentTableAdapter tProducentTableAdapter;
    }
}