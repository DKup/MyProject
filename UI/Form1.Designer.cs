namespace UI
{
    partial class MainMenu
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
            this.exchangeCurrency = new System.Windows.Forms.Button();
            this.showHistory = new System.Windows.Forms.Button();
            this.setLimits = new System.Windows.Forms.Button();
            this.setRateOfExchange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.enterAdmin = new System.Windows.Forms.Button();
            this.exitAdmin = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exchangeCurrency
            // 
            this.exchangeCurrency.Location = new System.Drawing.Point(203, 78);
            this.exchangeCurrency.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exchangeCurrency.Name = "exchangeCurrency";
            this.exchangeCurrency.Size = new System.Drawing.Size(200, 38);
            this.exchangeCurrency.TabIndex = 0;
            this.exchangeCurrency.Text = "Обмен валюты";
            this.exchangeCurrency.UseVisualStyleBackColor = true;
            this.exchangeCurrency.Click += new System.EventHandler(this.button1_Click);
            // 
            // showHistory
            // 
            this.showHistory.Location = new System.Drawing.Point(203, 132);
            this.showHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showHistory.Name = "showHistory";
            this.showHistory.Size = new System.Drawing.Size(200, 38);
            this.showHistory.TabIndex = 1;
            this.showHistory.Text = "История операций";
            this.showHistory.UseVisualStyleBackColor = true;
            this.showHistory.Visible = false;
            this.showHistory.Click += new System.EventHandler(this.showHistory_Click);
            // 
            // setLimits
            // 
            this.setLimits.Location = new System.Drawing.Point(203, 240);
            this.setLimits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.setLimits.Name = "setLimits";
            this.setLimits.Size = new System.Drawing.Size(200, 38);
            this.setLimits.TabIndex = 2;
            this.setLimits.Text = "Установить лимиты";
            this.setLimits.UseVisualStyleBackColor = true;
            this.setLimits.Visible = false;
            this.setLimits.Click += new System.EventHandler(this.setLimits_Click);
            // 
            // setRateOfExchange
            // 
            this.setRateOfExchange.Location = new System.Drawing.Point(203, 186);
            this.setRateOfExchange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.setRateOfExchange.Name = "setRateOfExchange";
            this.setRateOfExchange.Size = new System.Drawing.Size(200, 38);
            this.setRateOfExchange.TabIndex = 3;
            this.setRateOfExchange.Text = "Установить курсы обмена валют";
            this.setRateOfExchange.UseVisualStyleBackColor = true;
            this.setRateOfExchange.Visible = false;
            this.setRateOfExchange.Click += new System.EventHandler(this.setRateOfExchange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Режим администратора";
            // 
            // enterAdmin
            // 
            this.enterAdmin.Location = new System.Drawing.Point(54, 39);
            this.enterAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enterAdmin.Name = "enterAdmin";
            this.enterAdmin.Size = new System.Drawing.Size(70, 21);
            this.enterAdmin.TabIndex = 17;
            this.enterAdmin.Text = "Включить";
            this.enterAdmin.UseVisualStyleBackColor = true;
            this.enterAdmin.Click += new System.EventHandler(this.enterAdmin_Click);
            // 
            // exitAdmin
            // 
            this.exitAdmin.Location = new System.Drawing.Point(29, 69);
            this.exitAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitAdmin.Name = "exitAdmin";
            this.exitAdmin.Size = new System.Drawing.Size(113, 47);
            this.exitAdmin.TabIndex = 18;
            this.exitAdmin.Text = "Выйти из режима администратора";
            this.exitAdmin.UseVisualStyleBackColor = true;
            this.exitAdmin.Click += new System.EventHandler(this.exitAdmin_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(504, 10);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(87, 50);
            this.exitButton.TabIndex = 19;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.exitAdmin);
            this.Controls.Add(this.enterAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.setRateOfExchange);
            this.Controls.Add(this.setLimits);
            this.Controls.Add(this.showHistory);
            this.Controls.Add(this.exchangeCurrency);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exchangeCurrency;
        private System.Windows.Forms.Button showHistory;
        private System.Windows.Forms.Button setLimits;
        private System.Windows.Forms.Button setRateOfExchange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button enterAdmin;
        private System.Windows.Forms.Button exitAdmin;
        private System.Windows.Forms.Button exitButton;
    }
}

