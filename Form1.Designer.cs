namespace scDecoder
{
    partial class scDecoder
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_Encoded = new System.Windows.Forms.TextBox();
            this.TB_Decoded = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_Encoded
            // 
            this.TB_Encoded.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Encoded.Location = new System.Drawing.Point(30, 12);
            this.TB_Encoded.Multiline = true;
            this.TB_Encoded.Name = "TB_Encoded";
            this.TB_Encoded.Size = new System.Drawing.Size(592, 53);
            this.TB_Encoded.TabIndex = 0;
            this.TB_Encoded.Text = "String to decode";
            // 
            // TB_Decoded
            // 
            this.TB_Decoded.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Decoded.Location = new System.Drawing.Point(30, 77);
            this.TB_Decoded.Multiline = true;
            this.TB_Decoded.Name = "TB_Decoded";
            this.TB_Decoded.Size = new System.Drawing.Size(592, 53);
            this.TB_Decoded.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(30, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(592, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Decode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // scDecoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 228);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TB_Decoded);
            this.Controls.Add(this.TB_Encoded);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "scDecoder";
            this.Text = "scDecoder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Encoded;
        private System.Windows.Forms.TextBox TB_Decoded;
        private System.Windows.Forms.Button button1;
    }
}

