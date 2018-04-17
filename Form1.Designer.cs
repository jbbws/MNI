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
            this.seriesGrid = new System.Windows.Forms.DataGridView();
            this.btnStartMNK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.funcLbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fisherLab = new System.Windows.Forms.Label();
            this.computeGbx = new System.Windows.Forms.GroupBox();
            this.InitPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.toolPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.FactorPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buildExptBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.deteminationLab = new System.Windows.Forms.Label();
            this.fisherTbx = new System.Windows.Forms.TextBox();
            this.determTbx = new System.Windows.Forms.TextBox();
            this.clearMNKBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.seriesGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.computeGbx.SuspendLayout();
            this.toolPanel1.SuspendLayout();
            this.FactorPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox2.Controls.Add(this.funcLbl);
            this.groupBox2.Location = new System.Drawing.Point(507, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 56);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результирующая функция";
            // 
            // funcLbl
            // 
            this.funcLbl.AutoSize = true;
            this.funcLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.funcLbl.Location = new System.Drawing.Point(7, 20);
            this.funcLbl.Name = "funcLbl";
            this.funcLbl.Size = new System.Drawing.Size(0, 24);
            this.funcLbl.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.determTbx);
            this.groupBox3.Controls.Add(this.fisherTbx);
            this.groupBox3.Controls.Add(this.deteminationLab);
            this.groupBox3.Controls.Add(this.fisherLab);
            this.groupBox3.Location = new System.Drawing.Point(507, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 150);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Проверка адекватности";
            // 
            // fisherLab
            // 
            this.fisherLab.AutoSize = true;
            this.fisherLab.Location = new System.Drawing.Point(9, 39);
            this.fisherLab.Name = "fisherLab";
            this.fisherLab.Size = new System.Drawing.Size(104, 13);
            this.fisherLab.TabIndex = 0;
            this.fisherLab.Text = "Критерий Фишера:";
            // 
            // computeGbx
            // 
            this.computeGbx.Controls.Add(this.clearMNKBtn);
            this.computeGbx.Controls.Add(this.seriesGrid);
            this.computeGbx.Controls.Add(this.btnStartMNK);
            this.computeGbx.Enabled = false;
            this.computeGbx.Location = new System.Drawing.Point(3, 3);
            this.computeGbx.Name = "computeGbx";
            this.computeGbx.Size = new System.Drawing.Size(404, 201);
            this.computeGbx.TabIndex = 5;
            this.computeGbx.TabStop = false;
            this.computeGbx.Text = "Проведение эксперимента";
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
            this.flowLayoutPanel1.Controls.Add(this.computeGbx);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(507, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(416, 215);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // deteminationLab
            // 
            this.deteminationLab.AutoSize = true;
            this.deteminationLab.Location = new System.Drawing.Point(9, 84);
            this.deteminationLab.Name = "deteminationLab";
            this.deteminationLab.Size = new System.Drawing.Size(153, 13);
            this.deteminationLab.TabIndex = 2;
            this.deteminationLab.Text = "Коэффициент детерминации";
            // 
            // fisherTbx
            // 
            this.fisherTbx.Location = new System.Drawing.Point(188, 32);
            this.fisherTbx.Name = "fisherTbx";
            this.fisherTbx.ReadOnly = true;
            this.fisherTbx.Size = new System.Drawing.Size(44, 20);
            this.fisherTbx.TabIndex = 3;
            this.fisherTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // determTbx
            // 
            this.determTbx.Location = new System.Drawing.Point(188, 77);
            this.determTbx.Name = "determTbx";
            this.determTbx.ReadOnly = true;
            this.determTbx.Size = new System.Drawing.Size(44, 20);
            this.determTbx.TabIndex = 4;
            this.determTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clearMNKBtn
            // 
            this.clearMNKBtn.Location = new System.Drawing.Point(90, 19);
            this.clearMNKBtn.Name = "clearMNKBtn";
            this.clearMNKBtn.Size = new System.Drawing.Size(75, 23);
            this.clearMNKBtn.TabIndex = 3;
            this.clearMNKBtn.Text = "Очистить";
            this.clearMNKBtn.UseVisualStyleBackColor = true;
            this.clearMNKBtn.Click += new System.EventHandler(this.clearMNKBtn_Click);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.computeGbx.ResumeLayout(false);
            this.toolPanel1.ResumeLayout(false);
            this.toolPanel1.PerformLayout();
            this.FactorPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView seriesGrid;
        private System.Windows.Forms.Button btnStartMNK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label funcLbl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label fisherLab;
        private System.Windows.Forms.GroupBox computeGbx;
        private System.Windows.Forms.FlowLayoutPanel InitPanel;
        private System.Windows.Forms.FlowLayoutPanel toolPanel1;
        private System.Windows.Forms.FlowLayoutPanel FactorPanel;
        private System.Windows.Forms.Button buildExptBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox determTbx;
        private System.Windows.Forms.TextBox fisherTbx;
        private System.Windows.Forms.Label deteminationLab;
        private System.Windows.Forms.Button clearMNKBtn;
    }
}

