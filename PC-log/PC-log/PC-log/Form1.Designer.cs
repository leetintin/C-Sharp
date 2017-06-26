namespace PC_log
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iPLabel;
            System.Windows.Forms.Label pCLabel;
            System.Windows.Forms.Label logLabel;
            System.Windows.Forms.Label adminLabel;
            System.Windows.Forms.Label timeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label iDLabel;
            this.database2DataSet1 = new PC_log.Database2DataSet1();
            this.pClogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pClogTableAdapter = new PC_log.Database2DataSet1TableAdapters.PClogTableAdapter();
            this.tableAdapterManager = new PC_log.Database2DataSet1TableAdapters.TableAdapterManager();
            this.pClogBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pClogBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iPTextBox = new System.Windows.Forms.TextBox();
            this.pCTextBox = new System.Windows.Forms.TextBox();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.adminTextBox = new System.Windows.Forms.TextBox();
            this.timeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.database2DataSet2 = new PC_log.Database2DataSet2();
            this.pClogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pClogTableAdapter1 = new PC_log.Database2DataSet2TableAdapters.PClogTableAdapter();
            this.tableAdapterManager1 = new PC_log.Database2DataSet2TableAdapters.TableAdapterManager();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            iPLabel = new System.Windows.Forms.Label();
            pCLabel = new System.Windows.Forms.Label();
            logLabel = new System.Windows.Forms.Label();
            adminLabel = new System.Windows.Forms.Label();
            timeLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pClogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pClogBindingNavigator)).BeginInit();
            this.pClogBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pClogBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // iPLabel
            // 
            iPLabel.AutoSize = true;
            iPLabel.Location = new System.Drawing.Point(11, 43);
            iPLabel.Name = "iPLabel";
            iPLabel.Size = new System.Drawing.Size(23, 12);
            iPLabel.TabIndex = 1;
            iPLabel.Text = "IP:";
            // 
            // pCLabel
            // 
            pCLabel.AutoSize = true;
            pCLabel.Location = new System.Drawing.Point(11, 70);
            pCLabel.Name = "pCLabel";
            pCLabel.Size = new System.Drawing.Size(23, 12);
            pCLabel.TabIndex = 3;
            pCLabel.Text = "PC:";
            // 
            // logLabel
            // 
            logLabel.AutoSize = true;
            logLabel.Location = new System.Drawing.Point(11, 112);
            logLabel.Name = "logLabel";
            logLabel.Size = new System.Drawing.Size(29, 12);
            logLabel.TabIndex = 5;
            logLabel.Text = "log:";
            // 
            // adminLabel
            // 
            adminLabel.AutoSize = true;
            adminLabel.Location = new System.Drawing.Point(399, 344);
            adminLabel.Name = "adminLabel";
            adminLabel.Size = new System.Drawing.Size(41, 12);
            adminLabel.TabIndex = 7;
            adminLabel.Text = "admin:";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new System.Drawing.Point(279, 70);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(35, 12);
            timeLabel.TabIndex = 9;
            timeLabel.Text = "time:";
            // 
            // database2DataSet1
            // 
            this.database2DataSet1.DataSetName = "Database2DataSet1";
            this.database2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pClogBindingSource
            // 
            this.pClogBindingSource.DataMember = "PClog";
            this.pClogBindingSource.DataSource = this.database2DataSet1;
            // 
            // pClogTableAdapter
            // 
            this.pClogTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PClogTableAdapter = this.pClogTableAdapter;
            this.tableAdapterManager.UpdateOrder = PC_log.Database2DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pClogBindingNavigator
            // 
            this.pClogBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pClogBindingNavigator.BindingSource = this.pClogBindingSource;
            this.pClogBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pClogBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pClogBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pClogBindingNavigatorSaveItem});
            this.pClogBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pClogBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pClogBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pClogBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pClogBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pClogBindingNavigator.Name = "pClogBindingNavigator";
            this.pClogBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pClogBindingNavigator.Size = new System.Drawing.Size(717, 25);
            this.pClogBindingNavigator.TabIndex = 0;
            this.pClogBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
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
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pClogBindingNavigatorSaveItem
            // 
            this.pClogBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pClogBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pClogBindingNavigatorSaveItem.Image")));
            this.pClogBindingNavigatorSaveItem.Name = "pClogBindingNavigatorSaveItem";
            this.pClogBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pClogBindingNavigatorSaveItem.Text = "保存数据";
            this.pClogBindingNavigatorSaveItem.Click += new System.EventHandler(this.pClogBindingNavigatorSaveItem_Click);
            // 
            // iPTextBox
            // 
            this.iPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pClogBindingSource, "IP", true));
            this.iPTextBox.Location = new System.Drawing.Point(58, 40);
            this.iPTextBox.Name = "iPTextBox";
            this.iPTextBox.Size = new System.Drawing.Size(200, 21);
            this.iPTextBox.TabIndex = 2;
            // 
            // pCTextBox
            // 
            this.pCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pClogBindingSource, "PC", true));
            this.pCTextBox.Location = new System.Drawing.Point(58, 67);
            this.pCTextBox.Name = "pCTextBox";
            this.pCTextBox.Size = new System.Drawing.Size(200, 21);
            this.pCTextBox.TabIndex = 4;
            // 
            // logTextBox
            // 
            this.logTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pClogBindingSource, "log", true));
            this.logTextBox.Location = new System.Drawing.Point(58, 109);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(333, 327);
            this.logTextBox.TabIndex = 6;
            // 
            // adminTextBox
            // 
            this.adminTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pClogBindingSource, "admin", true));
            this.adminTextBox.Location = new System.Drawing.Point(446, 341);
            this.adminTextBox.Name = "adminTextBox";
            this.adminTextBox.Size = new System.Drawing.Size(91, 21);
            this.adminTextBox.TabIndex = 8;
            // 
            // timeDateTimePicker
            // 
            this.timeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pClogBindingSource, "time", true));
            this.timeDateTimePicker.Location = new System.Drawing.Point(326, 66);
            this.timeDateTimePicker.Name = "timeDateTimePicker";
            this.timeDateTimePicker.Size = new System.Drawing.Size(211, 21);
            this.timeDateTimePicker.TabIndex = 10;
            // 
            // database2DataSet2
            // 
            this.database2DataSet2.DataSetName = "Database2DataSet2";
            this.database2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pClogBindingSource1
            // 
            this.pClogBindingSource1.DataMember = "PClog";
            this.pClogBindingSource1.DataSource = this.database2DataSet2;
            // 
            // pClogTableAdapter1
            // 
            this.pClogTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.PClogTableAdapter = this.pClogTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = PC_log.Database2DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(417, 109);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(23, 12);
            iDLabel.TabIndex = 11;
            iDLabel.Text = "ID:";
            iDLabel.Click += new System.EventHandler(this.iDLabel_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pClogBindingSource1, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(446, 106);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 21);
            this.iDTextBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 461);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(iPLabel);
            this.Controls.Add(this.iPTextBox);
            this.Controls.Add(pCLabel);
            this.Controls.Add(this.pCTextBox);
            this.Controls.Add(logLabel);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(adminLabel);
            this.Controls.Add(this.adminTextBox);
            this.Controls.Add(timeLabel);
            this.Controls.Add(this.timeDateTimePicker);
            this.Controls.Add(this.pClogBindingNavigator);
            this.Name = "Form1";
            this.Text = "PC-log-for GanLu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pClogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pClogBindingNavigator)).EndInit();
            this.pClogBindingNavigator.ResumeLayout(false);
            this.pClogBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pClogBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database2DataSet1 database2DataSet1;
        private System.Windows.Forms.BindingSource pClogBindingSource;
        private Database2DataSet1TableAdapters.PClogTableAdapter pClogTableAdapter;
        private Database2DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pClogBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pClogBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iPTextBox;
        private System.Windows.Forms.TextBox pCTextBox;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.TextBox adminTextBox;
        private System.Windows.Forms.DateTimePicker timeDateTimePicker;
        private Database2DataSet2 database2DataSet2;
        private System.Windows.Forms.BindingSource pClogBindingSource1;
        private Database2DataSet2TableAdapters.PClogTableAdapter pClogTableAdapter1;
        private Database2DataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox iDTextBox;
    }
}

