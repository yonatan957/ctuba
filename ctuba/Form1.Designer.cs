namespace ctuba
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
            comboBox_year = new ComboBox();
            comboBox_weekDays = new ComboBox();
            comboBox_monthDays = new ComboBox();
            comboBox_months = new ComboBox();
            button_add = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // comboBox_year
            // 
            comboBox_year.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_year.FormattingEnabled = true;
            comboBox_year.Items.AddRange(new object[] { "תשפ\"ד", "תשפ\"ה", "תשפ\"ו", "תשפ\"ז", "תשפ\"ח", "תשפ\"ט", "תש\"צ", "תשצ\"א", "תשצ\"ב", "תשצ\"ג" });
            comboBox_year.Location = new Point(12, 42);
            comboBox_year.Name = "comboBox_year";
            comboBox_year.RightToLeft = RightToLeft.Yes;
            comboBox_year.Size = new Size(151, 28);
            comboBox_year.TabIndex = 0;
            // 
            // comboBox_weekDays
            // 
            comboBox_weekDays.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_weekDays.FormattingEnabled = true;
            comboBox_weekDays.Items.AddRange(new object[] { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "ששי" });
            comboBox_weekDays.Location = new Point(621, 42);
            comboBox_weekDays.Name = "comboBox_weekDays";
            comboBox_weekDays.RightToLeft = RightToLeft.Yes;
            comboBox_weekDays.Size = new Size(151, 28);
            comboBox_weekDays.TabIndex = 1;
            // 
            // comboBox_monthDays
            // 
            comboBox_monthDays.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_monthDays.FormattingEnabled = true;
            comboBox_monthDays.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            comboBox_monthDays.Location = new Point(426, 42);
            comboBox_monthDays.Name = "comboBox_monthDays";
            comboBox_monthDays.RightToLeft = RightToLeft.Yes;
            comboBox_monthDays.Size = new Size(151, 28);
            comboBox_monthDays.TabIndex = 2;
            // 
            // comboBox_months
            // 
            comboBox_months.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_months.FormattingEnabled = true;
            comboBox_months.Items.AddRange(new object[] { "תשרי", "מרחשון", "כסלו", "טבת", "שבט", "אדר", "אדר הראשון", "אדר השני", "ניסן", "אייר", "סיון", "תמוז", "אב", "אלול" });
            comboBox_months.Location = new Point(221, 42);
            comboBox_months.Name = "comboBox_months";
            comboBox_months.RightToLeft = RightToLeft.Yes;
            comboBox_months.Size = new Size(151, 28);
            comboBox_months.TabIndex = 3;
            // 
            // button_add
            // 
            button_add.Location = new Point(357, 376);
            button_add.Name = "button_add";
            button_add.Size = new Size(94, 29);
            button_add.TabIndex = 4;
            button_add.Text = "הוסף";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 19);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 5;
            label1.Text = "שנה";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 19);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 6;
            label2.Text = "חדש";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(468, 19);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 7;
            label3.Text = "יום בחודש";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(663, 19);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 8;
            label4.Text = "יום בשבוע";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_add);
            Controls.Add(comboBox_months);
            Controls.Add(comboBox_monthDays);
            Controls.Add(comboBox_weekDays);
            Controls.Add(comboBox_year);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_year;
        private ComboBox comboBox_weekDays;
        private ComboBox comboBox_monthDays;
        private ComboBox comboBox_months;
        private Button button_add;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
