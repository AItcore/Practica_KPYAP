using System;
using SpaceVIL;
using SpaceVIL.Common;
namespace _17
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