
namespace DB_Copycenter.Forms
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PaymentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientFIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.NotClientButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.NotClientConfirmButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ServicePriceLabel = new System.Windows.Forms.Label();
            this.RefreshButton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaymentNumber,
            this.ClientFIO,
            this.ServiceName,
            this.PaymentSum,
            this.ServiceStatus});
            this.dataGridView1.Location = new System.Drawing.Point(6, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 190);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // PaymentNumber
            // 
            this.PaymentNumber.HeaderText = "Номер Платежа";
            this.PaymentNumber.Name = "PaymentNumber";
            this.PaymentNumber.ReadOnly = true;
            this.PaymentNumber.Width = 150;
            // 
            // ClientFIO
            // 
            this.ClientFIO.HeaderText = "ФИО Клиента";
            this.ClientFIO.Name = "ClientFIO";
            this.ClientFIO.ReadOnly = true;
            this.ClientFIO.Width = 200;
            // 
            // ServiceName
            // 
            this.ServiceName.HeaderText = "Название Услуги";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.Width = 150;
            // 
            // PaymentSum
            // 
            this.PaymentSum.HeaderText = "Сумма Платежа";
            this.PaymentSum.Name = "PaymentSum";
            this.PaymentSum.Width = 75;
            // 
            // ServiceStatus
            // 
            this.ServiceStatus.HeaderText = "Состояние Заказа";
            this.ServiceStatus.Name = "ServiceStatus";
            this.ServiceStatus.ReadOnly = true;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConfirmButton.BackgroundImage")));
            this.ConfirmButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConfirmButton.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmButton.Location = new System.Drawing.Point(645, 19);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(51, 57);
            this.ConfirmButton.TabIndex = 24;
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // NotClientButton
            // 
            this.NotClientButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NotClientButton.BackgroundImage")));
            this.NotClientButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NotClientButton.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotClientButton.Location = new System.Drawing.Point(619, 469);
            this.NotClientButton.Name = "NotClientButton";
            this.NotClientButton.Size = new System.Drawing.Size(77, 86);
            this.NotClientButton.TabIndex = 25;
            this.NotClientButton.UseVisualStyleBackColor = true;
            this.NotClientButton.Click += new System.EventHandler(this.NotClientButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshButton.BackgroundImage")));
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshButton.Location = new System.Drawing.Point(702, 19);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(51, 57);
            this.RefreshButton.TabIndex = 30;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RefreshButton1);
            this.groupBox1.Controls.Add(this.ServicePriceLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ServiceComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.NotClientConfirmButton);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.RefreshButton);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.ConfirmButton);
            this.groupBox1.Controls.Add(this.NotClientButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 737);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Окно Заказов";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView2.Location = new System.Drawing.Point(6, 444);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(569, 287);
            this.dataGridView2.TabIndex = 31;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // NotClientConfirmButton
            // 
            this.NotClientConfirmButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NotClientConfirmButton.BackgroundImage")));
            this.NotClientConfirmButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NotClientConfirmButton.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotClientConfirmButton.Location = new System.Drawing.Point(619, 612);
            this.NotClientConfirmButton.Name = "NotClientConfirmButton";
            this.NotClientConfirmButton.Size = new System.Drawing.Size(77, 86);
            this.NotClientConfirmButton.TabIndex = 32;
            this.NotClientConfirmButton.UseVisualStyleBackColor = true;
            this.NotClientConfirmButton.Click += new System.EventHandler(this.NotClientConfirmButton_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(20, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 41);
            this.label9.TabIndex = 33;
            this.label9.Text = "Заказы клиентов";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 52);
            this.label1.TabIndex = 34;
            this.label1.Text = "Заказы не-клиентов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер Платежа";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Название Услуги";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Сумма Платежа";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Состояние Заказа";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ServiceComboBox
            // 
            this.ServiceComboBox.FormattingEnabled = true;
            this.ServiceComboBox.Location = new System.Drawing.Point(159, 365);
            this.ServiceComboBox.Name = "ServiceComboBox";
            this.ServiceComboBox.Size = new System.Drawing.Size(192, 21);
            this.ServiceComboBox.TabIndex = 35;
            this.ServiceComboBox.SelectedIndexChanged += new System.EventHandler(this.ServiceComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(16, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 34);
            this.label2.TabIndex = 36;
            this.label2.Text = "Перечень услуг:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(98, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 34);
            this.label3.TabIndex = 37;
            this.label3.Text = "Цена:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServicePriceLabel
            // 
            this.ServicePriceLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServicePriceLabel.Location = new System.Drawing.Point(159, 400);
            this.ServicePriceLabel.Name = "ServicePriceLabel";
            this.ServicePriceLabel.Size = new System.Drawing.Size(55, 27);
            this.ServicePriceLabel.TabIndex = 38;
            this.ServicePriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RefreshButton1
            // 
            this.RefreshButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshButton1.BackgroundImage")));
            this.RefreshButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshButton1.Location = new System.Drawing.Point(702, 400);
            this.RefreshButton1.Name = "RefreshButton1";
            this.RefreshButton1.Size = new System.Drawing.Size(51, 57);
            this.RefreshButton1.TabIndex = 39;
            this.RefreshButton1.UseVisualStyleBackColor = true;
            this.RefreshButton1.Click += new System.EventHandler(this.RefreshButton1_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "OrderForm";
            this.Text = "Order Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button NotClientButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientFIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button NotClientConfirmButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox ServiceComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ServicePriceLabel;
        private System.Windows.Forms.Button RefreshButton1;
    }
}