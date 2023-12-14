using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_Memento
{
    internal class TextEditorMemento : IMemento
    {
        protected string _text;
        protected DateTime _date;
        public TextEditorMemento(string text)
        {
            _text = text;
            _date = DateTime.Now;
        }
        public string GetState()
        {
            return _text;
        }
        public DateTime GetDate()
        {
            return _date;
        }
    }
}
