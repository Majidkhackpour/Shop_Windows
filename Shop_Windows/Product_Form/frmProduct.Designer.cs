namespace Shop_Windows.Product_Form
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.grpAccount = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cmbGroup = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.GroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKind = new System.Windows.Forms.TextBox();
            this.txtAbad = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnDeleteImage = new DevComponents.DotNetBar.ButtonX();
            this.btnInsImage = new DevComponents.DotNetBar.ButtonX();
            this.fPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.uC_Date1 = new UC_Date.UC_Date();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnFinish = new DevComponents.DotNetBar.ButtonX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.grpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBindingSource)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAccount
            // 
            this.grpAccount.BackColor = System.Drawing.Color.White;
            this.grpAccount.CanvasColor = System.Drawing.SystemColors.Control;
            this.grpAccount.Controls.Add(this.cmbGroup);
            this.grpAccount.Controls.Add(this.txtColor);
            this.grpAccount.Controls.Add(this.label6);
            this.grpAccount.Controls.Add(this.label8);
            this.grpAccount.Controls.Add(this.label7);
            this.grpAccount.Controls.Add(this.txtDesc);
            this.grpAccount.Controls.Add(this.label1);
            this.grpAccount.Controls.Add(this.txtKind);
            this.grpAccount.Controls.Add(this.txtAbad);
            this.grpAccount.Controls.Add(this.txtCode);
            this.grpAccount.Controls.Add(this.label5);
            this.grpAccount.Controls.Add(this.lblCode);
            this.grpAccount.Controls.Add(this.label3);
            this.grpAccount.Controls.Add(this.txtPrice);
            this.grpAccount.Controls.Add(this.label4);
            this.grpAccount.Controls.Add(this.txtName);
            this.grpAccount.Controls.Add(this.label2);
            this.grpAccount.DisabledBackColor = System.Drawing.Color.Empty;
            this.grpAccount.Location = new System.Drawing.Point(237, 55);
            this.grpAccount.Name = "grpAccount";
            this.grpAccount.Size = new System.Drawing.Size(708, 359);
            // 
            // 
            // 
            this.grpAccount.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.grpAccount.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.grpAccount.Style.BackColorGradientAngle = 90;
            this.grpAccount.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpAccount.Style.BorderBottomWidth = 3;
            this.grpAccount.Style.BorderColor = System.Drawing.Color.Silver;
            this.grpAccount.Style.BorderColor2 = System.Drawing.Color.Silver;
            this.grpAccount.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpAccount.Style.BorderLeftWidth = 3;
            this.grpAccount.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpAccount.Style.BorderRightWidth = 3;
            this.grpAccount.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpAccount.Style.BorderTopWidth = 3;
            this.grpAccount.Style.CornerDiameter = 4;
            this.grpAccount.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grpAccount.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grpAccount.Style.TextColor = System.Drawing.Color.Black;
            this.grpAccount.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.grpAccount.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.grpAccount.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.grpAccount.TabIndex = 0;
            // 
            // cmbGroup
            // 
            this.cmbGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbGroup.DataSource = this.GroupBindingSource;
            this.cmbGroup.DisplayMember = "Name";
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroup.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cmbGroup.ForeColor = System.Drawing.Color.Black;
            this.cmbGroup.ItemHeight = 20;
            this.cmbGroup.Location = new System.Drawing.Point(360, 91);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(327, 28);
            this.cmbGroup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbGroup.TabIndex = 2;
            this.cmbGroup.ValueMember = "Guid";
            this.cmbGroup.SelectedIndexChanged += new System.EventHandler(this.cmbGroup_SelectedIndexChanged);
            // 
            // GroupBindingSource
            // 
            this.GroupBindingSource.DataSource = typeof(EntityCache.Bussines.ProductGroupBussines);
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColor.ForeColor = System.Drawing.Color.Silver;
            this.txtColor.Location = new System.Drawing.Point(360, 204);
            this.txtColor.MaxLength = 3000;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(327, 27);
            this.txtColor.TabIndex = 6;
            this.txtColor.Enter += new System.EventHandler(this.txtColor_Enter);
            this.txtColor.Leave += new System.EventHandler(this.txtColor_Leave);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(539, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "رنگ";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(553, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "گروه";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(190, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "جنس";
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.ForeColor = System.Drawing.Color.Silver;
            this.txtDesc.Location = new System.Drawing.Point(11, 258);
            this.txtDesc.MaxLength = 30000;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(676, 92);
            this.txtDesc.TabIndex = 7;
            this.txtDesc.Enter += new System.EventHandler(this.txtDesc_Enter);
            this.txtDesc.Leave += new System.EventHandler(this.txtDesc_Leave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(539, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "توضیحات";
            // 
            // txtKind
            // 
            this.txtKind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.txtKind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKind.ForeColor = System.Drawing.Color.Silver;
            this.txtKind.Location = new System.Drawing.Point(11, 149);
            this.txtKind.MaxLength = 3000;
            this.txtKind.Name = "txtKind";
            this.txtKind.Size = new System.Drawing.Size(327, 27);
            this.txtKind.TabIndex = 5;
            this.txtKind.Enter += new System.EventHandler(this.txtKind_Enter);
            this.txtKind.Leave += new System.EventHandler(this.txtKind_Leave);
            // 
            // txtAbad
            // 
            this.txtAbad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.txtAbad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAbad.ForeColor = System.Drawing.Color.Silver;
            this.txtAbad.Location = new System.Drawing.Point(11, 91);
            this.txtAbad.MaxLength = 3000;
            this.txtAbad.Name = "txtAbad";
            this.txtAbad.Size = new System.Drawing.Size(327, 27);
            this.txtAbad.TabIndex = 3;
            this.txtAbad.Enter += new System.EventHandler(this.txtAbad_Enter);
            this.txtAbad.Leave += new System.EventHandler(this.txtAbad_Leave);
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.ForeColor = System.Drawing.Color.Silver;
            this.txtCode.Location = new System.Drawing.Point(109, 37);
            this.txtCode.MaxLength = 3000;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(229, 27);
            this.txtCode.TabIndex = 1;
            this.txtCode.Enter += new System.EventHandler(this.txtCode_Enter);
            this.txtCode.Leave += new System.EventHandler(this.txtCode_Leave);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(190, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "ابعاد";
            // 
            // lblCode
            // 
            this.lblCode.BackColor = System.Drawing.Color.Transparent;
            this.lblCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCode.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCode.ForeColor = System.Drawing.Color.Silver;
            this.lblCode.Location = new System.Drawing.Point(11, 36);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(92, 28);
            this.lblCode.TabIndex = 30;
            this.lblCode.Text = "000";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(190, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "کد کالا";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.ForeColor = System.Drawing.Color.Silver;
            this.txtPrice.Location = new System.Drawing.Point(360, 149);
            this.txtPrice.MaxLength = 3000;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(327, 27);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.Enter += new System.EventHandler(this.txtPrice_Enter);
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(539, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "قیمت";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.Silver;
            this.txtName.Location = new System.Drawing.Point(360, 36);
            this.txtName.MaxLength = 3000;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(327, 27);
            this.txtName.TabIndex = 0;
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(539, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "عنوان";
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.Controls.Add(this.btnDeleteImage);
            this.groupPanel1.Controls.Add(this.btnInsImage);
            this.groupPanel1.Controls.Add(this.fPanel);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(5, 55);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(226, 359);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.groupPanel1.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 3;
            this.groupPanel1.Style.BorderColor = System.Drawing.Color.Silver;
            this.groupPanel1.Style.BorderColor2 = System.Drawing.Color.Silver;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 3;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 3;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 3;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColor = System.Drawing.Color.Black;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 1;
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeleteImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.btnDeleteImage.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnDeleteImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteImage.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDeleteImage.Location = new System.Drawing.Point(4, 324);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(14);
            this.btnDeleteImage.Size = new System.Drawing.Size(214, 25);
            this.btnDeleteImage.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.btnDeleteImage.TabIndex = 1;
            this.btnDeleteImage.Text = "حدف تصویر";
            this.btnDeleteImage.TextColor = System.Drawing.Color.Silver;
            this.btnDeleteImage.ThemeAware = true;
            this.btnDeleteImage.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // btnInsImage
            // 
            this.btnInsImage.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInsImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInsImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.btnInsImage.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnInsImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsImage.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnInsImage.Location = new System.Drawing.Point(4, 289);
            this.btnInsImage.Name = "btnInsImage";
            this.btnInsImage.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(14);
            this.btnInsImage.Size = new System.Drawing.Size(214, 25);
            this.btnInsImage.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.btnInsImage.TabIndex = 0;
            this.btnInsImage.Text = "افزودن تصویر ...";
            this.btnInsImage.TextColor = System.Drawing.Color.Silver;
            this.btnInsImage.ThemeAware = true;
            this.btnInsImage.Click += new System.EventHandler(this.btnInsImage_Click);
            // 
            // fPanel
            // 
            this.fPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.fPanel.Location = new System.Drawing.Point(4, 3);
            this.fPanel.Name = "fPanel";
            this.fPanel.Size = new System.Drawing.Size(214, 280);
            this.fPanel.TabIndex = 2;
            // 
            // uC_Date1
            // 
            this.uC_Date1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.uC_Date1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uC_Date1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.uC_Date1.Location = new System.Drawing.Point(0, 0);
            this.uC_Date1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uC_Date1.Name = "uC_Date1";
            this.uC_Date1.Size = new System.Drawing.Size(957, 47);
            this.uC_Date1.TabIndex = 55714;
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblHeader.ForeColor = System.Drawing.Color.Silver;
            this.lblHeader.Location = new System.Drawing.Point(770, 5);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(180, 24);
            this.lblHeader.TabIndex = 55715;
            this.lblHeader.Text = "مدیریت کالاها";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.Location = new System.Drawing.Point(12, 445);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(14);
            this.btnCancel.Size = new System.Drawing.Size(214, 25);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "انصراف (ESC)";
            this.btnCancel.TextColor = System.Drawing.Color.Silver;
            this.btnCancel.ThemeAware = true;
            // 
            // btnFinish
            // 
            this.btnFinish.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.btnFinish.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinish.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFinish.Location = new System.Drawing.Point(600, 445);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(14);
            this.btnFinish.Size = new System.Drawing.Size(327, 25);
            this.btnFinish.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.btnFinish.TabIndex = 2;
            this.btnFinish.Text = "تایید (F5)";
            this.btnFinish.TextColor = System.Drawing.Color.Silver;
            this.btnFinish.ThemeAware = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // line1
            // 
            this.line1.ForeColor = System.Drawing.Color.Silver;
            this.line1.Location = new System.Drawing.Point(0, 420);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(957, 19);
            this.line1.TabIndex = 55718;
            this.line1.Text = "line1";
            this.line1.Thickness = 2;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(957, 483);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.uC_Date1);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.grpAccount);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProduct";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProduct_KeyDown);
            this.grpAccount.ResumeLayout(false);
            this.grpAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBindingSource)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.Controls.GroupPanel grpAccount;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cmbGroup;
        public System.Windows.Forms.TextBox txtColor;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtDesc;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtKind;
        public System.Windows.Forms.TextBox txtAbad;
        public System.Windows.Forms.TextBox txtCode;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblCode;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.Label label2;
        public DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private UC_Date.UC_Date uC_Date1;
        private System.Windows.Forms.Label lblHeader;
        public DevComponents.DotNetBar.ButtonX btnCancel;
        public DevComponents.DotNetBar.ButtonX btnFinish;
        private DevComponents.DotNetBar.Controls.Line line1;
        public DevComponents.DotNetBar.ButtonX btnDeleteImage;
        public DevComponents.DotNetBar.ButtonX btnInsImage;
        private System.Windows.Forms.FlowLayoutPanel fPanel;
        private System.Windows.Forms.BindingSource GroupBindingSource;
    }
}