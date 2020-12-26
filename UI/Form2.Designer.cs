namespace UI
{
    partial class CurrencyExchange
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
            this.toBuyRB = new System.Windows.Forms.RadioButton();
            this.toSellRB = new System.Windows.Forms.RadioButton();
            this.eurRB = new System.Windows.Forms.RadioButton();
            this.usdRB = new System.Windows.Forms.RadioButton();
            this.rubRB = new System.Windows.Forms.RadioButton();
            this.clientName = new System.Windows.Forms.TextBox();
            this.cashierName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.givenValue = new System.Windows.Forms.TextBox();
            this.gotValue = new System.Windows.Forms.TextBox();
            this.toExchangeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateBox = new System.Windows.Forms.ListBox();
            this.nextDayButton = new System.Windows.Forms.Button();
            this.userID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.limOpUSDLabel = new System.Windows.Forms.Label();
            this.limOpUSDValue = new System.Windows.Forms.Label();
            this.limOpEURLabel = new System.Windows.Forms.Label();
            this.limOpEURValue = new System.Windows.Forms.Label();
            this.limOpRUBLabel = new System.Windows.Forms.Label();
            this.limOpRUBValue = new System.Windows.Forms.Label();
            this.limClUSDLabel = new System.Windows.Forms.Label();
            this.limClUSDValue = new System.Windows.Forms.Label();
            this.limClEURLabel = new System.Windows.Forms.Label();
            this.limClEURValue = new System.Windows.Forms.Label();
            this.limClRUBLabel = new System.Windows.Forms.Label();
            this.limClRUBValue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toBuyRB
            // 
            this.toBuyRB.AutoSize = true;
            this.toBuyRB.Checked = true;
            this.toBuyRB.Location = new System.Drawing.Point(29, 12);
            this.toBuyRB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toBuyRB.Name = "toBuyRB";
            this.toBuyRB.Size = new System.Drawing.Size(68, 17);
            this.toBuyRB.TabIndex = 0;
            this.toBuyRB.TabStop = true;
            this.toBuyRB.Text = "Покупка";
            this.toBuyRB.UseVisualStyleBackColor = true;
            this.toBuyRB.CheckedChanged += new System.EventHandler(this.toBuyRB_CheckedChanged);
            // 
            // toSellRB
            // 
            this.toSellRB.AutoSize = true;
            this.toSellRB.Location = new System.Drawing.Point(138, 12);
            this.toSellRB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toSellRB.Name = "toSellRB";
            this.toSellRB.Size = new System.Drawing.Size(71, 17);
            this.toSellRB.TabIndex = 1;
            this.toSellRB.Text = "Продажа";
            this.toSellRB.UseVisualStyleBackColor = true;
            this.toSellRB.CheckedChanged += new System.EventHandler(this.toSellRB_CheckedChanged);
            // 
            // eurRB
            // 
            this.eurRB.AutoSize = true;
            this.eurRB.Location = new System.Drawing.Point(86, 12);
            this.eurRB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eurRB.Name = "eurRB";
            this.eurRB.Size = new System.Drawing.Size(48, 17);
            this.eurRB.TabIndex = 2;
            this.eurRB.TabStop = true;
            this.eurRB.Text = "EUR";
            this.eurRB.UseVisualStyleBackColor = true;
            this.eurRB.CheckedChanged += new System.EventHandler(this.eurRB_CheckedChanged);
            // 
            // usdRB
            // 
            this.usdRB.AutoSize = true;
            this.usdRB.Checked = true;
            this.usdRB.Location = new System.Drawing.Point(17, 12);
            this.usdRB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usdRB.Name = "usdRB";
            this.usdRB.Size = new System.Drawing.Size(48, 17);
            this.usdRB.TabIndex = 3;
            this.usdRB.TabStop = true;
            this.usdRB.Text = "USD";
            this.usdRB.UseVisualStyleBackColor = true;
            this.usdRB.CheckedChanged += new System.EventHandler(this.usdRB_CheckedChanged);
            // 
            // rubRB
            // 
            this.rubRB.AutoSize = true;
            this.rubRB.Location = new System.Drawing.Point(153, 12);
            this.rubRB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rubRB.Name = "rubRB";
            this.rubRB.Size = new System.Drawing.Size(48, 17);
            this.rubRB.TabIndex = 4;
            this.rubRB.TabStop = true;
            this.rubRB.Text = "RUB";
            this.rubRB.UseVisualStyleBackColor = true;
            this.rubRB.CheckedChanged += new System.EventHandler(this.rubRB_CheckedChanged);
            // 
            // clientName
            // 
            this.clientName.Location = new System.Drawing.Point(200, 141);
            this.clientName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(222, 20);
            this.clientName.TabIndex = 5;
            this.clientName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cashierName
            // 
            this.cashierName.Location = new System.Drawing.Point(200, 184);
            this.cashierName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cashierName.Name = "cashierName";
            this.cashierName.Size = new System.Drawing.Size(222, 20);
            this.cashierName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ФИО клиента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ФИО кассира";
            // 
            // givenValue
            // 
            this.givenValue.Location = new System.Drawing.Point(211, 271);
            this.givenValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.givenValue.Name = "givenValue";
            this.givenValue.Size = new System.Drawing.Size(76, 20);
            this.givenValue.TabIndex = 9;
            this.givenValue.TextChanged += new System.EventHandler(this.givenValue_TextChanged);
            // 
            // gotValue
            // 
            this.gotValue.Location = new System.Drawing.Point(333, 271);
            this.gotValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gotValue.Name = "gotValue";
            this.gotValue.Size = new System.Drawing.Size(76, 20);
            this.gotValue.TabIndex = 10;
            this.gotValue.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // toExchangeButton
            // 
            this.toExchangeButton.Location = new System.Drawing.Point(224, 336);
            this.toExchangeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toExchangeButton.Name = "toExchangeButton";
            this.toExchangeButton.Size = new System.Drawing.Size(166, 29);
            this.toExchangeButton.TabIndex = 11;
            this.toExchangeButton.Text = "Обмен валюты";
            this.toExchangeButton.UseVisualStyleBackColor = true;
            this.toExchangeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 294);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Отдаваемая валюта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 294);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Получаемая валюта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(230, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Обмен валюты";
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMenuButton.Location = new System.Drawing.Point(9, 10);
            this.mainMenuButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(154, 53);
            this.mainMenuButton.TabIndex = 15;
            this.mainMenuButton.Text = "Вернуться на главную страницу";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(94, 367);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toBuyRB);
            this.groupBox1.Controls.Add(this.toSellRB);
            this.groupBox1.Location = new System.Drawing.Point(194, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(226, 39);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.eurRB);
            this.groupBox2.Controls.Add(this.usdRB);
            this.groupBox2.Controls.Add(this.rubRB);
            this.groupBox2.Location = new System.Drawing.Point(194, 93);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(226, 34);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // dateBox
            // 
            this.dateBox.FormattingEnabled = true;
            this.dateBox.Location = new System.Drawing.Point(432, 33);
            this.dateBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(160, 30);
            this.dateBox.TabIndex = 19;
            this.dateBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // nextDayButton
            // 
            this.nextDayButton.Location = new System.Drawing.Point(484, 67);
            this.nextDayButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nextDayButton.Name = "nextDayButton";
            this.nextDayButton.Size = new System.Drawing.Size(88, 50);
            this.nextDayButton.TabIndex = 20;
            this.nextDayButton.Text = "Перейти на новый день";
            this.nextDayButton.UseVisualStyleBackColor = true;
            this.nextDayButton.Visible = false;
            this.nextDayButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // userID
            // 
            this.userID.Location = new System.Drawing.Point(200, 223);
            this.userID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(222, 20);
            this.userID.TabIndex = 21;
            this.userID.Text = "User1001";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 244);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Идентификатор пользователя";
            // 
            // limOpUSDLabel
            // 
            this.limOpUSDLabel.AutoSize = true;
            this.limOpUSDLabel.Location = new System.Drawing.Point(472, 170);
            this.limOpUSDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.limOpUSDLabel.Name = "limOpUSDLabel";
            this.limOpUSDLabel.Size = new System.Drawing.Size(33, 13);
            this.limOpUSDLabel.TabIndex = 24;
            this.limOpUSDLabel.Text = "USD:";
            // 
            // limOpUSDValue
            // 
            this.limOpUSDValue.AutoSize = true;
            this.limOpUSDValue.Location = new System.Drawing.Point(504, 170);
            this.limOpUSDValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.limOpUSDValue.Name = "limOpUSDValue";
            this.limOpUSDValue.Size = new System.Drawing.Size(35, 13);
            this.limOpUSDValue.TabIndex = 25;
            this.limOpUSDValue.Text = "label9";
            // 
            // limOpEURLabel
            // 
            this.limOpEURLabel.AutoSize = true;
            this.limOpEURLabel.Location = new System.Drawing.Point(472, 193);
            this.limOpEURLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.limOpEURLabel.Name = "limOpEURLabel";
            this.limOpEURLabel.Size = new System.Drawing.Size(33, 13);
            this.limOpEURLabel.TabIndex = 26;
            this.limOpEURLabel.Text = "EUR:";
            // 
            // limOpEURValue
            // 
            this.limOpEURValue.AutoSize = true;
            this.limOpEURValue.Location = new System.Drawing.Point(504, 193);
            this.limOpEURValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.limOpEURValue.Name = "limOpEURValue";
            this.limOpEURValue.Size = new System.Drawing.Size(41, 13);
            this.limOpEURValue.TabIndex = 27;
            this.limOpEURValue.Text = "label11";
            // 
            // limOpRUBLabel
            // 
            this.limOpRUBLabel.AutoSize = true;
            this.limOpRUBLabel.Location = new System.Drawing.Point(472, 212);
            this.limOpRUBLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.limOpRUBLabel.Name = "limOpRUBLabel";
            this.limOpRUBLabel.Size = new System.Drawing.Size(33, 13);
            this.limOpRUBLabel.TabIndex = 28;
            this.limOpRUBLabel.Text = "RUB:";
            // 
            // limOpRUBValue
            // 
            this.limOpRUBValue.AutoSize = true;
            this.limOpRUBValue.Location = new System.Drawing.Point(504, 213);
            this.limOpRUBValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.limOpRUBValue.Name = "limOpRUBValue";
            this.limOpRUBValue.Size = new System.Drawing.Size(41, 13);
            this.limOpRUBValue.TabIndex = 29;
            this.limOpRUBValue.Text = "label13";
            // 
            // limClUSDLabel
            // 
            this.limClUSDLabel.AutoSize = true;
            this.limClUSDLabel.Location = new System.Drawing.Point(472, 260);
            this.limClUSDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.limClUSDLabel.Name = "limClUSDLabel";
            this.limClUSDLabel.Size = new System.Drawing.Size(33, 13);
            this.limClUSDLabel.TabIndex = 30;
            this.limClUSDLabel.Text = "USD:";
            // 
            // limClUSDValue
            // 
            this.limClUSDValue.AutoSize = true;
            this.limClUSDValue.Location = new System.Drawing.Point(517, 260);
            this.limClUSDValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.limClUSDValue.Name = "limClUSDValue";
            this.limClUSDValue.Size = new System.Drawing.Size(41, 13);
            this.limClUSDValue.TabIndex = 31;
            this.limClUSDValue.Text = "label15";
            // 
            // limClEURLabel
            // 
            this.limClEURLabel.AutoSize = true;
            this.limClEURLabel.Location = new System.Drawing.Point(472, 280);
            this.limClEURLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.limClEURLabel.Name = "limClEURLabel";
            this.limClEURLabel.Size = new System.Drawing.Size(33, 13);
            this.limClEURLabel.TabIndex = 32;
            this.limClEURLabel.Text = "EUR:";
            // 
            // limClEURValue
            // 
            this.limClEURValue.AutoSize = true;
            this.limClEURValue.Location = new System.Drawing.Point(517, 280);
            this.limClEURValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.limClEURValue.Name = "limClEURValue";
            this.limClEURValue.Size = new System.Drawing.Size(41, 13);
            this.limClEURValue.TabIndex = 33;
            this.limClEURValue.Text = "label17";
            // 
            // limClRUBLabel
            // 
            this.limClRUBLabel.AutoSize = true;
            this.limClRUBLabel.Location = new System.Drawing.Point(472, 303);
            this.limClRUBLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.limClRUBLabel.Name = "limClRUBLabel";
            this.limClRUBLabel.Size = new System.Drawing.Size(33, 13);
            this.limClRUBLabel.TabIndex = 34;
            this.limClRUBLabel.Text = "RUB:";
            // 
            // limClRUBValue
            // 
            this.limClRUBValue.AutoSize = true;
            this.limClRUBValue.Location = new System.Drawing.Point(517, 303);
            this.limClRUBValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.limClRUBValue.Name = "limClRUBValue";
            this.limClRUBValue.Size = new System.Drawing.Size(41, 13);
            this.limClRUBValue.TabIndex = 35;
            this.limClRUBValue.Text = "label19";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(450, 142);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Лимиты на операцию";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(461, 234);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "Лимиты на день";
            // 
            // CurrencyExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 388);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.limClRUBValue);
            this.Controls.Add(this.limClRUBLabel);
            this.Controls.Add(this.limClEURValue);
            this.Controls.Add(this.limClEURLabel);
            this.Controls.Add(this.limClUSDValue);
            this.Controls.Add(this.limClUSDLabel);
            this.Controls.Add(this.limOpRUBValue);
            this.Controls.Add(this.limOpRUBLabel);
            this.Controls.Add(this.limOpEURValue);
            this.Controls.Add(this.limOpEURLabel);
            this.Controls.Add(this.limOpUSDValue);
            this.Controls.Add(this.limOpUSDLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.nextDayButton);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toExchangeButton);
            this.Controls.Add(this.gotValue);
            this.Controls.Add(this.givenValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cashierName);
            this.Controls.Add(this.clientName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CurrencyExchange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обмен валюты";
            this.Load += new System.EventHandler(this.CurrencyExchange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton toBuyRB;
        private System.Windows.Forms.RadioButton toSellRB;
        private System.Windows.Forms.RadioButton eurRB;
        private System.Windows.Forms.RadioButton usdRB;
        private System.Windows.Forms.RadioButton rubRB;
        private System.Windows.Forms.TextBox clientName;
        private System.Windows.Forms.TextBox cashierName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gotValue;
        private System.Windows.Forms.Button toExchangeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox dateBox;
        private System.Windows.Forms.Button nextDayButton;
        public System.Windows.Forms.TextBox givenValue;
        private System.Windows.Forms.TextBox userID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label limOpUSDLabel;
        private System.Windows.Forms.Label limOpUSDValue;
        private System.Windows.Forms.Label limOpEURLabel;
        private System.Windows.Forms.Label limOpEURValue;
        private System.Windows.Forms.Label limOpRUBLabel;
        private System.Windows.Forms.Label limOpRUBValue;
        private System.Windows.Forms.Label limClUSDLabel;
        private System.Windows.Forms.Label limClUSDValue;
        private System.Windows.Forms.Label limClEURLabel;
        private System.Windows.Forms.Label limClEURValue;
        private System.Windows.Forms.Label limClRUBLabel;
        private System.Windows.Forms.Label limClRUBValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}