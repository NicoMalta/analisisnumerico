namespace WpfApp1
{
    partial class Integracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_funcion = new System.Windows.Forms.TextBox();
            this.A = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_n = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bttn_ts = new System.Windows.Forms.Button();
            this.bttn_tm = new System.Windows.Forms.Button();
            this.bttn_s13 = new System.Windows.Forms.Button();
            this.bttn_s13m = new System.Windows.Forms.Button();
            this.bttn_s38 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(113, 31);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(42, 20);
            this.txt_a.TabIndex = 0;
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(220, 31);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(41, 20);
            this.txt_b.TabIndex = 1;
            // 
            // txt_funcion
            // 
            this.txt_funcion.Location = new System.Drawing.Point(51, 56);
            this.txt_funcion.Name = "txt_funcion";
            this.txt_funcion.Size = new System.Drawing.Size(210, 20);
            this.txt_funcion.TabIndex = 2;
            this.txt_funcion.TextChanged += new System.EventHandler(this.txt_funcion_TextChanged);
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.Location = new System.Drawing.Point(91, 30);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(16, 17);
            this.A.TabIndex = 3;
            this.A.Text = "a";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "b";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "F(x)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Intervalos:";
            // 
            // txt_n
            // 
            this.txt_n.Location = new System.Drawing.Point(51, 82);
            this.txt_n.Name = "txt_n";
            this.txt_n.Size = new System.Drawing.Size(56, 20);
            this.txt_n.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "n";
            // 
            // bttn_ts
            // 
            this.bttn_ts.Location = new System.Drawing.Point(12, 125);
            this.bttn_ts.Name = "bttn_ts";
            this.bttn_ts.Size = new System.Drawing.Size(116, 23);
            this.bttn_ts.TabIndex = 9;
            this.bttn_ts.Text = "Trapecios Simple";
            this.bttn_ts.UseVisualStyleBackColor = true;
            this.bttn_ts.Click += new System.EventHandler(this.bttn_ts_Click);
            // 
            // bttn_tm
            // 
            this.bttn_tm.Location = new System.Drawing.Point(12, 154);
            this.bttn_tm.Name = "bttn_tm";
            this.bttn_tm.Size = new System.Drawing.Size(116, 23);
            this.bttn_tm.TabIndex = 10;
            this.bttn_tm.Text = "Trapecios Multiple";
            this.bttn_tm.UseVisualStyleBackColor = true;
            this.bttn_tm.Click += new System.EventHandler(this.bttn_tm_Click);
            // 
            // bttn_s13
            // 
            this.bttn_s13.Location = new System.Drawing.Point(12, 183);
            this.bttn_s13.Name = "bttn_s13";
            this.bttn_s13.Size = new System.Drawing.Size(116, 23);
            this.bttn_s13.TabIndex = 11;
            this.bttn_s13.Text = "Simpson 1/3 Simple";
            this.bttn_s13.UseVisualStyleBackColor = true;
            this.bttn_s13.Click += new System.EventHandler(this.bttn_s13_Click);
            // 
            // bttn_s13m
            // 
            this.bttn_s13m.Location = new System.Drawing.Point(12, 212);
            this.bttn_s13m.Name = "bttn_s13m";
            this.bttn_s13m.Size = new System.Drawing.Size(116, 23);
            this.bttn_s13m.TabIndex = 12;
            this.bttn_s13m.Text = "Simpson 1/3 Multiple";
            this.bttn_s13m.UseVisualStyleBackColor = true;
            this.bttn_s13m.Click += new System.EventHandler(this.bttn_s13m_Click);
            // 
            // bttn_s38
            // 
            this.bttn_s38.Location = new System.Drawing.Point(12, 241);
            this.bttn_s38.Name = "bttn_s38";
            this.bttn_s38.Size = new System.Drawing.Size(116, 23);
            this.bttn_s38.TabIndex = 13;
            this.bttn_s38.Text = "Simpson 3/8 Simple";
            this.bttn_s38.UseVisualStyleBackColor = true;
            this.bttn_s38.Click += new System.EventHandler(this.bttn_s38_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Resultado";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(170, 154);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(0, 13);
            this.lbl_resultado.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(147, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 155);
            this.panel1.TabIndex = 16;
            // 
            // Integracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 284);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bttn_s38);
            this.Controls.Add(this.bttn_s13m);
            this.Controls.Add(this.bttn_s13);
            this.Controls.Add(this.bttn_tm);
            this.Controls.Add(this.bttn_ts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_n);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.A);
            this.Controls.Add(this.txt_funcion);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.panel1);
            this.Name = "Integracion";
            this.Text = "Integracion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_funcion;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_n;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttn_ts;
        private System.Windows.Forms.Button bttn_tm;
        private System.Windows.Forms.Button bttn_s13;
        private System.Windows.Forms.Button bttn_s13m;
        private System.Windows.Forms.Button bttn_s38;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Panel panel1;
    }
}