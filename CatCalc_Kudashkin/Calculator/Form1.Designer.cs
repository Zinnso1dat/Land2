namespace Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.Button();
            this.AgeCat = new System.Windows.Forms.ComboBox();
            this.AgePersonTxt = new System.Windows.Forms.Label();
            this.MounthPersonTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Возраст кошки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "По человеческим меркам";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ЛЕТ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ЛЕТ";
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(292, 32);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(87, 36);
            this.answer.TabIndex = 6;
            this.answer.Text = "Расчитать";
            this.answer.UseVisualStyleBackColor = true;
            // 
            // AgeCat
            // 
            this.AgeCat.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.AgeCat.Location = new System.Drawing.Point(169, 32);
            this.AgeCat.Name = "AgeCat";
            this.AgeCat.Size = new System.Drawing.Size(50, 21);
            this.AgeCat.TabIndex = 7;
            // 
            // AgePersonTxt
            // 
            this.AgePersonTxt.AutoSize = true;
            this.AgePersonTxt.Location = new System.Drawing.Point(169, 75);
            this.AgePersonTxt.Name = "AgePersonTxt";
            this.AgePersonTxt.Size = new System.Drawing.Size(0, 13);
            this.AgePersonTxt.TabIndex = 9;
            // 
            // MounthPersonTxt
            // 
            this.MounthPersonTxt.AutoSize = true;
            this.MounthPersonTxt.Location = new System.Drawing.Point(273, 75);
            this.MounthPersonTxt.Name = "MounthPersonTxt";
            this.MounthPersonTxt.Size = new System.Drawing.Size(0, 13);
            this.MounthPersonTxt.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 121);
            this.Controls.Add(this.MounthPersonTxt);
            this.Controls.Add(this.AgePersonTxt);
            this.Controls.Add(this.AgeCat);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Button answer;

        private System.Windows.Forms.ComboBox AgeCat;

        private System.Windows.Forms.Label AgePersonTxt;

        private System.Windows.Forms.Label MounthPersonTxt;
    }
}

