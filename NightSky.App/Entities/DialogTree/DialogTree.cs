using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace NightSky.App.Entities.DialogTree
{
    [Serializable]
    public class Branch
    {
        private List<Option> _options;
        public string Text { get; set; }
        public List<Option> Content
        {
            get
            {
                if (_options != null)
                {
                    return _options;
                }
                else
                {
                    throw new NullReferenceException("content is null");
                }
            }
        }

        public Branch(string text)
        {
            Text = text;
            _options = new List<Option>();

        }

        public Branch AddOption(string optionText, Branch nextBranch)
        {
            _options.Add(new Option(optionText, nextBranch));

            return this;
        }
    }

    [Serializable]
    public class Option
    {
        public string Value { get; set; }

        public Branch NextBranch { get; set; }

        public Option() { }

        public Option(string value, Branch nextBranch)
        {
            Value = value;
            NextBranch = nextBranch;
        }
    }

    [Serializable]
    public class DialogTree
    {
        private Branch _root;

        public List<Branch> branches = new List<Branch>();

        public Branch Root
        {
            get => _root;
            set
            {
                _root = value;
                branches.Add(value);
            }
        }

        public DialogTree() { }

    }
}




