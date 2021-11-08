namespace tic_tac_toe
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
            this.dessinLigne = new System.Windows.Forms.Panel();
            this.BD = new System.Windows.Forms.Panel();
            this.MD = new System.Windows.Forms.Panel();
            this.BM = new System.Windows.Forms.Panel();
            this.HD = new System.Windows.Forms.Panel();
            this.BG = new System.Windows.Forms.Panel();
            this.MM = new System.Windows.Forms.Panel();
            this.MG = new System.Windows.Forms.Panel();
            this.HM = new System.Windows.Forms.Panel();
            this.HG = new System.Windows.Forms.Panel();
            this.dessinLigne.SuspendLayout();
            this.SuspendLayout();
            // 
            // dessinLigne
            // 
            this.dessinLigne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dessinLigne.BackColor = System.Drawing.Color.White;
            this.dessinLigne.Controls.Add(this.BD);
            this.dessinLigne.Controls.Add(this.MD);
            this.dessinLigne.Controls.Add(this.BM);
            this.dessinLigne.Controls.Add(this.HD);
            this.dessinLigne.Controls.Add(this.BG);
            this.dessinLigne.Controls.Add(this.MM);
            this.dessinLigne.Controls.Add(this.MG);
            this.dessinLigne.Controls.Add(this.HM);
            this.dessinLigne.Controls.Add(this.HG);
            this.dessinLigne.Location = new System.Drawing.Point(0, 0);
            this.dessinLigne.Name = "dessinLigne";
            this.dessinLigne.Size = new System.Drawing.Size(584, 562);
            this.dessinLigne.TabIndex = 0;
            this.dessinLigne.Paint += new System.Windows.Forms.PaintEventHandler(this.dessinLigne_Paint);
            // 
            // BD
            // 
            this.BD.BackColor = System.Drawing.Color.White;
            this.BD.Location = new System.Drawing.Point(384, 387);
            this.BD.Name = "BD";
            this.BD.Size = new System.Drawing.Size(190, 175);
            this.BD.TabIndex = 5;
            this.BD.Click += new System.EventHandler(this.BD_Click);
            // 
            // MD
            // 
            this.MD.BackColor = System.Drawing.Color.White;
            this.MD.Location = new System.Drawing.Point(384, 193);
            this.MD.Name = "MD";
            this.MD.Size = new System.Drawing.Size(190, 175);
            this.MD.TabIndex = 5;
            this.MD.Click += new System.EventHandler(this.MD_Click);
            // 
            // BM
            // 
            this.BM.BackColor = System.Drawing.Color.White;
            this.BM.Location = new System.Drawing.Point(180, 387);
            this.BM.Name = "BM";
            this.BM.Size = new System.Drawing.Size(190, 175);
            this.BM.TabIndex = 4;
            this.BM.Click += new System.EventHandler(this.BM_Click);
            // 
            // HD
            // 
            this.HD.BackColor = System.Drawing.Color.White;
            this.HD.Location = new System.Drawing.Point(384, 0);
            this.HD.Name = "HD";
            this.HD.Size = new System.Drawing.Size(190, 175);
            this.HD.TabIndex = 2;
            this.HD.Click += new System.EventHandler(this.HD_Click);
            // 
            // BG
            // 
            this.BG.BackColor = System.Drawing.Color.White;
            this.BG.Location = new System.Drawing.Point(0, 387);
            this.BG.Name = "BG";
            this.BG.Size = new System.Drawing.Size(175, 175);
            this.BG.TabIndex = 3;
            this.BG.Click += new System.EventHandler(this.BG_Click);
            // 
            // MM
            // 
            this.MM.BackColor = System.Drawing.Color.White;
            this.MM.Location = new System.Drawing.Point(180, 193);
            this.MM.Name = "MM";
            this.MM.Size = new System.Drawing.Size(190, 175);
            this.MM.TabIndex = 4;
            this.MM.Click += new System.EventHandler(this.MM_Click);
            // 
            // MG
            // 
            this.MG.BackColor = System.Drawing.Color.White;
            this.MG.Location = new System.Drawing.Point(0, 193);
            this.MG.Name = "MG";
            this.MG.Size = new System.Drawing.Size(175, 175);
            this.MG.TabIndex = 3;
            this.MG.Click += new System.EventHandler(this.MG_Click);
            // 
            // HM
            // 
            this.HM.BackColor = System.Drawing.Color.White;
            this.HM.Location = new System.Drawing.Point(180, 0);
            this.HM.Name = "HM";
            this.HM.Size = new System.Drawing.Size(190, 175);
            this.HM.TabIndex = 1;
            this.HM.Click += new System.EventHandler(this.HM_Click);
            // 
            // HG
            // 
            this.HG.BackColor = System.Drawing.Color.White;
            this.HG.Location = new System.Drawing.Point(0, 0);
            this.HG.Name = "HG";
            this.HG.Size = new System.Drawing.Size(175, 175);
            this.HG.TabIndex = 0;
            this.HG.Click += new System.EventHandler(this.HG_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.dessinLigne);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.dessinLigne.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dessinLigne;
        private System.Windows.Forms.Panel HG;
        private System.Windows.Forms.Panel HD;
        private System.Windows.Forms.Panel HM;
        private System.Windows.Forms.Panel BD;
        private System.Windows.Forms.Panel MD;
        private System.Windows.Forms.Panel BM;
        private System.Windows.Forms.Panel BG;
        private System.Windows.Forms.Panel MM;
        private System.Windows.Forms.Panel MG;
    }
}

