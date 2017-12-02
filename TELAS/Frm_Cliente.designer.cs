namespace CSA_SISTEMA.TELAS
    {
    partial class Frm_Cliente
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
            this.Pan_botoes = new System.Windows.Forms.Panel();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_localizar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_retornar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.Pan_botoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pan_botoes
            // 
            this.Pan_botoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Pan_botoes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Pan_botoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Pan_botoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pan_botoes.Controls.Add(this.dataGrid1);
            this.Pan_botoes.Controls.Add(this.label1);
            this.Pan_botoes.Controls.Add(this.button1);
            this.Pan_botoes.Controls.Add(this.lb_localizar);
            this.Pan_botoes.Controls.Add(this.textBox1);
            this.Pan_botoes.Controls.Add(this.btn_retornar);
            this.Pan_botoes.Controls.Add(this.btn_excluir);
            this.Pan_botoes.Controls.Add(this.btn_consultar);
            this.Pan_botoes.Controls.Add(this.btn_alterar);
            this.Pan_botoes.Controls.Add(this.btn_inserir);
            this.Pan_botoes.Location = new System.Drawing.Point(1, 1);
            this.Pan_botoes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pan_botoes.Name = "Pan_botoes";
            this.Pan_botoes.Size = new System.Drawing.Size(1042, 637);
            this.Pan_botoes.TabIndex = 1;
            // 
            // dataGrid1
            // 
            this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGrid1.Location = new System.Drawing.Point(35, 78);
            this.dataGrid1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(979, 370);
            this.dataGrid1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(671, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cadastro de Usuários - [CSA - Sistemas]";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(855, 455);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Localizar / Pesquisar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lb_localizar
            // 
            this.lb_localizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_localizar.Location = new System.Drawing.Point(35, 455);
            this.lb_localizar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_localizar.Name = "lb_localizar";
            this.lb_localizar.Size = new System.Drawing.Size(133, 25);
            this.lb_localizar.TabIndex = 6;
            this.lb_localizar.Text = "Localizar";
            this.lb_localizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_localizar.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 455);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(669, 24);
            this.textBox1.TabIndex = 5;
            // 
            // btn_retornar
            // 
            this.btn_retornar.Location = new System.Drawing.Point(913, 496);
            this.btn_retornar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_retornar.Name = "btn_retornar";
            this.btn_retornar.Size = new System.Drawing.Size(100, 28);
            this.btn_retornar.TabIndex = 4;
            this.btn_retornar.Text = "Retornar";
            this.btn_retornar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_retornar.UseVisualStyleBackColor = true;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(713, 496);
            this.btn_excluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(100, 28);
            this.btn_excluir.TabIndex = 3;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(480, 496);
            this.btn_consultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(100, 28);
            this.btn_consultar.TabIndex = 2;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_consultar.UseVisualStyleBackColor = true;
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(269, 496);
            this.btn_alterar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(100, 28);
            this.btn_alterar.TabIndex = 1;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_alterar.UseVisualStyleBackColor = true;
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(35, 496);
            this.btn_inserir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(100, 28);
            this.btn_inserir.TabIndex = 0;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // Frm_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 692);
            this.Controls.Add(this.Pan_botoes);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro - Cliente [CSA - Sistemas]";
            this.Load += new System.EventHandler(this.frm_cli_Load);
            this.Pan_botoes.ResumeLayout(false);
            this.Pan_botoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.Panel Pan_botoes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_retornar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Label lb_localizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGrid dataGrid1;


        }
    }