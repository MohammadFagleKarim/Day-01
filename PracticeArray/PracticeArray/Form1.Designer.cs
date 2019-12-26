namespace PracticeArray
{
    partial class Reverse
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
            this.sizeTB = new System.Windows.Forms.TextBox();
            this.elementTB = new System.Windows.Forms.TextBox();
            this.addSizeBtn = new System.Windows.Forms.Button();
            this.addElementBtn = new System.Windows.Forms.Button();
            this.showRichTextBox = new System.Windows.Forms.RichTextBox();
            this.showReverseBtn = new System.Windows.Forms.Button();
            this.showElementsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Element";
            // 
            // sizeTB
            // 
            this.sizeTB.Location = new System.Drawing.Point(186, 56);
            this.sizeTB.Name = "sizeTB";
            this.sizeTB.Size = new System.Drawing.Size(100, 20);
            this.sizeTB.TabIndex = 2;
            // 
            // elementTB
            // 
            this.elementTB.Location = new System.Drawing.Point(186, 99);
            this.elementTB.Name = "elementTB";
            this.elementTB.Size = new System.Drawing.Size(100, 20);
            this.elementTB.TabIndex = 3;
            // 
            // addSizeBtn
            // 
            this.addSizeBtn.Location = new System.Drawing.Point(395, 56);
            this.addSizeBtn.Name = "addSizeBtn";
            this.addSizeBtn.Size = new System.Drawing.Size(75, 23);
            this.addSizeBtn.TabIndex = 4;
            this.addSizeBtn.Text = "Add Size";
            this.addSizeBtn.UseVisualStyleBackColor = true;
            this.addSizeBtn.Click += new System.EventHandler(this.addSizeBtn_Click);
            // 
            // addElementBtn
            // 
            this.addElementBtn.Location = new System.Drawing.Point(395, 95);
            this.addElementBtn.Name = "addElementBtn";
            this.addElementBtn.Size = new System.Drawing.Size(75, 23);
            this.addElementBtn.TabIndex = 5;
            this.addElementBtn.Text = "Add Element";
            this.addElementBtn.UseVisualStyleBackColor = true;
            this.addElementBtn.Click += new System.EventHandler(this.addElementBtn_Click);
            // 
            // showRichTextBox
            // 
            this.showRichTextBox.Location = new System.Drawing.Point(567, 36);
            this.showRichTextBox.Name = "showRichTextBox";
            this.showRichTextBox.Size = new System.Drawing.Size(138, 249);
            this.showRichTextBox.TabIndex = 6;
            this.showRichTextBox.Text = "";
            // 
            // showReverseBtn
            // 
            this.showReverseBtn.Location = new System.Drawing.Point(114, 174);
            this.showReverseBtn.Name = "showReverseBtn";
            this.showReverseBtn.Size = new System.Drawing.Size(111, 23);
            this.showReverseBtn.TabIndex = 7;
            this.showReverseBtn.Text = "Show Reverse";
            this.showReverseBtn.UseVisualStyleBackColor = true;
            this.showReverseBtn.Click += new System.EventHandler(this.showReverseBtn_Click);
            // 
            // showElementsBtn
            // 
            this.showElementsBtn.Location = new System.Drawing.Point(268, 174);
            this.showElementsBtn.Name = "showElementsBtn";
            this.showElementsBtn.Size = new System.Drawing.Size(106, 23);
            this.showElementsBtn.TabIndex = 8;
            this.showElementsBtn.Text = "Show Elements";
            this.showElementsBtn.UseVisualStyleBackColor = true;
            this.showElementsBtn.Click += new System.EventHandler(this.showElementsBtn_Click);
            // 
            // Reverse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showElementsBtn);
            this.Controls.Add(this.showReverseBtn);
            this.Controls.Add(this.showRichTextBox);
            this.Controls.Add(this.addElementBtn);
            this.Controls.Add(this.addSizeBtn);
            this.Controls.Add(this.elementTB);
            this.Controls.Add(this.sizeTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Reverse";
            this.Text = "Reverse Array";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sizeTB;
        private System.Windows.Forms.TextBox elementTB;
        private System.Windows.Forms.Button addSizeBtn;
        private System.Windows.Forms.Button addElementBtn;
        private System.Windows.Forms.RichTextBox showRichTextBox;
        private System.Windows.Forms.Button showReverseBtn;
        private System.Windows.Forms.Button showElementsBtn;
    }
}

