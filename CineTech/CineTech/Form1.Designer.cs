namespace CineTech
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.cmbFilme = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.PbFilmes = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCompletarDados = new System.Windows.Forms.Panel();
            this.btnAssistir = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNascimento = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbFilmes)).BeginInit();
            this.panelCompletarDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Location = new System.Drawing.Point(90, 275);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(124, 36);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            this.btnConfirmar.MouseEnter += new System.EventHandler(this.btnConfirmar_MouseEnter);
            this.btnConfirmar.MouseLeave += new System.EventHandler(this.btnConfirmar_MouseLeave);
            // 
            // cmbFilme
            // 
            this.cmbFilme.FormattingEnabled = true;
            this.cmbFilme.Items.AddRange(new object[] {
            "Trasnformes",
            "O Poderoso Chefão ",
            "A Origem",
            "O Senhor dos Anéis: O Retorno do Rei",
            "Clube da Luta",
            "Forrest Gump",
            "Cidade de Deus",
            "O Grande Lebowski",
            " através da minha janela"});
            this.cmbFilme.Location = new System.Drawing.Point(88, 225);
            this.cmbFilme.Name = "cmbFilme";
            this.cmbFilme.Size = new System.Drawing.Size(320, 21);
            this.cmbFilme.TabIndex = 1;
            this.cmbFilme.SelectedIndexChanged += new System.EventHandler(this.cmbFilme_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bem vindo ao nosso app de filme";
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.Red;
            this.btnFechar.Location = new System.Drawing.Point(1221, -1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(43, 28);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // PbFilmes
            // 
            this.PbFilmes.Image = ((System.Drawing.Image)(resources.GetObject("PbFilmes.Image")));
            this.PbFilmes.Location = new System.Drawing.Point(740, 160);
            this.PbFilmes.Name = "PbFilmes";
            this.PbFilmes.Size = new System.Drawing.Size(309, 430);
            this.PbFilmes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbFilmes.TabIndex = 4;
            this.PbFilmes.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "CineTech";
            // 
            // panelCompletarDados
            // 
            this.panelCompletarDados.Controls.Add(this.btnAssistir);
            this.panelCompletarDados.Controls.Add(this.label4);
            this.panelCompletarDados.Controls.Add(this.label3);
            this.panelCompletarDados.Controls.Add(this.txtNascimento);
            this.panelCompletarDados.Controls.Add(this.txtNome);
            this.panelCompletarDados.Location = new System.Drawing.Point(89, 342);
            this.panelCompletarDados.Name = "panelCompletarDados";
            this.panelCompletarDados.Size = new System.Drawing.Size(415, 203);
            this.panelCompletarDados.TabIndex = 6;
            this.panelCompletarDados.Visible = false;
            // 
            // btnAssistir
            // 
            this.btnAssistir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAssistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssistir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAssistir.IconColor = System.Drawing.Color.Black;
            this.btnAssistir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAssistir.Location = new System.Drawing.Point(22, 135);
            this.btnAssistir.Name = "btnAssistir";
            this.btnAssistir.Size = new System.Drawing.Size(124, 36);
            this.btnAssistir.TabIndex = 7;
            this.btnAssistir.Text = "Assistir agora";
            this.btnAssistir.UseVisualStyleBackColor = true;
            this.btnAssistir.MouseEnter += new System.EventHandler(this.btnAssistir_MouseEnter);
            this.btnAssistir.MouseLeave += new System.EventHandler(this.btnAssistir_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Digite sua idade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Digite seu nome:";
            // 
            // txtNascimento
            // 
            this.txtNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNascimento.Location = new System.Drawing.Point(24, 96);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(318, 22);
            this.txtNascimento.TabIndex = 1;
            this.txtNascimento.TextChanged += new System.EventHandler(this.txtNascimento_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(24, 47);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(318, 22);
            this.txtNome.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.panelCompletarDados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PbFilmes);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFilme);
            this.Controls.Add(this.btnConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PbFilmes)).EndInit();
            this.panelCompletarDados.ResumeLayout(false);
            this.panelCompletarDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ComboBox cmbFilme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox PbFilmes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelCompletarDados;
        private FontAwesome.Sharp.IconButton btnAssistir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNascimento;
        private System.Windows.Forms.TextBox txtNome;
    }
}

