namespace MNI
{
    partial class CustomForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.seriesGrid = new System.Windows.Forms.DataGridView();
            this.btnStartMNK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.UseManualLevel_cb = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.funcTextLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fisherLab = new System.Windows.Forms.Label();
            this.compute_gb = new System.Windows.Forms.GroupBox();
            this.InitPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.toolPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.FactorPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buildExptBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.seriesGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.compute_gb.SuspendLayout();
            this.toolPanel1.SuspendLayout();
            this.FactorPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фактор #2 (x2):Заразность болезни. \r\nОбласть определения [0,1]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фактор #1 (x1): Длительность лечения. \r\nОбласть определения [3,100]";
            // 
            // seriesGrid
            // 
            this.seriesGrid.AllowUserToAddRows = false;
            this.seriesGrid.AllowUserToDeleteRows = false;
            this.seriesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seriesGrid.Location = new System.Drawing.Point(9, 56);
            this.seriesGrid.Name = "seriesGrid";
            this.seriesGrid.Size = new System.Drawing.Size(389, 129);
            this.seriesGrid.TabIndex = 2;
            // 
            // btnStartMNK
            // 
            this.btnStartMNK.Location = new System.Drawing.Point(9, 19);
            this.btnStartMNK.Name = "btnStartMNK";
            this.btnStartMNK.Size = new System.Drawing.Size(75, 23);
            this.btnStartMNK.TabIndex = 1;
            this.btnStartMNK.Text = "Расчет";
            this.btnStartMNK.UseVisualStyleBackColor = true;
            this.btnStartMNK.Click += new System.EventHandler(this.btnStartMNK_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.funcTextLabel);
            this.groupBox2.Location = new System.Drawing.Point(507, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 56);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результирующая функция";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.UseManualLevel_cb);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.textBox4);
            this.groupBox7.Controls.Add(this.textBox3);
            this.groupBox7.Controls.Add(this.textBox2);
            this.groupBox7.Controls.Add(this.textBox1);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Location = new System.Drawing.Point(20, 55);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(453, 100);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Начальные параметры";
            // 
            // UseManualLevel_cb
            // 
            this.UseManualLevel_cb.AutoSize = true;
            this.UseManualLevel_cb.Location = new System.Drawing.Point(7, 37);
            this.UseManualLevel_cb.Name = "UseManualLevel_cb";
            this.UseManualLevel_cb.Size = new System.Drawing.Size(103, 17);
            this.UseManualLevel_cb.TabIndex = 11;
            this.UseManualLevel_cb.Text = "Разные уровни";
            this.UseManualLevel_cb.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(367, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Интервал";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(257, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Начальная точка";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(133, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Параметры фактора 2";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(370, 61);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(67, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(260, 61);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(67, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(370, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(260, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(133, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Параметры фактора 1";
            // 
            // funcTextLabel
            // 
            this.funcTextLabel.AutoSize = true;
            this.funcTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.funcTextLabel.Location = new System.Drawing.Point(7, 20);
            this.funcTextLabel.Name = "funcTextLabel";
            this.funcTextLabel.Size = new System.Drawing.Size(0, 24);
            this.funcTextLabel.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.fisherLab);
            this.groupBox3.Location = new System.Drawing.Point(507, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(443, 65);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Проверка адекватности";
            // 
            // fisherLab
            // 
            this.fisherLab.AutoSize = true;
            this.fisherLab.Location = new System.Drawing.Point(6, 36);
            this.fisherLab.Name = "fisherLab";
            this.fisherLab.Size = new System.Drawing.Size(104, 13);
            this.fisherLab.TabIndex = 0;
            this.fisherLab.Text = "Критерий Фишера:";
            // 
            // compute_gb
            // 
            this.compute_gb.Controls.Add(this.seriesGrid);
            this.compute_gb.Controls.Add(this.btnStartMNK);
            this.compute_gb.Location = new System.Drawing.Point(3, 3);
            this.compute_gb.Name = "compute_gb";
            this.compute_gb.Size = new System.Drawing.Size(404, 201);
            this.compute_gb.TabIndex = 5;
            this.compute_gb.TabStop = false;
            this.compute_gb.Text = "Проведение эксперимента";
            // 
            // InitPanel
            // 
            this.InitPanel.AutoSize = true;
            this.InitPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.InitPanel.Location = new System.Drawing.Point(3, 3);
            this.InitPanel.Name = "InitPanel";
            this.InitPanel.Size = new System.Drawing.Size(0, 0);
            this.InitPanel.TabIndex = 7;
            // 
            // toolPanel1
            // 
            this.toolPanel1.AutoSize = true;
            this.toolPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toolPanel1.Controls.Add(this.InitPanel);
            this.toolPanel1.Controls.Add(this.FactorPanel);
            this.toolPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.toolPanel1.Location = new System.Drawing.Point(2, 3);
            this.toolPanel1.Name = "toolPanel1";
            this.toolPanel1.Size = new System.Drawing.Size(87, 41);
            this.toolPanel1.TabIndex = 8;
            // 
            // FactorPanel
            // 
            this.FactorPanel.AutoSize = true;
            this.FactorPanel.Controls.Add(this.buildExptBtn);
            this.FactorPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FactorPanel.Location = new System.Drawing.Point(3, 9);
            this.FactorPanel.Name = "FactorPanel";
            this.FactorPanel.Size = new System.Drawing.Size(81, 29);
            this.FactorPanel.TabIndex = 9;
            // 
            // buildExptBtn
            // 
            this.buildExptBtn.Location = new System.Drawing.Point(3, 3);
            this.buildExptBtn.Name = "buildExptBtn";
            this.buildExptBtn.Size = new System.Drawing.Size(75, 23);
            this.buildExptBtn.TabIndex = 9;
            this.buildExptBtn.Text = "Построить";
            this.buildExptBtn.UseVisualStyleBackColor = true;
            this.buildExptBtn.Click += new System.EventHandler(this.buildExptBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.compute_gb);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(507, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(416, 215);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // CustomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 511);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.toolPanel1);
            this.Name = "CustomForm";
            this.Text = "Проведение эксперимента";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seriesGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.compute_gb.ResumeLayout(false);
            this.toolPanel1.ResumeLayout(false);
            this.toolPanel1.PerformLayout();
            this.FactorPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView seriesGrid;
        private System.Windows.Forms.Button btnStartMNK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label funcTextLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label fisherLab;
        private System.Windows.Forms.GroupBox compute_gb;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox UseManualLevel_cb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FlowLayoutPanel InitPanel;
        private System.Windows.Forms.FlowLayoutPanel toolPanel1;
        private System.Windows.Forms.FlowLayoutPanel FactorPanel;
        private System.Windows.Forms.Button buildExptBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

