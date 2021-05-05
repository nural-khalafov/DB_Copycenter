
namespace DB_Copycenter.Forms
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ServicePriceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddServiceButton = new System.Windows.Forms.Button();
            this.RemoveServiceButton = new System.Windows.Forms.Button();
            this.GetServiceButton = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.ServiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ServiceComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FioLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SelfCashLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ServicePriceLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AddServiceButton);
            this.groupBox1.Controls.Add(this.RemoveServiceButton);
            this.groupBox1.Controls.Add(this.GetServiceButton);
            this.groupBox1.Controls.Add(this.DataGridView1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ServiceComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(653, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 395);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заказ услуг";
            // 
            // ServicePriceLabel
            // 
            this.ServicePriceLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServicePriceLabel.Location = new System.Drawing.Point(75, 50);
            this.ServicePriceLabel.Name = "ServicePriceLabel";
            this.ServicePriceLabel.Size = new System.Drawing.Size(55, 27);
            this.ServicePriceLabel.TabIndex = 7;
            this.ServicePriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Цена:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddServiceButton
            // 
            this.AddServiceButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddServiceButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddServiceButton.BackgroundImage")));
            this.AddServiceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddServiceButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AddServiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddServiceButton.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddServiceButton.Location = new System.Drawing.Point(475, 22);
            this.AddServiceButton.Name = "AddServiceButton";
            this.AddServiceButton.Size = new System.Drawing.Size(53, 43);
            this.AddServiceButton.TabIndex = 5;
            this.AddServiceButton.UseVisualStyleBackColor = false;
            this.AddServiceButton.Click += new System.EventHandler(this.AddServiceButton_Click);
            // 
            // RemoveServiceButton
            // 
            this.RemoveServiceButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RemoveServiceButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveServiceButton.BackgroundImage")));
            this.RemoveServiceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RemoveServiceButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RemoveServiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveServiceButton.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveServiceButton.Location = new System.Drawing.Point(540, 22);
            this.RemoveServiceButton.Name = "RemoveServiceButton";
            this.RemoveServiceButton.Size = new System.Drawing.Size(53, 43);
            this.RemoveServiceButton.TabIndex = 4;
            this.RemoveServiceButton.UseVisualStyleBackColor = false;
            this.RemoveServiceButton.Click += new System.EventHandler(this.RemoveServiceButton_Click);
            // 
            // GetServiceButton
            // 
            this.GetServiceButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GetServiceButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GetServiceButton.BackgroundImage")));
            this.GetServiceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GetServiceButton.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetServiceButton.Location = new System.Drawing.Point(475, 186);
            this.GetServiceButton.Name = "GetServiceButton";
            this.GetServiceButton.Size = new System.Drawing.Size(118, 99);
            this.GetServiceButton.TabIndex = 3;
            this.GetServiceButton.UseVisualStyleBackColor = false;
            this.GetServiceButton.Click += new System.EventHandler(this.GetServiceButton_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceId,
            this.ServiceName,
            this.ServicePrice});
            this.DataGridView1.Location = new System.Drawing.Point(6, 94);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(463, 281);
            this.DataGridView1.TabIndex = 2;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // ServiceId
            // 
            this.ServiceId.HeaderText = "ИД";
            this.ServiceId.Name = "ServiceId";
            this.ServiceId.ReadOnly = true;
            this.ServiceId.Width = 40;
            // 
            // ServiceName
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceName.DefaultCellStyle = dataGridViewCellStyle1;
            this.ServiceName.HeaderText = "Название услуги";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            this.ServiceName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ServiceName.Width = 225;
            // 
            // ServicePrice
            // 
            this.ServicePrice.HeaderText = "Цена услуги";
            this.ServicePrice.Name = "ServicePrice";
            this.ServicePrice.ReadOnly = true;
            this.ServicePrice.Width = 125;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Перечень услуг:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServiceComboBox
            // 
            this.ServiceComboBox.FormattingEnabled = true;
            this.ServiceComboBox.Location = new System.Drawing.Point(165, 26);
            this.ServiceComboBox.Name = "ServiceComboBox";
            this.ServiceComboBox.Size = new System.Drawing.Size(297, 24);
            this.ServiceComboBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FioLabel
            // 
            this.FioLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.FioLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FioLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FioLabel.Location = new System.Drawing.Point(338, 46);
            this.FioLabel.Name = "FioLabel";
            this.FioLabel.Size = new System.Drawing.Size(288, 55);
            this.FioLabel.TabIndex = 4;
            this.FioLabel.Text = "Василий Иванов";
            this.FioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(206, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 55);
            this.label3.TabIndex = 5;
            this.label3.Text = "Данные клиента";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(206, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 55);
            this.label4.TabIndex = 6;
            this.label4.Text = "Личный счёт";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelfCashLabel
            // 
            this.SelfCashLabel.BackColor = System.Drawing.Color.Tan;
            this.SelfCashLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelfCashLabel.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelfCashLabel.Location = new System.Drawing.Point(381, 137);
            this.SelfCashLabel.Name = "SelfCashLabel";
            this.SelfCashLabel.Size = new System.Drawing.Size(200, 55);
            this.SelfCashLabel.TabIndex = 7;
            this.SelfCashLabel.Text = "1000 $";
            this.SelfCashLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelfCashLabel.Click += new System.EventHandler(this.SelfCashLabel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.SelfCashLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.FioLabel);
            this.groupBox2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 395);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Клиент";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1264, 411);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(1280, 450);
            this.MinimumSize = new System.Drawing.Size(1280, 450);
            this.Name = "ClientForm";
            this.Text = "Client Form";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ServiceComboBox;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Button GetServiceButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label FioLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SelfCashLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddServiceButton;
        private System.Windows.Forms.Button RemoveServiceButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ServicePriceLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicePrice;
    }
}