using System;
using System.Drawing;
using SpaceVIL;
using SpaceVIL.Common;
using SpaceVIL.Core;
using SpaceVIL.Decorations;

namespace _17
{
    class Dialog : DialogWindow
    {
        public override void InitWindow()
        {
            IsCentered = true;
            SetParameters("Решение", "Решение", 300, 150);
            VerticalStack splitArea = new VerticalStack();
            double x = 6.37;
            double a = 2.56;
            double b = 7.18;
            
            double answ = (Math.Atan(Math.Sqrt(b+x)))/(0.3*Math.Exp(-a*x)-Math.Cos(b*x));
            Label lb = new Label($"Y = {answ}");
            lb.SetFontSize(24);
            lb.SetAlignment(ItemAlignment.HCenter);
            lb.SetAlignment(ItemAlignment.VCenter);
            lb.SetTextAlignment(ItemAlignment.VCenter);
            lb.SetTextAlignment(ItemAlignment.HCenter);
            ButtonCore btn = MainWindow.btnInit("Ок");
            AddItem(splitArea);
            splitArea.AddItems(lb, btn);
            btn.EventMouseClick += (sender, args) =>
            {
                Close();
            };
        }
    }
    class MainWindow : ActiveWindow
    {
        public override void InitWindow()
        {
            SetParameters("Лаба №17", "Лаба №17", 800, 600);
            IsCentered = true;
            IsResizable = false;
            ButtonCore btnBlue = btnInit("Синия");

            btnBlue.SetBackground(0, 0, 255);
            ButtonCore btnRed = btnInit("Красная");
            btnRed.SetBackground(255, 0, 0);

            ButtonCore btnZad = btnInit("Решение"); 

            ButtonCore btnExit = btnInit("Выход");

            btnBlue.EventMouseClick += (sender, args) =>
            {
                Color color = btnRed.GetBackground();
                btnRed.SetBackground(btnBlue.GetBackground());
                btnBlue.SetBackground(color);
            };

            btnRed.EventMouseClick += (sender, args) =>
            {
                Color color = btnRed.GetBackground();
                btnRed.SetBackground(btnBlue.GetBackground());
                btnBlue.SetBackground(color);
            };

            btnZad.EventMouseClick += (sender, args) =>
            {
                Dialog dw = new Dialog();
                dw.Show();
            };

            btnExit.EventMouseClick += (sender, args) =>
            {
                Close();
            };

            VerticalStack splitArea = new VerticalStack();
            AddItem(splitArea);
            splitArea.SetContentAlignment(ItemAlignment.VCenter);
            splitArea.AddItems(btnBlue, btnRed, btnZad, btnExit);
            SetMinSize(800, 600);
            SetMaxSize(800, 600);
            SetBackground(50, 50, 50);
        }
        public static ButtonCore btnInit(string text)
        {
            ButtonCore btn = new ButtonCore(text);
            btn.SetAlignment(ItemAlignment.VCenter);
            btn.SetAlignment(ItemAlignment.HCenter);
            btn.SetMargin(20, 20, 20, 20);
            btn.SetWidth(200);
            btn.SetHeight(50);
            btn.AddItemState(ItemStateType.Hovered, new ItemState());
            return btn;
        }
    }
}