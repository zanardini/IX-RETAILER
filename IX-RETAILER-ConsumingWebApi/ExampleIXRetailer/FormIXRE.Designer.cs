namespace ExampleIXRetailer
{
    partial class FormIXRE
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
            this.label39 = new System.Windows.Forms.Label();
            this.textBoxUrlIxV3 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.buttonLoginIxV3 = new System.Windows.Forms.Button();
            this.textBoxUsernameIxV3 = new System.Windows.Forms.TextBox();
            this.textBoxPasswordIxV3 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(12, 18);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(26, 17);
            this.label39.TabIndex = 26;
            this.label39.Text = "Url";
            // 
            // textBoxUrlIxV3
            // 
            this.textBoxUrlIxV3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUrlIxV3.Location = new System.Drawing.Point(111, 15);
            this.textBoxUrlIxV3.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUrlIxV3.Name = "textBoxUrlIxV3";
            this.textBoxUrlIxV3.Size = new System.Drawing.Size(854, 22);
            this.textBoxUrlIxV3.TabIndex = 27;
            this.textBoxUrlIxV3.Text = "https://ixapidemo.arxivar.it";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(12, 50);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(73, 17);
            this.label40.TabIndex = 28;
            this.label40.Text = "Username";
            // 
            // buttonLoginIxV3
            // 
            this.buttonLoginIxV3.Location = new System.Drawing.Point(540, 76);
            this.buttonLoginIxV3.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoginIxV3.Name = "buttonLoginIxV3";
            this.buttonLoginIxV3.Size = new System.Drawing.Size(100, 28);
            this.buttonLoginIxV3.TabIndex = 32;
            this.buttonLoginIxV3.Text = "Login";
            this.buttonLoginIxV3.UseVisualStyleBackColor = true;
            this.buttonLoginIxV3.Click += new System.EventHandler(this.buttonLoginIxV3_Click);
            // 
            // textBoxUsernameIxV3
            // 
            this.textBoxUsernameIxV3.Location = new System.Drawing.Point(111, 47);
            this.textBoxUsernameIxV3.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsernameIxV3.Name = "textBoxUsernameIxV3";
            this.textBoxUsernameIxV3.Size = new System.Drawing.Size(420, 22);
            this.textBoxUsernameIxV3.TabIndex = 29;
            // 
            // textBoxPasswordIxV3
            // 
            this.textBoxPasswordIxV3.Location = new System.Drawing.Point(111, 79);
            this.textBoxPasswordIxV3.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPasswordIxV3.Name = "textBoxPasswordIxV3";
            this.textBoxPasswordIxV3.PasswordChar = '*';
            this.textBoxPasswordIxV3.Size = new System.Drawing.Size(420, 22);
            this.textBoxPasswordIxV3.TabIndex = 31;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(12, 82);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(69, 17);
            this.label41.TabIndex = 30;
            this.label41.Text = "Password";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(17, 112);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(949, 428);
            this.tabControl1.TabIndex = 39;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(941, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "IX.Retailer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormIXRE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.textBoxUrlIxV3);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.buttonLoginIxV3);
            this.Controls.Add(this.textBoxUsernameIxV3);
            this.Controls.Add(this.textBoxPasswordIxV3);
            this.Controls.Add(this.label41);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormIXRE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormIXRE - Client example";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox textBoxUrlIxV3;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Button buttonLoginIxV3;
        private System.Windows.Forms.TextBox textBoxUsernameIxV3;
        private System.Windows.Forms.TextBox textBoxPasswordIxV3;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

