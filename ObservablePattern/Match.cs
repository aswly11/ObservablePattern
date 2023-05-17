using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservablePattern
{
    public class Match : IMatch, IObservable
    {
        public ICollection<IObserver> Observers { get; set; } = new List<IObserver>();
        private int Score { get; set; }
        public void Add(IObserver Observer)
        {
            Observers.Add(Observer);
        }

        public int GetScore()
        {
            return Score;
        }

        public void Notify()
        {
            foreach (var item in Observers)
            {
                item.Update();
            }
        }

        public void Remove(IObserver Observer)
        {
            Observers.Remove(Observer);
        }

        public void SetScore(int score)
        {
            Score = score;
            Notify();
        }
    }
}
