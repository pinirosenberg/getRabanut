namespace getRabanut
{
    partial class Form1
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
            comboBoxWeek = new ComboBox();
            comboBoxDayMonth = new ComboBox();
            comboBoxMonth = new ComboBox();
            comboBoxYear = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBoxWeek
            // 
            comboBoxWeek.FormattingEnabled = true;
            comboBoxWeek.Location = new Point(627, 221);
            comboBoxWeek.Name = "comboBoxWeek";
            comboBoxWeek.Size = new Size(151, 28);
            comboBoxWeek.TabIndex = 0;
            comboBoxWeek.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBoxDayMonth
            // 
            comboBoxDayMonth.FormattingEnabled = true;
            comboBoxDayMonth.Location = new Point(440, 221);
            comboBoxDayMonth.Name = "comboBoxDayMonth";
            comboBoxDayMonth.Size = new Size(151, 28);
            comboBoxDayMonth.TabIndex = 1;
            comboBoxDayMonth.SelectedIndexChanged += comboBoxDayMonth_SelectedIndexChanged;
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Location = new Point(246, 221);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(151, 28);
            comboBoxMonth.TabIndex = 2;
            comboBoxMonth.SelectedIndexChanged += comboBoxMonth_SelectedIndexChanged;
            // 
            // comboBoxYear
            // 
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Location = new Point(40, 221);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(151, 28);
            comboBoxYear.TabIndex = 3;
            comboBoxYear.SelectedIndexChanged += comboBoxYear_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(691, 185);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 4;
            label1.Text = "יום בשבוע";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(490, 185);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 5;
            label2.Text = "יום בחודש";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(312, 185);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 6;
            label3.Text = "חודש";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 185);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 7;
            label4.Text = "שנה";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(360, 75);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 8;
            label5.Text = "כתיבת תאריך";
            // 
            // button1
            // 
            button1.Location = new Point(367, 314);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "שמירה";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxYear);
            Controls.Add(comboBoxMonth);
            Controls.Add(comboBoxDayMonth);
            Controls.Add(comboBoxWeek);
            Name = "Form1";
            Text = "כתיבת תאריך";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxWeek;
        private ComboBox comboBoxDayMonth;
        private ComboBox comboBoxMonth;
        private ComboBox comboBoxYear;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}
