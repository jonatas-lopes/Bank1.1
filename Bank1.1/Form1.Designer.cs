
namespace Bank1._1
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
            this.campoTitular = new System.Windows.Forms.TextBox();
            this.campoNumero = new System.Windows.Forms.TextBox();
            this.campoSaldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.campoValor = new System.Windows.Forms.TextBox();
            this.buttonDepositar = new System.Windows.Forms.Button();
            this.buttonSacar = new System.Windows.Forms.Button();
            this.buttonTranferir2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.comboTransfere = new System.Windows.Forms.ComboBox();
            this.campoTransfere = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // campoTitular
            // 
            this.campoTitular.Location = new System.Drawing.Point(30, 152);
            this.campoTitular.Name = "campoTitular";
            this.campoTitular.ReadOnly = true;
            this.campoTitular.Size = new System.Drawing.Size(100, 20);
            this.campoTitular.TabIndex = 0;
            // 
            // campoNumero
            // 
            this.campoNumero.Location = new System.Drawing.Point(30, 203);
            this.campoNumero.Name = "campoNumero";
            this.campoNumero.ReadOnly = true;
            this.campoNumero.Size = new System.Drawing.Size(100, 20);
            this.campoNumero.TabIndex = 1;
            // 
            // campoSaldo
            // 
            this.campoSaldo.Location = new System.Drawing.Point(30, 254);
            this.campoSaldo.Name = "campoSaldo";
            this.campoSaldo.ReadOnly = true;
            this.campoSaldo.Size = new System.Drawing.Size(100, 20);
            this.campoSaldo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Conta Corrente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome Titular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numero Conta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Saldo";
            // 
            // campoValor
            // 
            this.campoValor.Location = new System.Drawing.Point(194, 117);
            this.campoValor.Name = "campoValor";
            this.campoValor.Size = new System.Drawing.Size(75, 20);
            this.campoValor.TabIndex = 7;
            // 
            // buttonDepositar
            // 
            this.buttonDepositar.Location = new System.Drawing.Point(194, 152);
            this.buttonDepositar.Name = "buttonDepositar";
            this.buttonDepositar.Size = new System.Drawing.Size(75, 23);
            this.buttonDepositar.TabIndex = 8;
            this.buttonDepositar.Text = "Depositar";
            this.buttonDepositar.UseVisualStyleBackColor = true;
            this.buttonDepositar.Click += new System.EventHandler(this.buttonDepositar_Click);
            // 
            // buttonSacar
            // 
            this.buttonSacar.Location = new System.Drawing.Point(194, 187);
            this.buttonSacar.Name = "buttonSacar";
            this.buttonSacar.Size = new System.Drawing.Size(75, 23);
            this.buttonSacar.TabIndex = 9;
            this.buttonSacar.Text = "Sacar";
            this.buttonSacar.UseVisualStyleBackColor = true;
            this.buttonSacar.Click += new System.EventHandler(this.buttonSacar_Click);
            // 
            // buttonTranferir2
            // 
            this.buttonTranferir2.Location = new System.Drawing.Point(331, 301);
            this.buttonTranferir2.Name = "buttonTranferir2";
            this.buttonTranferir2.Size = new System.Drawing.Size(75, 23);
            this.buttonTranferir2.TabIndex = 28;
            this.buttonTranferir2.Text = "Tranferir";
            this.buttonTranferir2.UseVisualStyleBackColor = true;
            this.buttonTranferir2.Click += new System.EventHandler(this.buttonTranferir2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Titular";
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(30, 49);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(121, 21);
            this.comboContas.TabIndex = 32;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // comboTransfere
            // 
            this.comboTransfere.FormattingEnabled = true;
            this.comboTransfere.Location = new System.Drawing.Point(194, 254);
            this.comboTransfere.Name = "comboTransfere";
            this.comboTransfere.Size = new System.Drawing.Size(121, 21);
            this.comboTransfere.TabIndex = 33;
            this.comboTransfere.SelectedIndexChanged += new System.EventHandler(this.comboTransfere_SelectedIndexChanged);
            // 
            // campoTransfere
            // 
            this.campoTransfere.Location = new System.Drawing.Point(331, 254);
            this.campoTransfere.Name = "campoTransfere";
            this.campoTransfere.Size = new System.Drawing.Size(75, 20);
            this.campoTransfere.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 336);
            this.Controls.Add(this.campoTransfere);
            this.Controls.Add(this.comboTransfere);
            this.Controls.Add(this.comboContas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonTranferir2);
            this.Controls.Add(this.buttonSacar);
            this.Controls.Add(this.buttonDepositar);
            this.Controls.Add(this.campoValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.campoSaldo);
            this.Controls.Add(this.campoNumero);
            this.Controls.Add(this.campoTitular);
            this.Name = "Form1";
            this.Text = "AgileBank";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox campoTitular;
        private System.Windows.Forms.TextBox campoNumero;
        private System.Windows.Forms.TextBox campoSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox campoValor;
        private System.Windows.Forms.Button buttonDepositar;
        private System.Windows.Forms.Button buttonSacar;
        private System.Windows.Forms.Button buttonTranferir2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.ComboBox comboTransfere;
        private System.Windows.Forms.TextBox campoTransfere;
    }
}

