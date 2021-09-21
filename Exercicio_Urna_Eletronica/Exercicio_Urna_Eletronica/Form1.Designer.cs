
namespace Exercicio_Urna_Eletronica
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCandA = new System.Windows.Forms.Button();
            this.btnCandB = new System.Windows.Forms.Button();
            this.btnCandC = new System.Windows.Forms.Button();
            this.btnCandD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblVotosA = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblVotosB = new System.Windows.Forms.Label();
            this.lblVotosC = new System.Windows.Forms.Label();
            this.lblVotosD = new System.Windows.Forms.Label();
            this.lblPorD = new System.Windows.Forms.Label();
            this.lblPorC = new System.Windows.Forms.Label();
            this.lblPorB = new System.Windows.Forms.Label();
            this.lblPorA = new System.Windows.Forms.Label();
            this.lblVencedor = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // btnCandA
            // 
            this.btnCandA.Location = new System.Drawing.Point(12, 62);
            this.btnCandA.Name = "btnCandA";
            this.btnCandA.Size = new System.Drawing.Size(75, 23);
            this.btnCandA.TabIndex = 0;
            this.btnCandA.Text = "Votar";
            this.btnCandA.UseVisualStyleBackColor = true;
            this.btnCandA.Click += new System.EventHandler(this.btnCandA_Click);
            // 
            // btnCandB
            // 
            this.btnCandB.Location = new System.Drawing.Point(112, 62);
            this.btnCandB.Name = "btnCandB";
            this.btnCandB.Size = new System.Drawing.Size(75, 23);
            this.btnCandB.TabIndex = 1;
            this.btnCandB.Text = "Votar";
            this.btnCandB.UseVisualStyleBackColor = true;
            this.btnCandB.Click += new System.EventHandler(this.btnCandB_Click);
            // 
            // btnCandC
            // 
            this.btnCandC.Location = new System.Drawing.Point(211, 62);
            this.btnCandC.Name = "btnCandC";
            this.btnCandC.Size = new System.Drawing.Size(75, 23);
            this.btnCandC.TabIndex = 2;
            this.btnCandC.Text = "Votar";
            this.btnCandC.UseVisualStyleBackColor = true;
            this.btnCandC.Click += new System.EventHandler(this.btnCandC_Click);
            // 
            // btnCandD
            // 
            this.btnCandD.Location = new System.Drawing.Point(311, 62);
            this.btnCandD.Name = "btnCandD";
            this.btnCandD.Size = new System.Drawing.Size(75, 23);
            this.btnCandD.TabIndex = 3;
            this.btnCandD.Text = "Votar";
            this.btnCandD.UseVisualStyleBackColor = true;
            this.btnCandD.Click += new System.EventHandler(this.btnCandD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "CandA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CandB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CandC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CandD";
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Location = new System.Drawing.Point(276, 115);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(110, 32);
            this.btnEncerrar.TabIndex = 8;
            this.btnEncerrar.Text = "Enecerrar";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cand A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cand B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cand C";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cand D";
            // 
            // lblVotosA
            // 
            this.lblVotosA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVotosA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVotosA.Location = new System.Drawing.Point(75, 205);
            this.lblVotosA.Name = "lblVotosA";
            this.lblVotosA.Size = new System.Drawing.Size(52, 22);
            this.lblVotosA.TabIndex = 13;
            this.lblVotosA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Votos";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(62, 295);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 13);
            this.label19.TabIndex = 21;
            this.label19.Text = "Vencedor";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 252);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 13);
            this.label20.TabIndex = 23;
            this.label20.Text = "%";
            // 
            // lblVotosB
            // 
            this.lblVotosB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVotosB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVotosB.Location = new System.Drawing.Point(142, 205);
            this.lblVotosB.Name = "lblVotosB";
            this.lblVotosB.Size = new System.Drawing.Size(52, 22);
            this.lblVotosB.TabIndex = 24;
            this.lblVotosB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVotosC
            // 
            this.lblVotosC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVotosC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVotosC.Location = new System.Drawing.Point(211, 205);
            this.lblVotosC.Name = "lblVotosC";
            this.lblVotosC.Size = new System.Drawing.Size(52, 22);
            this.lblVotosC.TabIndex = 25;
            this.lblVotosC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVotosD
            // 
            this.lblVotosD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVotosD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVotosD.Location = new System.Drawing.Point(276, 205);
            this.lblVotosD.Name = "lblVotosD";
            this.lblVotosD.Size = new System.Drawing.Size(52, 22);
            this.lblVotosD.TabIndex = 26;
            this.lblVotosD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPorD
            // 
            this.lblPorD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPorD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPorD.Location = new System.Drawing.Point(276, 244);
            this.lblPorD.Name = "lblPorD";
            this.lblPorD.Size = new System.Drawing.Size(52, 22);
            this.lblPorD.TabIndex = 30;
            this.lblPorD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPorC
            // 
            this.lblPorC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPorC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPorC.Location = new System.Drawing.Point(211, 244);
            this.lblPorC.Name = "lblPorC";
            this.lblPorC.Size = new System.Drawing.Size(52, 22);
            this.lblPorC.TabIndex = 29;
            this.lblPorC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPorB
            // 
            this.lblPorB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPorB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPorB.Location = new System.Drawing.Point(142, 244);
            this.lblPorB.Name = "lblPorB";
            this.lblPorB.Size = new System.Drawing.Size(52, 22);
            this.lblPorB.TabIndex = 28;
            this.lblPorB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPorA
            // 
            this.lblPorA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPorA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPorA.Location = new System.Drawing.Point(75, 244);
            this.lblPorA.Name = "lblPorA";
            this.lblPorA.Size = new System.Drawing.Size(52, 22);
            this.lblPorA.TabIndex = 27;
            this.lblPorA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVencedor
            // 
            this.lblVencedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVencedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVencedor.Location = new System.Drawing.Point(121, 290);
            this.lblVencedor.Name = "lblVencedor";
            this.lblVencedor.Size = new System.Drawing.Size(150, 22);
            this.lblVencedor.TabIndex = 31;
            this.lblVencedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 330);
            this.Controls.Add(this.lblVencedor);
            this.Controls.Add(this.lblPorD);
            this.Controls.Add(this.lblPorC);
            this.Controls.Add(this.lblPorB);
            this.Controls.Add(this.lblPorA);
            this.Controls.Add(this.lblVotosD);
            this.Controls.Add(this.lblVotosC);
            this.Controls.Add(this.lblVotosB);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblVotosA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCandD);
            this.Controls.Add(this.btnCandC);
            this.Controls.Add(this.btnCandB);
            this.Controls.Add(this.btnCandA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Urna Eletronica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCandA;
        private System.Windows.Forms.Button btnCandB;
        private System.Windows.Forms.Button btnCandC;
        private System.Windows.Forms.Button btnCandD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblVotosA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblVotosB;
        private System.Windows.Forms.Label lblVotosC;
        private System.Windows.Forms.Label lblVotosD;
        private System.Windows.Forms.Label lblPorD;
        private System.Windows.Forms.Label lblPorC;
        private System.Windows.Forms.Label lblPorB;
        private System.Windows.Forms.Label lblPorA;
        private System.Windows.Forms.Label lblVencedor;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

