using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commons.Xml.Relaxng;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace relax_ng
{
    class Validator
    {
        private string _instance;
        private string _grammar;
        private XmlTextReader _grammarReader
        {
            get
            {
                return new XmlTextReader(new StringReader(_grammar));
            }
        }
        private XmlTextReader _instanceReader
        {
            get
            {
                return new XmlTextReader(new StringReader(_instance));
            }
        }

        public string Validate()
        {
            string error;
            if (_validateFormat(_instanceReader, "INSTANCE", out error))
                if(_validateFormat(_grammarReader, "GRAMMAR", out error))
                    _validatePattern(out error);

            if (error != null)
                return error;
            else
                return "INSTANCE: OK\r\nGRAMMAR: OK\r\nPATTERN: OK";
        }

        public void SetInstance(string xml)
        {
            _instance = xml;
        }

        public void SetGrammar(string xml)
        {
            _grammar = xml;
        }

        private bool _validateFormat(XmlReader reader, string type, out string error)
        {
            try
            {
                while (reader.Read()) ;
                error = null;
                return true;
            }
            catch (XmlException e)
            {
                error = type + " PARSE ERROR: " + e.Message;
                return false;
            }
        }

        private bool _validatePattern(out string error)
        {
            RelaxngValidatingReader validator;
            try
            {
                validator = new RelaxngValidatingReader(_instanceReader, _grammarReader);
            }
            catch (Exception e)
            {
                error =  "PARSE ERROR: " + e.Message;
                return false;
            }

            try
            {
                while (validator.Read()) ;
            }
            catch (Exception e)
            {
                error = "PATTERN ERROR: " + e.Message;
                return false;
            }

            error = null;
            return true;
        }
    }
}
