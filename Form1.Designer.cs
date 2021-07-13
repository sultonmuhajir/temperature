
namespace temperature
{
    partial class temperature
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.judul = new System.Windows.Forms.Label();
            this.celsius = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fahrenheit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kelvin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.reamur = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // judul
            // 
            this.judul.AutoSize = true;
            this.judul.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.judul.Location = new System.Drawing.Point(210, 15);
            this.judul.Name = "judul";
            this.judul.Size = new System.Drawing.Size(210, 45);
            this.judul.TabIndex = 0;
            this.judul.Text = "Temperature";
            // 
            // celsius
            // 
            this.celsius.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.celsius.Location = new System.Drawing.Point(45, 121);
            this.celsius.Multiline = true;
            this.celsius.Name = "celsius";
            this.celsius.Size = new System.Drawing.Size(257, 50);
            this.celsius.TabIndex = 1;
            this.celsius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.celsius.KeyUp += new System.Windows.Forms.KeyEventHandler(this.celsius_KeyUp);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Celsius";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(329, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fahrenheit";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fahrenheit
            // 
            this.fahrenheit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fahrenheit.Location = new System.Drawing.Point(329, 121);
            this.fahrenheit.Multiline = true;
            this.fahrenheit.Name = "fahrenheit";
            this.fahrenheit.Size = new System.Drawing.Size(257, 50);
            this.fahrenheit.TabIndex = 3;
            this.fahrenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fahrenheit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fahrenheit_KeyUp);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(45, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kelvin";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kelvin
            // 
            this.kelvin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kelvin.Location = new System.Drawing.Point(45, 235);
            this.kelvin.Multiline = true;
            this.kelvin.Name = "kelvin";
            this.kelvin.Size = new System.Drawing.Size(257, 50);
            this.kelvin.TabIndex = 5;
            this.kelvin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kelvin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kelvin_KeyUp);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(329, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reamur";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reamur
            // 
            this.reamur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reamur.Location = new System.Drawing.Point(329, 235);
            this.reamur.Multiline = true;
            this.reamur.Name = "reamur";
            this.reamur.Size = new System.Drawing.Size(257, 50);
            this.reamur.TabIndex = 7;
            this.reamur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reamur.KeyUp += new System.Windows.Forms.KeyEventHandler(this.reamur_KeyUp);
            // 
            // temperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 339);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reamur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kelvin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fahrenheit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.celsius);
            this.Controls.Add(this.judul);
            this.Name = "temperature";
            this.Text = "Temperature";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label judul;
        private System.Windows.Forms.TextBox celsius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fahrenheit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kelvin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox reamur;
    }
}

