using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_Memento
{
    public class Store
    {
        protected List<IMemento> _mementos;
        public Store()
        {
            _mementos = new List<IMemento>();
        }
        public void Add(IMemento memento)
        {
            _mementos.Add(memento);
        }
        public IMemento Previous()
        {
            if (_mementos.Count > 0)
            {
                return _mementos[1];
            }
            else
            {
                throw new InvalidOperationException("Пусто");
            }
        }
        public IMemento GetByDate(DateTime date)
        {
            IMemento memento = _mementos.FirstOrDefault(m => m.GetDate() == date);
            if (memento != null)
            {
                return memento;
            }
            else
            {
                throw new InvalidOperationException($"Не найдено состояние для даты {date}");
            }
        }
    }
}
