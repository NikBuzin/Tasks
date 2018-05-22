using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Trees
{
    public class Node
    {
        public object data;
        public Node left;
        public Node right;
        public int x;
        public int y;
        public bool visit;
        public int count;

        public Node(Node left, Node right, object data, int x, int y) // конструктор
        {
            this.left = left;
            this.right = right;
            this.data = data;
            this.x = x;
            this.y = y;
            this.visit = false;
            this.count = 1;
        }

    }
}
