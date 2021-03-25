using System;

namespace _9
{
    class MyString 
    {
        protected string text;
        private ushort length;

        public MyString(string text)
        {
            this.text = text;
        }
        public MyString(char text)
        {
            this.text = text.ToString();
        }
        public MyString()
        {
        }

        public string TEXT { get => text; set => text = value; }
        public int GetLength()
        {
            this.length = Convert.ToUInt16(this.text.Length);
            return this.length;
        }
        public void Clear()
        {
            this.TEXT = "";
        }
    }
}
