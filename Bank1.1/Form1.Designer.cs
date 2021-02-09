
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.campoSaldo2 = new System.Windows.Forms.TextBox();
            this.campoNumero2 = new System.Windows.Forms.TextBox();
            this.campoTitular2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSacar2 = new System.Windows.Forms.Button();
            this.buttonDepositar2 = new System.Windows.Forms.Button();
            this.campoValor2 = new System.Windows.Forms.TextBox();
            this.buttonTransferir = new System.Windows.Forms.Button();
            this.buttonTranferir2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // campoTitular
            // 
            this.campoTitular.Location = new System.Drawing.Point(24, 73);
            this.campoTitular.Name = "campoTitular";
            this.campoTitular.ReadOnly = true;
            this.campoTitular.Size = new System.Drawing.Size(100, 20);
            this.campoTitular.TabIndex = 0;
            // 
            // campoNumero
            // 
            this.campoNumero.Location = new System.Drawing.Point(24, 124);
            this.campoNumero.Name = "campoNumero";
            this.campoNumero.ReadOnly = true;
            this.campoNumero.Size = new System.Drawing.Size(100, 20);
            this.campoNumero.TabIndex = 1;
            // 
            // campoSaldo
            // 
            this.campoSaldo.Location = new System.Drawing.Point(24, 175);
            this.campoSaldo.Name = "campoSaldo";
            this.campoSaldo.ReadOnly = true;
            this.campoSaldo.Size = new System.Drawing.Size(100, 20);
            this.campoSaldo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Conta Corrente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome Titular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numero Conta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Saldo";
            // 
            // campoValor
            // 
            this.campoValor.Location = new System.Drawing.Point(24, 217);
            this.campoValor.Name = "campoValor";
            this.campoValor.Size = new System.Drawing.Size(75, 20);
            this.campoValor.TabIndex = 7;
            // 
            // buttonDepositar
            // 
            this.buttonDepositar.Location = new System.Drawing.Point(24, 243);
            this.buttonDepositar.Name = "buttonDepositar";
            this.buttonDepositar.Size = new System.Drawing.Size(75, 23);
            this.buttonDepositar.TabIndex = 8;
            this.buttonDepositar.Text = "Depositar";
            this.buttonDepositar.UseVisualStyleBackColor = true;
            this.buttonDepositar.Click += new System.EventHandler(this.buttonDepositar_Click);
            // 
            // buttonSacar
            // 
            this.buttonSacar.Location = new System.Drawing.Point(24, 272);
            this.buttonSacar.Name = "buttonSacar";
            this.buttonSacar.Size = new System.Drawing.Size(75, 23);
            this.buttonSacar.TabIndex = 9;
            this.buttonSacar.Text = "Sacar";
            this.buttonSacar.UseVisualStyleBackColor = true;
            this.buttonSacar.Click += new System.EventHandler(this.buttonSacar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Saldo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Numero Conta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nome Titular";
            // 
            // campoSaldo2
            // 
            this.campoSaldo2.Location = new System.Drawing.Point(210, 175);
            this.campoSaldo2.Name = "campoSaldo2";
            this.campoSaldo2.ReadOnly = true;
            this.campoSaldo2.Size = new System.Drawing.Size(100, 20);
            this.campoSaldo2.TabIndex = 12;
            // 
            // campoNumero2
            // 
            this.campoNumero2.Location = new System.Drawing.Point(210, 124);
            this.campoNumero2.Name = "campoNumero2";
            this.campoNumero2.ReadOnly = true;
            this.campoNumero2.Size = new System.Drawing.Size(100, 20);
            this.campoNumero2.TabIndex = 11;
            // 
            // campoTitular2
            // 
            this.campoTitular2.Location = new System.Drawing.Point(210, 73);
            this.campoTitular2.Name = "campoTitular2";
            this.campoTitular2.ReadOnly = true;
            this.campoTitular2.Size = new System.Drawing.Size(100, 20);
            this.campoTitular2.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(207, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Conta Corrente 2";
            // 
            // buttonSacar2
            // 
            this.buttonSacar2.Location = new System.Drawing.Point(210, 271);
            this.buttonSacar2.Name = "buttonSacar2";
            this.buttonSacar2.Size = new System.Drawing.Size(75, 23);
            this.buttonSacar2.TabIndex = 19;
            this.buttonSacar2.Text = "Sacar";
            this.buttonSacar2.UseVisualStyleBackColor = true;
            this.buttonSacar2.Click += new System.EventHandler(this.buttonSacar2_Click);
            // 
            // buttonDepositar2
            // 
            this.buttonDepositar2.Location = new System.Drawing.Point(210, 242);
            this.buttonDepositar2.Name = "buttonDepositar2";
            this.buttonDepositar2.Size = new System.Drawing.Size(75, 23);
            this.buttonDepositar2.TabIndex = 18;
            this.buttonDepositar2.Text = "Depositar";
            this.buttonDepositar2.UseVisualStyleBackColor = true;
            this.buttonDepositar2.Click += new System.EventHandler(this.buttonDepositar2_Click);
            // 
            // campoValor2
            // 
            this.campoValor2.Location = new System.Drawing.Point(210, 217);
            this.campoValor2.Name = "campoValor2";
            this.campoValor2.Size = new System.Drawing.Size(75, 20);
            this.campoValor2.TabIndex = 17;
            // 
            // buttonTransferir
            // 
            this.buttonTransferir.Location = new System.Drawing.Point(210, 300);
            this.buttonTransferir.Name = "buttonTransferir";
            this.buttonTransferir.Size = new System.Drawing.Size(75, 23);
            this.buttonTransferir.TabIndex = 25;
            this.buttonTransferir.Text = "Tranferir";
            this.buttonTransferir.UseVisualStyleBackColor = true;
            this.buttonTransferir.Click += new System.EventHandler(this.buttonTransferir_Click);
            // 
            // buttonTranferir2
            // 
            this.buttonTranferir2.Location = new System.Drawing.Point(24, 301);
            this.buttonTranferir2.Name = "buttonTranferir2";
            this.buttonTranferir2.Size = new System.Drawing.Size(75, 23);
            this.buttonTranferir2.TabIndex = 28;
            this.buttonTranferir2.Text = "Tranferir";
            this.buttonTranferir2.UseVisualStyleBackColor = true;
            this.buttonTranferir2.Click += new System.EventHandler(this.buttonTranferir2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 341);
            this.Controls.Add(this.buttonTranferir2);
            this.Controls.Add(this.buttonTransferir);
            this.Controls.Add(this.buttonSacar2);
            this.Controls.Add(this.buttonDepositar2);
            this.Controls.Add(this.campoValor2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.campoSaldo2);
            this.Controls.Add(this.campoNumero2);
            this.Controls.Add(this.campoTitular2);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox campoSaldo2;
        private System.Windows.Forms.TextBox campoNumero2;
        private System.Windows.Forms.TextBox campoTitular2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSacar2;
        private System.Windows.Forms.Button buttonDepositar2;
        private System.Windows.Forms.TextBox campoValor2;
        private System.Windows.Forms.Button buttonTransferir;
        private System.Windows.Forms.Button buttonTranferir2;
    }
}

