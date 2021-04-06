using System;

namespace _15
{
    class DecimalString : MyString
    {
        public DecimalString(int number)
        {
            m_string = Convert.ToString(number);

            if (m_string[0] == '+' || m_string[0] == '-' || m_string[0] < '0' || m_string[0] > '9')
            {
                m_string = "0";
            }
            else
            {
                for (int i = 1; i < m_string.Length; i++)
                {
                    if (m_string[i] < '0' || m_string[i] > '9')
                        m_string = "0";
                }
            }
        }

        public static int operator -(DecimalString ds, DecimalString ds2)
        {
            return Convert.ToInt32(ds.m_string) - Convert.ToInt32(ds2.m_string);
        }

        public static bool operator >(DecimalString ds1, DecimalString ds2)
        {
            return Convert.ToInt32(ds1.m_string) > Convert.ToInt32(ds2.m_string);
        }

        public static bool operator <(DecimalString ds1, DecimalString ds2)
        {
            return Convert.ToInt32(ds1.m_string) < Convert.ToInt32(ds2.m_string);
        }
    }
}