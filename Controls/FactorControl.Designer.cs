namespace MNI.Controls
{
    partial class FactorControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbFact1 = new System.Windows.Forms.GroupBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.intTbx = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.topTbx = new System.Windows.Forms.TextBox();
            this.initTbx = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.botTbx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbFact1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFact1
            // 
            this.gbFact1.Controls.Add(this.clearBtn);
            this.gbFact1.Controls.Add(this.submitBtn);
            this.gbFact1.Controls.Add(this.intTbx);
            this.gbFact1.Controls.Add(this.label13);
            this.gbFact1.Controls.Add(this.topTbx);
            this.gbFact1.Controls.Add(this.initTbx);
            this.gbFact1.Controls.Add(this.label12);
            this.gbFact1.Controls.Add(this.botTbx);
            this.gbFact1.Controls.Add(this.label6);
            this.gbFact1.Controls.Add(this.label5);
            this.gbFact1.Location = new System.Drawing.Point(0, 0);
            this.gbFact1.Name = "gbFact1";
            this.gbFact1.Size = new System.Drawing.Size(480, 81);
            this.gbFact1.TabIndex = 1;
            this.gbFact1.TabStop = false;
            this.gbFact1.Text = "Фактор";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(418, 53);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(53, 23);
            this.clearBtn.TabIndex = 15;
            this.clearBtn.Text = "Сброс";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearHanlder);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(418, 22);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(53, 23);
            this.submitBtn.TabIndex = 14;
            this.submitBtn.Text = "Ok";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.SubmitHandler);
            // 
            // intTbx
            // 
            this.intTbx.Location = new System.Drawing.Point(296, 52);
            this.intTbx.Name = "intTbx";
            this.intTbx.Size = new System.Drawing.Size(67, 20);
            this.intTbx.TabIndex = 13;
            this.intTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(197, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Интервал";
            // 
            // topTbx
            // 
            this.topTbx.Location = new System.Drawing.Point(296, 22);
            this.topTbx.Name = "topTbx";
            this.topTbx.Size = new System.Drawing.Size(67, 20);
            this.topTbx.TabIndex = 6;
            this.topTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // initTbx
            // 
            this.initTbx.Location = new System.Drawing.Point(103, 52);
            this.initTbx.Name = "initTbx";
            this.initTbx.Size = new System.Drawing.Size(67, 20);
            this.initTbx.TabIndex = 11;
            this.initTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Начальная точка";
            // 
            // botTbx
            // 
            this.botTbx.Location = new System.Drawing.Point(103, 22);
            this.botTbx.Name = "botTbx";
            this.botTbx.Size = new System.Drawing.Size(67, 20);
            this.botTbx.TabIndex = 5;
            this.botTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Верхняя граница";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Нижняя граница";
            // 
            // FactorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFact1);
            this.Name = "FactorControl";
            this.Size = new System.Drawing.Size(480, 83);
            this.gbFact1.ResumeLayout(false);
            this.gbFact1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFact1;
        private System.Windows.Forms.TextBox botTbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox initTbx;
        private System.Windows.Forms.TextBox topTbx;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox intTbx;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button clearBtn;
    }
}
