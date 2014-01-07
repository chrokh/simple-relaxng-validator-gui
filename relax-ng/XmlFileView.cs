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
        private Form _form;
        private TextBox _output;
        private TextBox _filenameContainer;
        private Button _loadButton;
        private Button _unloadButton;
        private FileTracker _tracker;

        public XmlFileView(Form form, TextBox output, TextBox filenameContainer, Button loadButton, Button unloadButton)
        {
            _dialog = new OpenFileDialog();
            _form = form;
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
                _tracker = new FileTracker(_dialog.FileName, _reloadFile, UnloadFile);
                if (_tracker.Start())
                    _reloadFile();
                else
                    _output.Text = "Could not poll file for changes: " + _tracker.Error;
            }
        }

        public void UnloadFile()
        {
            if (_form.InvokeRequired)
                _form.Invoke(new MethodInvoker(() => { UnloadFile(); }));
            else
            {
                _output.ReadOnly = false;
                _output.Text = "Unloaded file. Not listening for changes...";
                _dialog.FileName = null;
                _loadButton.Enabled = true;
                _unloadButton.Enabled = false;
                _filenameContainer.Clear();
                _tracker.Stop();
            }
        }

        public void EditFile()
        {
            if (_form.InvokeRequired)
                _form.Invoke(new MethodInvoker(() => { EditFile(); }));
            else
            {
                _output.ReadOnly = false;
                _dialog.FileName = null;
                _loadButton.Enabled = true;
                _unloadButton.Enabled = false;
                _filenameContainer.Clear();
            }
        }

        private void _reloadFile()
        {
            if (!String.IsNullOrEmpty(_dialog.FileName))
                if (_form.InvokeRequired)
                    _form.Invoke(new MethodInvoker(() => { _reloadFile(); }));
                else
                {
                   SimpleFileReader reader = new SimpleFileReader(_dialog.FileName);
                    _output.ReadOnly = true;
                    _output.Text = reader.Read();
                    _loadButton.Enabled = false;
                    _unloadButton.Enabled = true;
                    _filenameContainer.Text = _dialog.FileName;
                }
        }
    }
}
