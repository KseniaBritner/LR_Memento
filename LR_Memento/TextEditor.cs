using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_Memento
{
    public class TextEditor
    {
        protected string _text;
        public TextEditor()
        {
            _text = string.Empty;
        }
        public TextEditor(IMemento memento)
        {
            if (memento is TextEditorMemento texEditorMemento)
            {
                _text = texEditorMemento.GetState();
            }
            else
            {
                throw new ArgumentException("Недопустимый тип");
            }
        }
        public string GetState()
        {
            return _text;
        }
        public IMemento CreateMemento()
        {
            return new TextEditorMemento(_text);
        }
    }
}
