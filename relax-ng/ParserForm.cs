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
        private Validator _validator;

        private static Color COLOR_WRONG = Color.PaleVioletRed,
                             COLOR_RIGHT = Color.GreenYellow;
        private XmlFileView _instanceFile;
        private XmlFileView _grammarFile;

        public ParserForm()
        {
            InitializeComponent();
            OpenFileDialog instanceFileDialog = new OpenFileDialog();
            OpenFileDialog grammarFileDialog = new OpenFileDialog();
            _validator = new Validator(txtInstance.Text, txtGrammar.Text);
            txtInstance_TextChanged(null, null);
            txtGrammar_TextChanged(null, null);

            _instanceFile = new XmlFileView(new OpenFileDialog(), txtInstance, txtInstanceEditMode, btnBrowseInstance, btnRemoveInstanceFile);
            _grammarFile = new XmlFileView(new OpenFileDialog(), txtGrammar, txtGrammarEditMode, btnBrowseGrammar, btnRemoveGrammarFile);
        }


        /*
         * event listeners
         */

        private void btnBrowseInstance_Click(object sender, EventArgs e)
        {
            _instanceFile.LoadFile();
        }

        private void btnBrowseGrammar_Click(object sender, EventArgs e)
        {
            _grammarFile.LoadFile();
        }

        private void txtInstance_DoubleClick(object sender, EventArgs e)
        {
            if (txtInstance.ReadOnly == true)
                _instanceFile.EditFile();
        }

        private void txtGrammar_DoubleClick(object sender, EventArgs e)
        {
            if (txtGrammar.ReadOnly == true)
                _grammarFile.EditFile();
        }

        private void btnRemoveInstanceFile_Click(object sender, EventArgs e)
        {
            _instanceFile.UnloadFile();
        }

        private void btnRemoveGrammarFile_Click(object sender, EventArgs e)
        {
            _grammarFile.UnloadFile();
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
