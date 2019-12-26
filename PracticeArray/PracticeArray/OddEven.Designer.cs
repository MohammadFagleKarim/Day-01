namespace PracticeArray
{
    partial class OddEven
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
            this.addElementBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBtn = new System.Windows.Forms.Button();
            this.elementTB = new System.Windows.Forms.TextBox();
            this.checkTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Element";
            // 
            // addElementBtn
            // 
            this.addElementBtn.Location = new System.Drawing.Point(493, 53);
            this.addElementBtn.Name = "addElementBtn";
            this.addElementBtn.Size = new System.Drawing.Size(75, 23);
            this.addElementBtn.TabIndex = 1;
            this.addElementBtn.Text = "Add Element";
            this.addElementBtn.UseVisualStyleBackColor = true;
            this.addElementBtn.Click += new System.EventHandler(this.addElementBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Odd OR Even";
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(493, 119);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(75, 23);
            this.checkBtn.TabIndex = 1;
            this.checkBtn.Text = "Check";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // elementTB
            // 
            this.elementTB.Location = new System.Drawing.Point(253, 56);
            this.elementTB.Name = "elementTB";
            this.elementTB.Size = new System.Drawing.Size(180, 20);
            this.elementTB.TabIndex = 2;
            // 
            // checkTB
            // 
            this.checkTB.Location = new System.Drawing.Point(253, 121);
            this.checkTB.Name = "checkTB";
            this.checkTB.Size = new System.Drawing.Size(180, 20);
            this.checkTB.TabIndex = 3;
            // 
            // OddEven
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkTB);
            this.Controls.Add(this.elementTB);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addElementBtn);
            this.Controls.Add(this.label1);
            this.Name = "OddEven";
            this.Text = "OddEven";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addElementBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.TextBox elementTB;
        private System.Windows.Forms.TextBox checkTB;
    }
}