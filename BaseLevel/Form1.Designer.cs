namespace BaseLevel
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
            label1 = new Label();
            label2 = new Label();
            wTxtBox = new TextBox();
            hTxtBox = new TextBox();
            button1 = new Button();
            rTxtBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Weight in KG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 1;
            label2.Text = "Height in Meters";
            // 
            // wTxtBox
            // 
            wTxtBox.Location = new Point(113, 53);
            wTxtBox.Name = "wTxtBox";
            wTxtBox.Size = new Size(147, 23);
            wTxtBox.TabIndex = 2;
            // 
            // hTxtBox
            // 
            hTxtBox.Location = new Point(113, 97);
            hTxtBox.Name = "hTxtBox";
            hTxtBox.Size = new Size(147, 23);
            hTxtBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(145, 151);
            button1.Name = "button1";
            button1.Size = new Size(115, 23);
            button1.TabIndex = 4;
            button1.Text = "Calculate BMI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rTxtBox
            // 
            rTxtBox.Location = new Point(321, 52);
            rTxtBox.Name = "rTxtBox";
            rTxtBox.Size = new Size(100, 23);
            rTxtBox.TabIndex = 5;
            rTxtBox.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 262);
            Controls.Add(rTxtBox);
            Controls.Add(button1);
            Controls.Add(hTxtBox);
            Controls.Add(wTxtBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "BMI Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox wTxtBox;
        private TextBox hTxtBox;
        private Button button1;
        private TextBox rTxtBox;
    }
}