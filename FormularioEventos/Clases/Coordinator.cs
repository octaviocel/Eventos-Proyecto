using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioEventos
{
    [Serializable]
    class Coordinator : Employee
    {
        public Coordinator(int identificador, String apellido, String nombre): base(identificador, apellido, nombre)
        {
            
        }

        
        public override Double setTarifa()
        {
            return 20.00; 
        }

        
        public override String setPuesto()
        {
            return "Coodinador"; 
        }
    }
}
