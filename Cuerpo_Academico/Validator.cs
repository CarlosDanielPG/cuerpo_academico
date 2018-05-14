using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuerpo_Academico
{
    class Validator
    {
        public static bool validateField(Field field)
        {
            if (field.getField() == "")
                return false;
            if (field.getType() == "text")
            {
                return true;
            }
            if (field.getType() == "email")
            {
                return true;
            }
            if (field.getType() == "password")
            {
                if (field.getField().Length < 6)
                    return false;
            }
            return true;
        }
        public static bool validateFields(List<Field> fields)
        {
            foreach(Field field in fields)
            {
                if (field.getField() == "")
                    return false;
                if(field.getType() == "text")
                {
                    
                }
                if(field.getType() == "email")
                {
                    
                }
                if(field.getType() == "password")
                {
                    if (field.getField().Length < 6)
                        return false;
                }
            }
            return true;
        }
        public static bool validateComboBoxs(List<ComboBox> list)
        {
            foreach(ComboBox combobox in list)
            {
                if (combobox.SelectedItem == null)
                    return false;
            }
            return true;
        }

        public static bool validateID(string id)
        {
            if (id == "")
                return false;
            int i;
            if (int.TryParse(id, out i))
                return true;
            return false;
        }
    }
}
