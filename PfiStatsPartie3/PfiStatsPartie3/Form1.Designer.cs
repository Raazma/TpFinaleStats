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
            this.Tb_IntervalMin = new System.Windows.Forms.TextBox();
            this.Tb_IntervalMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Tb_MargeErreur = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Tb_prob = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Calculate
            // 
            this.Btn_Calculate.Location = new System.Drawing.Point(253, 138);
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
            this.X_Max.Location = new System.Drawing.Point(295, 53);
            this.X_Max.Name = "X_Max";
            this.X_Max.Size = new System.Drawing.Size(38, 20);
            this.X_Max.TabIndex = 3;
            this.X_Max.TextChanged += new System.EventHandler(this.X_Max_TextChanged);
            // 
            // X_min
            // 
            this.X_min.Location = new System.Drawing.Point(193, 52);
            this.X_min.Name = "X_min";
            this.X_min.Size = new System.Drawing.Size(34, 20);
            this.X_min.TabIndex = 4;
            this.X_min.TextChanged += new System.EventHandler(this.X_min_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "b:";
            // 
            // Rep
            // 
            this.Rep.Location = new System.Drawing.Point(125, 117);
            this.Rep.Name = "Rep";
            this.Rep.Size = new System.Drawing.Size(70, 20);
            this.Rep.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Air sous la courbe:";
            // 
            // Tb_IntervalMin
            // 
            this.Tb_IntervalMin.Location = new System.Drawing.Point(125, 143);
            this.Tb_IntervalMin.Name = "Tb_IntervalMin";
            this.Tb_IntervalMin.Size = new System.Drawing.Size(70, 20);
            this.Tb_IntervalMin.TabIndex = 11;
            // 
            // Tb_IntervalMax
            // 
            this.Tb_IntervalMax.Location = new System.Drawing.Point(125, 169);
            this.Tb_IntervalMax.Name = "Tb_IntervalMax";
            this.Tb_IntervalMax.Size = new System.Drawing.Size(70, 20);
            this.Tb_IntervalMax.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Interval Min :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Interval Max :";
            // 
            // Tb_MargeErreur
            // 
            this.Tb_MargeErreur.Location = new System.Drawing.Point(125, 195);
            this.Tb_MargeErreur.Name = "Tb_MargeErreur";
            this.Tb_MargeErreur.Size = new System.Drawing.Size(70, 20);
            this.Tb_MargeErreur.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Marge d\'erreur :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Probabilité:";
            // 
            // Tb_prob
            // 
            this.Tb_prob.Location = new System.Drawing.Point(126, 224);
            this.Tb_prob.Name = "Tb_prob";
            this.Tb_prob.Size = new System.Drawing.Size(70, 20);
            this.Tb_prob.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 297);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Tb_prob);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Tb_MargeErreur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tb_IntervalMax);
            this.Controls.Add(this.Tb_IntervalMin);
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
		private System.Windows.Forms.TextBox Tb_IntervalMin;
		private System.Windows.Forms.TextBox Tb_IntervalMax;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox Tb_MargeErreur;
		private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Tb_prob;
    }
}

