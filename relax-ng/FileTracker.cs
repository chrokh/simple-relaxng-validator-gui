using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace relax_ng
{
    class FileTracker
    {
        public string Error { get; private set; }
        private  Action _callbackOnChange;
        private Action _callbackOnDelete;
        private string _path;
        private FileSystemWatcher _watcher;

        public FileTracker(string path, Action callbackOnChange, Action callbackOnDelete)
        {
            _path = path;
            _callbackOnChange = callbackOnChange;
            _callbackOnDelete = callbackOnDelete;
        }

        public bool Start()
        {
            try
            {
                Stop();
                _watcher = new FileSystemWatcher();
                _watcher.Path = Path.GetDirectoryName(_path);
                _watcher.Changed += watcher_Changed;
                _watcher.Deleted += watcher_Deleted;
                _watcher.Renamed += watcher_Deleted;
                _watcher.EnableRaisingEvents = true;
                return true;
            }
            catch (IOException e)
            {
                Error = "ERROR: " + e.Message;
                return false;
            }
        }

        public void Stop()
        {
            if(_watcher != null)
            {
                _watcher.Changed -= watcher_Changed;
                _watcher.Deleted -= watcher_Deleted;
                _watcher.Renamed -= watcher_Deleted;
                _watcher.EnableRaisingEvents = false;
                _watcher = null;
            }
        }

        void watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            if(!File.Exists(_path))
                _callbackOnDelete();
        }

        void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            if(e.FullPath == _path)
                _callbackOnChange();
        }
    }
}
