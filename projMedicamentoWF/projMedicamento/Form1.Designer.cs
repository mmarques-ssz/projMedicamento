namespace projMedicamento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVencLote = new System.Windows.Forms.DateTimePicker();
            this.txtQtdeLote = new System.Windows.Forms.TextBox();
            this.txtIdLote = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeMedicamento = new System.Windows.Forms.TextBox();
            this.txtIdMedicamento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLabMedicamento = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cboMedicamentos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.lstLotes = new System.Windows.Forms.ListBox();
            this.txtQtdeVender = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lstMedicamentos = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.lstLotes);
            this.groupBox1.Controls.Add(this.txtQtdeVender);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboMedicamentos);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtVencLote);
            this.groupBox1.Controls.Add(this.txtQtdeLote);
            this.groupBox1.Controls.Add(this.txtIdLote);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 402);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lote";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Venc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Qtde:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id:";
            // 
            // txtVencLote
            // 
            this.txtVencLote.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtVencLote.Location = new System.Drawing.Point(57, 65);
            this.txtVencLote.Name = "txtVencLote";
            this.txtVencLote.Size = new System.Drawing.Size(104, 20);
            this.txtVencLote.TabIndex = 8;
            // 
            // txtQtdeLote
            // 
            this.txtQtdeLote.Location = new System.Drawing.Point(57, 39);
            this.txtQtdeLote.Name = "txtQtdeLote";
            this.txtQtdeLote.Size = new System.Drawing.Size(86, 20);
            this.txtQtdeLote.TabIndex = 7;
            // 
            // txtIdLote
            // 
            this.txtIdLote.Location = new System.Drawing.Point(57, 13);
            this.txtIdLote.Name = "txtIdLote";
            this.txtIdLote.Size = new System.Drawing.Size(70, 20);
            this.txtIdLote.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstMedicamentos);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtLabMedicamento);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNomeMedicamento);
            this.groupBox2.Controls.Add(this.txtIdMedicamento);
            this.groupBox2.Location = new System.Drawing.Point(211, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 401);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medicamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Id:";
            // 
            // txtNomeMedicamento
            // 
            this.txtNomeMedicamento.Location = new System.Drawing.Point(56, 45);
            this.txtNomeMedicamento.Name = "txtNomeMedicamento";
            this.txtNomeMedicamento.Size = new System.Drawing.Size(132, 20);
            this.txtNomeMedicamento.TabIndex = 12;
            // 
            // txtIdMedicamento
            // 
            this.txtIdMedicamento.Location = new System.Drawing.Point(56, 19);
            this.txtIdMedicamento.Name = "txtIdMedicamento";
            this.txtIdMedicamento.Size = new System.Drawing.Size(70, 20);
            this.txtIdMedicamento.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Lab.:";
            // 
            // txtLabMedicamento
            // 
            this.txtLabMedicamento.Location = new System.Drawing.Point(56, 71);
            this.txtLabMedicamento.Name = "txtLabMedicamento";
            this.txtLabMedicamento.Size = new System.Drawing.Size(132, 20);
            this.txtLabMedicamento.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Deletar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(57, 154);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Comprar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cboMedicamentos
            // 
            this.cboMedicamentos.FormattingEnabled = true;
            this.cboMedicamentos.Location = new System.Drawing.Point(19, 116);
            this.cboMedicamentos.Name = "cboMedicamentos";
            this.cboMedicamentos.Size = new System.Drawing.Size(142, 21);
            this.cboMedicamentos.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Medicamento";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(57, 246);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 28;
            this.button5.Text = "Listar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lstLotes
            // 
            this.lstLotes.FormattingEnabled = true;
            this.lstLotes.Location = new System.Drawing.Point(12, 275);
            this.lstLotes.Name = "lstLotes";
            this.lstLotes.Size = new System.Drawing.Size(170, 121);
            this.lstLotes.TabIndex = 27;
            // 
            // txtQtdeVender
            // 
            this.txtQtdeVender.Location = new System.Drawing.Point(26, 200);
            this.txtQtdeVender.Name = "txtQtdeVender";
            this.txtQtdeVender.Size = new System.Drawing.Size(54, 20);
            this.txtQtdeVender.TabIndex = 26;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(86, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Vender";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lstMedicamentos
            // 
            this.lstMedicamentos.FormattingEnabled = true;
            this.lstMedicamentos.Location = new System.Drawing.Point(19, 140);
            this.lstMedicamentos.Name = "lstMedicamentos";
            this.lstMedicamentos.Size = new System.Drawing.Size(170, 121);
            this.lstMedicamentos.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 426);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtVencLote;
        private System.Windows.Forms.TextBox txtQtdeLote;
        private System.Windows.Forms.TextBox txtIdLote;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLabMedicamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeMedicamento;
        private System.Windows.Forms.TextBox txtIdMedicamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboMedicamentos;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox lstLotes;
        private System.Windows.Forms.TextBox txtQtdeVender;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lstMedicamentos;
    }
}

