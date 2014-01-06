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
    public partial class ParserForm : Form
    {
        private OpenFileDialog _instanceFileDialog;
        private OpenFileDialog _grammarFileDialog;
        private Validator _validator;

        private static Color COLOR_WRONG = Color.PaleVioletRed,
                             COLOR_RIGHT = Color.GreenYellow;

        public ParserForm()
        {
            InitializeComponent();
            _instanceFileDialog = new OpenFileDialog();
            _grammarFileDialog = new OpenFileDialog();
            _validator = new Validator(txtInstance.Text, txtGrammar.Text);
            txtInstance_TextChanged(null, null);
            txtGrammar_TextChanged(null, null);
        }

        private void _loadFile(OpenFileDialog dialog, TextBox target, TextBox fileNameContainer, Button loadButton, Button unloadButton)
        {
            if (!String.IsNullOrEmpty(dialog.FileName))
            {
                AnnotatedFileReader reader = new AnnotatedFileReader(dialog.FileName);
                target.ReadOnly = true;
                target.Text = reader.Read();
                loadButton.Enabled = false;
                unloadButton.Enabled = true;
                fileNameContainer.Text = dialog.FileName;
            }
        }

        private void _unloadFile(OpenFileDialog dialog, TextBox target, TextBox fileNameContainer, Button loadButton, Button unloadButton)
        {
            txtOutput.Text = "Unloaded file: " + dialog.FileName;
            dialog.FileName = null;
            target.ReadOnly = false;
            target.Clear();
            loadButton.Enabled = true;
            unloadButton.Enabled = false;
            fileNameContainer.Clear();
        }

        private void _editFile(OpenFileDialog dialog, TextBox target, TextBox fileNameContainer, Button loadButton, Button unloadButton)
        {
            target.ReadOnly = false;
            dialog.FileName = null;
            loadButton.Enabled = true;
            unloadButton.Enabled = false;
            fileNameContainer.Clear();
        }


        /*
         * event listeners
         */

        private void btnBrowseInstance_Click(object sender, EventArgs e)
        {
            _instanceFileDialog.ShowDialog();
            _loadFile(_instanceFileDialog, txtInstance, txtInstanceEditMode, btnBrowseInstance, btnRemoveInstanceFile);
        }

        private void btnBrowseGrammar_Click(object sender, EventArgs e)
        {
            _grammarFileDialog.ShowDialog();
            _loadFile(_grammarFileDialog, txtGrammar, txtGrammarEditMode, btnBrowseGrammar, btnRemoveGrammarFile);
        }

        private void txtInstance_DoubleClick(object sender, EventArgs e)
        {
            if (txtInstance.ReadOnly == true)
                _editFile(_instanceFileDialog, txtInstance, txtInstanceEditMode, btnBrowseInstance, btnRemoveInstanceFile);
        }

        private void txtGrammar_DoubleClick(object sender, EventArgs e)
        {
            if (txtGrammar.ReadOnly == true)
                _editFile(_grammarFileDialog, txtGrammar, txtGrammarEditMode, btnBrowseGrammar, btnRemoveGrammarFile);
        }

        private void btnRemoveInstanceFile_Click(object sender, EventArgs e)
        {
            _unloadFile(_instanceFileDialog, txtInstance, txtInstanceEditMode, btnBrowseInstance, btnRemoveInstanceFile);
        }

        private void btnRemoveGrammarFile_Click(object sender, EventArgs e)
        {
            _unloadFile(_grammarFileDialog, txtGrammar, txtGrammarEditMode, btnBrowseGrammar, btnRemoveGrammarFile);
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
                txtPatternMatchValidness.BackColor = COLOR_WRONG;
            else
                txtPatternMatchValidness.BackColor = COLOR_RIGHT;

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
