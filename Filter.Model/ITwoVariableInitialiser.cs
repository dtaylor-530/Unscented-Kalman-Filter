﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter.Model
{

    // a contract for filters to ensure they have a method that takes two double parameters so that is can be used in with genetic optimisation
    public interface ITwoVariableInitialiser
    {
       
        void Initialise(double a, double b);


    }
}