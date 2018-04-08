namespace MNI.Controls
{
    partial class InitExperimentControl
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.acceptExpBtn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.factsCountTbx = new System.Windows.Forms.TextBox();
            this.setModelRbtn = new System.Windows.Forms.RadioButton();
            this.setOptimRbtn = new System.Windows.Forms.RadioButton();
            this.expTypeCbx = new System.Windows.Forms.ComboBox();
            this.clearExpBtn = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.clearExpBtn);
            this.groupBox5.Controls.Add(this.expTypeCbx);
            this.groupBox5.Controls.Add(this.acceptExpBtn);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.factsCountTbx);
            this.groupBox5.Controls.Add(this.setModelRbtn);
            this.groupBox5.Controls.Add(this.setOptimRbtn);
            this.groupBox5.Location = new System.Drawing.Point(0, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(480, 81);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Настройка эксперимента";
            // 
            // acceptExpBtn
            // 
            this.acceptExpBtn.Location = new System.Drawing.Point(406, 20);
            this.acceptExpBtn.Name = "acceptExpBtn";
            this.acceptExpBtn.Size = new System.Drawing.Size(66, 23);
            this.acceptExpBtn.TabIndex = 9;
            this.acceptExpBtn.Text = "ОК";
            this.acceptExpBtn.UseVisualStyleBackColor = true;
            this.acceptExpBtn.Click += new System.EventHandler(this.acceptExpBtn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(155, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Оптимизация";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(155, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Количество факторов";
            // 
            // factsCountTbx
            // 
            this.factsCountTbx.Location = new System.Drawing.Point(279, 20);
            this.factsCountTbx.Name = "factsCountTbx";
            this.factsCountTbx.Size = new System.Drawing.Size(121, 20);
            this.factsCountTbx.TabIndex = 6;
            // 
            // setModelRbtn
            // 
            this.setModelRbtn.AutoSize = true;
            this.setModelRbtn.Checked = true;
            this.setModelRbtn.Location = new System.Drawing.Point(6, 23);
            this.setModelRbtn.Name = "setModelRbtn";
            this.setModelRbtn.Size = new System.Drawing.Size(130, 17);
            this.setModelRbtn.TabIndex = 0;
            this.setModelRbtn.TabStop = true;
            this.setModelRbtn.Text = "Построение  модели";
            this.setModelRbtn.UseVisualStyleBackColor = true;
            // 
            // setOptimRbtn
            // 
            this.setOptimRbtn.AutoSize = true;
            this.setOptimRbtn.Location = new System.Drawing.Point(6, 48);
            this.setOptimRbtn.Name = "setOptimRbtn";
            this.setOptimRbtn.Size = new System.Drawing.Size(110, 17);
            this.setOptimRbtn.TabIndex = 1;
            this.setOptimRbtn.Text = "Поиск оптимума";
            this.setOptimRbtn.UseVisualStyleBackColor = true;
            // 
            // expTypeCbx
            // 
            this.expTypeCbx.FormattingEnabled = true;
            this.expTypeCbx.Items.AddRange(new object[] {
            "Максимум",
            "Минимум"});
            this.expTypeCbx.Location = new System.Drawing.Point(279, 52);
            this.expTypeCbx.Name = "expTypeCbx";
            this.expTypeCbx.Size = new System.Drawing.Size(121, 21);
            this.expTypeCbx.TabIndex = 10;
            // 
            // clearExpBtn
            // 
            this.clearExpBtn.Location = new System.Drawing.Point(406, 52);
            this.clearExpBtn.Name = "clearExpBtn";
            this.clearExpBtn.Size = new System.Drawing.Size(66, 23);
            this.clearExpBtn.TabIndex = 11;
            this.clearExpBtn.Text = "Сброс";
            this.clearExpBtn.UseVisualStyleBackColor = true;
            this.clearExpBtn.Click += new System.EventHandler(this.clearExpBtn_Click);
            // 
            // InitExperimentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox5);
            this.Name = "InitExperimentControl";
            this.Size = new System.Drawing.Size(481, 87);
            this.Load += new System.EventHandler(this.InitExperimentControl_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button acceptExpBtn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox factsCountTbx;
        private System.Windows.Forms.RadioButton setModelRbtn;
        private System.Windows.Forms.RadioButton setOptimRbtn;
        private System.Windows.Forms.ComboBox expTypeCbx;
        private System.Windows.Forms.Button clearExpBtn;
    }
}
