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

        public Form1()
        {
            InitializeComponent();
            _instanceFileDialog = new OpenFileDialog();
            _grammarFileDialog = new OpenFileDialog();
            _validator = new Validator();
        }

        private void _loadFile(OpenFileDialog dialog, TextBox target, Button loadButton, Button unloadButton)
        {
            if (!String.IsNullOrEmpty(dialog.FileName))
            {
                AnnotatedFileReader reader = new AnnotatedFileReader(dialog.FileName);
                target.Text = reader.Read();
                target.ReadOnly = true;
                loadButton.Enabled = false;
                unloadButton.Enabled = true;
                txtOutput.Text = "Loaded file: " + dialog.FileName;
                txtOutput.Text += "\r\nIMPORTANT: There's no need to reload the file if it changes on disk, it will be automatically reloaded each time you press Validate! :)";
            }
        }

        private void _unloadFile(OpenFileDialog dialog, TextBox target, Button loadButton, Button unloadButton)
        {
            txtOutput.Text = "Unloaded file: " + dialog.FileName;
            dialog.FileName = null;
            target.Clear();
            target.ReadOnly = false;
            loadButton.Enabled = true;
            unloadButton.Enabled = false;
        }


        /*
         * event listeners
         */

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if(_instanceFileDialog.FileName != null)
                _loadFile(_instanceFileDialog, txtInstance, btnBrowseInstance, btnRemoveInstanceFile);

            if (_grammarFileDialog.FileName != null)
                _loadFile(_grammarFileDialog, txtGrammar, btnBrowseGrammar, btnRemoveGrammarFile);

            _validator.SetInstance(txtInstance.Text);
            _validator.SetGrammar(txtGrammar.Text);

            txtOutput.Text = _validator.Validate();
        }

        private void btnBrowseInstance_Click(object sender, EventArgs e)
        {
            _instanceFileDialog.ShowDialog();
            _loadFile(_instanceFileDialog, txtInstance, btnBrowseInstance, btnRemoveInstanceFile);
        }

        private void btnBrowseGrammar_Click(object sender, EventArgs e)
        {
            _grammarFileDialog.ShowDialog();
            _loadFile(_grammarFileDialog, txtGrammar, btnBrowseGrammar, btnRemoveGrammarFile);
        }

        private void txtInstance_DoubleClick(object sender, EventArgs e)
        {
            if (txtInstance.ReadOnly == true)
                _unloadFile(_instanceFileDialog, txtInstance, btnBrowseInstance, btnRemoveInstanceFile);
        }

        private void txtGrammar_DoubleClick(object sender, EventArgs e)
        {
            if (txtGrammar.ReadOnly == true)
                _unloadFile(_grammarFileDialog, txtGrammar, btnBrowseGrammar, btnRemoveGrammarFile);
        }

        private void btnRemoveInstanceFile_Click(object sender, EventArgs e)
        {
            _unloadFile(_instanceFileDialog, txtInstance, btnBrowseInstance, btnRemoveInstanceFile);
        }

        private void btnRemoveGrammarFile_Click(object sender, EventArgs e)
        {
            _unloadFile(_grammarFileDialog, txtGrammar, btnBrowseGrammar, btnRemoveGrammarFile);
        }
    }
}
