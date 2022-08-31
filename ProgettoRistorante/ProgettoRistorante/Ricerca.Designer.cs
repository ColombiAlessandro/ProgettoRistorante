
namespace ProgettoRistorante
{
    partial class Ricerca
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
            this.label1 = new System.Windows.Forms.Label();
            this.nomePiatto = new System.Windows.Forms.TextBox();
            this.risultatoTextBox = new System.Windows.Forms.RichTextBox();
            this.cercaBottone = new System.Windows.Forms.Button();
            this.indietroButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome piatto:";
            // 
            // nomePiatto
            // 
            this.nomePiatto.Location = new System.Drawing.Point(300, 178);
            this.nomePiatto.Name = "nomePiatto";
            this.nomePiatto.Size = new System.Drawing.Size(100, 20);
            this.nomePiatto.TabIndex = 1;
            // 
            // risultatoTextBox
            // 
            this.risultatoTextBox.Location = new System.Drawing.Point(460, 143);
            this.risultatoTextBox.Name = "risultatoTextBox";
            this.risultatoTextBox.ReadOnly = true;
            this.risultatoTextBox.Size = new System.Drawing.Size(199, 125);
            this.risultatoTextBox.TabIndex = 2;
            this.risultatoTextBox.Text = "";
            this.risultatoTextBox.Visible = false;
            // 
            // cercaBottone
            // 
            this.cercaBottone.Location = new System.Drawing.Point(309, 216);
            this.cercaBottone.Name = "cercaBottone";
            this.cercaBottone.Size = new System.Drawing.Size(75, 23);
            this.cercaBottone.TabIndex = 4;
            this.cercaBottone.Text = "Cerca";
            this.cercaBottone.UseVisualStyleBackColor = true;
            this.cercaBottone.Click += new System.EventHandler(this.button1_Click);
            // 
            // indietroButton
            // 
            this.indietroButton.Location = new System.Drawing.Point(13, 13);
            this.indietroButton.Name = "indietroButton";
            this.indietroButton.Size = new System.Drawing.Size(75, 23);
            this.indietroButton.TabIndex = 5;
            this.indietroButton.Text = "Indietro";
            this.indietroButton.UseVisualStyleBackColor = true;
            this.indietroButton.Click += new System.EventHandler(this.indietroButton_Click);
            // 
            // Ricerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.indietroButton);
            this.Controls.Add(this.cercaBottone);
            this.Controls.Add(this.risultatoTextBox);
            this.Controls.Add(this.nomePiatto);
            this.Controls.Add(this.label1);
            this.Name = "Ricerca";
            this.Text = "Ricerca";
            this.Load += new System.EventHandler(this.Ricerca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomePiatto;
        private System.Windows.Forms.RichTextBox risultatoTextBox;
        private System.Windows.Forms.Button cercaBottone;
        private System.Windows.Forms.Button indietroButton;
    }
}