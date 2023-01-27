using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Class1
    {
        public int a;
        public string b;

        public Class1(string Text)
        {
            b = Text;
            MessageBox.Show(a + b);
        }
    }
}
