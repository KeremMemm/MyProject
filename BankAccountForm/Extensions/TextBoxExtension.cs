using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountForm.Extensions
{
    internal static class TextBoxExtension
    {
        public static bool IsNull(this TextBox textBox)
        {
            return string.IsNullOrEmpty(textBox.Text);
        }

        public static bool GreaterThan(this TextBox textBox, int number)
        {
            return Convert.ToInt32(textBox.Text) > number;
        }

        public static bool LessThan(this TextBox textBox, int number)
        {
            return Convert.ToInt32(textBox.Text) < number;
        }

        public static int ToInt(this TextBox textBox)
        {
            return Convert.ToInt32(textBox.Text);
        }
    }
}
