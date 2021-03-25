using System;

namespace _9
{
    class MyTrigger : Element
    {
        private int Q;
        public MyTrigger(string name) : base(name, 1, 2)
        {
            this.Q = 0;
        }
        public void input(int i)
        {
            Console.Write("При T = " + i +" Q(t) = " + Q + " ");
            if (i == 1)
            {
                Q = Q == 1? 0 : 1;
            }
            Console.Write("Q(t+1) = "+Q);
            Console.WriteLine();
        }
    }
}
