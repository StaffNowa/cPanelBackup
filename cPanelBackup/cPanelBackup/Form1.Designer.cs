namespace cPanelBackup
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
            this.button1 = new System.Windows.Forms.Button();
            this.domain = new System.Windows.Forms.TextBox();
            this.QueryResult = new System.Windows.Forms.RichTextBox();
            this.domain_list = new System.Windows.Forms.ComboBox();
            this.label_domain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // domain
            // 
            this.domain.Location = new System.Drawing.Point(216, 207);
            this.domain.Name = "domain";
            this.domain.Size = new System.Drawing.Size(100, 20);
            this.domain.TabIndex = 1;
            // 
            // QueryResult
            // 
            this.QueryResult.Location = new System.Drawing.Point(12, 52);
            this.QueryResult.Name = "QueryResult";
            this.QueryResult.Size = new System.Drawing.Size(260, 96);
            this.QueryResult.TabIndex = 2;
            this.QueryResult.Text = "";
            // 
            // domain_list
            // 
            this.domain_list.FormattingEnabled = true;
            this.domain_list.Location = new System.Drawing.Point(61, 6);
            this.domain_list.Name = "domain_list";
            this.domain_list.Size = new System.Drawing.Size(121, 21);
            this.domain_list.TabIndex = 3;
            // 
            // label_domain
            // 
            this.label_domain.AutoSize = true;
            this.label_domain.Location = new System.Drawing.Point(9, 9);
            this.label_domain.Name = "label_domain";
            this.label_domain.Size = new System.Drawing.Size(46, 13);
            this.label_domain.TabIndex = 4;
            this.label_domain.Text = "Domain:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 412);
            this.Controls.Add(this.label_domain);
            this.Controls.Add(this.domain_list);
            this.Controls.Add(this.QueryResult);
            this.Controls.Add(this.domain);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox domain;
        private System.Windows.Forms.RichTextBox QueryResult;
        private System.Windows.Forms.ComboBox domain_list;
        private System.Windows.Forms.Label label_domain;
    }
}

