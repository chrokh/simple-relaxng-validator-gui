namespace relax_ng
{
    partial class ParserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParserForm));
            this.txtInstance = new System.Windows.Forms.TextBox();
            this.txtGrammar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnBrowseInstance = new System.Windows.Forms.Button();
            this.btnRemoveGrammarFile = new System.Windows.Forms.Button();
            this.btnRemoveInstanceFile = new System.Windows.Forms.Button();
            this.btnBrowseGrammar = new System.Windows.Forms.Button();
            this.txtInstanceValidnessXML = new System.Windows.Forms.TextBox();
            this.txtGrammarValidnessXML = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGrammarValidnessRNG = new System.Windows.Forms.TextBox();
            this.txtInstanceEditMode = new System.Windows.Forms.TextBox();
            this.txtGrammarEditMode = new System.Windows.Forms.TextBox();
            this.txtPatternMatchValidness = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInstance
            // 
            this.txtInstance.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstance.Location = new System.Drawing.Point(12, 98);
            this.txtInstance.Multiline = true;
            this.txtInstance.Name = "txtInstance";
            this.txtInstance.Size = new System.Drawing.Size(425, 267);
            this.txtInstance.TabIndex = 3;
            this.txtInstance.Text = "<?xml version=\"1.0\"?>\r\n<book>\r\n  <page>\r\n    Someone must have been telling lies " +
    "about Josef K.\r\n  </page>\r\n  <page>\r\n    <paragraph>Intentionally left blank.</p" +
    "aragraph>\r\n  </page>\r\n</book>";
            this.txtInstance.TextChanged += new System.EventHandler(this.txtInstance_TextChanged);
            this.txtInstance.DoubleClick += new System.EventHandler(this.txtInstance_DoubleClick);
            // 
            // txtGrammar
            // 
            this.txtGrammar.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrammar.Location = new System.Drawing.Point(443, 98);
            this.txtGrammar.Multiline = true;
            this.txtGrammar.Name = "txtGrammar";
            this.txtGrammar.Size = new System.Drawing.Size(425, 267);
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
            this.txtOutput.Location = new System.Drawing.Point(12, 423);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(856, 73);
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
            // txtInstanceValidnessXML
            // 
            this.txtInstanceValidnessXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstanceValidnessXML.Location = new System.Drawing.Point(12, 371);
            this.txtInstanceValidnessXML.Multiline = true;
            this.txtInstanceValidnessXML.Name = "txtInstanceValidnessXML";
            this.txtInstanceValidnessXML.ReadOnly = true;
            this.txtInstanceValidnessXML.Size = new System.Drawing.Size(425, 21);
            this.txtInstanceValidnessXML.TabIndex = 5;
            this.txtInstanceValidnessXML.TabStop = false;
            this.txtInstanceValidnessXML.Text = "Valid XML?";
            this.txtInstanceValidnessXML.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGrammarValidnessXML
            // 
            this.txtGrammarValidnessXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrammarValidnessXML.Location = new System.Drawing.Point(443, 371);
            this.txtGrammarValidnessXML.Multiline = true;
            this.txtGrammarValidnessXML.Name = "txtGrammarValidnessXML";
            this.txtGrammarValidnessXML.ReadOnly = true;
            this.txtGrammarValidnessXML.Size = new System.Drawing.Size(209, 21);
            this.txtGrammarValidnessXML.TabIndex = 5;
            this.txtGrammarValidnessXML.TabStop = false;
            this.txtGrammarValidnessXML.Text = "Valid XML?";
            this.txtGrammarValidnessXML.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // txtGrammarValidnessRNG
            // 
            this.txtGrammarValidnessRNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrammarValidnessRNG.Location = new System.Drawing.Point(661, 371);
            this.txtGrammarValidnessRNG.Multiline = true;
            this.txtGrammarValidnessRNG.Name = "txtGrammarValidnessRNG";
            this.txtGrammarValidnessRNG.ReadOnly = true;
            this.txtGrammarValidnessRNG.Size = new System.Drawing.Size(207, 21);
            this.txtGrammarValidnessRNG.TabIndex = 5;
            this.txtGrammarValidnessRNG.TabStop = false;
            this.txtGrammarValidnessRNG.Text = "Valid RNG?";
            this.txtGrammarValidnessRNG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInstanceEditMode
            // 
            this.txtInstanceEditMode.Location = new System.Drawing.Point(12, 72);
            this.txtInstanceEditMode.Multiline = true;
            this.txtInstanceEditMode.Name = "txtInstanceEditMode";
            this.txtInstanceEditMode.ReadOnly = true;
            this.txtInstanceEditMode.Size = new System.Drawing.Size(425, 21);
            this.txtInstanceEditMode.TabIndex = 5;
            this.txtInstanceEditMode.TabStop = false;
            this.txtInstanceEditMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGrammarEditMode
            // 
            this.txtGrammarEditMode.Location = new System.Drawing.Point(443, 71);
            this.txtGrammarEditMode.Multiline = true;
            this.txtGrammarEditMode.Name = "txtGrammarEditMode";
            this.txtGrammarEditMode.ReadOnly = true;
            this.txtGrammarEditMode.Size = new System.Drawing.Size(425, 21);
            this.txtGrammarEditMode.TabIndex = 5;
            this.txtGrammarEditMode.TabStop = false;
            this.txtGrammarEditMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPatternMatchValidness
            // 
            this.txtPatternMatchValidness.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatternMatchValidness.Location = new System.Drawing.Point(12, 396);
            this.txtPatternMatchValidness.Multiline = true;
            this.txtPatternMatchValidness.Name = "txtPatternMatchValidness";
            this.txtPatternMatchValidness.ReadOnly = true;
            this.txtPatternMatchValidness.Size = new System.Drawing.Size(856, 21);
            this.txtPatternMatchValidness.TabIndex = 5;
            this.txtPatternMatchValidness.TabStop = false;
            this.txtPatternMatchValidness.Text = "Instance conforms to grammar?";
            this.txtPatternMatchValidness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(558, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "The error above always corresponds to the first occured error (first red-marked b" +
    "ox above). Left to right, top to bottom.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ParserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 523);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGrammarValidnessRNG);
            this.Controls.Add(this.txtGrammarValidnessXML);
            this.Controls.Add(this.txtGrammarEditMode);
            this.Controls.Add(this.txtInstanceEditMode);
            this.Controls.Add(this.txtPatternMatchValidness);
            this.Controls.Add(this.txtInstanceValidnessXML);
            this.Controls.Add(this.btnBrowseGrammar);
            this.Controls.Add(this.btnRemoveGrammarFile);
            this.Controls.Add(this.btnRemoveInstanceFile);
            this.Controls.Add(this.btnBrowseInstance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGrammar);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInstance);
            this.Name = "ParserForm";
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
        private System.Windows.Forms.TextBox txtInstanceValidnessXML;
        private System.Windows.Forms.TextBox txtGrammarValidnessXML;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGrammarValidnessRNG;
        private System.Windows.Forms.TextBox txtInstanceEditMode;
        private System.Windows.Forms.TextBox txtGrammarEditMode;
        private System.Windows.Forms.TextBox txtPatternMatchValidness;
        private System.Windows.Forms.Label label3;
    }
}

