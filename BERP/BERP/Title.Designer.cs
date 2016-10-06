namespace BERP
{
    partial class formTitle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTitle));
            System.Windows.Forms.Label titleIDLabel;
            System.Windows.Forms.Label titleDescLabel;
            this.bERPDataSetTitle = new BERP.BERPDataSetTitle();
            this.titleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleTableAdapter = new BERP.BERPDataSetTitleTableAdapters.TitleTableAdapter();
            this.tableAdapterManager = new BERP.BERPDataSetTitleTableAdapters.TableAdapterManager();
            this.titleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.titleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.titleIDTextBox = new System.Windows.Forms.TextBox();
            this.titleDescTextBox = new System.Windows.Forms.TextBox();
            titleIDLabel = new System.Windows.Forms.Label();
            titleDescLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bERPDataSetTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBindingNavigator)).BeginInit();
            this.titleBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bERPDataSetTitle
            // 
            this.bERPDataSetTitle.DataSetName = "BERPDataSetTitle";
            this.bERPDataSetTitle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // titleBindingSource
            // 
            this.titleBindingSource.DataMember = "Title";
            this.titleBindingSource.DataSource = this.bERPDataSetTitle;
            // 
            // titleTableAdapter
            // 
            this.titleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TitleTableAdapter = this.titleTableAdapter;
            this.tableAdapterManager.UpdateOrder = BERP.BERPDataSetTitleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // titleBindingNavigator
            // 
            this.titleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.titleBindingNavigator.BindingSource = this.titleBindingSource;
            this.titleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.titleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.titleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.titleBindingNavigatorSaveItem});
            this.titleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.titleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.titleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.titleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.titleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.titleBindingNavigator.Name = "titleBindingNavigator";
            this.titleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.titleBindingNavigator.Size = new System.Drawing.Size(959, 25);
            this.titleBindingNavigator.TabIndex = 0;
            this.titleBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
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
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // titleBindingNavigatorSaveItem
            // 
            this.titleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.titleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("titleBindingNavigatorSaveItem.Image")));
            this.titleBindingNavigatorSaveItem.Name = "titleBindingNavigatorSaveItem";
            this.titleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.titleBindingNavigatorSaveItem.Text = "Save Data";
            this.titleBindingNavigatorSaveItem.Click += new System.EventHandler(this.titleBindingNavigatorSaveItem_Click);
            // 
            // titleIDLabel
            // 
            titleIDLabel.AutoSize = true;
            titleIDLabel.Location = new System.Drawing.Point(257, 126);
            titleIDLabel.Name = "titleIDLabel";
            titleIDLabel.Size = new System.Drawing.Size(44, 13);
            titleIDLabel.TabIndex = 1;
            titleIDLabel.Text = "Title ID:";
            // 
            // titleIDTextBox
            // 
            this.titleIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.titleBindingSource, "TitleID", true));
            this.titleIDTextBox.Location = new System.Drawing.Point(321, 123);
            this.titleIDTextBox.Name = "titleIDTextBox";
            this.titleIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleIDTextBox.TabIndex = 2;
            // 
            // titleDescLabel
            // 
            titleDescLabel.AutoSize = true;
            titleDescLabel.Location = new System.Drawing.Point(257, 152);
            titleDescLabel.Name = "titleDescLabel";
            titleDescLabel.Size = new System.Drawing.Size(58, 13);
            titleDescLabel.TabIndex = 3;
            titleDescLabel.Text = "Title Desc:";
            // 
            // titleDescTextBox
            // 
            this.titleDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.titleBindingSource, "TitleDesc", true));
            this.titleDescTextBox.Location = new System.Drawing.Point(321, 149);
            this.titleDescTextBox.Name = "titleDescTextBox";
            this.titleDescTextBox.Size = new System.Drawing.Size(340, 20);
            this.titleDescTextBox.TabIndex = 4;
            // 
            // formTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 687);
            this.ControlBox = false;
            this.Controls.Add(titleIDLabel);
            this.Controls.Add(this.titleIDTextBox);
            this.Controls.Add(titleDescLabel);
            this.Controls.Add(this.titleDescTextBox);
            this.Controls.Add(this.titleBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formTitle";
            this.Text = "Title";
            this.Load += new System.EventHandler(this.formTitle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bERPDataSetTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBindingNavigator)).EndInit();
            this.titleBindingNavigator.ResumeLayout(false);
            this.titleBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BERPDataSetTitle bERPDataSetTitle;
        private System.Windows.Forms.BindingSource titleBindingSource;
        private BERPDataSetTitleTableAdapters.TitleTableAdapter titleTableAdapter;
        private BERPDataSetTitleTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator titleBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton titleBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox titleIDTextBox;
        private System.Windows.Forms.TextBox titleDescTextBox;
    }
}