using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioEventos
{
    [Serializable]
    class Waitstaff : Employee
    {
        public Waitstaff(int identificador, String apellido, String nombre): base(identificador, apellido, nombre)
        {
            
        }

        
        public override Double setTarifa()
        {
            return 10.0; 
        }

        
        public override String setPuesto()
        {
            return "Mesero"; 
        }
    }
}
