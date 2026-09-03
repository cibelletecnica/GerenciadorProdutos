namespace GerenciadorProdutos
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
            this.Nome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.PrecoBase = new System.Windows.Forms.Label();
            this.txtPrecoBase = new System.Windows.Forms.TextBox();
            this.Tipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtAtributoEspecifico = new System.Windows.Forms.TextBox();
            this.Atributo = new System.Windows.Forms.Label();
            this.lblAtributo = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(157, 213);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(225, 210);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(121, 20);
            this.txtNome.TabIndex = 1;
            // 
            // PrecoBase
            // 
            this.PrecoBase.AutoSize = true;
            this.PrecoBase.Location = new System.Drawing.Point(157, 239);
            this.PrecoBase.Name = "PrecoBase";
            this.PrecoBase.Size = new System.Drawing.Size(62, 13);
            this.PrecoBase.TabIndex = 2;
            this.PrecoBase.Text = "Preço Base";
            // 
            // txtPrecoBase
            // 
            this.txtPrecoBase.Location = new System.Drawing.Point(225, 236);
            this.txtPrecoBase.Name = "txtPrecoBase";
            this.txtPrecoBase.Size = new System.Drawing.Size(121, 20);
            this.txtPrecoBase.TabIndex = 3;
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Location = new System.Drawing.Point(157, 265);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(28, 13);
            this.Tipo.TabIndex = 4;
            this.Tipo.Text = "Tipo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Físico",
            "Digital",
            "DAO"});
            this.cmbTipo.Location = new System.Drawing.Point(225, 262);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 6;
            // 
            // txtAtributoEspecifico
            // 
            this.txtAtributoEspecifico.Location = new System.Drawing.Point(225, 289);
            this.txtAtributoEspecifico.Name = "txtAtributoEspecifico";
            this.txtAtributoEspecifico.Size = new System.Drawing.Size(121, 20);
            this.txtAtributoEspecifico.TabIndex = 8;
            // 
            // Atributo
            // 
            this.Atributo.AutoSize = true;
            this.Atributo.Location = new System.Drawing.Point(157, 292);
            this.Atributo.Name = "Atributo";
            this.Atributo.Size = new System.Drawing.Size(43, 13);
            this.Atributo.TabIndex = 7;
            this.Atributo.Text = "Atributo";
            // 
            // lblAtributo
            // 
            this.lblAtributo.AutoSize = true;
            this.lblAtributo.Location = new System.Drawing.Point(370, 292);
            this.lblAtributo.Name = "lblAtributo";
            this.lblAtributo.Size = new System.Drawing.Size(16, 13);
            this.lblAtributo.TabIndex = 9;
            this.lblAtributo.Text = "...";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(225, 315);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(65, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(833, 517);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblAtributo);
            this.Controls.Add(this.txtAtributoEspecifico);
            this.Controls.Add(this.Atributo);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.txtPrecoBase);
            this.Controls.Add(this.PrecoBase);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.Nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label PrecoBase;
        private System.Windows.Forms.TextBox txtPrecoBase;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtAtributoEspecifico;
        private System.Windows.Forms.Label Atributo;
        private System.Windows.Forms.Label lblAtributo;
        private System.Windows.Forms.Button btnSalvar;
    }
}

