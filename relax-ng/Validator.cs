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

        public static string ValidateFromURLs(string instanceURI, string grammarURI)
        {
            XmlReader instance = new XmlTextReader("../../example.xml");
            XmlReader grammar = new XmlTextReader("../../example.rng");
            return _validate(instance, grammar);
        }

        public string Validate()
        {
            TextReader textreaderInstance = new StringReader(_instance);
            TextReader textreaderGrammar = new StringReader(_grammar);

            XmlReader xmlreaderInstance = new XmlTextReader(textreaderInstance);
            XmlReader xmlreaderGrammar = new XmlTextReader(textreaderGrammar);

            return _validate(xmlreaderInstance, xmlreaderGrammar);
        }

        public void SetInstance(string xml)
        {
            _instance = xml;
        }

        public void SetGrammar(string xml)
        {
            _grammar = xml;
        }

        private static string _validate(XmlReader instance, XmlReader grammar)
        {
            RelaxngValidatingReader validator;
            try
            {
                validator = new RelaxngValidatingReader(instance, grammar);
            }
            catch (Exception e)
            {
                return "XML ERROR: " + e.Message;
            }

            try
            {
                while (validator.Read()) ;
            }
            catch (Exception e)
            {
                return "VALIDATION ERROR: " + e.Message;
            }
            return "OK";
        }
    }
}
