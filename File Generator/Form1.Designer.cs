namespace File_Generator
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.generate_button = new System.Windows.Forms.Button();
            this.unity = new System.Windows.Forms.ComboBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // generate_button
            // 
            this.generate_button.Location = new System.Drawing.Point(123, 12);
            this.generate_button.Name = "generate_button";
            this.generate_button.Size = new System.Drawing.Size(75, 23);
            this.generate_button.TabIndex = 1;
            this.generate_button.Text = "Generate";
            this.generate_button.UseVisualStyleBackColor = true;
            this.generate_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // unity
            // 
            this.unity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unity.FormattingEnabled = true;
            this.unity.Items.AddRange(new object[] {
            "MB",
            "GB",
            "TB"});
            this.unity.Location = new System.Drawing.Point(67, 12);
            this.unity.Name = "unity";
            this.unity.Size = new System.Drawing.Size(50, 21);
            this.unity.TabIndex = 2;
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(12, 12);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(49, 20);
            this.quantity.TabIndex = 3;
            this.quantity.Text = "1";
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 46);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.unity);
            this.Controls.Add(this.generate_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "File Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button generate_button;
        private System.Windows.Forms.ComboBox unity;
        private System.Windows.Forms.TextBox quantity;
    }
}

