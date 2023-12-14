using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_Memento
{
    internal class Program
    {
        static void Main()
        {
            TextEditorMemento textEditor = new TextEditorMemento("Текст");
            TextEditorMemento textEditor2 = new TextEditorMemento("Текст2");
            TextEditor editor = new TextEditor(textEditor);
            TextEditor editor2 = new TextEditor(textEditor2);
            IMemento editorMemento = editor.CreateMemento();
            IMemento editorMemento1 = editor2.CreateMemento();

            Store store = new Store();
            store.Add(editorMemento);
            IMemento previousMemento = store.Previous();
            store.Add(editorMemento1);
            TextEditor restoredEditor = new TextEditor(previousMemento);
            Console.WriteLine(restoredEditor.GetState());
        }
    }
}
