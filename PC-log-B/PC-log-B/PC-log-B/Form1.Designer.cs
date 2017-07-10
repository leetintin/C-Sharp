namespace PC_log_B
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label iPLabel;
            System.Windows.Forms.Label logLabel;
            System.Windows.Forms.Label adminLabel;
            System.Windows.Forms.Label timeLabel;
            this.database1DataSet1 = new PC_log_B.Database1DataSet1();
            this.pc_log_BBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pc_log_BTableAdapter = new PC_log_B.Database1DataSet1TableAdapters.Pc_log_BTableAdapter();
            this.tableAdapterManager = new PC_log_B.Database1DataSet1TableAdapters.TableAdapterManager();
            this.pc_log_BBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pc_log_BBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.iPTextBox = new System.Windows.Forms.TextBox();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.adminTextBox = new System.Windows.Forms.TextBox();
            this.timeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            iPLabel = new System.Windows.Forms.Label();
            logLabel = new System.Windows.Forms.Label();
            adminLabel = new System.Windows.Forms.Label();
            timeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_log_BBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_log_BBindingNavigator)).BeginInit();
            this.pc_log_BBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pc_log_BBindingSource
            // 
            this.pc_log_BBindingSource.DataMember = "Pc-log-B";
            this.pc_log_BBindingSource.DataSource = this.database1DataSet1;
            // 
            // pc_log_BTableAdapter
            // 
            this.pc_log_BTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Pc_log_BTableAdapter = this.pc_log_BTableAdapter;
            this.tableAdapterManager.UpdateOrder = PC_log_B.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pc_log_BBindingNavigator
            // 
            this.pc_log_BBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pc_log_BBindingNavigator.BindingSource = this.pc_log_BBindingSource;
            this.pc_log_BBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pc_log_BBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pc_log_BBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pc_log_BBindingNavigatorSaveItem});
            this.pc_log_BBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pc_log_BBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pc_log_BBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pc_log_BBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pc_log_BBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pc_log_BBindingNavigator.Name = "pc_log_BBindingNavigator";
            this.pc_log_BBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pc_log_BBindingNavigator.Size = new System.Drawing.Size(452, 25);
            this.pc_log_BBindingNavigator.TabIndex = 0;
            this.pc_log_BBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 17);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // pc_log_BBindingNavigatorSaveItem
            // 
            this.pc_log_BBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pc_log_BBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pc_log_BBindingNavigatorSaveItem.Image")));
            this.pc_log_BBindingNavigatorSaveItem.Name = "pc_log_BBindingNavigatorSaveItem";
            this.pc_log_BBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.pc_log_BBindingNavigatorSaveItem.Text = "保存数据";
            this.pc_log_BBindingNavigatorSaveItem.Click += new System.EventHandler(this.pc_log_BBindingNavigatorSaveItem_Click_1);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(8, 43);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(23, 12);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_log_BBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(55, 40);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(62, 21);
            this.iDTextBox.TabIndex = 2;
            // 
            // iPLabel
            // 
            iPLabel.AutoSize = true;
            iPLabel.Location = new System.Drawing.Point(8, 70);
            iPLabel.Name = "iPLabel";
            iPLabel.Size = new System.Drawing.Size(23, 12);
            iPLabel.TabIndex = 3;
            iPLabel.Text = "IP:";
            // 
            // iPTextBox
            // 
            this.iPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_log_BBindingSource, "IP", true));
            this.iPTextBox.Location = new System.Drawing.Point(55, 67);
            this.iPTextBox.Name = "iPTextBox";
            this.iPTextBox.Size = new System.Drawing.Size(200, 21);
            this.iPTextBox.TabIndex = 4;
            // 
            // logLabel
            // 
            logLabel.AutoSize = true;
            logLabel.Location = new System.Drawing.Point(8, 97);
            logLabel.Name = "logLabel";
            logLabel.Size = new System.Drawing.Size(29, 12);
            logLabel.TabIndex = 5;
            logLabel.Text = "log:";
            // 
            // logTextBox
            // 
            this.logTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_log_BBindingSource, "log", true));
            this.logTextBox.Location = new System.Drawing.Point(55, 94);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(200, 214);
            this.logTextBox.TabIndex = 6;
            // 
            // adminLabel
            // 
            adminLabel.AutoSize = true;
            adminLabel.Location = new System.Drawing.Point(266, 70);
            adminLabel.Name = "adminLabel";
            adminLabel.Size = new System.Drawing.Size(41, 12);
            adminLabel.TabIndex = 7;
            adminLabel.Text = "admin:";
            // 
            // adminTextBox
            // 
            this.adminTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_log_BBindingSource, "admin", true));
            this.adminTextBox.Location = new System.Drawing.Point(313, 67);
            this.adminTextBox.Name = "adminTextBox";
            this.adminTextBox.Size = new System.Drawing.Size(100, 21);
            this.adminTextBox.TabIndex = 8;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new System.Drawing.Point(162, 44);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(35, 12);
            timeLabel.TabIndex = 9;
            timeLabel.Text = "Time:";
            // 
            // timeDateTimePicker
            // 
            this.timeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pc_log_BBindingSource, "Time", true));
            this.timeDateTimePicker.Location = new System.Drawing.Point(209, 40);
            this.timeDateTimePicker.Name = "timeDateTimePicker";
            this.timeDateTimePicker.Size = new System.Drawing.Size(178, 21);
            this.timeDateTimePicker.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 49);
            this.button1.TabIndex = 11;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 342);
            this.Controls.Add(this.button1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(iPLabel);
            this.Controls.Add(this.iPTextBox);
            this.Controls.Add(logLabel);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(adminLabel);
            this.Controls.Add(this.adminTextBox);
            this.Controls.Add(timeLabel);
            this.Controls.Add(this.timeDateTimePicker);
            this.Controls.Add(this.pc_log_BBindingNavigator);
            this.Name = "Form1";
            this.Text = "Pc-log-B";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_log_BBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_log_BBindingNavigator)).EndInit();
            this.pc_log_BBindingNavigator.ResumeLayout(false);
            this.pc_log_BBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource pc_log_BBindingSource;
        private Database1DataSet1TableAdapters.Pc_log_BTableAdapter pc_log_BTableAdapter;
        private Database1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pc_log_BBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pc_log_BBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox iPTextBox;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.TextBox adminTextBox;
        private System.Windows.Forms.DateTimePicker timeDateTimePicker;
        private System.Windows.Forms.Button button1;

    }
}

