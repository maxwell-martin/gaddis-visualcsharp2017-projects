namespace PopulationInformation2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.populationDataSet = new PopulationInformation2.PopulationDataSet();
            this.city3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.city3TableAdapter = new PopulationInformation2.PopulationDataSetTableAdapters.City3TableAdapter();
            this.tableAdapterManager = new PopulationInformation2.PopulationDataSetTableAdapters.TableAdapterManager();
            this.city3BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.city3BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.city3DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sortAscPopulation = new System.Windows.Forms.Button();
            this.sortDescPopulation = new System.Windows.Forms.Button();
            this.sortNameButton = new System.Windows.Forms.Button();
            this.totalPopulationButton = new System.Windows.Forms.Button();
            this.avgPopulationButton = new System.Windows.Forms.Button();
            this.maxPopulationButton = new System.Windows.Forms.Button();
            this.minPopulationButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.populationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.city3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.city3BindingNavigator)).BeginInit();
            this.city3BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.city3DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // populationDataSet
            // 
            this.populationDataSet.DataSetName = "PopulationDataSet";
            this.populationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // city3BindingSource
            // 
            this.city3BindingSource.DataMember = "City3";
            this.city3BindingSource.DataSource = this.populationDataSet;
            // 
            // city3TableAdapter
            // 
            this.city3TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.City3TableAdapter = this.city3TableAdapter;
            this.tableAdapterManager.UpdateOrder = PopulationInformation2.PopulationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // city3BindingNavigator
            // 
            this.city3BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.city3BindingNavigator.BindingSource = this.city3BindingSource;
            this.city3BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.city3BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.city3BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.city3BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.city3BindingNavigatorSaveItem});
            this.city3BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.city3BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.city3BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.city3BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.city3BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.city3BindingNavigator.Name = "city3BindingNavigator";
            this.city3BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.city3BindingNavigator.Size = new System.Drawing.Size(1008, 27);
            this.city3BindingNavigator.TabIndex = 0;
            this.city3BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // city3BindingNavigatorSaveItem
            // 
            this.city3BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.city3BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("city3BindingNavigatorSaveItem.Image")));
            this.city3BindingNavigatorSaveItem.Name = "city3BindingNavigatorSaveItem";
            this.city3BindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.city3BindingNavigatorSaveItem.Text = "Save Data";
            this.city3BindingNavigatorSaveItem.Click += new System.EventHandler(this.city3BindingNavigatorSaveItem_Click);
            // 
            // city3DataGridView
            // 
            this.city3DataGridView.AutoGenerateColumns = false;
            this.city3DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.city3DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.city3DataGridView.DataSource = this.city3BindingSource;
            this.city3DataGridView.Location = new System.Drawing.Point(82, 56);
            this.city3DataGridView.Name = "city3DataGridView";
            this.city3DataGridView.RowTemplate.Height = 24;
            this.city3DataGridView.Size = new System.Drawing.Size(840, 221);
            this.city3DataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "City ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "City ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Population";
            this.dataGridViewTextBoxColumn3.HeaderText = "Population";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // sortAscPopulation
            // 
            this.sortAscPopulation.AutoSize = true;
            this.sortAscPopulation.Location = new System.Drawing.Point(127, 318);
            this.sortAscPopulation.Name = "sortAscPopulation";
            this.sortAscPopulation.Size = new System.Drawing.Size(81, 27);
            this.sortAscPopulation.TabIndex = 2;
            this.sortAscPopulation.Text = "Sort (Asc)";
            this.sortAscPopulation.UseVisualStyleBackColor = true;
            this.sortAscPopulation.Click += new System.EventHandler(this.sortAscPopulation_Click);
            // 
            // sortDescPopulation
            // 
            this.sortDescPopulation.AutoSize = true;
            this.sortDescPopulation.Location = new System.Drawing.Point(268, 318);
            this.sortDescPopulation.Name = "sortDescPopulation";
            this.sortDescPopulation.Size = new System.Drawing.Size(90, 27);
            this.sortDescPopulation.TabIndex = 3;
            this.sortDescPopulation.Text = "Sort (Desc)";
            this.sortDescPopulation.UseVisualStyleBackColor = true;
            this.sortDescPopulation.Click += new System.EventHandler(this.sortDescPopulation_Click);
            // 
            // sortNameButton
            // 
            this.sortNameButton.AutoSize = true;
            this.sortNameButton.Location = new System.Drawing.Point(414, 318);
            this.sortNameButton.Name = "sortNameButton";
            this.sortNameButton.Size = new System.Drawing.Size(104, 27);
            this.sortNameButton.TabIndex = 4;
            this.sortNameButton.Text = "Sort by Name";
            this.sortNameButton.UseVisualStyleBackColor = true;
            this.sortNameButton.Click += new System.EventHandler(this.sortNameButton_Click);
            // 
            // totalPopulationButton
            // 
            this.totalPopulationButton.AutoSize = true;
            this.totalPopulationButton.Location = new System.Drawing.Point(584, 318);
            this.totalPopulationButton.Name = "totalPopulationButton";
            this.totalPopulationButton.Size = new System.Drawing.Size(79, 27);
            this.totalPopulationButton.TabIndex = 5;
            this.totalPopulationButton.Text = "Total Pop";
            this.totalPopulationButton.UseVisualStyleBackColor = true;
            this.totalPopulationButton.Click += new System.EventHandler(this.totalPopulationButton_Click);
            // 
            // avgPopulationButton
            // 
            this.avgPopulationButton.AutoSize = true;
            this.avgPopulationButton.Location = new System.Drawing.Point(740, 318);
            this.avgPopulationButton.Name = "avgPopulationButton";
            this.avgPopulationButton.Size = new System.Drawing.Size(100, 27);
            this.avgPopulationButton.TabIndex = 6;
            this.avgPopulationButton.Text = "Average Pop";
            this.avgPopulationButton.UseVisualStyleBackColor = true;
            this.avgPopulationButton.Click += new System.EventHandler(this.avgPopulationButton_Click);
            // 
            // maxPopulationButton
            // 
            this.maxPopulationButton.AutoSize = true;
            this.maxPopulationButton.Location = new System.Drawing.Point(127, 379);
            this.maxPopulationButton.Name = "maxPopulationButton";
            this.maxPopulationButton.Size = new System.Drawing.Size(75, 27);
            this.maxPopulationButton.TabIndex = 7;
            this.maxPopulationButton.Text = "Max Pop";
            this.maxPopulationButton.UseVisualStyleBackColor = true;
            this.maxPopulationButton.Click += new System.EventHandler(this.maxPopulationButton_Click);
            // 
            // minPopulationButton
            // 
            this.minPopulationButton.AutoSize = true;
            this.minPopulationButton.Location = new System.Drawing.Point(268, 379);
            this.minPopulationButton.Name = "minPopulationButton";
            this.minPopulationButton.Size = new System.Drawing.Size(75, 27);
            this.minPopulationButton.TabIndex = 8;
            this.minPopulationButton.Text = "Min Pop";
            this.minPopulationButton.UseVisualStyleBackColor = true;
            this.minPopulationButton.Click += new System.EventHandler(this.minPopulationButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.AutoSize = true;
            this.resetButton.Location = new System.Drawing.Point(414, 381);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(122, 27);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset (Show All)";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 501);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.minPopulationButton);
            this.Controls.Add(this.maxPopulationButton);
            this.Controls.Add(this.avgPopulationButton);
            this.Controls.Add(this.totalPopulationButton);
            this.Controls.Add(this.sortNameButton);
            this.Controls.Add(this.sortDescPopulation);
            this.Controls.Add(this.sortAscPopulation);
            this.Controls.Add(this.city3DataGridView);
            this.Controls.Add(this.city3BindingNavigator);
            this.Name = "Form1";
            this.Text = "Population Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.populationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.city3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.city3BindingNavigator)).EndInit();
            this.city3BindingNavigator.ResumeLayout(false);
            this.city3BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.city3DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PopulationDataSet populationDataSet;
        private System.Windows.Forms.BindingSource city3BindingSource;
        private PopulationDataSetTableAdapters.City3TableAdapter city3TableAdapter;
        private PopulationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator city3BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton city3BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView city3DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button sortAscPopulation;
        private System.Windows.Forms.Button sortDescPopulation;
        private System.Windows.Forms.Button sortNameButton;
        private System.Windows.Forms.Button totalPopulationButton;
        private System.Windows.Forms.Button avgPopulationButton;
        private System.Windows.Forms.Button maxPopulationButton;
        private System.Windows.Forms.Button minPopulationButton;
        private System.Windows.Forms.Button resetButton;
    }
}

