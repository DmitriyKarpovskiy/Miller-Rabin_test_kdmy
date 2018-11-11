namespace Miller_Rabin_test_kdmy
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
            this.lb_MillerRabin = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Go = new System.Windows.Forms.Button();
            this.lb_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_MillerRabin
            // 
            this.lb_MillerRabin.AutoSize = true;
            this.lb_MillerRabin.Font = new System.Drawing.Font("Tempus Sans ITC", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MillerRabin.Location = new System.Drawing.Point(154, 9);
            this.lb_MillerRabin.Name = "lb_MillerRabin";
            this.lb_MillerRabin.Size = new System.Drawing.Size(143, 34);
            this.lb_MillerRabin.TabIndex = 0;
            this.lb_MillerRabin.Text = "Is it Simple?";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btn_Go
            // 
            this.btn_Go.Location = new System.Drawing.Point(178, 93);
            this.btn_Go.Name = "btn_Go";
            this.btn_Go.Size = new System.Drawing.Size(100, 35);
            this.btn_Go.TabIndex = 2;
            this.btn_Go.Text = "Go";
            this.btn_Go.UseVisualStyleBackColor = true;
            this.btn_Go.Click += new System.EventHandler(this.btn_Go_Click);
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_result.Location = new System.Drawing.Point(154, 189);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(0, 35);
            this.lb_result.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 326);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.btn_Go);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_MillerRabin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_MillerRabin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Go;
        private System.Windows.Forms.Label lb_result;
    }
}

