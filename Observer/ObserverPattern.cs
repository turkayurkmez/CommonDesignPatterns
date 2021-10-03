using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface IObserver
    {
        void ChangeBackgroundColor(Color color);
    }

    public interface ISubscription
    {
        void Subscribe(IObserver observer);
        void UnSubscribe(IObserver observer);
        void Notify();
    }

    public class ColorSubscription : ISubscription
    {
        private HashSet<IObserver> observers = new HashSet<IObserver>();
        public Color NewColor { get; set; }
        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.ChangeBackgroundColor(NewColor);
            }
        }

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        public void UnSubscribe(IObserver observer)
        {
            observers.Remove(observer); 
        }
    }
}

