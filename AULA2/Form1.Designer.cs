namespace AULA2
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
            this.BTN_ENTRAR = new System.Windows.Forms.Button();
            this.LB_UOR = new System.Windows.Forms.Label();
            this.TEXTBOX_ID = new System.Windows.Forms.TextBox();
            this.LB_ID = new System.Windows.Forms.Label();
            this.LB_SENHA = new System.Windows.Forms.Label();
            this.textBox_SENHA = new System.Windows.Forms.TextBox();
            this.BTN_SAIR = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_ENTRAR
            // 
            this.BTN_ENTRAR.BackColor = System.Drawing.Color.Blue;
            this.BTN_ENTRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ENTRAR.ForeColor = System.Drawing.Color.White;
            this.BTN_ENTRAR.Location = new System.Drawing.Point(41, 207);
            this.BTN_ENTRAR.Name = "BTN_ENTRAR";
            this.BTN_ENTRAR.Size = new System.Drawing.Size(112, 36);
            this.BTN_ENTRAR.TabIndex = 0;
            this.BTN_ENTRAR.Text = "Entrar";
            this.BTN_ENTRAR.UseVisualStyleBackColor = false;
            this.BTN_ENTRAR.Click += new System.EventHandler(this.BTN_ENTRAR_Click);
            // 
            // LB_UOR
            // 
            this.LB_UOR.AutoSize = true;
            this.LB_UOR.BackColor = System.Drawing.Color.White;
            this.LB_UOR.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_UOR.ForeColor = System.Drawing.Color.Red;
            this.LB_UOR.Image = global::AULA2.Properties.Resources.OUR_LOG_2023_11_14_à_s__21_59_50_53f9f57a;
            this.LB_UOR.Location = new System.Drawing.Point(12, 9);
            this.LB_UOR.Name = "LB_UOR";
            this.LB_UOR.Size = new System.Drawing.Size(0, 28);
            this.LB_UOR.TabIndex = 1;
            // 
            // TEXTBOX_ID
            // 
            this.TEXTBOX_ID.Location = new System.Drawing.Point(41, 97);
            this.TEXTBOX_ID.Name = "TEXTBOX_ID";
            this.TEXTBOX_ID.Size = new System.Drawing.Size(288, 20);
            this.TEXTBOX_ID.TabIndex = 2;
            this.TEXTBOX_ID.TextChanged += new System.EventHandler(this.TEXTBOX_TEXTO_TextChanged);
            // 
            // LB_ID
            // 
            this.LB_ID.AutoSize = true;
            this.LB_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ID.Location = new System.Drawing.Point(37, 70);
            this.LB_ID.Name = "LB_ID";
            this.LB_ID.Size = new System.Drawing.Size(29, 24);
            this.LB_ID.TabIndex = 3;
            this.LB_ID.Text = "ID";
            // 
            // LB_SENHA
            // 
            this.LB_SENHA.AutoSize = true;
            this.LB_SENHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_SENHA.Location = new System.Drawing.Point(38, 130);
            this.LB_SENHA.Name = "LB_SENHA";
            this.LB_SENHA.Size = new System.Drawing.Size(70, 24);
            this.LB_SENHA.TabIndex = 4;
            this.LB_SENHA.Text = "Senha";
            // 
            // textBox_SENHA
            // 
            this.textBox_SENHA.Location = new System.Drawing.Point(41, 157);
            this.textBox_SENHA.Name = "textBox_SENHA";
            this.textBox_SENHA.Size = new System.Drawing.Size(288, 20);
            this.textBox_SENHA.TabIndex = 5;
            this.textBox_SENHA.UseSystemPasswordChar = true;
            // 
            // BTN_SAIR
            // 
            this.BTN_SAIR.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_SAIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SAIR.ForeColor = System.Drawing.Color.White;
            this.BTN_SAIR.Location = new System.Drawing.Point(206, 207);
            this.BTN_SAIR.Name = "BTN_SAIR";
            this.BTN_SAIR.Size = new System.Drawing.Size(111, 36);
            this.BTN_SAIR.TabIndex = 6;
            this.BTN_SAIR.Text = "sair";
            this.BTN_SAIR.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::AULA2.Properties.Resources.OUR_LOG_2023_11_14_à_s__21_59_50_53f9f57a;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 42);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(328, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(8, 4);
            this.listBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_SAIR);
            this.Controls.Add(this.textBox_SENHA);
            this.Controls.Add(this.LB_SENHA);
            this.Controls.Add(this.LB_ID);
            this.Controls.Add(this.TEXTBOX_ID);
            this.Controls.Add(this.LB_UOR);
            this.Controls.Add(this.BTN_ENTRAR);
            this.Name = "Form1";
            this.Text = "F_login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_ENTRAR;
        private System.Windows.Forms.Label LB_UOR;
        private System.Windows.Forms.TextBox TEXTBOX_ID;
        private System.Windows.Forms.Label LB_ID;
        private System.Windows.Forms.Label LB_SENHA;
        private System.Windows.Forms.TextBox textBox_SENHA;
        private System.Windows.Forms.Button BTN_SAIR;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

