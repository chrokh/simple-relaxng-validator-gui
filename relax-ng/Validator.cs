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
        public static string ValidateFromURLs(string instanceURI, string grammarURI)
        {
            XmlReader instance = new XmlTextReader("../../example.xml");
            XmlReader grammar = new XmlTextReader("../../example.rng");
            return _validate(instance, grammar);
        }

        public static string ValidateFromStrings(string instance, string grammar)
        {
            TextReader textreaderInstance = new StringReader(instance);
            TextReader textreaderGrammar = new StringReader(grammar);

            XmlReader xmlreaderInstance = new XmlTextReader(textreaderInstance);
            XmlReader xmlreaderGrammar = new XmlTextReader(textreaderGrammar);

            return _validate(xmlreaderInstance, xmlreaderGrammar);
        }

        private static string _validate(XmlReader instance, XmlReader grammar)
        {
            RelaxngValidatingReader validator = new RelaxngValidatingReader(instance, grammar);
            try
            {
                while (validator.Read()) ;
            }
            catch (Exception e)
            {
                return "ERROR: " + e.Message;
            }
            return "OK";
        }
    }
}
