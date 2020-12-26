namespace UI
{
    partial class Limits
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.USDoper = new System.Windows.Forms.TextBox();
            this.EURoper = new System.Windows.Forms.TextBox();
            this.RUBoper = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.USDclient = new System.Windows.Forms.TextBox();
            this.EURclient = new System.Windows.Forms.TextBox();
            this.RUBclient = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(287, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Лимиты на обмен";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(107, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Лимиты на операцию";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "EUR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "USD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "RUB";
            // 
            // USDoper
            // 
            this.USDoper.Location = new System.Drawing.Point(141, 195);
            this.USDoper.Name = "USDoper";
            this.USDoper.Size = new System.Drawing.Size(100, 22);
            this.USDoper.TabIndex = 5;
            this.USDoper.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EURoper
            // 
            this.EURoper.Location = new System.Drawing.Point(141, 246);
            this.EURoper.Name = "EURoper";
            this.EURoper.Size = new System.Drawing.Size(100, 22);
            this.EURoper.TabIndex = 6;
            // 
            // RUBoper
            // 
            this.RUBoper.Location = new System.Drawing.Point(141, 300);
            this.RUBoper.Name = "RUBoper";
            this.RUBoper.Size = new System.Drawing.Size(100, 22);
            this.RUBoper.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 65);
            this.button2.TabIndex = 10;
            this.button2.Text = "Вернуться на главную страницу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(490, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Лимиты на день для пользователя";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(586, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "USD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(586, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "EUR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(586, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "RUB";
            // 
            // USDclient
            // 
            this.USDclient.Location = new System.Drawing.Point(555, 195);
            this.USDclient.Name = "USDclient";
            this.USDclient.Size = new System.Drawing.Size(100, 22);
            this.USDclient.TabIndex = 15;
            // 
            // EURclient
            // 
            this.EURclient.Location = new System.Drawing.Point(555, 246);
            this.EURclient.Name = "EURclient";
            this.EURclient.Size = new System.Drawing.Size(100, 22);
            this.EURclient.TabIndex = 16;
            // 
            // RUBclient
            // 
            this.RUBclient.Location = new System.Drawing.Point(555, 300);
            this.RUBclient.Name = "RUBclient";
            this.RUBclient.Size = new System.Drawing.Size(100, 22);
            this.RUBclient.TabIndex = 17;
            // 
            // Limits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RUBclient);
            this.Controls.Add(this.EURclient);
            this.Controls.Add(this.USDclient);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RUBoper);
            this.Controls.Add(this.EURoper);
            this.Controls.Add(this.USDoper);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Limits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лимиты на обмен";
            this.Load += new System.EventHandler(this.Limits_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox USDoper;
        private System.Windows.Forms.TextBox EURoper;
        private System.Windows.Forms.TextBox RUBoper;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox USDclient;
        private System.Windows.Forms.TextBox EURclient;
        private System.Windows.Forms.TextBox RUBclient;
    }
}