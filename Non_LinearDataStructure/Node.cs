using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_LinearDataStructure
{
    public class Node
    {
        public int key;
        public Node left, right;
      
        public Node(int key)
        {
            this.key = key;
            left = null;
            right = null;
        }
    }
}