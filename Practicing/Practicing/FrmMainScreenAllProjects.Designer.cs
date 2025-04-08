namespace Practicing
{
    partial class FrmMainScreenAllProjects
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
            this.btnGenerateRandomChar = new System.Windows.Forms.Button();
            this.btnNumberofDigits = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMathGameProject = new System.Windows.Forms.Button();
            this.btnBilliardClubProject = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerateRandomChar
            // 
            this.btnGenerateRandomChar.Location = new System.Drawing.Point(635, 97);
            this.btnGenerateRandomChar.Name = "btnGenerateRandomChar";
            this.btnGenerateRandomChar.Size = new System.Drawing.Size(210, 89);
            this.btnGenerateRandomChar.TabIndex = 0;
            this.btnGenerateRandomChar.Text = "Generate Random Characters";
            this.btnGenerateRandomChar.UseVisualStyleBackColor = true;
            this.btnGenerateRandomChar.Click += new System.EventHandler(this.btnGenerateRandomChar_Click);
            // 
            // btnNumberofDigits
            // 
            this.btnNumberofDigits.Location = new System.Drawing.Point(635, 250);
            this.btnNumberofDigits.Name = "btnNumberofDigits";
            this.btnNumberofDigits.Size = new System.Drawing.Size(210, 89);
            this.btnNumberofDigits.TabIndex = 1;
            this.btnNumberofDigits.Text = "Number of Digits in Matrix";
            this.btnNumberofDigits.UseVisualStyleBackColor = true;
            this.btnNumberofDigits.Click += new System.EventHandler(this.btnNumberofDigits_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(635, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 89);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculator(Simple)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 89);
            this.button2.TabIndex = 3;
            this.button2.Text = "Keyboard Project";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(149, 247);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 92);
            this.button3.TabIndex = 4;
            this.button3.Text = "Memory Game";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMathGameProject
            // 
            this.btnMathGameProject.Location = new System.Drawing.Point(149, 391);
            this.btnMathGameProject.Name = "btnMathGameProject";
            this.btnMathGameProject.Size = new System.Drawing.Size(200, 88);
            this.btnMathGameProject.TabIndex = 5;
            this.btnMathGameProject.Text = "Math Game";
            this.btnMathGameProject.UseVisualStyleBackColor = true;
            this.btnMathGameProject.Click += new System.EventHandler(this.btnMathGameProject_Click);
            // 
            // btnBilliardClubProject
            // 
            this.btnBilliardClubProject.Location = new System.Drawing.Point(149, 513);
            this.btnBilliardClubProject.Name = "btnBilliardClubProject";
            this.btnBilliardClubProject.Size = new System.Drawing.Size(200, 72);
            this.btnBilliardClubProject.TabIndex = 6;
            this.btnBilliardClubProject.Text = "Billiard Club ";
            this.btnBilliardClubProject.UseVisualStyleBackColor = true;
            this.btnBilliardClubProject.Click += new System.EventHandler(this.button4_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(658, 502);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 61);
            this.button4.TabIndex = 7;
            this.button4.Text = "Menu Strip";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // FrmMainScreenAllProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 626);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnBilliardClubProject);
            this.Controls.Add(this.btnMathGameProject);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNumberofDigits);
            this.Controls.Add(this.btnGenerateRandomChar);
            this.Name = "FrmMainScreenAllProjects";
            this.Text = "FrmMainScreenAllProjects";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateRandomChar;
        private System.Windows.Forms.Button btnNumberofDigits;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnMathGameProject;
        private System.Windows.Forms.Button btnBilliardClubProject;
        private System.Windows.Forms.Button button4;
    }
}