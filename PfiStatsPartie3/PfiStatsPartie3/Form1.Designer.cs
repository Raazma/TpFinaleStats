namespace PfiStatsPartie3
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
            this.Btn_Calculate = new System.Windows.Forms.Button();
            this.Cb_Fonction = new System.Windows.Forms.ComboBox();
            this.Fonctionimous = new System.Windows.Forms.Label();
            this.X_Max = new System.Windows.Forms.TextBox();
            this.X_min = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Rep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Calculate
            // 
            this.Btn_Calculate.Location = new System.Drawing.Point(71, 121);
            this.Btn_Calculate.Name = "Btn_Calculate";
            this.Btn_Calculate.Size = new System.Drawing.Size(117, 47);
            this.Btn_Calculate.TabIndex = 0;
            this.Btn_Calculate.Text = "Calculatation";
            this.Btn_Calculate.UseVisualStyleBackColor = true;
            this.Btn_Calculate.Click += new System.EventHandler(this.Btn_Calculate_Click);
            // 
            // Cb_Fonction
            // 
            this.Cb_Fonction.FormattingEnabled = true;
            this.Cb_Fonction.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5"});
            this.Cb_Fonction.Location = new System.Drawing.Point(12, 52);
            this.Cb_Fonction.Name = "Cb_Fonction";
            this.Cb_Fonction.Size = new System.Drawing.Size(121, 21);
            this.Cb_Fonction.TabIndex = 1;
            // 
            // Fonctionimous
            // 
            this.Fonctionimous.AutoSize = true;
            this.Fonctionimous.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fonctionimous.Location = new System.Drawing.Point(12, 33);
            this.Fonctionimous.Name = "Fonctionimous";
            this.Fonctionimous.Size = new System.Drawing.Size(108, 16);
            this.Fonctionimous.TabIndex = 2;
            this.Fonctionimous.Text = "Fonctionimous";
            // 
            // X_Max
            // 
            this.X_Max.Location = new System.Drawing.Point(322, 43);
            this.X_Max.Name = "X_Max";
            this.X_Max.Size = new System.Drawing.Size(38, 20);
            this.X_Max.TabIndex = 3;
            // 
            // X_min
            // 
            this.X_min.Location = new System.Drawing.Point(213, 43);
            this.X_min.Name = "X_min";
            this.X_min.Size = new System.Drawing.Size(34, 20);
            this.X_min.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "x min:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "x max:";
            // 
            // Rep
            // 
            this.Rep.Location = new System.Drawing.Point(286, 131);
            this.Rep.Name = "Rep";
            this.Rep.Size = new System.Drawing.Size(70, 20);
            this.Rep.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rep:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 297);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Rep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.X_min);
            this.Controls.Add(this.X_Max);
            this.Controls.Add(this.Fonctionimous);
            this.Controls.Add(this.Cb_Fonction);
            this.Controls.Add(this.Btn_Calculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "ThatCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Calculate;
        private System.Windows.Forms.ComboBox Cb_Fonction;
        private System.Windows.Forms.Label Fonctionimous;
        private System.Windows.Forms.TextBox X_Max;
        private System.Windows.Forms.TextBox X_min;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Rep;
        private System.Windows.Forms.Label label3;
    }
}

