namespace sample
{
    partial class Main
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObjectType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OS_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationMap_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HVID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interfaces_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAC_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Date_ON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Installed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonNewWrite = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTemplate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ObjectName,
            this.ObjectType,
            this.OS_id,
            this.LocationRoom,
            this.LocationMap_id,
            this.LocationX,
            this.LocationY,
            this.Last_ip,
            this.HVID,
            this.Interfaces_id,
            this.MAC_Address,
            this.Last_Date_ON,
            this.Responsible,
            this.Installed});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1544, 252);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // ObjectName
            // 
            this.ObjectName.HeaderText = "Имя объекта";
            this.ObjectName.Name = "ObjectName";
            // 
            // ObjectType
            // 
            this.ObjectType.HeaderText = "Тип объекта";
            this.ObjectType.Name = "ObjectType";
            // 
            // OS_id
            // 
            this.OS_id.HeaderText = "OS";
            this.OS_id.Name = "OS_id";
            // 
            // LocationRoom
            // 
            this.LocationRoom.HeaderText = "Кабинет";
            this.LocationRoom.Name = "LocationRoom";
            // 
            // LocationMap_id
            // 
            this.LocationMap_id.HeaderText = "Номер чертежа";
            this.LocationMap_id.Name = "LocationMap_id";
            // 
            // LocationX
            // 
            this.LocationX.HeaderText = "X";
            this.LocationX.Name = "LocationX";
            // 
            // LocationY
            // 
            this.LocationY.HeaderText = "Y";
            this.LocationY.Name = "LocationY";
            // 
            // Last_ip
            // 
            this.Last_ip.HeaderText = "IP";
            this.Last_ip.Name = "Last_ip";
            // 
            // HVID
            // 
            this.HVID.HeaderText = "HVID";
            this.HVID.Name = "HVID";
            // 
            // Interfaces_id
            // 
            this.Interfaces_id.HeaderText = "Интерфейс";
            this.Interfaces_id.Name = "Interfaces_id";
            // 
            // MAC_Address
            // 
            this.MAC_Address.HeaderText = "MAC";
            this.MAC_Address.Name = "MAC_Address";
            // 
            // Last_Date_ON
            // 
            this.Last_Date_ON.HeaderText = "Последнее включение";
            this.Last_Date_ON.Name = "Last_Date_ON";
            // 
            // Responsible
            // 
            this.Responsible.HeaderText = "Ответственный";
            this.Responsible.Name = "Responsible";
            // 
            // Installed
            // 
            this.Installed.HeaderText = "Инженер";
            this.Installed.Name = "Installed";
            // 
            // buttonNewWrite
            // 
            this.buttonNewWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonNewWrite.Location = new System.Drawing.Point(12, 271);
            this.buttonNewWrite.Name = "buttonNewWrite";
            this.buttonNewWrite.Size = new System.Drawing.Size(108, 37);
            this.buttonNewWrite.TabIndex = 1;
            this.buttonNewWrite.Text = "Новая запись";
            this.buttonNewWrite.UseVisualStyleBackColor = true;
            this.buttonNewWrite.Click += new System.EventHandler(this.buttonNewWrite_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonRefresh.Location = new System.Drawing.Point(1694, 38);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(108, 37);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.textBoxSearch.Location = new System.Drawing.Point(1568, 38);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(120, 37);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(1563, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Поиск";
            // 
            // buttonTemplate
            // 
            this.buttonTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonTemplate.Location = new System.Drawing.Point(12, 314);
            this.buttonTemplate.Name = "buttonTemplate";
            this.buttonTemplate.Size = new System.Drawing.Size(108, 37);
            this.buttonTemplate.TabIndex = 1;
            this.buttonTemplate.Text = "Шаблоны";
            this.buttonTemplate.UseVisualStyleBackColor = true;
            this.buttonTemplate.Click += new System.EventHandler(this.buttonTemplate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonDelete.Location = new System.Drawing.Point(12, 357);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(108, 37);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1862, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonTemplate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNewWrite);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonNewWrite;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTemplate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectType;
        private System.Windows.Forms.DataGridViewTextBoxColumn OS_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationMap_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationX;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn HVID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interfaces_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAC_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Date_ON;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsible;
        private System.Windows.Forms.DataGridViewTextBoxColumn Installed;
    }
}

