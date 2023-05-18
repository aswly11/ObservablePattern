using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ObservablePattern
{
    public class Viewer : IObserver<int>
    {
        private IMatch match { get; set; }
        public Viewer(IMatch match)
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
