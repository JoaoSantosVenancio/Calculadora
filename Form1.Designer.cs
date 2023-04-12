
namespace exercicioCalculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.value7 = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.value9 = new System.Windows.Forms.Button();
            this.value8 = new System.Windows.Forms.Button();
            this.value5 = new System.Windows.Forms.Button();
            this.value6 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.value4 = new System.Windows.Forms.Button();
            this.value2 = new System.Windows.Forms.Button();
            this.value3 = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.value1 = new System.Windows.Forms.Button();
            this.value0 = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // value7
            // 
            this.value7.Location = new System.Drawing.Point(12, 65);
            this.value7.Name = "value7";
            this.value7.Size = new System.Drawing.Size(38, 36);
            this.value7.TabIndex = 1;
            this.value7.Text = "7";
            this.value7.UseVisualStyleBackColor = true;
            this.value7.Click += new System.EventHandler(this.value7_Click);
            // 
            // backspace
            // 
            this.backspace.Location = new System.Drawing.Point(188, 65);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(38, 36);
            this.backspace.TabIndex = 2;
            this.backspace.Text = "<--";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(144, 65);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(38, 36);
            this.clear.TabIndex = 3;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // value9
            // 
            this.value9.Location = new System.Drawing.Point(100, 65);
            this.value9.Name = "value9";
            this.value9.Size = new System.Drawing.Size(38, 36);
            this.value9.TabIndex = 4;
            this.value9.Text = "9";
            this.value9.UseVisualStyleBackColor = true;
            this.value9.Click += new System.EventHandler(this.value9_Click);
            // 
            // value8
            // 
            this.value8.Location = new System.Drawing.Point(56, 65);
            this.value8.Name = "value8";
            this.value8.Size = new System.Drawing.Size(38, 36);
            this.value8.TabIndex = 5;
            this.value8.Text = "8";
            this.value8.UseVisualStyleBackColor = true;
            this.value8.Click += new System.EventHandler(this.value8_Click);
            // 
            // value5
            // 
            this.value5.Location = new System.Drawing.Point(56, 117);
            this.value5.Name = "value5";
            this.value5.Size = new System.Drawing.Size(38, 36);
            this.value5.TabIndex = 10;
            this.value5.Text = "5";
            this.value5.UseVisualStyleBackColor = true;
            this.value5.Click += new System.EventHandler(this.value5_Click);
            // 
            // value6
            // 
            this.value6.Location = new System.Drawing.Point(100, 117);
            this.value6.Name = "value6";
            this.value6.Size = new System.Drawing.Size(38, 36);
            this.value6.TabIndex = 9;
            this.value6.Text = "6";
            this.value6.UseVisualStyleBackColor = true;
            this.value6.Click += new System.EventHandler(this.value6_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(144, 117);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(38, 36);
            this.add.TabIndex = 8;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(188, 117);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(38, 36);
            this.sub.TabIndex = 7;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // value4
            // 
            this.value4.Location = new System.Drawing.Point(12, 117);
            this.value4.Name = "value4";
            this.value4.Size = new System.Drawing.Size(38, 36);
            this.value4.TabIndex = 6;
            this.value4.Text = "4";
            this.value4.UseVisualStyleBackColor = true;
            this.value4.Click += new System.EventHandler(this.value4_Click);
            // 
            // value2
            // 
            this.value2.Location = new System.Drawing.Point(56, 169);
            this.value2.Name = "value2";
            this.value2.Size = new System.Drawing.Size(38, 36);
            this.value2.TabIndex = 15;
            this.value2.Text = "2";
            this.value2.UseVisualStyleBackColor = true;
            this.value2.Click += new System.EventHandler(this.value2_Click);
            // 
            // value3
            // 
            this.value3.Location = new System.Drawing.Point(100, 169);
            this.value3.Name = "value3";
            this.value3.Size = new System.Drawing.Size(38, 36);
            this.value3.TabIndex = 14;
            this.value3.Text = "3";
            this.value3.UseVisualStyleBackColor = true;
            this.value3.Click += new System.EventHandler(this.value3_Click);
            // 
            // mult
            // 
            this.mult.Location = new System.Drawing.Point(144, 169);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(38, 36);
            this.mult.TabIndex = 13;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(188, 169);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(38, 36);
            this.div.TabIndex = 12;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // value1
            // 
            this.value1.Location = new System.Drawing.Point(12, 169);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(38, 36);
            this.value1.TabIndex = 11;
            this.value1.Text = "1";
            this.value1.UseVisualStyleBackColor = true;
            this.value1.Click += new System.EventHandler(this.value1_Click);
            // 
            // value0
            // 
            this.value0.Location = new System.Drawing.Point(12, 220);
            this.value0.Name = "value0";
            this.value0.Size = new System.Drawing.Size(76, 36);
            this.value0.TabIndex = 16;
            this.value0.Text = "0";
            this.value0.UseVisualStyleBackColor = true;
            this.value0.Click += new System.EventHandler(this.value0_Click);
            // 
            // point
            // 
            this.point.Location = new System.Drawing.Point(100, 220);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(38, 36);
            this.point.TabIndex = 17;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(144, 220);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(82, 36);
            this.equals.TabIndex = 18;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 276);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.point);
            this.Controls.Add(this.value0);
            this.Controls.Add(this.value2);
            this.Controls.Add(this.value3);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.div);
            this.Controls.Add(this.value1);
            this.Controls.Add(this.value5);
            this.Controls.Add(this.value6);
            this.Controls.Add(this.add);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.value4);
            this.Controls.Add(this.value8);
            this.Controls.Add(this.value9);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.value7);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button value7;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button value9;
        private System.Windows.Forms.Button value8;
        private System.Windows.Forms.Button value5;
        private System.Windows.Forms.Button value6;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button value4;
        private System.Windows.Forms.Button value2;
        private System.Windows.Forms.Button value3;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button value1;
        private System.Windows.Forms.Button value0;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button equals;
    }
}

