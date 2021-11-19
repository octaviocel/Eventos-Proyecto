using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioEventos
{
    [Serializable]
    class CraerEvent: Event
    {
        private  String[] PRINCIPAL = { "Mole", "Estofado", "Cabrito" };
        private  String[] GUARNICIONES = { "Ensalada", "Crema Elote", "Sopa" };
        private  String[] POSTRES = { "Helado", "Platanos fritos", "Duraznos en almibar" };


        private int principal;
        private int guarnicion1;
        private int guarnicion2;
        private int postre;
        private List<Employee> empleados;

        public CraerEvent(int principal, int guarnicion1,int guarni2, int postre,
                         String nevento, int invitados, string tipoEvent): base(nevento, invitados, tipoEvent)
        {            
            this.principal = principal;
            this.guarnicion1 = guarnicion1;
            this.postre = postre;
            this.empleados = new List<Employee>();            
        }     
        
        public void addEmpleado(Employee emple)
        {
            empleados.Add(emple);
        }
        public List<Employee> getEmpleados()
        {
            return empleados;
        }
        private int meseros(int invitados)
        {
            return (invitados / 20) + 1;
        }
        private int bartender(int invitados)
        {
            return (invitados / 35) + 1;
        }

        public String getEvento()
        {
            return base.NoEvento;
        }

        public int getPrincipal()
        {
            return this.principal;
        }

        public void setPrincipal(int principal)
        {
            this.principal = principal;
        }

        public int getGuarnicion1()
        {
            return this.guarnicion1;
        }

        public void setGuarnicion1(int guarnicion1)
        {
            this.guarnicion1 = guarnicion1;
        }

        public String getGuarnicion2()
        {
            return GUARNICIONES[this.guarnicion2];
        }

        public void setGuarnicion2(int guarnicion2)
        {
            this.guarnicion2 = guarnicion2;
        }

        public int getPostre()
        {
            return this.postre;
        }

        public void setPostre(int postre)
        {
            this.postre = postre;
        }

     
    }
}
