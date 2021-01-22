namespace WF_HOMEWORK_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SectionPay1 = new System.Windows.Forms.GroupBox();
            this.FluentSumLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.texMoney = new System.Windows.Forms.TextBox();
            this.CountFuel = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.PriceFuel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Fluents = new System.Windows.Forms.ComboBox();
            this.Caffe = new System.Windows.Forms.GroupBox();
            this.Sum2 = new System.Windows.Forms.GroupBox();
            this.SectionCaffe = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CountCola = new System.Windows.Forms.TextBox();
            this.PrCola = new System.Windows.Forms.TextBox();
            this.CountFri = new System.Windows.Forms.TextBox();
            this.PrFri = new System.Windows.Forms.TextBox();
            this.CountHam = new System.Windows.Forms.TextBox();
            this.CountHotDog = new System.Windows.Forms.TextBox();
            this.PrHam = new System.Windows.Forms.TextBox();
            this.PrHotDog = new System.Windows.Forms.TextBox();
            this.checkCola = new System.Windows.Forms.CheckBox();
            this.CheckFri = new System.Windows.Forms.CheckBox();
            this.checkHam = new System.Windows.Forms.CheckBox();
            this.CheckHotDog = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.AllSum = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SectionPay1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Caffe.SuspendLayout();
            this.Sum2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SectionPay1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.texMoney);
            this.groupBox1.Controls.Add(this.CountFuel);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.PriceFuel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Fluents);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(29, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 358);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автозаправка";
            // 
            // SectionPay1
            // 
            this.SectionPay1.BackColor = System.Drawing.Color.White;
            this.SectionPay1.Controls.Add(this.FluentSumLabel);
            this.SectionPay1.ForeColor = System.Drawing.Color.Red;
            this.SectionPay1.Location = new System.Drawing.Point(6, 256);
            this.SectionPay1.Name = "SectionPay1";
            this.SectionPay1.Size = new System.Drawing.Size(251, 85);
            this.SectionPay1.TabIndex = 10;
            this.SectionPay1.TabStop = false;
            this.SectionPay1.Text = "К оплате";
            // 
            // FluentSumLabel
            // 
            this.FluentSumLabel.AutoSize = true;
            this.FluentSumLabel.Location = new System.Drawing.Point(140, 41);
            this.FluentSumLabel.Name = "FluentSumLabel";
            this.FluentSumLabel.Size = new System.Drawing.Size(0, 16);
            this.FluentSumLabel.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "руб.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "л.";
            // 
            // texMoney
            // 
            this.texMoney.Location = new System.Drawing.Point(131, 211);
            this.texMoney.Name = "texMoney";
            this.texMoney.Size = new System.Drawing.Size(100, 22);
            this.texMoney.TabIndex = 7;
            this.texMoney.TextChanged += new System.EventHandler(this.texMoney_TextChanged);
            this.texMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountFuel_KeyPress);
            // 
            // CountFuel
            // 
            this.CountFuel.Location = new System.Drawing.Point(131, 170);
            this.CountFuel.Name = "CountFuel";
            this.CountFuel.Size = new System.Drawing.Size(100, 22);
            this.CountFuel.TabIndex = 6;
            this.CountFuel.TextChanged += new System.EventHandler(this.CountFuel_TextChanged);
            this.CountFuel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountFuel_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(6, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(119, 100);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 61);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Сумма";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(107, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Количество";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // PriceFuel
            // 
            this.PriceFuel.Enabled = false;
            this.PriceFuel.Location = new System.Drawing.Point(110, 111);
            this.PriceFuel.Name = "PriceFuel";
            this.PriceFuel.Size = new System.Drawing.Size(121, 22);
            this.PriceFuel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Цена";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Бензин";
            // 
            // Fluents
            // 
            this.Fluents.FormattingEnabled = true;
            this.Fluents.Location = new System.Drawing.Point(110, 60);
            this.Fluents.Name = "Fluents";
            this.Fluents.Size = new System.Drawing.Size(121, 24);
            this.Fluents.TabIndex = 0;
            this.Fluents.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Caffe
            // 
            this.Caffe.Controls.Add(this.Sum2);
            this.Caffe.Controls.Add(this.label6);
            this.Caffe.Controls.Add(this.label5);
            this.Caffe.Controls.Add(this.CountCola);
            this.Caffe.Controls.Add(this.PrCola);
            this.Caffe.Controls.Add(this.CountFri);
            this.Caffe.Controls.Add(this.PrFri);
            this.Caffe.Controls.Add(this.CountHam);
            this.Caffe.Controls.Add(this.CountHotDog);
            this.Caffe.Controls.Add(this.PrHam);
            this.Caffe.Controls.Add(this.PrHotDog);
            this.Caffe.Controls.Add(this.checkCola);
            this.Caffe.Controls.Add(this.CheckFri);
            this.Caffe.Controls.Add(this.checkHam);
            this.Caffe.Controls.Add(this.CheckHotDog);
            this.Caffe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Caffe.Location = new System.Drawing.Point(339, 35);
            this.Caffe.Name = "Caffe";
            this.Caffe.Size = new System.Drawing.Size(306, 371);
            this.Caffe.TabIndex = 1;
            this.Caffe.TabStop = false;
            this.Caffe.Text = "Мини-кафе";
            // 
            // Sum2
            // 
            this.Sum2.BackColor = System.Drawing.Color.White;
            this.Sum2.Controls.Add(this.SectionCaffe);
            this.Sum2.ForeColor = System.Drawing.Color.Red;
            this.Sum2.Location = new System.Drawing.Point(22, 256);
            this.Sum2.Name = "Sum2";
            this.Sum2.Size = new System.Drawing.Size(251, 85);
            this.Sum2.TabIndex = 10;
            this.Sum2.TabStop = false;
            this.Sum2.Text = "К оплате";
            // 
            // SectionCaffe
            // 
            this.SectionCaffe.AutoSize = true;
            this.SectionCaffe.Location = new System.Drawing.Point(140, 41);
            this.SectionCaffe.Name = "SectionCaffe";
            this.SectionCaffe.Size = new System.Drawing.Size(0, 16);
            this.SectionCaffe.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Кол-во";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Цена";
            // 
            // CountCola
            // 
            this.CountCola.Location = new System.Drawing.Point(225, 136);
            this.CountCola.Name = "CountCola";
            this.CountCola.Size = new System.Drawing.Size(61, 22);
            this.CountCola.TabIndex = 1;
            this.CountCola.TextChanged += new System.EventHandler(this.CountCola_TextChanged);
            this.CountCola.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountFuel_KeyPress);
            // 
            // PrCola
            // 
            this.PrCola.Location = new System.Drawing.Point(148, 136);
            this.PrCola.Name = "PrCola";
            this.PrCola.Size = new System.Drawing.Size(61, 22);
            this.PrCola.TabIndex = 1;
            // 
            // CountFri
            // 
            this.CountFri.Location = new System.Drawing.Point(225, 108);
            this.CountFri.Name = "CountFri";
            this.CountFri.Size = new System.Drawing.Size(61, 22);
            this.CountFri.TabIndex = 1;
            this.CountFri.TextChanged += new System.EventHandler(this.CountFri_TextChanged);
            this.CountFri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountFuel_KeyPress);
            // 
            // PrFri
            // 
            this.PrFri.Location = new System.Drawing.Point(148, 108);
            this.PrFri.Name = "PrFri";
            this.PrFri.Size = new System.Drawing.Size(61, 22);
            this.PrFri.TabIndex = 1;
            // 
            // CountHam
            // 
            this.CountHam.Location = new System.Drawing.Point(225, 80);
            this.CountHam.Name = "CountHam";
            this.CountHam.Size = new System.Drawing.Size(61, 22);
            this.CountHam.TabIndex = 1;
            this.CountHam.TextChanged += new System.EventHandler(this.CountHam_TextChanged);
            this.CountHam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountFuel_KeyPress);
            // 
            // CountHotDog
            // 
            this.CountHotDog.Location = new System.Drawing.Point(225, 52);
            this.CountHotDog.Name = "CountHotDog";
            this.CountHotDog.Size = new System.Drawing.Size(61, 22);
            this.CountHotDog.TabIndex = 1;
            this.CountHotDog.TextChanged += new System.EventHandler(this.CountHotDog_TextChanged);
            this.CountHotDog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountFuel_KeyPress);
            // 
            // PrHam
            // 
            this.PrHam.Location = new System.Drawing.Point(148, 80);
            this.PrHam.Name = "PrHam";
            this.PrHam.Size = new System.Drawing.Size(61, 22);
            this.PrHam.TabIndex = 1;
            // 
            // PrHotDog
            // 
            this.PrHotDog.Location = new System.Drawing.Point(148, 52);
            this.PrHotDog.Name = "PrHotDog";
            this.PrHotDog.Size = new System.Drawing.Size(61, 22);
            this.PrHotDog.TabIndex = 1;
            // 
            // checkCola
            // 
            this.checkCola.AutoSize = true;
            this.checkCola.Location = new System.Drawing.Point(6, 136);
            this.checkCola.Name = "checkCola";
            this.checkCola.Size = new System.Drawing.Size(62, 20);
            this.checkCola.TabIndex = 0;
            this.checkCola.Text = "Кола";
            this.checkCola.UseVisualStyleBackColor = true;
            this.checkCola.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // CheckFri
            // 
            this.CheckFri.AutoSize = true;
            this.CheckFri.Location = new System.Drawing.Point(6, 111);
            this.CheckFri.Name = "CheckFri";
            this.CheckFri.Size = new System.Drawing.Size(133, 20);
            this.CheckFri.TabIndex = 0;
            this.CheckFri.Text = "Картофель фри";
            this.CheckFri.UseVisualStyleBackColor = true;
            this.CheckFri.CheckedChanged += new System.EventHandler(this.CheckFri_CheckedChanged);
            // 
            // checkHam
            // 
            this.checkHam.AutoSize = true;
            this.checkHam.Location = new System.Drawing.Point(6, 82);
            this.checkHam.Name = "checkHam";
            this.checkHam.Size = new System.Drawing.Size(100, 20);
            this.checkHam.TabIndex = 0;
            this.checkHam.Text = "Гамбургер";
            this.checkHam.UseVisualStyleBackColor = true;
            this.checkHam.CheckedChanged += new System.EventHandler(this.checkHam_CheckedChanged);
            // 
            // CheckHotDog
            // 
            this.CheckHotDog.AutoSize = true;
            this.CheckHotDog.BackColor = System.Drawing.Color.White;
            this.CheckHotDog.Location = new System.Drawing.Point(6, 54);
            this.CheckHotDog.Name = "CheckHotDog";
            this.CheckHotDog.Size = new System.Drawing.Size(80, 20);
            this.CheckHotDog.TabIndex = 0;
            this.CheckHotDog.Text = "Хот-Дог";
            this.CheckHotDog.UseVisualStyleBackColor = false;
            this.CheckHotDog.CheckedChanged += new System.EventHandler(this.CheckHotDog_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.AllSum);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Location = new System.Drawing.Point(29, 459);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(616, 159);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Всего к оплате";
            // 
            // AllSum
            // 
            this.AllSum.AutoSize = true;
            this.AllSum.Location = new System.Drawing.Point(332, 53);
            this.AllSum.Name = "AllSum";
            this.AllSum.Size = new System.Drawing.Size(0, 16);
            this.AllSum.TabIndex = 1;
            this.AllSum.TextChanged += new System.EventHandler(this.AllSum_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Всего к оплате";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 724);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(335, 87);
            this.button2.TabIndex = 3;
            this.button2.Text = "Закрыть смену";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(689, 847);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.Caffe);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Касса";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SectionPay1.ResumeLayout(false);
            this.SectionPay1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Caffe.ResumeLayout(false);
            this.Caffe.PerformLayout();
            this.Sum2.ResumeLayout(false);
            this.Sum2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PriceFuel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Fluents;
        private System.Windows.Forms.GroupBox Caffe;
        private System.Windows.Forms.GroupBox SectionPay1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox texMoney;
        private System.Windows.Forms.TextBox CountFuel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label FluentSumLabel;
        private System.Windows.Forms.TextBox CountCola;
        private System.Windows.Forms.TextBox PrCola;
        private System.Windows.Forms.TextBox CountFri;
        private System.Windows.Forms.TextBox PrFri;
        private System.Windows.Forms.TextBox CountHam;
        private System.Windows.Forms.TextBox CountHotDog;
        private System.Windows.Forms.TextBox PrHam;
        private System.Windows.Forms.TextBox PrHotDog;
        private System.Windows.Forms.CheckBox checkCola;
        private System.Windows.Forms.CheckBox CheckFri;
        private System.Windows.Forms.CheckBox checkHam;
        private System.Windows.Forms.CheckBox CheckHotDog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox Sum2;
        private System.Windows.Forms.Label SectionCaffe;
        private System.Windows.Forms.Label AllSum;
        private System.Windows.Forms.Button button2;
    }
}

