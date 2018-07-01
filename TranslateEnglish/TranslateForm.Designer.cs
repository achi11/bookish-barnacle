namespace TranslateEnglish
{
    partial class TranslateForm
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
            this.BtnTranslate = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.TbInput = new System.Windows.Forms.TextBox();
            this.TbOutput = new System.Windows.Forms.TextBox();
            this.RbLatin = new System.Windows.Forms.RadioButton();
            this.RbGreek = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter English text here:";
            // 
            // BtnTranslate
            // 
            this.BtnTranslate.Location = new System.Drawing.Point(34, 350);
            this.BtnTranslate.Name = "BtnTranslate";
            this.BtnTranslate.Size = new System.Drawing.Size(75, 23);
            this.BtnTranslate.TabIndex = 2;
            this.BtnTranslate.Text = "Translate";
            this.BtnTranslate.UseVisualStyleBackColor = true;
            this.BtnTranslate.Click += new System.EventHandler(this.BtnTranslate_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(129, 350);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(266, 350);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // TbInput
            // 
            this.TbInput.Location = new System.Drawing.Point(29, 53);
            this.TbInput.Multiline = true;
            this.TbInput.Name = "TbInput";
            this.TbInput.Size = new System.Drawing.Size(324, 45);
            this.TbInput.TabIndex = 5;
            // 
            // TbOutput
            // 
            this.TbOutput.Location = new System.Drawing.Point(29, 225);
            this.TbOutput.Multiline = true;
            this.TbOutput.Name = "TbOutput";
            this.TbOutput.Size = new System.Drawing.Size(324, 47);
            this.TbOutput.TabIndex = 6;
            // 
            // RbLatin
            // 
            this.RbLatin.AutoSize = true;
            this.RbLatin.Checked = true;
            this.RbLatin.Location = new System.Drawing.Point(29, 138);
            this.RbLatin.Name = "RbLatin";
            this.RbLatin.Size = new System.Drawing.Size(66, 17);
            this.RbLatin.TabIndex = 7;
            this.RbLatin.TabStop = true;
            this.RbLatin.Text = "Pig Latin";
            this.RbLatin.UseVisualStyleBackColor = true;
            // 
            // RbGreek
            // 
            this.RbGreek.AutoSize = true;
            this.RbGreek.Location = new System.Drawing.Point(132, 138);
            this.RbGreek.Name = "RbGreek";
            this.RbGreek.Size = new System.Drawing.Size(72, 17);
            this.RbGreek.TabIndex = 8;
            this.RbGreek.Text = "Pig Greek";
            this.RbGreek.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "translate";
            // 
            // TranslateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 434);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RbGreek);
            this.Controls.Add(this.RbLatin);
            this.Controls.Add(this.TbOutput);
            this.Controls.Add(this.TbInput);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnTranslate);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TranslateForm";
            this.Text = "translateform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnTranslate;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TextBox TbInput;
        private System.Windows.Forms.TextBox TbOutput;
        private System.Windows.Forms.RadioButton RbLatin;
        private System.Windows.Forms.RadioButton RbGreek;
        private System.Windows.Forms.Label label2;
    }
}

