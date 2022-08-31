
namespace ProgettoRistorante
{
    partial class EliminaCliente
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
            this.nomiBox = new System.Windows.Forms.ComboBox();
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
            this.indietroButton.Click += new System.EventHandler(this.indietroButton_Click);
            // 
            // nomiBox
            // 
            this.nomiBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nomiBox.FormattingEnabled = true;
            this.nomiBox.Location = new System.Drawing.Point(299, 164);
            this.nomiBox.Name = "nomiBox";
            this.nomiBox.Size = new System.Drawing.Size(121, 21);
            this.nomiBox.TabIndex = 1;
            // 
            // confermaButton
            // 
            this.confermaButton.Location = new System.Drawing.Point(322, 303);
            this.confermaButton.Name = "confermaButton";
            this.confermaButton.Size = new System.Drawing.Size(75, 23);
            this.confermaButton.TabIndex = 2;
            this.confermaButton.Text = "Conferma";
            this.confermaButton.UseVisualStyleBackColor = true;
            this.confermaButton.Click += new System.EventHandler(this.confermaButton_Click);
            // 
            // EliminaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confermaButton);
            this.Controls.Add(this.nomiBox);
            this.Controls.Add(this.indietroButton);
            this.Name = "EliminaCliente";
            this.Text = "EliminaCliente";
            this.Load += new System.EventHandler(this.EliminaCliente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button indietroButton;
        private System.Windows.Forms.ComboBox nomiBox;
        private System.Windows.Forms.Button confermaButton;
    }
}