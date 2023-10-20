using System.Text;

namespace lmao
{
    class Node 
    {
        public int Data;
        public Node right; 
        public Node left;
        public Node (int data)
        {
            Data = data;
            right = left = null;
        }
    }
    class binarytree
    {
        public Node root;
        public binarytree()
        {
            root = null;
        }
        public void Insert(int value)
        {
            root = InsertRec(root, value);
        }

        private Node InsertRec(Node root, int value)
        {
            if (root == null)
            {
                root = new Node(value);
                return root;
            }

            if (value < root.Data)
            {
                root.left = InsertRec(root.left, value);
            }
            else if (value > root.Data)
            {
                root.right = InsertRec(root.right, value);
            }

            return root;
        }

        public int countnode(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            return 1 + countnode(root.left) + countnode(root.right);
        }
        public int countnode()
        {
            return countnode(root);
        }
        public int Sum(Node root)
        {
            if(root == null) { return 0; }
            return root.Data + Sum(root.left)+Sum(root.right);
        }
        public int Sum()
        {
            return Sum(root);
        }
        public void chan(Node root)
        {
            if(root != null)
            {
                if (root.Data % 2 == 0)
                {
                    Console.Write(root.Data + " ");
                }
                chan(root.left);
                chan(root.right);
            }
        }
        public int countchan(Node root)
        {
            if(root == null) { return 0; }
            int Count = 0;
            if(root.Data % 2 == 0)
            {
                Count++;
            }
            Count += countchan(root.right);
            Count += countchan(root.left);
            return Count;
        }
        public int countleft(Node root)
        {
            if (root == null) { return 0; }
            return 1 + countnode(root.left);
        }
        public string showleft(Node root, string a)
        {
            if(root==null) { return a; }
            a += root.Data.ToString()+" ";
            return a = showleft(root.left, a).ToString(); ;
        }
        public static void first_mid_last(Node root)
        {
           
            if (root != null)
            {
                Console.Write(root.Data+" ");
                first_mid_last(root.left);
                first_mid_last(root.right);
            }
        }
    }
    class lmeo
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Unicode;
            binarytree tree = new binarytree();
            tree.Insert(4);

            tree.Insert(2);
            tree.Insert(1);
            tree.Insert(3);

            tree.Insert(6);
            tree.Insert(5);
            tree.Insert(7);

            Console.WriteLine($"Có {tree.countnode(tree.root)} phần tử trong cây");

            Console.WriteLine($"tổng các số trong cây là :{tree.Sum(tree.root)}");

            Console.WriteLine($"có {tree.countchan(tree.root)} số chẵn trong cây");

            Console.Write($"các số chắn trong cây là :");
            tree.chan(tree.root);
            Console.WriteLine();

            Console.WriteLine($"có {tree.countleft(tree.root)} phần tử bên trái của cây");

            Console.WriteLine($"các phần tử bên trái của cây :{tree.showleft(tree.root,"")}");

            Console.Write("các phần tử Trước – Giữa – Sau :");
            binarytree.first_mid_last(tree.root);
            Console.WriteLine();
        }
    }
}