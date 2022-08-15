
namespace ProgettoRistorante
{
    partial class VisualizzaTOT
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
            this.tuttiBottone = new System.Windows.Forms.Button();
            this.antipastiBottone = new System.Windows.Forms.Button();
            this.primiBottone = new System.Windows.Forms.Button();
            this.secondiBottone = new System.Windows.Forms.Button();
            this.dessertBottone = new System.Windows.Forms.Button();
            this.risultato = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.indietroButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tuttiBottone
            // 
            this.tuttiBottone.Location = new System.Drawing.Point(69, 121);
            this.tuttiBottone.Name = "tuttiBottone";
            this.tuttiBottone.Size = new System.Drawing.Size(75, 23);
            this.tuttiBottone.TabIndex = 0;
            this.tuttiBottone.Text = "Tutti";
            this.tuttiBottone.UseVisualStyleBackColor = true;
            this.tuttiBottone.Click += new System.EventHandler(this.tuttiBottone_Click);
            // 
            // antipastiBottone
            // 
            this.antipastiBottone.Location = new System.Drawing.Point(207, 121);
            this.antipastiBottone.Name = "antipastiBottone";
            this.antipastiBottone.Size = new System.Drawing.Size(75, 23);
            this.antipastiBottone.TabIndex = 1;
            this.antipastiBottone.Text = "Antipasti";
            this.antipastiBottone.UseVisualStyleBackColor = true;
            this.antipastiBottone.Click += new System.EventHandler(this.antipastiBottone_Click);
            // 
            // primiBottone
            // 
            this.primiBottone.Location = new System.Drawing.Point(347, 121);
            this.primiBottone.Name = "primiBottone";
            this.primiBottone.Size = new System.Drawing.Size(75, 23);
            this.primiBottone.TabIndex = 2;
            this.primiBottone.Text = "Primi";
            this.primiBottone.UseVisualStyleBackColor = true;
            this.primiBottone.Click += new System.EventHandler(this.primiBottone_Click);
            // 
            // secondiBottone
            // 
            this.secondiBottone.Location = new System.Drawing.Point(481, 121);
            this.secondiBottone.Name = "secondiBottone";
            this.secondiBottone.Size = new System.Drawing.Size(75, 23);
            this.secondiBottone.TabIndex = 3;
            this.secondiBottone.Text = "Secondi";
            this.secondiBottone.UseVisualStyleBackColor = true;
            this.secondiBottone.Click += new System.EventHandler(this.secondiBottone_Click);
            // 
            // dessertBottone
            // 
            this.dessertBottone.Location = new System.Drawing.Point(623, 121);
            this.dessertBottone.Name = "dessertBottone";
            this.dessertBottone.Size = new System.Drawing.Size(75, 23);
            this.dessertBottone.TabIndex = 4;
            this.dessertBottone.Text = "Dessert";
            this.dessertBottone.UseVisualStyleBackColor = true;
            this.dessertBottone.Click += new System.EventHandler(this.dessertBottone_Click);
            // 
            // risultato
            // 
            this.risultato.Location = new System.Drawing.Point(309, 198);
            this.risultato.Name = "risultato";
            this.risultato.ReadOnly = true;
            this.risultato.Size = new System.Drawing.Size(157, 179);
            this.risultato.TabIndex = 5;
            this.risultato.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filtri:";
            // 
            // indietroButton
            // 
            this.indietroButton.Location = new System.Drawing.Point(13, 13);
            this.indietroButton.Name = "indietroButton";
            this.indietroButton.Size = new System.Drawing.Size(75, 23);
            this.indietroButton.TabIndex = 7;
            this.indietroButton.Text = "Indietro";
            this.indietroButton.UseVisualStyleBackColor = true;
            this.indietroButton.Click += new System.EventHandler(this.indietroButton_Click);
            // 
            // VisualizzaTOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.indietroButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.risultato);
            this.Controls.Add(this.dessertBottone);
            this.Controls.Add(this.secondiBottone);
            this.Controls.Add(this.primiBottone);
            this.Controls.Add(this.antipastiBottone);
            this.Controls.Add(this.tuttiBottone);
            this.Name = "VisualizzaTOT";
            this.Text = "VisualizzaTOT";
            this.Load += new System.EventHandler(this.VisualizzaTOT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tuttiBottone;
        private System.Windows.Forms.Button antipastiBottone;
        private System.Windows.Forms.Button primiBottone;
        private System.Windows.Forms.Button secondiBottone;
        private System.Windows.Forms.Button dessertBottone;
        private System.Windows.Forms.RichTextBox risultato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button indietroButton;
    }
}