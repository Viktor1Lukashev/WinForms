namespace WinformsHomeWork_1._7
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OnDay = new System.Windows.Forms.RadioButton();
            this.OnMinutes = new System.Windows.Forms.RadioButton();
            this.OnHours = new System.Windows.Forms.RadioButton();
            this.OnMonth = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "рассчитать время";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 22);
            this.textBox1.TabIndex = 1;
            // 
            // OnDay
            // 
            this.OnDay.AutoSize = true;
            this.OnDay.Location = new System.Drawing.Point(6, 31);
            this.OnDay.Name = "OnDay";
            this.OnDay.Size = new System.Drawing.Size(70, 20);
            this.OnDay.TabIndex = 2;
            this.OnDay.TabStop = true;
            this.OnDay.Text = "В днях";
            this.OnDay.UseVisualStyleBackColor = true;
            this.OnDay.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // OnMinutes
            // 
            this.OnMinutes.AutoSize = true;
            this.OnMinutes.Location = new System.Drawing.Point(6, 57);
            this.OnMinutes.Name = "OnMinutes";
            this.OnMinutes.Size = new System.Drawing.Size(95, 20);
            this.OnMinutes.TabIndex = 2;
            this.OnMinutes.TabStop = true;
            this.OnMinutes.Text = "В минутах";
            this.OnMinutes.UseVisualStyleBackColor = true;
            this.OnMinutes.MouseCaptureChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // OnHours
            // 
            this.OnHours.AutoSize = true;
            this.OnHours.Location = new System.Drawing.Point(6, 83);
            this.OnHours.Name = "OnHours";
            this.OnHours.Size = new System.Drawing.Size(78, 20);
            this.OnHours.TabIndex = 2;
            this.OnHours.TabStop = true;
            this.OnHours.Text = "В часах";
            this.OnHours.UseVisualStyleBackColor = true;
            this.OnHours.MouseCaptureChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // OnMonth
            // 
            this.OnMonth.AutoSize = true;
            this.OnMonth.Location = new System.Drawing.Point(6, 109);
            this.OnMonth.Name = "OnMonth";
            this.OnMonth.Size = new System.Drawing.Size(94, 20);
            this.OnMonth.TabIndex = 2;
            this.OnMonth.TabStop = true;
            this.OnMonth.Text = "В месяцах";
            this.OnMonth.UseVisualStyleBackColor = true;
            this.OnMonth.MouseCaptureChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OnMinutes);
            this.groupBox1.Controls.Add(this.OnDay);
            this.groupBox1.Controls.Add(this.OnMonth);
            this.groupBox1.Controls.Add(this.OnHours);
            this.groupBox1.Location = new System.Drawing.Point(254, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 217);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Варианты рассчета  времени";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите дату (ДД.ММ.ГГГГ)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton OnDay;
        private System.Windows.Forms.RadioButton OnMinutes;
        private System.Windows.Forms.RadioButton OnHours;
        private System.Windows.Forms.RadioButton OnMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}

