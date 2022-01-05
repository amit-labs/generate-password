
namespace generate_password
{
    partial class GeneratePassword
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblSymbols = new System.Windows.Forms.Label();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.lblLower = new System.Windows.Forms.Label();
            this.lblUpper = new System.Windows.Forms.Label();
            this.chkSymbols = new System.Windows.Forms.CheckBox();
            this.chkNumbers = new System.Windows.Forms.CheckBox();
            this.chkLower = new System.Windows.Forms.CheckBox();
            this.chkUpper = new System.Windows.Forms.CheckBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(15, 180);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(279, 28);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate Password";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPassword.Location = new System.Drawing.Point(15, 227);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(279, 138);
            this.txtPassword.TabIndex = 1;
            // 
            // lblSymbols
            // 
            this.lblSymbols.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSymbols.Location = new System.Drawing.Point(15, 9);
            this.lblSymbols.Name = "lblSymbols";
            this.lblSymbols.Size = new System.Drawing.Size(249, 25);
            this.lblSymbols.TabIndex = 2;
            this.lblSymbols.Text = "Include Symbols (e.g. $-+?_&&=!%) :";
            this.lblSymbols.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumbers
            // 
            this.lblNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumbers.Location = new System.Drawing.Point(15, 38);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(249, 25);
            this.lblNumbers.TabIndex = 3;
            this.lblNumbers.Text = "Include Numbers (e.g. 0-9) :";
            this.lblNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLower
            // 
            this.lblLower.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLower.Location = new System.Drawing.Point(15, 67);
            this.lblLower.Name = "lblLower";
            this.lblLower.Size = new System.Drawing.Size(249, 25);
            this.lblLower.TabIndex = 4;
            this.lblLower.Text = "Include Lowercase Characters (e.g. a-z) :";
            this.lblLower.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUpper
            // 
            this.lblUpper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUpper.Location = new System.Drawing.Point(15, 96);
            this.lblUpper.Name = "lblUpper";
            this.lblUpper.Size = new System.Drawing.Size(249, 25);
            this.lblUpper.TabIndex = 5;
            this.lblUpper.Text = "Include Uppercase Characters (e.g. A-Z) :";
            this.lblUpper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkSymbols
            // 
            this.chkSymbols.Checked = true;
            this.chkSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSymbols.Location = new System.Drawing.Point(274, 12);
            this.chkSymbols.Name = "chkSymbols";
            this.chkSymbols.Size = new System.Drawing.Size(20, 19);
            this.chkSymbols.TabIndex = 6;
            this.chkSymbols.UseVisualStyleBackColor = true;
            this.chkSymbols.CheckedChanged += new System.EventHandler(this.Symbols_CheckedChanged);
            // 
            // chkNumbers
            // 
            this.chkNumbers.Checked = true;
            this.chkNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNumbers.Location = new System.Drawing.Point(274, 42);
            this.chkNumbers.Name = "chkNumbers";
            this.chkNumbers.Size = new System.Drawing.Size(20, 19);
            this.chkNumbers.TabIndex = 7;
            this.chkNumbers.UseVisualStyleBackColor = true;
            this.chkNumbers.CheckedChanged += new System.EventHandler(this.Numbers_CheckedChanged);
            // 
            // chkLower
            // 
            this.chkLower.Checked = true;
            this.chkLower.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLower.Location = new System.Drawing.Point(274, 71);
            this.chkLower.Name = "chkLower";
            this.chkLower.Size = new System.Drawing.Size(20, 19);
            this.chkLower.TabIndex = 8;
            this.chkLower.UseVisualStyleBackColor = true;
            this.chkLower.CheckedChanged += new System.EventHandler(this.Lower_CheckedChanged);
            // 
            // chkUpper
            // 
            this.chkUpper.Checked = true;
            this.chkUpper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUpper.Location = new System.Drawing.Point(274, 100);
            this.chkUpper.Name = "chkUpper";
            this.chkUpper.Size = new System.Drawing.Size(20, 19);
            this.chkUpper.TabIndex = 9;
            this.chkUpper.UseVisualStyleBackColor = true;
            this.chkUpper.CheckedChanged += new System.EventHandler(this.Upper_CheckedChanged);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(210, 125);
            this.txtLength.MaxLength = 3;
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(54, 25);
            this.txtLength.TabIndex = 10;
            this.txtLength.TextChanged += new System.EventHandler(this.Length_TextChanged);
            this.txtLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Length_KeyPress);
            // 
            // lblLength
            // 
            this.lblLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLength.Location = new System.Drawing.Point(15, 125);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(196, 25);
            this.lblLength.TabIndex = 11;
            this.lblLength.Text = "Password Length (Max - 999) :";
            this.lblLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(15, 152);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(279, 25);
            this.lblMessage.TabIndex = 12;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GeneratePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(308, 374);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.chkUpper);
            this.Controls.Add(this.chkLower);
            this.Controls.Add(this.chkNumbers);
            this.Controls.Add(this.chkSymbols);
            this.Controls.Add(this.lblUpper);
            this.Controls.Add(this.lblLower);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.lblSymbols);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnGenerate);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GeneratePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Password";
            this.Load += new System.EventHandler(this.GeneratePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblSymbols;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Label lblLower;
        private System.Windows.Forms.Label lblUpper;
        private System.Windows.Forms.CheckBox chkSymbols;
        private System.Windows.Forms.CheckBox chkNumbers;
        private System.Windows.Forms.CheckBox chkLower;
        private System.Windows.Forms.CheckBox chkUpper;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblMessage;
    }
}

