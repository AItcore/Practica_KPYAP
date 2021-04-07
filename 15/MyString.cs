using System;

namespace _15
{
    class MyString
    {
        protected string m_string;
        private int stringLength;
        public MyString()
        {
            m_string = "";
            stringLength = m_string.Length;
        }
        public MyString(string str)
        {
            m_string = str;
            stringLength = m_string.Length;
        }
        public MyString(char ch)
        {
            m_string = Convert.ToString(ch);
            stringLength = m_string.Length;
        }

        protected int StringLength { get => stringLength;}

        public void clearString()
        {
            m_string = "";
            stringLength = m_string.Length;
        }

    }
}