namespace ProcessamentoDeImagens
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btLoadA = new System.Windows.Forms.Button();
            this.btLoadB = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btSalvarImg = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txBlending = new System.Windows.Forms.TextBox();
            this.btBlending = new System.Windows.Forms.Button();
            this.btMed = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.btMult = new System.Windows.Forms.Button();
            this.btSub = new System.Windows.Forms.Button();
            this.btAdc = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btNOT = new System.Windows.Forms.Button();
            this.btXOR = new System.Windows.Forms.Button();
            this.btOR = new System.Windows.Forms.Button();
            this.btAND = new System.Windows.Forms.Button();
            this.RGBtoOneBit = new System.Windows.Forms.Button();
            this.RGBtoEigthBit = new System.Windows.Forms.Button();
            this.btEqualHist = new System.Windows.Forms.Button();
            this.ToNeg = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btSuavizacao = new System.Windows.Forms.Button();
            this.numOrdem = new System.Windows.Forms.NumericUpDown();
            this.btOrdem = new System.Windows.Forms.Button();
            this.btMediana = new System.Windows.Forms.Button();
            this.rb7x7 = new System.Windows.Forms.RadioButton();
            this.rb5x5 = new System.Windows.Forms.RadioButton();
            this.rb3x3 = new System.Windows.Forms.RadioButton();
            this.btMedia = new System.Windows.Forms.Button();
            this.btMin = new System.Windows.Forms.Button();
            this.btMax = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btGaussiano = new System.Windows.Forms.Button();
            this.txGaussiano = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrdem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // btLoadA
            // 
            this.btLoadA.Location = new System.Drawing.Point(58, 201);
            this.btLoadA.Name = "btLoadA";
            this.btLoadA.Size = new System.Drawing.Size(125, 40);
            this.btLoadA.TabIndex = 0;
            this.btLoadA.Text = "Carregar Imagem A";
            this.btLoadA.UseVisualStyleBackColor = true;
            this.btLoadA.Click += new System.EventHandler(this.btLoadA_Click);
            // 
            // btLoadB
            // 
            this.btLoadB.Location = new System.Drawing.Point(61, 201);
            this.btLoadB.Name = "btLoadB";
            this.btLoadB.Size = new System.Drawing.Size(125, 40);
            this.btLoadB.TabIndex = 1;
            this.btLoadB.Text = "Carregar Imagem B";
            this.btLoadB.UseVisualStyleBackColor = true;
            this.btLoadB.Click += new System.EventHandler(this.btLoadB_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(270, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 178);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btLoadA);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 247);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imagem A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btLoadB);
            this.groupBox2.Location = new System.Drawing.Point(259, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 247);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imagem B";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.btSalvarImg);
            this.groupBox3.Location = new System.Drawing.Point(804, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 247);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Imagem Resultante";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(6, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(216, 178);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // btSalvarImg
            // 
            this.btSalvarImg.Location = new System.Drawing.Point(55, 201);
            this.btSalvarImg.Name = "btSalvarImg";
            this.btSalvarImg.Size = new System.Drawing.Size(125, 40);
            this.btSalvarImg.TabIndex = 1;
            this.btSalvarImg.Text = "Salvar Imagem";
            this.btSalvarImg.UseVisualStyleBackColor = true;
            this.btSalvarImg.Click += new System.EventHandler(this.btSalvarImg_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txBlending);
            this.groupBox4.Controls.Add(this.btBlending);
            this.groupBox4.Controls.Add(this.btMed);
            this.groupBox4.Controls.Add(this.btDiv);
            this.groupBox4.Controls.Add(this.btMult);
            this.groupBox4.Controls.Add(this.btSub);
            this.groupBox4.Controls.Add(this.btAdc);
            this.groupBox4.Location = new System.Drawing.Point(549, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(181, 194);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Operações aritméticas";
            // 
            // txBlending
            // 
            this.txBlending.Location = new System.Drawing.Point(108, 162);
            this.txBlending.Name = "txBlending";
            this.txBlending.Size = new System.Drawing.Size(67, 20);
            this.txBlending.TabIndex = 8;
            // 
            // btBlending
            // 
            this.btBlending.Location = new System.Drawing.Point(7, 162);
            this.btBlending.Name = "btBlending";
            this.btBlending.Size = new System.Drawing.Size(95, 23);
            this.btBlending.TabIndex = 5;
            this.btBlending.Text = "Blending";
            this.btBlending.UseVisualStyleBackColor = true;
            this.btBlending.Click += new System.EventHandler(this.btBlending_Click);
            // 
            // btMed
            // 
            this.btMed.Location = new System.Drawing.Point(7, 133);
            this.btMed.Name = "btMed";
            this.btMed.Size = new System.Drawing.Size(95, 23);
            this.btMed.TabIndex = 4;
            this.btMed.Text = "Média";
            this.btMed.UseVisualStyleBackColor = true;
            this.btMed.Click += new System.EventHandler(this.btMed_Click);
            // 
            // btDiv
            // 
            this.btDiv.Location = new System.Drawing.Point(7, 104);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(95, 23);
            this.btDiv.TabIndex = 3;
            this.btDiv.Text = "Divisão";
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
            // 
            // btMult
            // 
            this.btMult.Location = new System.Drawing.Point(7, 75);
            this.btMult.Name = "btMult";
            this.btMult.Size = new System.Drawing.Size(95, 23);
            this.btMult.TabIndex = 2;
            this.btMult.Text = "Multiplicação";
            this.btMult.UseVisualStyleBackColor = true;
            this.btMult.Click += new System.EventHandler(this.btMult_Click);
            // 
            // btSub
            // 
            this.btSub.Location = new System.Drawing.Point(7, 46);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(95, 23);
            this.btSub.TabIndex = 1;
            this.btSub.Text = "Subtração";
            this.btSub.UseVisualStyleBackColor = true;
            this.btSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // btAdc
            // 
            this.btAdc.Location = new System.Drawing.Point(7, 17);
            this.btAdc.Name = "btAdc";
            this.btAdc.Size = new System.Drawing.Size(95, 23);
            this.btAdc.TabIndex = 0;
            this.btAdc.Text = "Adição";
            this.btAdc.UseVisualStyleBackColor = true;
            this.btAdc.Click += new System.EventHandler(this.btAdc_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btNOT);
            this.groupBox5.Controls.Add(this.btXOR);
            this.groupBox5.Controls.Add(this.btOR);
            this.groupBox5.Controls.Add(this.btAND);
            this.groupBox5.Location = new System.Drawing.Point(549, 213);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(112, 137);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Operações lógicas";
            // 
            // btNOT
            // 
            this.btNOT.Location = new System.Drawing.Point(7, 106);
            this.btNOT.Name = "btNOT";
            this.btNOT.Size = new System.Drawing.Size(95, 23);
            this.btNOT.TabIndex = 9;
            this.btNOT.Text = "NOT";
            this.btNOT.UseVisualStyleBackColor = true;
            this.btNOT.Click += new System.EventHandler(this.btNOT_Click);
            // 
            // btXOR
            // 
            this.btXOR.Location = new System.Drawing.Point(7, 77);
            this.btXOR.Name = "btXOR";
            this.btXOR.Size = new System.Drawing.Size(95, 23);
            this.btXOR.TabIndex = 8;
            this.btXOR.Text = "XOR";
            this.btXOR.UseVisualStyleBackColor = true;
            this.btXOR.Click += new System.EventHandler(this.btXOR_Click);
            // 
            // btOR
            // 
            this.btOR.Location = new System.Drawing.Point(7, 48);
            this.btOR.Name = "btOR";
            this.btOR.Size = new System.Drawing.Size(95, 23);
            this.btOR.TabIndex = 7;
            this.btOR.Text = "OR";
            this.btOR.UseVisualStyleBackColor = true;
            this.btOR.Click += new System.EventHandler(this.btOR_Click);
            // 
            // btAND
            // 
            this.btAND.Location = new System.Drawing.Point(7, 19);
            this.btAND.Name = "btAND";
            this.btAND.Size = new System.Drawing.Size(95, 23);
            this.btAND.TabIndex = 6;
            this.btAND.Text = "AND";
            this.btAND.UseVisualStyleBackColor = true;
            this.btAND.Click += new System.EventHandler(this.btAND_Click);
            // 
            // RGBtoOneBit
            // 
            this.RGBtoOneBit.Location = new System.Drawing.Point(25, 265);
            this.RGBtoOneBit.Name = "RGBtoOneBit";
            this.RGBtoOneBit.Size = new System.Drawing.Size(75, 23);
            this.RGBtoOneBit.TabIndex = 12;
            this.RGBtoOneBit.Text = "RGB -> 1bit";
            this.RGBtoOneBit.UseVisualStyleBackColor = true;
            this.RGBtoOneBit.Click += new System.EventHandler(this.RGBtoOneBit_Click);
            // 
            // RGBtoEigthBit
            // 
            this.RGBtoEigthBit.Location = new System.Drawing.Point(25, 294);
            this.RGBtoEigthBit.Name = "RGBtoEigthBit";
            this.RGBtoEigthBit.Size = new System.Drawing.Size(75, 23);
            this.RGBtoEigthBit.TabIndex = 13;
            this.RGBtoEigthBit.Text = "RGB -> 8bit";
            this.RGBtoEigthBit.UseVisualStyleBackColor = true;
            this.RGBtoEigthBit.Click += new System.EventHandler(this.RGBtoEigthBit_Click);
            // 
            // btEqualHist
            // 
            this.btEqualHist.Location = new System.Drawing.Point(259, 470);
            this.btEqualHist.Name = "btEqualHist";
            this.btEqualHist.Size = new System.Drawing.Size(73, 61);
            this.btEqualHist.TabIndex = 8;
            this.btEqualHist.Text = "Equalização do Histograma";
            this.btEqualHist.UseVisualStyleBackColor = true;
            this.btEqualHist.Click += new System.EventHandler(this.btEqualHist_Click);
            // 
            // ToNeg
            // 
            this.ToNeg.Location = new System.Drawing.Point(25, 323);
            this.ToNeg.Name = "ToNeg";
            this.ToNeg.Size = new System.Drawing.Size(75, 23);
            this.ToNeg.TabIndex = 14;
            this.ToNeg.Text = "Negativo";
            this.ToNeg.UseVisualStyleBackColor = true;
            this.ToNeg.Click += new System.EventHandler(this.ToNeg_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txGaussiano);
            this.groupBox7.Controls.Add(this.btGaussiano);
            this.groupBox7.Controls.Add(this.btSuavizacao);
            this.groupBox7.Controls.Add(this.numOrdem);
            this.groupBox7.Controls.Add(this.btOrdem);
            this.groupBox7.Controls.Add(this.btMediana);
            this.groupBox7.Controls.Add(this.rb7x7);
            this.groupBox7.Controls.Add(this.rb5x5);
            this.groupBox7.Controls.Add(this.rb3x3);
            this.groupBox7.Controls.Add(this.btMedia);
            this.groupBox7.Controls.Add(this.btMin);
            this.groupBox7.Controls.Add(this.btMax);
            this.groupBox7.Location = new System.Drawing.Point(804, 265);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(229, 162);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Realce de Imagens";
            // 
            // btSuavizacao
            // 
            this.btSuavizacao.Location = new System.Drawing.Point(108, 77);
            this.btSuavizacao.Name = "btSuavizacao";
            this.btSuavizacao.Size = new System.Drawing.Size(95, 23);
            this.btSuavizacao.TabIndex = 15;
            this.btSuavizacao.Text = "SUAVIZAÇÃO";
            this.btSuavizacao.UseVisualStyleBackColor = true;
            this.btSuavizacao.Click += new System.EventHandler(this.btSuavizacao_Click);
            // 
            // numOrdem
            // 
            this.numOrdem.Location = new System.Drawing.Point(186, 51);
            this.numOrdem.Name = "numOrdem";
            this.numOrdem.Size = new System.Drawing.Size(36, 20);
            this.numOrdem.TabIndex = 14;
            // 
            // btOrdem
            // 
            this.btOrdem.Location = new System.Drawing.Point(108, 48);
            this.btOrdem.Name = "btOrdem";
            this.btOrdem.Size = new System.Drawing.Size(72, 23);
            this.btOrdem.TabIndex = 13;
            this.btOrdem.Text = "ORDEM";
            this.btOrdem.UseVisualStyleBackColor = true;
            this.btOrdem.Click += new System.EventHandler(this.btOrdem_Click);
            // 
            // btMediana
            // 
            this.btMediana.Location = new System.Drawing.Point(108, 19);
            this.btMediana.Name = "btMediana";
            this.btMediana.Size = new System.Drawing.Size(95, 23);
            this.btMediana.TabIndex = 12;
            this.btMediana.Text = "MEDIANA";
            this.btMediana.UseVisualStyleBackColor = true;
            this.btMediana.Click += new System.EventHandler(this.btMediana_Click);
            // 
            // rb7x7
            // 
            this.rb7x7.AutoSize = true;
            this.rb7x7.Location = new System.Drawing.Point(181, 139);
            this.rb7x7.Name = "rb7x7";
            this.rb7x7.Size = new System.Drawing.Size(48, 17);
            this.rb7x7.TabIndex = 11;
            this.rb7x7.Text = "7 x 7";
            this.rb7x7.UseVisualStyleBackColor = true;
            // 
            // rb5x5
            // 
            this.rb5x5.AutoSize = true;
            this.rb5x5.Location = new System.Drawing.Point(132, 139);
            this.rb5x5.Name = "rb5x5";
            this.rb5x5.Size = new System.Drawing.Size(48, 17);
            this.rb5x5.TabIndex = 10;
            this.rb5x5.Text = "5 x 5";
            this.rb5x5.UseVisualStyleBackColor = true;
            // 
            // rb3x3
            // 
            this.rb3x3.AutoSize = true;
            this.rb3x3.Checked = true;
            this.rb3x3.Location = new System.Drawing.Point(78, 139);
            this.rb3x3.Name = "rb3x3";
            this.rb3x3.Size = new System.Drawing.Size(48, 17);
            this.rb3x3.TabIndex = 9;
            this.rb3x3.TabStop = true;
            this.rb3x3.Text = "3 x 3";
            this.rb3x3.UseVisualStyleBackColor = true;
            // 
            // btMedia
            // 
            this.btMedia.Location = new System.Drawing.Point(7, 77);
            this.btMedia.Name = "btMedia";
            this.btMedia.Size = new System.Drawing.Size(95, 23);
            this.btMedia.TabIndex = 8;
            this.btMedia.Text = "MEDIA";
            this.btMedia.UseVisualStyleBackColor = true;
            this.btMedia.Click += new System.EventHandler(this.btMedia_Click);
            // 
            // btMin
            // 
            this.btMin.Location = new System.Drawing.Point(7, 48);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(95, 23);
            this.btMin.TabIndex = 7;
            this.btMin.Text = "MIN";
            this.btMin.UseVisualStyleBackColor = true;
            this.btMin.Click += new System.EventHandler(this.btMin_Click);
            // 
            // btMax
            // 
            this.btMax.Location = new System.Drawing.Point(7, 19);
            this.btMax.Name = "btMax";
            this.btMax.Size = new System.Drawing.Size(95, 23);
            this.btMax.TabIndex = 6;
            this.btMax.Text = "MAX";
            this.btMax.UseVisualStyleBackColor = true;
            this.btMax.Click += new System.EventHandler(this.btMax_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(25, 405);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(319, 216);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(350, 405);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(319, 214);
            this.chart2.TabIndex = 16;
            this.chart2.Text = "chart2";
            // 
            // btGaussiano
            // 
            this.btGaussiano.Location = new System.Drawing.Point(108, 106);
            this.btGaussiano.Name = "btGaussiano";
            this.btGaussiano.Size = new System.Drawing.Size(72, 23);
            this.btGaussiano.TabIndex = 16;
            this.btGaussiano.Text = "GAUSSIAN";
            this.btGaussiano.UseVisualStyleBackColor = true;
            this.btGaussiano.Click += new System.EventHandler(this.btGaussiano_Click);
            // 
            // txGaussiano
            // 
            this.txGaussiano.Location = new System.Drawing.Point(186, 108);
            this.txGaussiano.Name = "txGaussiano";
            this.txGaussiano.Size = new System.Drawing.Size(36, 20);
            this.txGaussiano.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 633);
            this.Controls.Add(this.ToNeg);
            this.Controls.Add(this.btEqualHist);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.RGBtoEigthBit);
            this.Controls.Add(this.RGBtoOneBit);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrdem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btLoadA;
        private System.Windows.Forms.Button btLoadB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btSalvarImg;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btBlending;
        private System.Windows.Forms.Button btMed;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Button btMult;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button btAdc;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btNOT;
        private System.Windows.Forms.Button btXOR;
        private System.Windows.Forms.Button btOR;
        private System.Windows.Forms.Button btAND;
        private System.Windows.Forms.TextBox txBlending;
        private System.Windows.Forms.Button RGBtoOneBit;
        private System.Windows.Forms.Button RGBtoEigthBit;
        private System.Windows.Forms.Button btEqualHist;
        private System.Windows.Forms.Button ToNeg;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btMedia;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Button btMax;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.RadioButton rb7x7;
        private System.Windows.Forms.RadioButton rb5x5;
        private System.Windows.Forms.RadioButton rb3x3;
        private System.Windows.Forms.Button btMediana;
        private System.Windows.Forms.NumericUpDown numOrdem;
        private System.Windows.Forms.Button btOrdem;
        private System.Windows.Forms.Button btSuavizacao;
        private System.Windows.Forms.TextBox txGaussiano;
        private System.Windows.Forms.Button btGaussiano;
    }
}

