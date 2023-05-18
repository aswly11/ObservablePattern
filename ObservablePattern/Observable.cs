using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservablePattern
{
    public class Observable<T> : IObservable<T>
    {
        public ICollection<IObserver<T>> Observers { get; set; } = new List<IObserver<T>>();

        public T Value { get; set; }
        public void Add(IObserver<T> Observer)
        {
            Observers.Add(Observer);
        }

       

        public T GetValue()
        {
            return Value;
        }

        public void Notify()
        {
            foreach (var item in Observers)
            {
                item.Update();
            }
        }

        public void Remove(IObserver<T> Observer)
        {
            Observers.Remove(Observer);
        }

        public void SetValue(T Value)
        {
            this.Value = Value;
        }
    }
}
