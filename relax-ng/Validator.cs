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
        public string GrammarFormatError { get; private set; }
        public string InstanceFormatError { get; private set; }
        public string GrammarRuleError { get; private set; }
        public string PatternMatchError { get; private set; }

        public bool HasInstanceFormatError { get { return InstanceFormatError != null; } }
        public bool HasGrammarFormatError { get { return GrammarFormatError != null; } }
        public bool HasGrammarRuleError { get { return GrammarRuleError != null; } }
        public bool HasAnyGrammarError { get { return GrammarFormatError != null || GrammarRuleError != null; } }
        public bool HasPatternMatchError { get { return PatternMatchError != null; } }
        public string FirstError
        {
            get
            {
                if (HasInstanceFormatError)
                    return InstanceFormatError;
                else if (HasAnyGrammarError)
                    return FirstGrammarError;
                else if (HasPatternMatchError)
                    return PatternMatchError;
                else
                    return null;
            }
        }
        public string FirstGrammarError
        {
            get
            {
                if (HasAnyGrammarError)
                    if (HasGrammarFormatError)
                        return GrammarFormatError;
                    else
                        return GrammarRuleError;
                else
                    return null;
            }
        }

        private string _instance = "";
        private string _grammar = "";
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

        public void SetInstance(string xml)
        {
            _instance = xml;
            _validateAll();
        }

        public void SetGrammar(string xml)
        {
            _grammar = xml;
            _validateAll();
        }

        private void _validateAll()
        {
            bool instanceFormat = _validateInstanceFormat();
            bool grammarFormat = _validateGrammarFormat();

            bool grammarRules = false;
            if (grammarFormat)
                grammarRules = _validateGrammarRules();
            else
                GrammarRuleError = "Invalid XML";

            if(instanceFormat && grammarFormat && grammarRules)
                if (_validatePattern())
                    return;
            
            PatternMatchError = "Earlier errors exist";
        }

        private bool _validateInstanceFormat()
        {
            string error;
            bool res = _validateFormat(_instanceReader, out error);
            InstanceFormatError = error;
            return res;
        }

        private bool _validateGrammarFormat()
        {
            string error;
            bool res = _validateFormat(_grammarReader, out error);
            GrammarFormatError = error;
            return res;
        }

        private bool _validateGrammarRules()
        {
            if (!_validateGrammarFormat())
                return false;

            try
            {
                RelaxngPattern pattern = RelaxngPattern.Read(_grammarReader);
                GrammarRuleError = null;
                return true;
            }
            catch (RelaxngException e)
            {
                GrammarRuleError = e.Message;
                return false;
            }
        }

        private bool _validatePattern()
        {
            if (!_validateGrammarFormat() || !_validateGrammarRules())
                return false;

            try
            {
                RelaxngValidatingReader reader = new RelaxngValidatingReader(_instanceReader, _grammarReader);
                while (reader.Read()) ;
                PatternMatchError = null;
                return true;
            }
            catch (Exception e)
            {
                if (e is RelaxngException || e is XmlException)
                {
                    PatternMatchError = e.Message;
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }

        private bool _validateFormat(XmlReader reader, out string error)
        {
            try
            {
                while (reader.Read()) ;
                error = null;
                return true;
            }
            catch (XmlException e)
            {
                error = e.Message;
                return false;
            }
        }
    }
}
