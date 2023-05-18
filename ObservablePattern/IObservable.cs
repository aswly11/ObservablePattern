using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservablePattern
{
    public interface IObservable<T>
    {
        void Add(IObserver<T> Observer);
        void Remove(IObserver<T> Observer);
        void Notify();
        void SetValue(T Value);
        T GetValue();

    }
}
