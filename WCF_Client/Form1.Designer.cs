namespace WCF_Client
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownEingabe = new System.Windows.Forms.NumericUpDown();
            this.labelGetData = new System.Windows.Forms.Label();
            this.listBoxPause = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEingabe)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownEingabe
            // 
            this.numericUpDownEingabe.Location = new System.Drawing.Point(12, 12);
            this.numericUpDownEingabe.Name = "numericUpDownEingabe";
            this.numericUpDownEingabe.Size = new System.Drawing.Size(63, 20);
            this.numericUpDownEingabe.TabIndex = 0;
            this.numericUpDownEingabe.ValueChanged += new System.EventHandler(this.numericUpDownEingabe_ValueChanged);
            // 
            // labelGetData
            // 
            this.labelGetData.AutoSize = true;
            this.labelGetData.Location = new System.Drawing.Point(9, 35);
            this.labelGetData.Name = "labelGetData";
            this.labelGetData.Size = new System.Drawing.Size(35, 13);
            this.labelGetData.TabIndex = 1;
            this.labelGetData.Text = "label1";
            // 
            // listBoxPause
            // 
            this.listBoxPause.FormattingEnabled = true;
            this.listBoxPause.Location = new System.Drawing.Point(12, 67);
            this.listBoxPause.Name = "listBoxPause";
            this.listBoxPause.Size = new System.Drawing.Size(264, 160);
            this.listBoxPause.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.listBoxPause);
            this.Controls.Add(this.labelGetData);
            this.Controls.Add(this.numericUpDownEingabe);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEingabe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownEingabe;
        private System.Windows.Forms.Label labelGetData;
        private System.Windows.Forms.ListBox listBoxPause;
    }
}

