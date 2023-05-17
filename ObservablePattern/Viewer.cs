using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ObservablePattern
{
    public class Viewer : IObserver
    {
        private Match match { get; set; }
        public Viewer(Match match)
        {
            this.match = match;
        }
        public void Update()
        {
            var score = this.match.GetScore();
            Console.WriteLine(score.ToString());

        }
    }
}
