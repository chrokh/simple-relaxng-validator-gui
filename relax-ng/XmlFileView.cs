using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace relax_ng
{
    class XmlFileView
    {
        private OpenFileDialog _dialog;
        private TextBox _output;
        private TextBox _filenameContainer;
        private Button _loadButton;
        private Button _unloadButton;

        public XmlFileView(OpenFileDialog dialog, TextBox output, TextBox filenameContainer, Button loadButton, Button unloadButton)
        {
            _dialog = dialog;
            _output = output;
            _filenameContainer = filenameContainer;
            _loadButton = loadButton;
            _unloadButton = unloadButton;
        }

        public void LoadFile()
        {
            _dialog.ShowDialog();
            if (!String.IsNullOrEmpty(_dialog.FileName))
            {
                SimpleFileReader reader = new SimpleFileReader(_dialog.FileName);
                _output.ReadOnly = true;
                _output.Text = reader.Read();
                _loadButton.Enabled = false;
                _unloadButton.Enabled = true;
                _filenameContainer.Text = _dialog.FileName;
            }
        }

        public void UnloadFile()
        {
            _output.ReadOnly = false;
            _output.Text = "Unloaded file: " + _dialog.FileName;
            _dialog.FileName = null;
            _loadButton.Enabled = true;
            _unloadButton.Enabled = false;
            _filenameContainer.Clear();
        }

        public void EditFile()
        {
            _output.ReadOnly = false;
            _dialog.FileName = null;
            _loadButton.Enabled = true;
            _unloadButton.Enabled = false;
            _filenameContainer.Clear();
        }
    }
}
