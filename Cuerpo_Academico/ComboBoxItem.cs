using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuerpo_Academico
{
    class ComboBoxItem
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public ComboBoxItem(string value, string text)
        {
            this.Value = value;
            this.Text = text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
