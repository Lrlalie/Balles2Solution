namespace Balles2
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pbBalle = new Balles2.Balles2Class();
            this.balles2Class1 = new Balles2.Balles2Class();
            ((System.ComponentModel.ISupportInitialize)(this.pbBalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balles2Class1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBalle
            // 
            this.pbBalle.Image = ((System.Drawing.Image)(resources.GetObject("pbBalle.Image")));
            this.pbBalle.Location = new System.Drawing.Point(385, 218);
            this.pbBalle.Name = "pbBalle";
            this.pbBalle.Size = new System.Drawing.Size(100, 100);
            this.pbBalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbBalle.TabIndex = 0;
            this.pbBalle.TabStop = false;
            // 
            // balles2Class1
            // 
            this.balles2Class1.Image = ((System.Drawing.Image)(resources.GetObject("balles2Class1.Image")));
            this.balles2Class1.Location = new System.Drawing.Point(182, 293);
            this.balles2Class1.Name = "balles2Class1";
            this.balles2Class1.Size = new System.Drawing.Size(100, 100);
            this.balles2Class1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.balles2Class1.TabIndex = 1;
            this.balles2Class1.TabStop = false;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.balles2Class1);
            this.Controls.Add(this.pbBalle);
            this.Name = "form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbBalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balles2Class1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Balles2Class pbBalle;
        private Balles2Class balles2Class1;
    }
}

