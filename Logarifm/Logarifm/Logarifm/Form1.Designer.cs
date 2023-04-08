namespace Logarifm
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
            this.btn_sim = new System.Windows.Forms.Button();
            this.btn_sqr = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.textSim = new System.Windows.Forms.TextBox();
            this.text_sqr = new System.Windows.Forms.TextBox();
            this.text_del = new System.Windows.Forms.TextBox();
            this.FormulaTextBox = new System.Windows.Forms.TextBox();
            this.btnFormula = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.ArgTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_sim
            // 
            this.btn_sim.Location = new System.Drawing.Point(464, 220);
            this.btn_sim.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sim.Name = "btn_sim";
            this.btn_sim.Size = new System.Drawing.Size(100, 28);
            this.btn_sim.TabIndex = 0;
            this.btn_sim.Text = "Simpson";
            this.btn_sim.UseVisualStyleBackColor = true;
            this.btn_sim.Click += new System.EventHandler(this.btn_sim_Click);
            // 
            // btn_sqr
            // 
            this.btn_sqr.Location = new System.Drawing.Point(464, 256);
            this.btn_sqr.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sqr.Name = "btn_sqr";
            this.btn_sqr.Size = new System.Drawing.Size(100, 28);
            this.btn_sqr.TabIndex = 2;
            this.btn_sqr.Text = "Sqr";
            this.btn_sqr.UseVisualStyleBackColor = true;
            this.btn_sqr.Click += new System.EventHandler(this.btn_sqr_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(464, 292);
            this.btn_del.Margin = new System.Windows.Forms.Padding(4);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(100, 28);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "Del";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // textSim
            // 
            this.textSim.Location = new System.Drawing.Point(572, 220);
            this.textSim.Margin = new System.Windows.Forms.Padding(4);
            this.textSim.Name = "textSim";
            this.textSim.Size = new System.Drawing.Size(132, 22);
            this.textSim.TabIndex = 4;
            this.textSim.TextChanged += new System.EventHandler(this.textSim_TextChanged);
            // 
            // text_sqr
            // 
            this.text_sqr.Location = new System.Drawing.Point(572, 256);
            this.text_sqr.Margin = new System.Windows.Forms.Padding(4);
            this.text_sqr.Name = "text_sqr";
            this.text_sqr.Size = new System.Drawing.Size(132, 22);
            this.text_sqr.TabIndex = 5;
            this.text_sqr.TextChanged += new System.EventHandler(this.text_sqr_TextChanged);
            // 
            // text_del
            // 
            this.text_del.Location = new System.Drawing.Point(572, 295);
            this.text_del.Margin = new System.Windows.Forms.Padding(4);
            this.text_del.Name = "text_del";
            this.text_del.Size = new System.Drawing.Size(132, 22);
            this.text_del.TabIndex = 6;
            this.text_del.TextChanged += new System.EventHandler(this.text_del_TextChanged);
            // 
            // FormulaTextBox
            // 
            this.FormulaTextBox.Location = new System.Drawing.Point(54, 67);
            this.FormulaTextBox.Name = "FormulaTextBox";
            this.FormulaTextBox.Size = new System.Drawing.Size(328, 22);
            this.FormulaTextBox.TabIndex = 7;
            // 
            // btnFormula
            // 
            this.btnFormula.Location = new System.Drawing.Point(388, 30);
            this.btnFormula.Name = "btnFormula";
            this.btnFormula.Size = new System.Drawing.Size(176, 79);
            this.btnFormula.TabIndex = 8;
            this.btnFormula.Text = "Вычислить";
            this.btnFormula.UseVisualStyleBackColor = true;
            this.btnFormula.Click += new System.EventHandler(this.btnFormula_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(134, 105);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(197, 22);
            this.resultTextBox.TabIndex = 9;
            // 
            // ArgTextBox
            // 
            this.ArgTextBox.Location = new System.Drawing.Point(282, 36);
            this.ArgTextBox.Name = "ArgTextBox";
            this.ArgTextBox.Size = new System.Drawing.Size(82, 22);
            this.ArgTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "x =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "f(x) =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "значение в иксе";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArgTextBox);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.btnFormula);
            this.Controls.Add(this.FormulaTextBox);
            this.Controls.Add(this.text_del);
            this.Controls.Add(this.text_sqr);
            this.Controls.Add(this.textSim);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_sqr);
            this.Controls.Add(this.btn_sim);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sim;
        private System.Windows.Forms.Button btn_sqr;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.TextBox textSim;
        private System.Windows.Forms.TextBox text_sqr;
        private System.Windows.Forms.TextBox text_del;
        private System.Windows.Forms.TextBox FormulaTextBox;
        private System.Windows.Forms.Button btnFormula;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.TextBox ArgTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

