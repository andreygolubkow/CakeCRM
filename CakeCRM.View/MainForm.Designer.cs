namespace CakeCRM.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.складToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellVariantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSaleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.salesGroupBox = new System.Windows.Forms.GroupBox();
            this.salesGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showClientInfoButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.saleStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listByStatusButton = new System.Windows.Forms.Button();
            this.newSellButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.balanceText = new System.Windows.Forms.ToolStripStatusLabel();
            this.editSaleButton = new System.Windows.Forms.Button();
            this.mainMenu.SuspendLayout();
            this.salesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleStatusBindingSource)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.складToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(813, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "mainMenu";
            // 
            // складToolStripMenuItem
            // 
            this.складToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.packToolStripMenuItem,
            this.deliveryToolStripMenuItem,
            this.statusesToolStripMenuItem,
            this.sellVariantToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.заказыToolStripMenuItem});
            this.складToolStripMenuItem.Name = "складToolStripMenuItem";
            this.складToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.складToolStripMenuItem.Text = "Каталог";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productToolStripMenuItem.Text = "Товары";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // packToolStripMenuItem
            // 
            this.packToolStripMenuItem.Name = "packToolStripMenuItem";
            this.packToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.packToolStripMenuItem.Text = "Тара";
            this.packToolStripMenuItem.Click += new System.EventHandler(this.packToolStripMenuItem_Click);
            // 
            // deliveryToolStripMenuItem
            // 
            this.deliveryToolStripMenuItem.Name = "deliveryToolStripMenuItem";
            this.deliveryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deliveryToolStripMenuItem.Text = "Доставка";
            this.deliveryToolStripMenuItem.Click += new System.EventHandler(this.deliveryToolStripMenuItem_Click);
            // 
            // statusesToolStripMenuItem
            // 
            this.statusesToolStripMenuItem.Name = "statusesToolStripMenuItem";
            this.statusesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.statusesToolStripMenuItem.Text = "Статусы";
            this.statusesToolStripMenuItem.Click += new System.EventHandler(this.statusesToolStripMenuItem_Click);
            // 
            // sellVariantToolStripMenuItem
            // 
            this.sellVariantToolStripMenuItem.Name = "sellVariantToolStripMenuItem";
            this.sellVariantToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sellVariantToolStripMenuItem.Text = "Витрина";
            this.sellVariantToolStripMenuItem.Click += new System.EventHandler(this.sellVariantToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientsToolStripMenuItem.Text = "Клиенты";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeSaleButton});
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.заказыToolStripMenuItem.Text = "Заказы";
            // 
            // removeSaleButton
            // 
            this.removeSaleButton.Name = "removeSaleButton";
            this.removeSaleButton.Size = new System.Drawing.Size(180, 22);
            this.removeSaleButton.Text = "Удалить заказ";
            this.removeSaleButton.Click += new System.EventHandler(this.removeSaleButton_Click);
            // 
            // salesGroupBox
            // 
            this.salesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salesGroupBox.Controls.Add(this.salesGridView);
            this.salesGroupBox.Location = new System.Drawing.Point(12, 27);
            this.salesGroupBox.Name = "salesGroupBox";
            this.salesGroupBox.Size = new System.Drawing.Size(789, 282);
            this.salesGroupBox.TabIndex = 1;
            this.salesGroupBox.TabStop = false;
            this.salesGroupBox.Text = "Заказы";
            // 
            // salesGridView
            // 
            this.salesGridView.AllowUserToAddRows = false;
            this.salesGridView.AllowUserToDeleteRows = false;
            this.salesGridView.AllowUserToResizeRows = false;
            this.salesGridView.AutoGenerateColumns = false;
            this.salesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.salesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.goodsDataGridViewTextBoxColumn,
            this.deliveryDataGridViewTextBoxColumn,
            this.dateTimeDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.Status});
            this.salesGridView.DataSource = this.saleBindingSource;
            this.salesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesGridView.Location = new System.Drawing.Point(3, 16);
            this.salesGridView.MultiSelect = false;
            this.salesGridView.Name = "salesGridView";
            this.salesGridView.ReadOnly = true;
            this.salesGridView.RowHeadersVisible = false;
            this.salesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesGridView.Size = new System.Drawing.Size(783, 263);
            this.salesGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 50F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Номер заказа";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.FillWeight = 77.397F;
            this.clientDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodsDataGridViewTextBoxColumn
            // 
            this.goodsDataGridViewTextBoxColumn.DataPropertyName = "Goods";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.goodsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.goodsDataGridViewTextBoxColumn.FillWeight = 77.397F;
            this.goodsDataGridViewTextBoxColumn.HeaderText = "Товары";
            this.goodsDataGridViewTextBoxColumn.Name = "goodsDataGridViewTextBoxColumn";
            this.goodsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryDataGridViewTextBoxColumn
            // 
            this.deliveryDataGridViewTextBoxColumn.DataPropertyName = "Delivery";
            this.deliveryDataGridViewTextBoxColumn.FillWeight = 77.397F;
            this.deliveryDataGridViewTextBoxColumn.HeaderText = "Доставка";
            this.deliveryDataGridViewTextBoxColumn.Name = "deliveryDataGridViewTextBoxColumn";
            this.deliveryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.FillWeight = 77.397F;
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "Дата заказа";
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            this.dateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.FillWeight = 77.397F;
            this.costDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.FillWeight = 77.397F;
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // saleBindingSource
            // 
            this.saleBindingSource.DataSource = typeof(CakeCRM.Model.Sale);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.editSaleButton);
            this.groupBox2.Controls.Add(this.showClientInfoButton);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.listByStatusButton);
            this.groupBox2.Controls.Add(this.newSellButton);
            this.groupBox2.Location = new System.Drawing.Point(0, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(813, 78);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление";
            // 
            // showClientInfoButton
            // 
            this.showClientInfoButton.Location = new System.Drawing.Point(134, 19);
            this.showClientInfoButton.Name = "showClientInfoButton";
            this.showClientInfoButton.Size = new System.Drawing.Size(151, 23);
            this.showClientInfoButton.TabIndex = 4;
            this.showClientInfoButton.Text = "Информация клиенту";
            this.showClientInfoButton.UseVisualStyleBackColor = true;
            this.showClientInfoButton.Click += new System.EventHandler(this.showClientInfoButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.statusComboBox);
            this.groupBox1.Location = new System.Drawing.Point(497, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 48);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Изменить статус";
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.saleBindingSource, "Status", true));
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.saleBindingSource, "Status", true));
            this.statusComboBox.DataSource = this.saleStatusBindingSource;
            this.statusComboBox.DisplayMember = "Title";
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(6, 19);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(289, 21);
            this.statusComboBox.TabIndex = 3;
            this.statusComboBox.SelectionChangeCommitted += new System.EventHandler(this.statusComboBox_SelectionChangeCommitted);
            // 
            // saleStatusBindingSource
            // 
            this.saleStatusBindingSource.DataSource = typeof(CakeCRM.Model.SaleStatus);
            // 
            // listByStatusButton
            // 
            this.listByStatusButton.Location = new System.Drawing.Point(291, 19);
            this.listByStatusButton.Name = "listByStatusButton";
            this.listByStatusButton.Size = new System.Drawing.Size(200, 23);
            this.listByStatusButton.TabIndex = 1;
            this.listByStatusButton.Text = "Сформировать список по статусу";
            this.listByStatusButton.UseVisualStyleBackColor = true;
            this.listByStatusButton.Click += new System.EventHandler(this.salesDocumentButton_Click);
            // 
            // newSellButton
            // 
            this.newSellButton.Location = new System.Drawing.Point(12, 19);
            this.newSellButton.Name = "newSellButton";
            this.newSellButton.Size = new System.Drawing.Size(116, 23);
            this.newSellButton.TabIndex = 0;
            this.newSellButton.Text = "Новый заказ";
            this.newSellButton.UseVisualStyleBackColor = true;
            this.newSellButton.Click += new System.EventHandler(this.newSellButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.balanceText});
            this.statusStrip.Location = new System.Drawing.Point(0, 371);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(813, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // balanceText
            // 
            this.balanceText.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.balanceText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.balanceText.DoubleClickEnabled = true;
            this.balanceText.Name = "balanceText";
            this.balanceText.Size = new System.Drawing.Size(798, 17);
            this.balanceText.Spring = true;
            this.balanceText.Text = "Остатки:";
            this.balanceText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.balanceText.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.balanceText.DoubleClick += new System.EventHandler(this.balanceText_DoubleClick);
            // 
            // editSaleButton
            // 
            this.editSaleButton.Location = new System.Drawing.Point(15, 48);
            this.editSaleButton.Name = "editSaleButton";
            this.editSaleButton.Size = new System.Drawing.Size(113, 23);
            this.editSaleButton.TabIndex = 5;
            this.editSaleButton.Text = "Редактировать";
            this.editSaleButton.UseVisualStyleBackColor = true;
            this.editSaleButton.Click += new System.EventHandler(this.editSaleButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 393);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.salesGroupBox);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(829, 432);
            this.Name = "MainForm";
            this.Text = "Заказы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.salesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.saleStatusBindingSource)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem складToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryToolStripMenuItem;
        private System.Windows.Forms.GroupBox salesGroupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView salesGridView;
        private System.Windows.Forms.ToolStripMenuItem sellVariantToolStripMenuItem;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private System.Windows.Forms.Button newSellButton;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusesToolStripMenuItem;
        private System.Windows.Forms.Button listByStatusButton;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSaleButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.BindingSource saleStatusBindingSource;
        private System.Windows.Forms.Button showClientInfoButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ToolStripStatusLabel balanceText;
        private System.Windows.Forms.Button editSaleButton;
    }
}

