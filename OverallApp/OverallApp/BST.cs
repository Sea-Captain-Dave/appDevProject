using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverallApp
{
    internal class BST
    {
        public BST left;
        public BST right;
        public double num;
        bool initialized = false;
        public Stack<int> IDs = new Stack<int>();
        public BST()
        {
            this.left = null;
            this.right = null;

        }
        public BST(Animal inputAni,double prof,int ID)
        {
            this.left = null;
            this.right = null;
            this.num = prof;
            initialized = true;
            IDs.Push(ID);
            //this.ani = inputAni;
        }
        public BST getleft() { return this.left; }
        public BST getright() { return this.right; }

        public void setLeft(BST newLeft) { this.left = newLeft; }
        public void setRight(BST newRight) { this.right = newRight; }
        public double getnum() { return this.num; }


        public void addToTree(Animal ani,double inputnum,int ID)
        {
            if (!initialized) { num = inputnum; initialized = true; IDs.Push(ID); return;}
            try
            {

                if (num > inputnum)
                {
                    if (left == null)
                    {
                        left = new BST(ani,inputnum,ID);
                    }
                    else
                    {            
                        left.addToTree(ani,inputnum,ID);
                    }
                }
                else
                {
                    if (num < inputnum)
                    {
                        if (right == null)
                        {
                            right = new BST(ani,inputnum,ID);
                        }
                        else
                        {
                            right.addToTree(ani,inputnum,ID);
                        }
                    }
                    else {
                        IDs.Push(ID);
                    }
                }
            }
            catch { num = inputnum; }
        }
    }
}

