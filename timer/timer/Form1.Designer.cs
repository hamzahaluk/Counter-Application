namespace timer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_basla = new System.Windows.Forms.Button();
            this.btn_dur = new System.Windows.Forms.Button();
            this.btn_sifirla = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(190, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 35);
            this.textBox1.TabIndex = 0;
            // 
            // btn_basla
            // 
            this.btn_basla.Location = new System.Drawing.Point(190, 175);
            this.btn_basla.Name = "btn_basla";
            this.btn_basla.Size = new System.Drawing.Size(75, 23);
            this.btn_basla.TabIndex = 1;
            this.btn_basla.Text = "Başlat";
            this.btn_basla.UseVisualStyleBackColor = true;
            this.btn_basla.Click += new System.EventHandler(this.btn_basla_Click);
            // 
            // btn_dur
            // 
            this.btn_dur.Location = new System.Drawing.Point(285, 175);
            this.btn_dur.Name = "btn_dur";
            this.btn_dur.Size = new System.Drawing.Size(75, 23);
            this.btn_dur.TabIndex = 2;
            this.btn_dur.Text = "Dur";
            this.btn_dur.UseVisualStyleBackColor = true;
            this.btn_dur.Click += new System.EventHandler(this.btn_dur_Click);
            // 
            // btn_sifirla
            // 
            this.btn_sifirla.Location = new System.Drawing.Point(377, 175);
            this.btn_sifirla.Name = "btn_sifirla";
            this.btn_sifirla.Size = new System.Drawing.Size(75, 23);
            this.btn_sifirla.TabIndex = 3;
            this.btn_sifirla.Text = "Sıfırla";
            this.btn_sifirla.UseVisualStyleBackColor = true;
            this.btn_sifirla.Click += new System.EventHandler(this.btn_sifirla_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 340);
            this.Controls.Add(this.btn_sifirla);
            this.Controls.Add(this.btn_dur);
            this.Controls.Add(this.btn_basla);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_basla;
        private System.Windows.Forms.Button btn_dur;
        private System.Windows.Forms.Button btn_sifirla;
        private System.Windows.Forms.Timer timer1;
    }
}

