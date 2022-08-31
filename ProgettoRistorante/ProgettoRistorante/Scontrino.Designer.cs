
namespace ProgettoRistorante
{
    partial class Scontrino
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
            this.scontrinoBox = new System.Windows.Forms.RichTextBox();
            this.PrezzoBox = new System.Windows.Forms.TextBox();
            this.dettagliButton = new System.Windows.Forms.Button();
            this.indietroDettagli = new System.Windows.Forms.Button();
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
            // scontrinoBox
            // 
            this.scontrinoBox.Location = new System.Drawing.Point(287, 94);
            this.scontrinoBox.Name = "scontrinoBox";
            this.scontrinoBox.ReadOnly = true;
            this.scontrinoBox.Size = new System.Drawing.Size(149, 226);
            this.scontrinoBox.TabIndex = 1;
            this.scontrinoBox.Text = "";
            // 
            // PrezzoBox
            // 
            this.PrezzoBox.Location = new System.Drawing.Point(287, 326);
            this.PrezzoBox.Name = "PrezzoBox";
            this.PrezzoBox.ReadOnly = true;
            this.PrezzoBox.Size = new System.Drawing.Size(149, 20);
            this.PrezzoBox.TabIndex = 2;
            // 
            // dettagliButton
            // 
            this.dettagliButton.Location = new System.Drawing.Point(321, 352);
            this.dettagliButton.Name = "dettagliButton";
            this.dettagliButton.Size = new System.Drawing.Size(85, 23);
            this.dettagliButton.TabIndex = 3;
            this.dettagliButton.Text = "Dettagli piatti";
            this.dettagliButton.UseVisualStyleBackColor = true;
            this.dettagliButton.Click += new System.EventHandler(this.dettagliButton_Click);
            // 
            // indietroDettagli
            // 
            this.indietroDettagli.Location = new System.Drawing.Point(321, 381);
            this.indietroDettagli.Name = "indietroDettagli";
            this.indietroDettagli.Size = new System.Drawing.Size(85, 23);
            this.indietroDettagli.TabIndex = 4;
            this.indietroDettagli.Text = "Indietro";
            this.indietroDettagli.UseVisualStyleBackColor = true;
            this.indietroDettagli.Visible = false;
            this.indietroDettagli.Click += new System.EventHandler(this.indietroDettagli_Click);
            // 
            // Scontrino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.indietroDettagli);
            this.Controls.Add(this.dettagliButton);
            this.Controls.Add(this.PrezzoBox);
            this.Controls.Add(this.scontrinoBox);
            this.Controls.Add(this.indietroButton);
            this.Name = "Scontrino";
            this.Text = "Scontrino";
            this.Load += new System.EventHandler(this.Scontrino_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button indietroButton;
        private System.Windows.Forms.RichTextBox scontrinoBox;
        private System.Windows.Forms.TextBox PrezzoBox;
        private System.Windows.Forms.Button dettagliButton;
        private System.Windows.Forms.Button indietroDettagli;
    }
}