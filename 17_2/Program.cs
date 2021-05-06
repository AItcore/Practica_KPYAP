using System;

namespace _17_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonService.InitSpaceVILComponents();
            MainWindow mw = new MainWindow();
            mw.Show();
        }
    }
}
