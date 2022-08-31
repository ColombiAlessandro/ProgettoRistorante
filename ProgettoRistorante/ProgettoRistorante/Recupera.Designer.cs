
namespace ProgettoRistorante
{
    partial class Recupera
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
            this.indietroButton = new System.Windows.Forms.Button();
            this.piattiBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.confermaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // indietroButton
            // 
            this.indietroButton.Location = new System.Drawing.Point(13, 13);
            this.indietroButton.Name = "indietroButton";
            this.indietroButton.Size = new System.Drawing.Size(75, 23);
            this.indietroButton.TabIndex = 0;
            this.indietroButton.Text = "Indietro";
            this.indietroButton.UseVisualStyleBackColor = true;
            // 
            // piattiBox
            // 
            this.piattiBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.piattiBox.FormattingEnabled = true;
            this.piattiBox.Location = new System.Drawing.Point(290, 218);
            this.piattiBox.Name = "piattiBox";
            this.piattiBox.Size = new System.Drawing.Size(121, 21);
            this.piattiBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Piatto da recuperare";
            // 
            // confermaButton
            // 
            this.confermaButton.Location = new System.Drawing.Point(313, 282);
            this.confermaButton.Name = "confermaButton";
            this.confermaButton.Size = new System.Drawing.Size(75, 23);
            this.confermaButton.TabIndex = 3;
            this.confermaButton.Text = "Conferma";
            this.confermaButton.UseVisualStyleBackColor = true;
            this.confermaButton.Click += new System.EventHandler(this.confermaButton_Click);
            // 
            // Recupera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confermaButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.piattiBox);
            this.Controls.Add(this.indietroButton);
            this.Name = "Recupera";
            this.Text = "Recupera";
            this.Load += new System.EventHandler(this.Recupera_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button indietroButton;
        private System.Windows.Forms.ComboBox piattiBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confermaButton;
    }
}