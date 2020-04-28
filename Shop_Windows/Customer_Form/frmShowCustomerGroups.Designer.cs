namespace Shop_Windows.Customer_Form
{
    partial class frmShowCustomers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowCustomers));
            this.DGrid = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Radif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nahveAshnaeiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmCustomer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuInsAdv = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.trvGroup = new System.Windows.Forms.TreeView();
            this.cmCustGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAddCustGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditCustGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteCustGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuViwCustGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.CusGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGrid)).BeginInit();
            this.cmCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).BeginInit();
            this.cmCustGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CusGroupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DGrid
            // 
            this.DGrid.AllowUserToAddRows = false;
            this.DGrid.AllowUserToDeleteRows = false;
            this.DGrid.AllowUserToResizeColumns = false;
            this.DGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGrid.AutoGenerateColumns = false;
            this.DGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Radif,
            this.dgName,
            this.phone1DataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.dgGuid,
            this.modifiedDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.phone2DataGridViewTextBoxColumn,
            this.postalCodeDataGridViewTextBoxColumn,
            this.nationalCodeDataGridViewTextBoxColumn,
            this.nahveAshnaeiDataGridViewTextBoxColumn});
            this.DGrid.ContextMenuStrip = this.cmCustomer;
            this.DGrid.DataSource = this.CustomerBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DGrid.Location = new System.Drawing.Point(2, 51);
            this.DGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGrid.Name = "DGrid";
            this.DGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.DGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGrid.Size = new System.Drawing.Size(604, 507);
            this.DGrid.TabIndex = 55698;
            // 
            // Radif
            // 
            this.Radif.HeaderText = "ردیف";
            this.Radif.Name = "Radif";
            this.Radif.ReadOnly = true;
            this.Radif.Width = 50;
            // 
            // dgName
            // 
            this.dgName.DataPropertyName = "Name";
            this.dgName.HeaderText = "عنوان";
            this.dgName.Name = "dgName";
            this.dgName.Width = 200;
            // 
            // phone1DataGridViewTextBoxColumn
            // 
            this.phone1DataGridViewTextBoxColumn.DataPropertyName = "Phone1";
            this.phone1DataGridViewTextBoxColumn.HeaderText = "تلفن";
            this.phone1DataGridViewTextBoxColumn.Name = "phone1DataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "آدرس";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // dgGuid
            // 
            this.dgGuid.DataPropertyName = "Guid";
            this.dgGuid.HeaderText = "Guid";
            this.dgGuid.Name = "dgGuid";
            this.dgGuid.Visible = false;
            // 
            // modifiedDataGridViewTextBoxColumn
            // 
            this.modifiedDataGridViewTextBoxColumn.DataPropertyName = "Modified";
            this.modifiedDataGridViewTextBoxColumn.HeaderText = "Modified";
            this.modifiedDataGridViewTextBoxColumn.Name = "modifiedDataGridViewTextBoxColumn";
            this.modifiedDataGridViewTextBoxColumn.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Visible = false;
            // 
            // phone2DataGridViewTextBoxColumn
            // 
            this.phone2DataGridViewTextBoxColumn.DataPropertyName = "Phone2";
            this.phone2DataGridViewTextBoxColumn.HeaderText = "Phone2";
            this.phone2DataGridViewTextBoxColumn.Name = "phone2DataGridViewTextBoxColumn";
            this.phone2DataGridViewTextBoxColumn.Visible = false;
            // 
            // postalCodeDataGridViewTextBoxColumn
            // 
            this.postalCodeDataGridViewTextBoxColumn.DataPropertyName = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.HeaderText = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
            this.postalCodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // nationalCodeDataGridViewTextBoxColumn
            // 
            this.nationalCodeDataGridViewTextBoxColumn.DataPropertyName = "NationalCode";
            this.nationalCodeDataGridViewTextBoxColumn.HeaderText = "NationalCode";
            this.nationalCodeDataGridViewTextBoxColumn.Name = "nationalCodeDataGridViewTextBoxColumn";
            this.nationalCodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // nahveAshnaeiDataGridViewTextBoxColumn
            // 
            this.nahveAshnaeiDataGridViewTextBoxColumn.DataPropertyName = "NahveAshnaei";
            this.nahveAshnaeiDataGridViewTextBoxColumn.HeaderText = "NahveAshnaei";
            this.nahveAshnaeiDataGridViewTextBoxColumn.Name = "nahveAshnaeiDataGridViewTextBoxColumn";
            this.nahveAshnaeiDataGridViewTextBoxColumn.Visible = false;
            // 
            // cmCustomer
            // 
            this.cmCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.cmCustomer.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInsAdv,
            this.mnuEdit,
            this.mnuDelete,
            this.toolStripMenuItem5,
            this.mnuView});
            this.cmCustomer.Name = "contextMenuStrip1";
            this.cmCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmCustomer.Size = new System.Drawing.Size(182, 128);
            // 
            // mnuInsAdv
            // 
            this.mnuInsAdv.ForeColor = System.Drawing.Color.Silver;
            this.mnuInsAdv.Name = "mnuInsAdv";
            this.mnuInsAdv.Size = new System.Drawing.Size(181, 24);
            this.mnuInsAdv.Text = "درج مشتری جدید";
            this.mnuInsAdv.Click += new System.EventHandler(this.mnuInsAdv_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.ForeColor = System.Drawing.Color.Silver;
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(181, 24);
            this.mnuEdit.Text = "ویرایش مشتری جاری";
            this.mnuEdit.Click += new System.EventHandler(this.mnuEdit_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.ForeColor = System.Drawing.Color.Silver;
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(181, 24);
            this.mnuDelete.Text = "حذف مشتری جاری";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(178, 6);
            // 
            // mnuView
            // 
            this.mnuView.ForeColor = System.Drawing.Color.Silver;
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(181, 24);
            this.mnuView.Text = "مشاهده";
            this.mnuView.Click += new System.EventHandler(this.mnuView_Click);
            // 
            // CustomerBindingSource
            // 
            this.CustomerBindingSource.DataSource = typeof(EntityCache.Bussines.CustomerBussines);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSearch.Border.Class = "TextBoxBorder";
            this.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearch.Location = new System.Drawing.Point(41, 16);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PreventEnterBeep = true;
            this.txtSearch.Size = new System.Drawing.Size(701, 27);
            this.txtSearch.TabIndex = 55702;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.WatermarkText = "مورد جستجو را وارد نمایید ...";
            // 
            // trvGroup
            // 
            this.trvGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.trvGroup.ContextMenuStrip = this.cmCustGroup;
            this.trvGroup.ForeColor = System.Drawing.Color.Silver;
            this.trvGroup.Location = new System.Drawing.Point(612, 51);
            this.trvGroup.Name = "trvGroup";
            this.trvGroup.RightToLeftLayout = true;
            this.trvGroup.Size = new System.Drawing.Size(169, 507);
            this.trvGroup.TabIndex = 55703;
            this.trvGroup.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvGroup_AfterSelect);
            // 
            // cmCustGroup
            // 
            this.cmCustGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.cmCustGroup.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmCustGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddCustGroup,
            this.mnuEditCustGroup,
            this.mnuDeleteCustGroup,
            this.toolStripMenuItem2,
            this.mnuViwCustGroup});
            this.cmCustGroup.Name = "contextMenuStrip1";
            this.cmCustGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmCustGroup.Size = new System.Drawing.Size(207, 106);
            // 
            // mnuAddCustGroup
            // 
            this.mnuAddCustGroup.ForeColor = System.Drawing.Color.DarkGray;
            this.mnuAddCustGroup.Name = "mnuAddCustGroup";
            this.mnuAddCustGroup.Size = new System.Drawing.Size(206, 24);
            this.mnuAddCustGroup.Text = "درج گروه  مشتری جدید";
            this.mnuAddCustGroup.Click += new System.EventHandler(this.mnuAddCustGroup_Click);
            // 
            // mnuEditCustGroup
            // 
            this.mnuEditCustGroup.ForeColor = System.Drawing.Color.Silver;
            this.mnuEditCustGroup.Name = "mnuEditCustGroup";
            this.mnuEditCustGroup.Size = new System.Drawing.Size(206, 24);
            this.mnuEditCustGroup.Text = "ویرایش گروه مشتری جاری";
            this.mnuEditCustGroup.Click += new System.EventHandler(this.mnuEditCustGroup_Click);
            // 
            // mnuDeleteCustGroup
            // 
            this.mnuDeleteCustGroup.ForeColor = System.Drawing.Color.Silver;
            this.mnuDeleteCustGroup.Name = "mnuDeleteCustGroup";
            this.mnuDeleteCustGroup.Size = new System.Drawing.Size(206, 24);
            this.mnuDeleteCustGroup.Text = "حذف گروه مشتری جاری";
            this.mnuDeleteCustGroup.Click += new System.EventHandler(this.mnuDeleteCustGroup_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(203, 6);
            // 
            // mnuViwCustGroup
            // 
            this.mnuViwCustGroup.ForeColor = System.Drawing.Color.Silver;
            this.mnuViwCustGroup.Name = "mnuViwCustGroup";
            this.mnuViwCustGroup.Size = new System.Drawing.Size(206, 24);
            this.mnuViwCustGroup.Text = "مشاهده";
            this.mnuViwCustGroup.Click += new System.EventHandler(this.mnuViwCustGroup_Click);
            // 
            // CusGroupBindingSource
            // 
            this.CusGroupBindingSource.DataSource = typeof(EntityCache.Bussines.CustomerGroupBussines);
            // 
            // frmShowCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.trvGroup);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.DGrid);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowCustomers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmShowCustomerGroups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGrid)).EndInit();
            this.cmCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).EndInit();
            this.cmCustGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CusGroupBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX DGrid;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
        private System.Windows.Forms.BindingSource CusGroupBindingSource;
        private System.Windows.Forms.TreeView trvGroup;
        private System.Windows.Forms.ContextMenuStrip cmCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuInsAdv;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.ContextMenuStrip cmCustGroup;
        private System.Windows.Forms.ToolStripMenuItem mnuAddCustGroup;
        private System.Windows.Forms.ToolStripMenuItem mnuEditCustGroup;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteCustGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuViwCustGroup;
        private System.Windows.Forms.BindingSource CustomerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Radif;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nahveAshnaeiDataGridViewTextBoxColumn;
    }
}