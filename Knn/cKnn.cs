using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace Knn
{
    class Knn : Vector
    {
        double _distance;

        //Các phương thức

        //Các thuộc tính
        public double Distance
        {
            get
            {
                return _distance;
            }
            set
            {
                _distance = value;
            }
        }
    }
}
