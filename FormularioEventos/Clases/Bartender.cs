using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioEventos
{
    [Serializable]
    class Bartender: Employee
    {
        public Bartender(int identificador, String apellido, String nombre): base(identificador, apellido, nombre)
        {
            
        }

        
        public override Double setTarifa()
        {
            return 14.00; 
        }

        
        public override String setPuesto()
        {
            return "Bartender"; 
        }
    }
}
