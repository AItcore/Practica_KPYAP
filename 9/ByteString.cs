using System;
using System.Text;

namespace _9
{
    class ByteString : MyString
    {
        private char znak;

        public ByteString(string txt)
        {
            StringBuilder newText = new StringBuilder(txt);
            string temp = "";
            if (newText[0] == '-')
            {
                this.znak = '-';
                newText.Remove(0, 1);
            }
            else if (newText[0] == '+')
            {
                this.znak = '+';
                newText.Remove(0, 1);
            }
            else
            {
                this.znak = '+';
            }
            for (int i = 0; i < newText.Length; i++)
            {

                if (newText[i] == '1')
                {
                    temp += znak == '+' ? '1' : '0';
                }
                else if (newText[i] == '0')
                {
                    temp += znak == '+' ? '0' : '1';
                }
                else
                {
                    temp = "0";
                }
            }
            this.TEXT = temp;
            if (this.znak == '-')
            {
                this.text = (new ByteString(this.TEXT) + new ByteString("1")).Text;
            }
        }
        public void ChangeZnak()
        {
            StringBuilder newText = new StringBuilder(this.Text);
            string temp = "";
            if (this.znak == '-')
            {
                this.znak = '+';
            }
            else if (znak == '+')
            {
                this.znak = '-';
            }
            for (int i = 0; i < newText.Length; i++)
            {

                if (newText[i] == '1')
                {
                    temp += '0';
                }
                else if (newText[i] == '0')
                {
                    temp += '1';
                }
                else
                {
                    temp = "0";
                }
            }
            this.TEXT = temp;
            if (this.znak == '-')
            {
                this.text = (new ByteString(this.TEXT) + new ByteString("1")).Text;
            }
        }
        ~ByteString()
        {
            System.Console.WriteLine("Class was destroyed");
        }
        public static bool operator ==(ByteString bt1, ByteString bt2)
        {
            if (bt1.GetLength() == bt2.GetLength())
            {
                for (int i = 0; i < bt1.GetLength(); i++)
                {
                    if (bt1.Text[i] != bt2.Text[i])
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }
        public static bool operator !=(ByteString bt1, ByteString bt2)
        {
            if (bt1.GetLength() == bt2.GetLength())
            {
                for (int i = 0; i < bt1.GetLength(); i++)
                {
                    if (bt1.Text[i] != bt2.Text[i])
                    {
                        return true;
                    }
                }
            }
            else
            {
                return true;
            }
            return false;
        }
        public string Text { get => this.text; set => this.text = new ByteString(value).Text; }
        public static ByteString operator +(ByteString bt1, ByteString bt2)
        {
            int b1 = Convert.ToInt32(bt1.Text, 2);
            int b2 = Convert.ToInt32(bt2.Text, 2);
            string line = Convert.ToString(b1 + b2, 2);
            while (line.Length < bt1.GetLength())
            {
                line = line.Insert(0,"0");
            }
            return new ByteString(line);
        }
    }
}
