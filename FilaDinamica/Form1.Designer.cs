namespace FilaDinamica
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnEnfileirar = new System.Windows.Forms.Button();
            this.btnDesenfileirar = new System.Windows.Forms.Button();
            this.btnListarFila = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(26, 81);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(372, 20);
            this.txtNome.TabIndex = 0;
            // 
            // btnEnfileirar
            // 
            this.btnEnfileirar.Location = new System.Drawing.Point(26, 115);
            this.btnEnfileirar.Name = "btnEnfileirar";
            this.btnEnfileirar.Size = new System.Drawing.Size(120, 24);
            this.btnEnfileirar.TabIndex = 1;
            this.btnEnfileirar.Text = "Enfileirar";
            this.btnEnfileirar.UseVisualStyleBackColor = true;
            this.btnEnfileirar.Click += new System.EventHandler(this.btnEnfileirar_Click);
            // 
            // btnDesenfileirar
            // 
            this.btnDesenfileirar.Location = new System.Drawing.Point(152, 115);
            this.btnDesenfileirar.Name = "btnDesenfileirar";
            this.btnDesenfileirar.Size = new System.Drawing.Size(120, 24);
            this.btnDesenfileirar.TabIndex = 2;
            this.btnDesenfileirar.Text = "Desenfileirar";
            this.btnDesenfileirar.UseVisualStyleBackColor = true;
            this.btnDesenfileirar.Click += new System.EventHandler(this.btnDesenfileirar_Click);
            // 
            // btnListarFila
            // 
            this.btnListarFila.Location = new System.Drawing.Point(278, 115);
            this.btnListarFila.Name = "btnListarFila";
            this.btnListarFila.Size = new System.Drawing.Size(120, 24);
            this.btnListarFila.TabIndex = 3;
            this.btnListarFila.Text = "Listar a Fila";
            this.btnListarFila.UseVisualStyleBackColor = true;
            this.btnListarFila.Click += new System.EventHandler(this.btnListarFila_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "RA:";
            // 
            // txtRa
            // 
            this.txtRa.Location = new System.Drawing.Point(26, 31);
            this.txtRa.Name = "txtRa";
            this.txtRa.Size = new System.Drawing.Size(372, 20);
            this.txtRa.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(26, 177);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(372, 84);
            this.txtResultado.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 285);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListarFila);
            this.Controls.Add(this.btnDesenfileirar);
            this.Controls.Add(this.btnEnfileirar);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnEnfileirar;
        private System.Windows.Forms.Button btnDesenfileirar;
        private System.Windows.Forms.Button btnListarFila;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

