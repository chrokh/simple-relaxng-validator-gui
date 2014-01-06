using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace relax_ng
{
    public partial class Form1 : Form
    {
        private OpenFileDialog _instanceFileDialog;
        private OpenFileDialog _grammarFileDialog;
        private Validator _validator;

        private static Color COLOR_WRONG = Color.IndianRed,
                             COLOR_RIGHT = Color.GreenYellow;

        public Form1()
        {
            InitializeComponent();
            _instanceFileDialog = new OpenFileDialog();
            _grammarFileDialog = new OpenFileDialog();
            _validator = new Validator(txtInstance.Text, txtGrammar.Text);
        }

        private void _loadFile(OpenFileDialog dialog, TextBox target, TextBox status, Button loadButton, Button unloadButton)
        {
            if (!String.IsNullOrEmpty(dialog.FileName))
            {
                AnnotatedFileReader reader = new AnnotatedFileReader(dialog.FileName);
                target.ReadOnly = true;
                target.Text = reader.Read();
                loadButton.Enabled = false;
                unloadButton.Enabled = true;
                txtOutput.Text = "Loaded file: " + dialog.FileName;
                txtOutput.Text += "\r\nIMPORTANT: There's no need to reload the file if it changes on disk, it will be automatically reloaded each time you press Validate! :)";
                status.Text = dialog.FileName;
            }
        }

        private void _unloadFile(OpenFileDialog dialog, TextBox target, TextBox status, Button loadButton, Button unloadButton)
        {
            txtOutput.Text = "Unloaded file: " + dialog.FileName;
            dialog.FileName = null;
            target.ReadOnly = false;
            target.Clear();
            loadButton.Enabled = true;
            unloadButton.Enabled = false;
            status.Text = "FREE EDITING";
        }

        private void _editFile(OpenFileDialog dialog, TextBox target, TextBox status, Button loadButton, Button unloadButton)
        {
            target.ReadOnly = false;
            txtOutput.Text = "Opened contents of file for editing: " + dialog.FileName;
            txtOutput.Text += "IMPORTANT: File will not be reloaded when pressing Validate!";
            dialog.FileName = null;
            loadButton.Enabled = true;
            unloadButton.Enabled = false;
            status.Text = "FREE EDITING";
        }


        /*
         * event listeners
         */

        private void btnBrowseInstance_Click(object sender, EventArgs e)
        {
            _instanceFileDialog.ShowDialog();
            _loadFile(_instanceFileDialog, txtInstance, txtInstanceValidnessXML, btnBrowseInstance, btnRemoveInstanceFile);
        }

        private void btnBrowseGrammar_Click(object sender, EventArgs e)
        {
            _grammarFileDialog.ShowDialog();
            _loadFile(_grammarFileDialog, txtGrammar, txtGrammarValidnessXML, btnBrowseGrammar, btnRemoveGrammarFile);
        }

        private void txtInstance_DoubleClick(object sender, EventArgs e)
        {
            if (txtInstance.ReadOnly == true)
                _editFile(_instanceFileDialog, txtInstance, txtInstanceValidnessXML, btnBrowseInstance, btnRemoveInstanceFile);
        }

        private void txtGrammar_DoubleClick(object sender, EventArgs e)
        {
            if (txtGrammar.ReadOnly == true)
                _editFile(_grammarFileDialog, txtGrammar, txtGrammarValidnessXML, btnBrowseGrammar, btnRemoveGrammarFile);
        }

        private void btnRemoveInstanceFile_Click(object sender, EventArgs e)
        {
            _unloadFile(_instanceFileDialog, txtInstance, txtInstanceValidnessXML, btnBrowseInstance, btnRemoveInstanceFile);
        }

        private void btnRemoveGrammarFile_Click(object sender, EventArgs e)
        {
            _unloadFile(_grammarFileDialog, txtGrammar, txtGrammarValidnessXML, btnBrowseGrammar, btnRemoveGrammarFile);
        }

        private void txtInstance_TextChanged(object sender, EventArgs e)
        {
            _validator.SetInstance(txtInstance.Text);
            _showAllErrors();
        }

        private void txtGrammar_TextChanged(object sender, EventArgs e)
        {
            _validator.SetGrammar(txtGrammar.Text);
            _showAllErrors();
        }

        private void _showAllErrors()
        {
            if (_validator.HasInstanceFormatError)
                txtInstanceValidnessXML.BackColor = COLOR_WRONG;
            else
                txtInstanceValidnessXML.BackColor = COLOR_RIGHT;

            if (_validator.HasGrammarFormatError)
                txtGrammarValidnessXML.BackColor = COLOR_WRONG;
            else
                txtGrammarValidnessXML.BackColor = COLOR_RIGHT;

            if (_validator.HasGrammarRuleError)
                txtGrammarValidnessRNG.BackColor = COLOR_WRONG;
            else
                txtGrammarValidnessRNG.BackColor = COLOR_RIGHT;

            if (_validator.HasPatternMatchError)
                txtOutput.BackColor = COLOR_WRONG;
            else
                txtOutput.BackColor = COLOR_RIGHT;

            txtOutput.Text = _validator.FirstError;
        }

        private void _showError(bool erronous, string message, Control target)
        {
            if (erronous)
                target.BackColor = Color.IndianRed;
            else
                target.BackColor = Color.GreenYellow;

            txtOutput.Text = message;
        }
    }
}
