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
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnBrowseInstance = new System.Windows.Forms.Button();
            this.btnRemoveGrammarFile = new System.Windows.Forms.Button();
            this.btnRemoveInstanceFile = new System.Windows.Forms.Button();
            this.btnBrowseGrammar = new System.Windows.Forms.Button();
            this.txtInstanceState = new System.Windows.Forms.TextBox();
            this.txtGrammarState = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInstance
            // 
            this.txtInstance.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstance.Location = new System.Drawing.Point(12, 77);
            this.txtInstance.Multiline = true;
            this.txtInstance.Name = "txtInstance";
            this.txtInstance.Size = new System.Drawing.Size(425, 288);
            this.txtInstance.TabIndex = 3;
            this.txtInstance.Text = resources.GetString("txtInstance.Text");
            this.txtInstance.TextChanged += new System.EventHandler(this.txtInstance_TextChanged);
            this.txtInstance.DoubleClick += new System.EventHandler(this.txtInstance_DoubleClick);
            // 
            // txtGrammar
            // 
            this.txtGrammar.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrammar.Location = new System.Drawing.Point(443, 77);
            this.txtGrammar.Multiline = true;
            this.txtGrammar.Name = "txtGrammar";
            this.txtGrammar.Size = new System.Drawing.Size(425, 288);
            this.txtGrammar.TabIndex = 6;
            this.txtGrammar.Text = resources.GetString("txtGrammar.Text");
            this.txtGrammar.TextChanged += new System.EventHandler(this.txtGrammar_TextChanged);
            this.txtGrammar.DoubleClick += new System.EventHandler(this.txtGrammar_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "RelaxNG grammar   (.rng)";
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(145, 400);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(723, 111);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.TabStop = false;
            // 
            // btnBrowseInstance
            // 
            this.btnBrowseInstance.Location = new System.Drawing.Point(12, 43);
            this.btnBrowseInstance.Name = "btnBrowseInstance";
            this.btnBrowseInstance.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseInstance.TabIndex = 1;
            this.btnBrowseInstance.Text = "Load file";
            this.btnBrowseInstance.UseVisualStyleBackColor = true;
            this.btnBrowseInstance.Click += new System.EventHandler(this.btnBrowseInstance_Click);
            // 
            // btnRemoveGrammarFile
            // 
            this.btnRemoveGrammarFile.Enabled = false;
            this.btnRemoveGrammarFile.Location = new System.Drawing.Point(524, 43);
            this.btnRemoveGrammarFile.Name = "btnRemoveGrammarFile";
            this.btnRemoveGrammarFile.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveGrammarFile.TabIndex = 5;
            this.btnRemoveGrammarFile.Text = "Unload file";
            this.btnRemoveGrammarFile.UseVisualStyleBackColor = true;
            this.btnRemoveGrammarFile.Click += new System.EventHandler(this.btnRemoveGrammarFile_Click);
            // 
            // btnRemoveInstanceFile
            // 
            this.btnRemoveInstanceFile.Enabled = false;
            this.btnRemoveInstanceFile.Location = new System.Drawing.Point(93, 43);
            this.btnRemoveInstanceFile.Name = "btnRemoveInstanceFile";
            this.btnRemoveInstanceFile.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveInstanceFile.TabIndex = 2;
            this.btnRemoveInstanceFile.Text = "Unload File";
            this.btnRemoveInstanceFile.UseVisualStyleBackColor = true;
            this.btnRemoveInstanceFile.Click += new System.EventHandler(this.btnRemoveInstanceFile_Click);
            // 
            // btnBrowseGrammar
            // 
            this.btnBrowseGrammar.Location = new System.Drawing.Point(443, 43);
            this.btnBrowseGrammar.Name = "btnBrowseGrammar";
            this.btnBrowseGrammar.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseGrammar.TabIndex = 4;
            this.btnBrowseGrammar.Text = "Load file";
            this.btnBrowseGrammar.UseVisualStyleBackColor = true;
            this.btnBrowseGrammar.Click += new System.EventHandler(this.btnBrowseGrammar_Click);
            // 
            // txtInstanceState
            // 
            this.txtInstanceState.Location = new System.Drawing.Point(12, 371);
            this.txtInstanceState.Multiline = true;
            this.txtInstanceState.Name = "txtInstanceState";
            this.txtInstanceState.ReadOnly = true;
            this.txtInstanceState.Size = new System.Drawing.Size(425, 21);
            this.txtInstanceState.TabIndex = 5;
            this.txtInstanceState.TabStop = false;
            this.txtInstanceState.Text = "FREE EDITING";
            this.txtInstanceState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGrammarState
            // 
            this.txtGrammarState.Location = new System.Drawing.Point(443, 371);
            this.txtGrammarState.Multiline = true;
            this.txtGrammarState.Name = "txtGrammarState";
            this.txtGrammarState.ReadOnly = true;
            this.txtGrammarState.Size = new System.Drawing.Size(425, 21);
            this.txtGrammarState.TabIndex = 5;
            this.txtGrammarState.TabStop = false;
            this.txtGrammarState.Text = "FREE EDITING";
            this.txtGrammarState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Instance   (.xml)";
            // 
            // btnValidate
            // 
            this.btnValidate.Enabled = false;
            this.btnValidate.Location = new System.Drawing.Point(12, 400);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(127, 111);
            this.btnValidate.TabIndex = 0;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 523);
            this.Controls.Add(this.txtGrammarState);
            this.Controls.Add(this.txtInstanceState);
            this.Controls.Add(this.btnBrowseGrammar);
            this.Controls.Add(this.btnRemoveGrammarFile);
            this.Controls.Add(this.btnRemoveInstanceFile);
            this.Controls.Add(this.btnBrowseInstance);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnBrowseInstance;
        private System.Windows.Forms.Button btnRemoveGrammarFile;
        private System.Windows.Forms.Button btnRemoveInstanceFile;
        private System.Windows.Forms.Button btnBrowseGrammar;
        private System.Windows.Forms.TextBox txtInstanceState;
        private System.Windows.Forms.TextBox txtGrammarState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnValidate;
    }
}

