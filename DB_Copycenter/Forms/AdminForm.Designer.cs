
namespace DB_Copycenter.Forms
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RefreshInventoryButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.InventoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateWorkerButton = new System.Windows.Forms.Button();
            this.UpdateInventoryButton = new System.Windows.Forms.Button();
            this.DeleteWorkerButton = new System.Windows.Forms.Button();
            this.AddWorkerButton = new System.Windows.Forms.Button();
            this.DeleteInventoryButton = new System.Windows.Forms.Button();
            this.AddInventoryButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.WorkExperienceLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FioLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkerFIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkerPositionAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkerWorkExperienceAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkerSalaryAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RefreshInventoryButton);
            this.groupBox4.Controls.Add(this.RefreshButton);
            this.groupBox4.Controls.Add(this.dataGridView);
            this.groupBox4.Controls.Add(this.UpdateWorkerButton);
            this.groupBox4.Controls.Add(this.UpdateInventoryButton);
            this.groupBox4.Controls.Add(this.DeleteWorkerButton);
            this.groupBox4.Controls.Add(this.AddWorkerButton);
            this.groupBox4.Controls.Add(this.DeleteInventoryButton);
            this.groupBox4.Controls.Add(this.AddInventoryButton);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(787, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(785, 537);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Панель Админа";
            // 
            // RefreshInventoryButton
            // 
            this.RefreshInventoryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshInventoryButton.BackgroundImage")));
            this.RefreshInventoryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshInventoryButton.Location = new System.Drawing.Point(734, 19);
            this.RefreshInventoryButton.Name = "RefreshInventoryButton";
            this.RefreshInventoryButton.Size = new System.Drawing.Size(45, 38);
            this.RefreshInventoryButton.TabIndex = 29;
            this.RefreshInventoryButton.UseVisualStyleBackColor = true;
            this.RefreshInventoryButton.Click += new System.EventHandler(this.RefreshInventoryButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshButton.BackgroundImage")));
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshButton.Location = new System.Drawing.Point(734, 261);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(45, 38);
            this.RefreshButton.TabIndex = 28;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InventoryID,
            this.InventoryName,
            this.InventoryQuantity,
            this.InventoryCost});
            this.dataGridView.Location = new System.Drawing.Point(11, 45);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(542, 210);
            this.dataGridView.TabIndex = 23;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // InventoryID
            // 
            this.InventoryID.HeaderText = "ИД";
            this.InventoryID.Name = "InventoryID";
            this.InventoryID.ReadOnly = true;
            this.InventoryID.Width = 50;
            // 
            // InventoryName
            // 
            this.InventoryName.HeaderText = "Название инвентаря";
            this.InventoryName.Name = "InventoryName";
            this.InventoryName.Width = 200;
            // 
            // InventoryQuantity
            // 
            this.InventoryQuantity.HeaderText = "Кол-во";
            this.InventoryQuantity.Name = "InventoryQuantity";
            this.InventoryQuantity.Width = 65;
            // 
            // InventoryCost
            // 
            this.InventoryCost.HeaderText = "Стоимость за ед.";
            this.InventoryCost.Name = "InventoryCost";
            this.InventoryCost.Width = 150;
            // 
            // UpdateWorkerButton
            // 
            this.UpdateWorkerButton.Location = new System.Drawing.Point(677, 386);
            this.UpdateWorkerButton.Name = "UpdateWorkerButton";
            this.UpdateWorkerButton.Size = new System.Drawing.Size(84, 44);
            this.UpdateWorkerButton.TabIndex = 27;
            this.UpdateWorkerButton.Text = "Редактировать";
            this.UpdateWorkerButton.UseVisualStyleBackColor = true;
            this.UpdateWorkerButton.Click += new System.EventHandler(this.UpdateWorkerButton_Click);
            // 
            // UpdateInventoryButton
            // 
            this.UpdateInventoryButton.Location = new System.Drawing.Point(571, 114);
            this.UpdateInventoryButton.Name = "UpdateInventoryButton";
            this.UpdateInventoryButton.Size = new System.Drawing.Size(84, 44);
            this.UpdateInventoryButton.TabIndex = 26;
            this.UpdateInventoryButton.Text = "Редактировать";
            this.UpdateInventoryButton.UseVisualStyleBackColor = true;
            this.UpdateInventoryButton.Click += new System.EventHandler(this.UpdateInventoryButton_Click);
            // 
            // DeleteWorkerButton
            // 
            this.DeleteWorkerButton.Location = new System.Drawing.Point(677, 458);
            this.DeleteWorkerButton.Name = "DeleteWorkerButton";
            this.DeleteWorkerButton.Size = new System.Drawing.Size(84, 35);
            this.DeleteWorkerButton.TabIndex = 19;
            this.DeleteWorkerButton.Text = "Удалить";
            this.DeleteWorkerButton.UseVisualStyleBackColor = true;
            this.DeleteWorkerButton.Click += new System.EventHandler(this.DeleteWorkerButton_Click);
            // 
            // AddWorkerButton
            // 
            this.AddWorkerButton.Location = new System.Drawing.Point(677, 319);
            this.AddWorkerButton.Name = "AddWorkerButton";
            this.AddWorkerButton.Size = new System.Drawing.Size(84, 35);
            this.AddWorkerButton.TabIndex = 18;
            this.AddWorkerButton.Text = "Добавить";
            this.AddWorkerButton.UseVisualStyleBackColor = true;
            this.AddWorkerButton.Click += new System.EventHandler(this.AddWorkerButton_Click);
            // 
            // DeleteInventoryButton
            // 
            this.DeleteInventoryButton.Location = new System.Drawing.Point(571, 194);
            this.DeleteInventoryButton.Name = "DeleteInventoryButton";
            this.DeleteInventoryButton.Size = new System.Drawing.Size(84, 35);
            this.DeleteInventoryButton.TabIndex = 17;
            this.DeleteInventoryButton.Text = "Удалить";
            this.DeleteInventoryButton.UseVisualStyleBackColor = true;
            this.DeleteInventoryButton.Click += new System.EventHandler(this.DeleteInventoryButton_Click);
            // 
            // AddInventoryButton
            // 
            this.AddInventoryButton.Location = new System.Drawing.Point(571, 45);
            this.AddInventoryButton.Name = "AddInventoryButton";
            this.AddInventoryButton.Size = new System.Drawing.Size(84, 35);
            this.AddInventoryButton.TabIndex = 16;
            this.AddInventoryButton.Text = "Добавить";
            this.AddInventoryButton.UseVisualStyleBackColor = true;
            this.AddInventoryButton.Click += new System.EventHandler(this.AddInventoryButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.WorkerFIO,
            this.WorkerPositionAdmin,
            this.WorkerWorkExperienceAdmin,
            this.WorkerSalaryAdmin});
            this.dataGridView1.Location = new System.Drawing.Point(6, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 244);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(6, 261);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 23);
            this.label11.TabIndex = 14;
            this.label11.Text = "Список пользователей";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "Список инвентаря";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.WorkExperienceLabel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.SalaryLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.PositionLabel);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.FioLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(769, 537);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Окно Админа";
            // 
            // WorkExperienceLabel
            // 
            this.WorkExperienceLabel.BackColor = System.Drawing.Color.Bisque;
            this.WorkExperienceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WorkExperienceLabel.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkExperienceLabel.Location = new System.Drawing.Point(351, 219);
            this.WorkExperienceLabel.Name = "WorkExperienceLabel";
            this.WorkExperienceLabel.Size = new System.Drawing.Size(164, 29);
            this.WorkExperienceLabel.TabIndex = 13;
            this.WorkExperienceLabel.Text = "1 год";
            this.WorkExperienceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(347, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Стаж работы";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.BackColor = System.Drawing.Color.DarkOrange;
            this.SalaryLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalaryLabel.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SalaryLabel.Location = new System.Drawing.Point(331, 158);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(203, 29);
            this.SalaryLabel.TabIndex = 11;
            this.SalaryLabel.Text = "1500 $";
            this.SalaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(347, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Зарплата";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PositionLabel
            // 
            this.PositionLabel.BackColor = System.Drawing.Color.LightGray;
            this.PositionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PositionLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionLabel.Location = new System.Drawing.Point(288, 97);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(288, 29);
            this.PositionLabel.TabIndex = 9;
            this.PositionLabel.Text = "Администратор";
            this.PositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(347, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Должность";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FioLabel
            // 
            this.FioLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.FioLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FioLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FioLabel.Location = new System.Drawing.Point(288, 36);
            this.FioLabel.Name = "FioLabel";
            this.FioLabel.Size = new System.Drawing.Size(288, 29);
            this.FioLabel.TabIndex = 7;
            this.FioLabel.Text = "Виталий Громяко";
            this.FioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(347, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пользователь";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(35, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // UserID
            // 
            this.UserID.HeaderText = "ИД";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Width = 50;
            // 
            // WorkerFIO
            // 
            this.WorkerFIO.HeaderText = "ФИО Работника";
            this.WorkerFIO.Name = "WorkerFIO";
            this.WorkerFIO.ReadOnly = true;
            this.WorkerFIO.Width = 225;
            // 
            // WorkerPositionAdmin
            // 
            this.WorkerPositionAdmin.HeaderText = "Должность";
            this.WorkerPositionAdmin.Name = "WorkerPositionAdmin";
            this.WorkerPositionAdmin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.WorkerPositionAdmin.Width = 125;
            // 
            // WorkerWorkExperienceAdmin
            // 
            this.WorkerWorkExperienceAdmin.HeaderText = "Стаж работы";
            this.WorkerWorkExperienceAdmin.Name = "WorkerWorkExperienceAdmin";
            this.WorkerWorkExperienceAdmin.Width = 75;
            // 
            // WorkerSalaryAdmin
            // 
            this.WorkerSalaryAdmin.HeaderText = "Зарплата";
            this.WorkerSalaryAdmin.Name = "WorkerSalaryAdmin";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1584, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.MaximumSize = new System.Drawing.Size(1600, 600);
            this.MinimumSize = new System.Drawing.Size(1600, 600);
            this.Name = "AdminForm";
            this.Text = "Admin Form";
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button UpdateWorkerButton;
        private System.Windows.Forms.Button UpdateInventoryButton;
        private System.Windows.Forms.Button DeleteWorkerButton;
        private System.Windows.Forms.Button AddWorkerButton;
        private System.Windows.Forms.Button DeleteInventoryButton;
        private System.Windows.Forms.Button AddInventoryButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label WorkExperienceLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FioLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button RefreshInventoryButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkerFIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkerPositionAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkerWorkExperienceAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkerSalaryAdmin;
    }
}