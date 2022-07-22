
namespace ProgettoRistorante
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
            this.accessoGestore = new System.Windows.Forms.Button();
            this.accessoCliente = new System.Windows.Forms.Button();
            this.accessoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // accessoGestore
            // 
            this.accessoGestore.Location = new System.Drawing.Point(106, 174);
            this.accessoGestore.Name = "accessoGestore";
            this.accessoGestore.Size = new System.Drawing.Size(152, 53);
            this.accessoGestore.TabIndex = 0;
            this.accessoGestore.Text = "Gestore";
            this.accessoGestore.UseVisualStyleBackColor = true;
            this.accessoGestore.Click += new System.EventHandler(this.accessoGestore_Click);
            // 
            // accessoCliente
            // 
            this.accessoCliente.Location = new System.Drawing.Point(499, 174);
            this.accessoCliente.Name = "accessoCliente";
            this.accessoCliente.Size = new System.Drawing.Size(152, 53);
            this.accessoCliente.TabIndex = 1;
            this.accessoCliente.Text = "Cliente";
            this.accessoCliente.UseVisualStyleBackColor = true;
            this.accessoCliente.Click += new System.EventHandler(this.accessoCliente_Click);
            // 
            // accessoLabel
            // 
            this.accessoLabel.AutoSize = true;
            this.accessoLabel.Location = new System.Drawing.Point(349, 107);
            this.accessoLabel.Name = "accessoLabel";
            this.accessoLabel.Size = new System.Drawing.Size(48, 13);
            this.accessoLabel.TabIndex = 2;
            this.accessoLabel.Text = "Accesso";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.accessoLabel);
            this.Controls.Add(this.accessoCliente);
            this.Controls.Add(this.accessoGestore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accessoGestore;
        private System.Windows.Forms.Button accessoCliente;
        private System.Windows.Forms.Label accessoLabel;
    }
}

