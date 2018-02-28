﻿using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalmanFilter.Common
{

    public class NoiseGenerator
    {

        Matrix<double> q;

        Matrix<double> qout;

        public NoiseGenerator(double noise, int dimensions)
        {

            q = Matrix.Build.DenseOfColumnArrays(
            new double[][] {
                        new double[] {0.25,0.5},new double[]{0.5,1} });

            qout = Matrix.Build.Dense(2, 2).Multiply(noise);

        }

        public Matrix<double> MakeWhiteNoise(double time)
        {

            // Finally, let's assume that the process noise can be represented
            //by the discrete white noise model - that is, that over each time period 
            //the acceleration is constant.

            var t2 = Math.Pow(time, 2);
            var t3 = t2 * time;
            var t4 = t2 * t2;


            qout[0, 0] = q[0, 0] * t4;
            qout[0, 1] = q[0, 1] * t3;

            qout[1, 0] = q[0, 0] * t3;
            qout[1, 1] = q[0, 1] * t2;

            return qout;

        }
    }

}