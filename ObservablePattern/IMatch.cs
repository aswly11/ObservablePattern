﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservablePattern
{
    public interface IMatch
    {
        void SetScore(int score);
        int GetScore();
    }
}
