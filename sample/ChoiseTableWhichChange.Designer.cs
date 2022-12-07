namespace sample
{
    partial class ChoiseTableWhichChange
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
            this.buttonChoise = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonChoise
            // 
            this.buttonChoise.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.buttonChoise.Location = new System.Drawing.Point(12, 57);
            this.buttonChoise.Name = "buttonChoise";
            this.buttonChoise.Size = new System.Drawing.Size(130, 40);
            this.buttonChoise.TabIndex = 0;
            this.buttonChoise.Text = "Выбрать";
            this.buttonChoise.UseVisualStyleBackColor = true;
            this.buttonChoise.Click += new System.EventHandler(this.buttonChoise_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.buttonExit.Location = new System.Drawing.Point(12, 103);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(130, 40);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Location = new System.Drawing.Point(12, 12);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(130, 39);
            this.comboBoxTables.TabIndex = 1;
            // 
            // ChoiseTableWhichChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 160);
            this.Controls.Add(this.comboBoxTables);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonChoise);
            this.Name = "ChoiseTableWhichChange";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChoise;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ComboBox comboBoxTables;
    }
}