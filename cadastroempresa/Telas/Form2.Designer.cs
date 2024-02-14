namespace cadastroempresa
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.tx_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_razao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_nomefantasia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_data = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tx_cap = new System.Windows.Forms.TextBox();
            this.tx_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tx_situacao = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tx_est = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tx_bairro = new System.Windows.Forms.TextBox();
            this.tx_rua = new System.Windows.Forms.TextBox();
            this.tx_num = new System.Windows.Forms.NumericUpDown();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.tx_nat = new System.Windows.Forms.ComboBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.tx_nomepro = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tx_regime = new System.Windows.Forms.GroupBox();
            this.tx_porte = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.tx_tipo = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tx_cidade = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tx_num)).BeginInit();
            this.tx_regime.SuspendLayout();
            this.tx_porte.SuspendLayout();
            this.tx_tipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe seus dados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "CNPJ";
            // 
            // tx_cnpj
            // 
            this.tx_cnpj.Location = new System.Drawing.Point(144, 81);
            this.tx_cnpj.Mask = "00,000,000/0000-00";
            this.tx_cnpj.Name = "tx_cnpj";
            this.tx_cnpj.Size = new System.Drawing.Size(169, 22);
            this.tx_cnpj.TabIndex = 2;
            // 
            // tx_cpf
            // 
            this.tx_cpf.Location = new System.Drawing.Point(425, 81);
            this.tx_cpf.Mask = "000,000,000-00";
            this.tx_cpf.Name = "tx_cpf";
            this.tx_cpf.Size = new System.Drawing.Size(169, 22);
            this.tx_cpf.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(372, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(656, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Razão Social";
            // 
            // tx_razao
            // 
            this.tx_razao.Location = new System.Drawing.Point(782, 80);
            this.tx_razao.Name = "tx_razao";
            this.tx_razao.Size = new System.Drawing.Size(195, 22);
            this.tx_razao.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nome Fantasia";
            // 
            // tx_nomefantasia
            // 
            this.tx_nomefantasia.Location = new System.Drawing.Point(224, 153);
            this.tx_nomefantasia.Name = "tx_nomefantasia";
            this.tx_nomefantasia.Size = new System.Drawing.Size(209, 22);
            this.tx_nomefantasia.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(454, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Data Início";
            // 
            // tx_data
            // 
            this.tx_data.Location = new System.Drawing.Point(563, 151);
            this.tx_data.Name = "tx_data";
            this.tx_data.Size = new System.Drawing.Size(414, 22);
            this.tx_data.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Capital Social";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(463, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Telefone";
            // 
            // tx_cap
            // 
            this.tx_cap.Location = new System.Drawing.Point(224, 212);
            this.tx_cap.Name = "tx_cap";
            this.tx_cap.Size = new System.Drawing.Size(209, 22);
            this.tx_cap.TabIndex = 13;
            // 
            // tx_telefone
            // 
            this.tx_telefone.Location = new System.Drawing.Point(563, 212);
            this.tx_telefone.Mask = "(00) 00000 - 0000";
            this.tx_telefone.Name = "tx_telefone";
            this.tx_telefone.Size = new System.Drawing.Size(164, 22);
            this.tx_telefone.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(752, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "Situação";
            // 
            // tx_situacao
            // 
            this.tx_situacao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_situacao.FormattingEnabled = true;
            this.tx_situacao.Items.AddRange(new object[] {
            "Ativa",
            "Nula",
            "Suspensa",
            "Inapta",
            "Baixada"});
            this.tx_situacao.Location = new System.Drawing.Point(840, 208);
            this.tx_situacao.Name = "tx_situacao";
            this.tx_situacao.Size = new System.Drawing.Size(137, 30);
            this.tx_situacao.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(77, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 23);
            this.label10.TabIndex = 17;
            this.label10.Text = "Estado";
            // 
            // tx_est
            // 
            this.tx_est.FormattingEnabled = true;
            this.tx_est.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.tx_est.Location = new System.Drawing.Point(151, 269);
            this.tx_est.Name = "tx_est";
            this.tx_est.Size = new System.Drawing.Size(137, 24);
            this.tx_est.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(540, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 23);
            this.label11.TabIndex = 19;
            this.label11.Text = "Bairro";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(788, 270);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 23);
            this.label12.TabIndex = 20;
            this.label12.Text = "Rua";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(79, 317);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 23);
            this.label13.TabIndex = 21;
            this.label13.Text = "N°";
            // 
            // tx_bairro
            // 
            this.tx_bairro.Location = new System.Drawing.Point(605, 269);
            this.tx_bairro.Name = "tx_bairro";
            this.tx_bairro.Size = new System.Drawing.Size(170, 22);
            this.tx_bairro.TabIndex = 22;
            // 
            // tx_rua
            // 
            this.tx_rua.Location = new System.Drawing.Point(838, 271);
            this.tx_rua.Name = "tx_rua";
            this.tx_rua.Size = new System.Drawing.Size(142, 22);
            this.tx_rua.TabIndex = 23;
            // 
            // tx_num
            // 
            this.tx_num.Location = new System.Drawing.Point(118, 318);
            this.tx_num.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.tx_num.Name = "tx_num";
            this.tx_num.Size = new System.Drawing.Size(85, 22);
            this.tx_num.TabIndex = 24;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(20, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(173, 27);
            this.radioButton1.TabIndex = 26;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Simples Nacional";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(272, 39);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(174, 27);
            this.radioButton2.TabIndex = 27;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Lucro Presumido";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(528, 39);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(70, 27);
            this.radioButton3.TabIndex = 28;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Real";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(617, 315);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(159, 23);
            this.label16.TabIndex = 32;
            this.label16.Text = "Natureza Jurítica";
            // 
            // tx_nat
            // 
            this.tx_nat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_nat.FormattingEnabled = true;
            this.tx_nat.Items.AddRange(new object[] {
            "Empresário Indívidual",
            "Microempreendedor Indívidual",
            "Sociedade Anônima"});
            this.tx_nat.Location = new System.Drawing.Point(782, 310);
            this.tx_nat.Name = "tx_nat";
            this.tx_nat.Size = new System.Drawing.Size(195, 31);
            this.tx_nat.TabIndex = 33;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.Location = new System.Drawing.Point(20, 45);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(103, 27);
            this.radioButton6.TabIndex = 35;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Pequeno";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton7.Location = new System.Drawing.Point(211, 45);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(83, 27);
            this.radioButton7.TabIndex = 36;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Médio";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton8.Location = new System.Drawing.Point(372, 45);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(95, 27);
            this.radioButton8.TabIndex = 37;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Grande";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(211, 315);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(192, 23);
            this.label18.TabIndex = 38;
            this.label18.Text = "Nome do Proprietário";
            // 
            // tx_nomepro
            // 
            this.tx_nomepro.Location = new System.Drawing.Point(409, 316);
            this.tx_nomepro.Name = "tx_nomepro";
            this.tx_nomepro.Size = new System.Drawing.Size(202, 22);
            this.tx_nomepro.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(668, 659);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 38);
            this.button1.TabIndex = 40;
            this.button1.Text = "Apagar tudo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(859, 659);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 38);
            this.button2.TabIndex = 41;
            this.button2.Text = "Salvar ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tx_regime
            // 
            this.tx_regime.Controls.Add(this.radioButton1);
            this.tx_regime.Controls.Add(this.radioButton2);
            this.tx_regime.Controls.Add(this.radioButton3);
            this.tx_regime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_regime.Location = new System.Drawing.Point(62, 356);
            this.tx_regime.Name = "tx_regime";
            this.tx_regime.Size = new System.Drawing.Size(918, 97);
            this.tx_regime.TabIndex = 42;
            this.tx_regime.TabStop = false;
            this.tx_regime.Text = "Regime Tributário";
            this.tx_regime.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tx_porte
            // 
            this.tx_porte.Controls.Add(this.groupBox3);
            this.tx_porte.Controls.Add(this.radioButton6);
            this.tx_porte.Controls.Add(this.radioButton7);
            this.tx_porte.Controls.Add(this.radioButton8);
            this.tx_porte.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_porte.Location = new System.Drawing.Point(62, 459);
            this.tx_porte.Name = "tx_porte";
            this.tx_porte.Size = new System.Drawing.Size(918, 95);
            this.tx_porte.TabIndex = 43;
            this.tx_porte.TabStop = false;
            this.tx_porte.Text = "Porte da Empresa";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(0, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(896, 70);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(204, 38);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(72, 27);
            this.radioButton5.TabIndex = 31;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Filial";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(20, 38);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(89, 27);
            this.radioButton4.TabIndex = 30;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Matriz";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // tx_tipo
            // 
            this.tx_tipo.Controls.Add(this.radioButton4);
            this.tx_tipo.Controls.Add(this.radioButton5);
            this.tx_tipo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_tipo.Location = new System.Drawing.Point(62, 560);
            this.tx_tipo.Name = "tx_tipo";
            this.tx_tipo.Size = new System.Drawing.Size(918, 88);
            this.tx_tipo.TabIndex = 44;
            this.tx_tipo.TabStop = false;
            this.tx_tipo.Text = "Tipo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(312, 269);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 23);
            this.label14.TabIndex = 45;
            this.label14.Text = "Cidade";
            // 
            // tx_cidade
            // 
            this.tx_cidade.Location = new System.Drawing.Point(387, 269);
            this.tx_cidade.Name = "tx_cidade";
            this.tx_cidade.Size = new System.Drawing.Size(147, 22);
            this.tx_cidade.TabIndex = 46;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1013, 709);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tx_cidade);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tx_tipo);
            this.Controls.Add(this.tx_porte);
            this.Controls.Add(this.tx_regime);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tx_nomepro);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tx_nat);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tx_num);
            this.Controls.Add(this.tx_rua);
            this.Controls.Add(this.tx_bairro);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tx_est);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tx_situacao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tx_telefone);
            this.Controls.Add(this.tx_cap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tx_data);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tx_nomefantasia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tx_razao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx_cpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_cnpj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tx_num)).EndInit();
            this.tx_regime.ResumeLayout(false);
            this.tx_regime.PerformLayout();
            this.tx_porte.ResumeLayout(false);
            this.tx_porte.PerformLayout();
            this.tx_tipo.ResumeLayout(false);
            this.tx_tipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox tx_cnpj;
        private System.Windows.Forms.MaskedTextBox tx_cpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_razao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx_nomefantasia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker tx_data;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tx_cap;
        private System.Windows.Forms.MaskedTextBox tx_telefone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox tx_situacao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox tx_est;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tx_bairro;
        private System.Windows.Forms.TextBox tx_rua;
        private System.Windows.Forms.NumericUpDown tx_num;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox tx_nat;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tx_nomepro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox tx_regime;
        private System.Windows.Forms.GroupBox tx_porte;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox tx_tipo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tx_cidade;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}