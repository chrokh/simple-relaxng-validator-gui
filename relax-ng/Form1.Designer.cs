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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtInstance = new System.Windows.Forms.TextBox();
            this.txtGrammar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowseInstance = new System.Windows.Forms.Button();
            this.btnRemoveGrammarFile = new System.Windows.Forms.Button();
            this.btnRemoveInstanceFile = new System.Windows.Forms.Button();
            this.btnBrowseGrammar = new System.Windows.Forms.Button();
            this.txtInstanceState = new System.Windows.Forms.TextBox();
            this.txtGrammarState = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtInstance
            // 
            this.txtInstance.Location = new System.Drawing.Point(12, 77);
            this.txtInstance.Multiline = true;
            this.txtInstance.Name = "txtInstance";
            this.txtInstance.Size = new System.Drawing.Size(292, 288);
            this.txtInstance.TabIndex = 0;
            this.txtInstance.Text = resources.GetString("txtInstance.Text");
            this.txtInstance.DoubleClick += new System.EventHandler(this.txtInstance_DoubleClick);
            // 
            // txtGrammar
            // 
            this.txtGrammar.Location = new System.Drawing.Point(324, 77);
            this.txtGrammar.Multiline = true;
            this.txtGrammar.Name = "txtGrammar";
            this.txtGrammar.Size = new System.Drawing.Size(292, 288);
            this.txtGrammar.TabIndex = 0;
            this.txtGrammar.Text = resources.GetString("txtGrammar.Text");
            this.txtGrammar.DoubleClick += new System.EventHandler(this.txtGrammar_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Instance XML";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RelaxNG grammar XML";
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(272, 399);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 2;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 436);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(604, 60);
            this.txtOutput.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Result of validation below";
            // 
            // btnBrowseInstance
            // 
            this.btnBrowseInstance.Location = new System.Drawing.Point(147, 19);
            this.btnBrowseInstance.Name = "btnBrowseInstance";
            this.btnBrowseInstance.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseInstance.TabIndex = 4;
            this.btnBrowseInstance.Text = "Load file";
            this.btnBrowseInstance.UseVisualStyleBackColor = true;
            this.btnBrowseInstance.Click += new System.EventHandler(this.btnBrowseInstance_Click);
            // 
            // btnRemoveGrammarFile
            // 
            this.btnRemoveGrammarFile.Enabled = false;
            this.btnRemoveGrammarFile.Location = new System.Drawing.Point(541, 19);
            this.btnRemoveGrammarFile.Name = "btnRemoveGrammarFile";
            this.btnRemoveGrammarFile.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveGrammarFile.TabIndex = 4;
            this.btnRemoveGrammarFile.Text = "Unload file";
            this.btnRemoveGrammarFile.UseVisualStyleBackColor = true;
            this.btnRemoveGrammarFile.Click += new System.EventHandler(this.btnRemoveGrammarFile_Click);
            // 
            // btnRemoveInstanceFile
            // 
            this.btnRemoveInstanceFile.Enabled = false;
            this.btnRemoveInstanceFile.Location = new System.Drawing.Point(228, 19);
            this.btnRemoveInstanceFile.Name = "btnRemoveInstanceFile";
            this.btnRemoveInstanceFile.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveInstanceFile.TabIndex = 4;
            this.btnRemoveInstanceFile.Text = "Unload File";
            this.btnRemoveInstanceFile.UseVisualStyleBackColor = true;
            this.btnRemoveInstanceFile.Click += new System.EventHandler(this.btnRemoveInstanceFile_Click);
            // 
            // btnBrowseGrammar
            // 
            this.btnBrowseGrammar.Location = new System.Drawing.Point(459, 19);
            this.btnBrowseGrammar.Name = "btnBrowseGrammar";
            this.btnBrowseGrammar.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseGrammar.TabIndex = 4;
            this.btnBrowseGrammar.Text = "Load file";
            this.btnBrowseGrammar.UseVisualStyleBackColor = true;
            this.btnBrowseGrammar.Click += new System.EventHandler(this.btnBrowseGrammar_Click);
            // 
            // txtInstanceState
            // 
            this.txtInstanceState.Location = new System.Drawing.Point(12, 50);
            this.txtInstanceState.Multiline = true;
            this.txtInstanceState.Name = "txtInstanceState";
            this.txtInstanceState.ReadOnly = true;
            this.txtInstanceState.Size = new System.Drawing.Size(292, 21);
            this.txtInstanceState.TabIndex = 5;
            this.txtInstanceState.Text = "FREE EDITING";
            this.txtInstanceState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGrammarState
            // 
            this.txtGrammarState.Location = new System.Drawing.Point(324, 50);
            this.txtGrammarState.Multiline = true;
            this.txtGrammarState.Name = "txtGrammarState";
            this.txtGrammarState.ReadOnly = true;
            this.txtGrammarState.Size = new System.Drawing.Size(292, 21);
            this.txtGrammarState.TabIndex = 5;
            this.txtGrammarState.Text = "FREE EDITING";
            this.txtGrammarState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 523);
            this.Controls.Add(this.txtGrammarState);
            this.Controls.Add(this.txtInstanceState);
            this.Controls.Add(this.btnBrowseGrammar);
            this.Controls.Add(this.btnRemoveGrammarFile);
            this.Controls.Add(this.btnRemoveInstanceFile);
            this.Controls.Add(this.btnBrowseInstance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGrammar);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInstance);
            this.Name = "Form1";
            this.Text = "Simple RelaxNG Validator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInstance;
        private System.Windows.Forms.TextBox txtGrammar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowseInstance;
        private System.Windows.Forms.Button btnRemoveGrammarFile;
        private System.Windows.Forms.Button btnRemoveInstanceFile;
        private System.Windows.Forms.Button btnBrowseGrammar;
        private System.Windows.Forms.TextBox txtInstanceState;
        private System.Windows.Forms.TextBox txtGrammarState;
    }
}

