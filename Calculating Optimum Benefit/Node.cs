using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatingOptimumBenefit
{
    class Node
    {

        public int ResurcesUsing { get; set; }
        public float OptimumBenefit { get; set; }
        public Node NextNode { get; set; }

        public Node(float Benefit, Node next, int Resurce)
        {
            OptimumBenefit = Benefit;
            NextNode = next;
            ResurcesUsing = Resurce;
        }


    }
}
