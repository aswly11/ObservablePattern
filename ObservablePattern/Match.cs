using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservablePattern
{
    public class Match : IMatch
    {
        private IObservable<int> Score { get; set; }
        public Match(IObservable<int> Score)
        {
            this.Score = Score;
        }

        public int GetScore()
        {
            return Score.GetValue();
        }


        public void SetScore(int score)
        {
            Score.SetValue(score);
            Score.Notify();
        }

        public void Subscribe(IObserver<int> observer)
        {
            this.Score.Add(observer);
        }
    }
}
