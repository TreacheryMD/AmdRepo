using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Store : IStore
    {
        private readonly List<Observer> _obeservers = new List<Observer>();
        private int _int;
        public int Inventory
        {
            get{return _int;}
            set
            {
                if (value > _int)
                    Notify();
                _int = value;
            }
        }
        public void Subscribe(Observer observer)
        {
            _obeservers.Add(observer);
        }

        public void Unsubscribe(Observer observer)
        {
            _obeservers.Remove(observer);
        }

        public void Notify()
        {
            _obeservers.ForEach(x => x.Update());
        }
    }

    
}
