namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sete = new Button();
            oito = new Button();
            nove = new Button();
            Quatro = new Button();
            cinco = new Button();
            seis = new Button();
            UM = new Button();
            Dois = new Button();
            Tres = new Button();
            Zero = new Button();
            r = new Button();
            multiplicar = new Button();
            menos = new Button();
            mais = new Button();
            limpa = new Button();
            ponto = new Button();
            label1 = new Label();
            button1 = new Button();
            txtresultado = new TextBox();
            Sinal = new Label();
            igual = new Button();
            txtsinal = new Label();
            SuspendLayout();
            // 
            // sete
            // 
            sete.BackColor = Color.FromArgb(64, 0, 0);
            sete.FlatStyle = FlatStyle.System;
            sete.ForeColor = SystemColors.Control;
            sete.Location = new Point(32, 163);
            sete.Name = "sete";
            sete.Size = new Size(77, 53);
            sete.TabIndex = 1;
            sete.Text = "7";
            sete.UseVisualStyleBackColor = false;
            sete.Click += sete_Click;
            // 
            // oito
            // 
            oito.Location = new Point(122, 163);
            oito.Name = "oito";
            oito.Size = new Size(77, 53);
            oito.TabIndex = 2;
            oito.Text = "8";
            oito.UseVisualStyleBackColor = true;
            oito.Click += oito_Click;
            // 
            // nove
            // 
            nove.Location = new Point(209, 163);
            nove.Name = "nove";
            nove.Size = new Size(77, 53);
            nove.TabIndex = 3;
            nove.Text = "9";
            nove.UseVisualStyleBackColor = true;
            nove.Click += nove_Click;
            // 
            // Quatro
            // 
            Quatro.Location = new Point(32, 234);
            Quatro.Name = "Quatro";
            Quatro.Size = new Size(77, 53);
            Quatro.TabIndex = 4;
            Quatro.Text = "4";
            Quatro.UseVisualStyleBackColor = true;
            Quatro.Click += Quatro_Click;
            // 
            // cinco
            // 
            cinco.Location = new Point(122, 234);
            cinco.Name = "cinco";
            cinco.Size = new Size(77, 53);
            cinco.TabIndex = 5;
            cinco.Text = "5";
            cinco.UseVisualStyleBackColor = true;
            cinco.Click += cinco_Click;
            // 
            // seis
            // 
            seis.Location = new Point(210, 233);
            seis.Name = "seis";
            seis.Size = new Size(77, 53);
            seis.TabIndex = 6;
            seis.Text = "6";
            seis.UseVisualStyleBackColor = true;
            seis.Click += seis_Click;
            // 
            // UM
            // 
            UM.Location = new Point(32, 315);
            UM.Name = "UM";
            UM.Size = new Size(77, 53);
            UM.TabIndex = 7;
            UM.Text = "1";
            UM.UseVisualStyleBackColor = true;
            UM.Click += UM_Click;
            // 
            // Dois
            // 
            Dois.Location = new Point(123, 315);
            Dois.Name = "Dois";
            Dois.Size = new Size(77, 53);
            Dois.TabIndex = 8;
            Dois.Text = "2";
            Dois.UseVisualStyleBackColor = true;
            Dois.Click += Dois_Click;
            // 
            // Tres
            // 
            Tres.Location = new Point(211, 315);
            Tres.Name = "Tres";
            Tres.Size = new Size(77, 53);
            Tres.TabIndex = 9;
            Tres.Text = "3";
            Tres.UseVisualStyleBackColor = true;
            Tres.Click += Tres_Click;
            // 
            // Zero
            // 
            Zero.Location = new Point(123, 393);
            Zero.Name = "Zero";
            Zero.Size = new Size(77, 53);
            Zero.TabIndex = 10;
            Zero.Text = "0";
            Zero.UseVisualStyleBackColor = true;
            Zero.Click += Zero_Click;
            // 
            // r
            // 
            r.Location = new Point(300, 163);
            r.Name = "r";
            r.Size = new Size(77, 53);
            r.TabIndex = 11;
            r.Text = "/";
            r.UseVisualStyleBackColor = true;
            r.Click += r_Click;
            // 
            // multiplicar
            // 
            multiplicar.Location = new Point(300, 233);
            multiplicar.Name = "multiplicar";
            multiplicar.Size = new Size(77, 53);
            multiplicar.TabIndex = 12;
            multiplicar.Text = "x";
            multiplicar.UseVisualStyleBackColor = true;
            multiplicar.Click += multiplicar_Click;
            // 
            // menos
            // 
            menos.Location = new Point(33, 393);
            menos.Name = "menos";
            menos.Size = new Size(77, 53);
            menos.TabIndex = 13;
            menos.Text = "-";
            menos.UseVisualStyleBackColor = true;
            menos.Click += menos_Click;
            // 
            // mais
            // 
            mais.Location = new Point(299, 315);
            mais.Name = "mais";
            mais.Size = new Size(77, 53);
            mais.TabIndex = 14;
            mais.Text = "+";
            mais.UseVisualStyleBackColor = true;
            mais.Click += mais_Click;
            // 
            // limpa
            // 
            limpa.Location = new Point(117, 470);
            limpa.Name = "limpa";
            limpa.Size = new Size(171, 53);
            limpa.TabIndex = 15;
            limpa.Text = "Limpa";
            limpa.UseVisualStyleBackColor = true;
            limpa.Click += limpa_Click;
            // 
            // ponto
            // 
            ponto.Location = new Point(209, 393);
            ponto.Name = "ponto";
            ponto.Size = new Size(77, 53);
            ponto.TabIndex = 16;
            ponto.Text = ".";
            ponto.UseVisualStyleBackColor = true;
            ponto.Click += ponto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 59);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 17;
            label1.Text = "Calculadora";
            // 
            // button1
            // 
            button1.Location = new Point(32, 470);
            button1.Name = "button1";
            button1.Size = new Size(77, 53);
            button1.TabIndex = 19;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtresultado
            // 
            txtresultado.BackColor = Color.White;
            txtresultado.ForeColor = Color.Black;
            txtresultado.Location = new Point(31, 87);
            txtresultado.Name = "txtresultado";
            txtresultado.ScrollBars = ScrollBars.Both;
            txtresultado.Size = new Size(345, 23);
            txtresultado.TabIndex = 20;
            txtresultado.TextAlign = HorizontalAlignment.Right;
            txtresultado.TextChanged += Resultado_TextChanged;
            // 
            // Sinal
            // 
            Sinal.AutoSize = true;
            Sinal.Location = new Point(35, 92);
            Sinal.Name = "Sinal";
            Sinal.Size = new Size(0, 15);
            Sinal.TabIndex = 21;
            // 
            // igual
            // 
            igual.BackColor = Color.FromArgb(0, 64, 0);
            igual.Location = new Point(300, 383);
            igual.Name = "igual";
            igual.Size = new Size(76, 140);
            igual.TabIndex = 22;
            igual.Text = "=";
            igual.UseVisualStyleBackColor = false;
            igual.Click += igual_Click;
            // 
            // txtsinal
            // 
            txtsinal.AutoSize = true;
            txtsinal.Location = new Point(35, 92);
            txtsinal.Name = "txtsinal";
            txtsinal.Size = new Size(0, 15);
            txtsinal.TabIndex = 23;
            txtsinal.Click += txtsinal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(412, 570);
            Controls.Add(txtsinal);
            Controls.Add(igual);
            Controls.Add(Sinal);
            Controls.Add(txtresultado);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(ponto);
            Controls.Add(limpa);
            Controls.Add(mais);
            Controls.Add(menos);
            Controls.Add(multiplicar);
            Controls.Add(r);
            Controls.Add(Zero);
            Controls.Add(Tres);
            Controls.Add(Dois);
            Controls.Add(UM);
            Controls.Add(seis);
            Controls.Add(cinco);
            Controls.Add(Quatro);
            Controls.Add(nove);
            Controls.Add(oito);
            Controls.Add(sete);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button sete;
        private Button oito;
        private Button nove;
        private Button Quatro;
        private Button cinco;
        private Button seis;
        private Button UM;
        private Button Dois;
        private Button Tres;
        private Button Zero;
        private Button r;
        private Button multiplicar;
        private Button menos;
        private Button mais;
        private Button limpa;
        private Button ponto;
        private Label label1;
        private Button button1;
        private TextBox txtresultado;
        private Label Sinal;
        private Button igual;
        private Label txtsinal;
    }
}
