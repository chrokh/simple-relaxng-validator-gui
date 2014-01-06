namespace relax_ng
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
            this.txtInstance = new System.Windows.Forms.TextBox();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInstance
            // 
            this.txtInstance.Location = new System.Drawing.Point(12, 28);
            this.txtInstance.Multiline = true;
            this.txtInstance.Name = "txtInstance";
            this.txtInstance.Size = new System.Drawing.Size(292, 308);
            this.txtInstance.TabIndex = 0;
            this.txtInstance.Text = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>";
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(324, 28);
            this.txtPattern.Multiline = true;
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(292, 308);
            this.txtPattern.TabIndex = 0;
            this.txtPattern.Text = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Instance XML (TODO)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RelaxNG pattern XML (TODO)";
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(12, 345);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 2;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Enabled = false;
            this.txtOutput.Location = new System.Drawing.Point(12, 381);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(604, 60);
            this.txtOutput.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Result of validation below";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 453);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPattern);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInstance);
            this.Name = "Form1";
            this.Text = "Simple RelaxNG Validator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInstance;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label3;
    }
}

