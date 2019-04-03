namespace requete_linq
{
    partial class Form1
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
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.cb_requete = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.tb_resultat = new System.Windows.Forms.RichTextBox();
            this.lblRequete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // cb_requete
            // 
            this.cb_requete.FormattingEnabled = true;
            this.cb_requete.Location = new System.Drawing.Point(22, 23);
            this.cb_requete.Name = "cb_requete";
            this.cb_requete.Size = new System.Drawing.Size(639, 21);
            this.cb_requete.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(713, 21);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // tb_resultat
            // 
            this.tb_resultat.Location = new System.Drawing.Point(22, 64);
            this.tb_resultat.Name = "tb_resultat";
            this.tb_resultat.Size = new System.Drawing.Size(766, 353);
            this.tb_resultat.TabIndex = 2;
            this.tb_resultat.Text = "";
            // 
            // lblRequete
            // 
            this.lblRequete.AutoSize = true;
            this.lblRequete.Location = new System.Drawing.Point(22, 4);
            this.lblRequete.Name = "lblRequete";
            this.lblRequete.Size = new System.Drawing.Size(101, 13);
            this.lblRequete.TabIndex = 3;
            this.lblRequete.Text = "Requête à exécuter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRequete);
            this.Controls.Add(this.tb_resultat);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cb_requete);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.ComboBox cb_requete;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RichTextBox tb_resultat;
        private System.Windows.Forms.Label lblRequete;
    }
}

