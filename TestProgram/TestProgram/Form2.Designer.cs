namespace TestProgram
{
    partial class Form2
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
            this.testButton2 = new System.Windows.Forms.Button();
            this.form1Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testButton2
            // 
            this.testButton2.Location = new System.Drawing.Point(100, 107);
            this.testButton2.Name = "testButton2";
            this.testButton2.Size = new System.Drawing.Size(75, 23);
            this.testButton2.TabIndex = 0;
            this.testButton2.Text = "Click Me";
            this.testButton2.UseVisualStyleBackColor = true;
            this.testButton2.Click += new System.EventHandler(this.testButton2_Click);
            // 
            // form1Button
            // 
            this.form1Button.Location = new System.Drawing.Point(89, 165);
            this.form1Button.Name = "form1Button";
            this.form1Button.Size = new System.Drawing.Size(103, 23);
            this.form1Button.TabIndex = 1;
            this.form1Button.Text = "Go to Form 1";
            this.form1Button.UseVisualStyleBackColor = true;
            this.form1Button.Click += new System.EventHandler(this.form1Button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.form1Button);
            this.Controls.Add(this.testButton2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testButton2;
        private System.Windows.Forms.Button form1Button;
    }
}