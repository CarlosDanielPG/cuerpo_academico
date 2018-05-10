using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuerpo_Academico
{
    class Field
    {
        private string field;
        private string type;

        public Field(string field, string type)
        {
            this.field = field;
            this.type = type;
        }

        public string getField()
        {
            return field;
        }

        public string getType()
        {
            return type;
        }
    }
}
