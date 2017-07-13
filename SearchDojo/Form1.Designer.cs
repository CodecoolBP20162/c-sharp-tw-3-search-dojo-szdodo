namespace SearchDojo
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
            this.TextBox = new System.Windows.Forms.ListBox();
            this.MatchBox = new System.Windows.Forms.ListBox();
            this.PatternLbl = new System.Windows.Forms.Label();
            this.PatternTxt = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.TextLbl = new System.Windows.Forms.Label();
            this.MatchLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.FormattingEnabled = true;
            this.TextBox.Items.AddRange(new object[] {
            "Kacsa, csibe kuvasz , !!"});
            this.TextBox.Location = new System.Drawing.Point(26, 50);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(280, 212);
            this.TextBox.TabIndex = 0;
            // 
            // MatchBox
            // 
            this.MatchBox.FormattingEnabled = true;
            this.MatchBox.Location = new System.Drawing.Point(373, 48);
            this.MatchBox.Name = "MatchBox";
            this.MatchBox.Size = new System.Drawing.Size(195, 212);
            this.MatchBox.TabIndex = 1;
            // 
            // PatternLbl
            // 
            this.PatternLbl.AutoSize = true;
            this.PatternLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PatternLbl.Location = new System.Drawing.Point(96, 285);
            this.PatternLbl.Name = "PatternLbl";
            this.PatternLbl.Size = new System.Drawing.Size(58, 17);
            this.PatternLbl.TabIndex = 2;
            this.PatternLbl.Text = "Pattern:";
            // 
            // PatternTxt
            // 
            this.PatternTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PatternTxt.Location = new System.Drawing.Point(170, 285);
            this.PatternTxt.Name = "PatternTxt";
            this.PatternTxt.Size = new System.Drawing.Size(150, 23);
            this.PatternTxt.TabIndex = 3;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchBtn.Location = new System.Drawing.Point(384, 282);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(79, 26);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // TextLbl
            // 
            this.TextLbl.AutoSize = true;
            this.TextLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextLbl.Location = new System.Drawing.Point(23, 28);
            this.TextLbl.Name = "TextLbl";
            this.TextLbl.Size = new System.Drawing.Size(35, 17);
            this.TextLbl.TabIndex = 5;
            this.TextLbl.Text = "Text";
            // 
            // MatchLbl
            // 
            this.MatchLbl.AutoSize = true;
            this.MatchLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MatchLbl.Location = new System.Drawing.Point(370, 28);
            this.MatchLbl.Name = "MatchLbl";
            this.MatchLbl.Size = new System.Drawing.Size(62, 17);
            this.MatchLbl.TabIndex = 6;
            this.MatchLbl.Text = "Matched";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 332);
            this.Controls.Add(this.MatchLbl);
            this.Controls.Add(this.TextLbl);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.PatternTxt);
            this.Controls.Add(this.PatternLbl);
            this.Controls.Add(this.MatchBox);
            this.Controls.Add(this.TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox TextBox;
        private System.Windows.Forms.ListBox MatchBox;
        private System.Windows.Forms.Label PatternLbl;
        private System.Windows.Forms.TextBox PatternTxt;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label TextLbl;
        private System.Windows.Forms.Label MatchLbl;
    }
}

