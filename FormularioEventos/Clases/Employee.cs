using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioEventos
{
    [Serializable]
    abstract class Employee
    {
        private int identificador;
        private String apellido;
        private String nombre;
        private Double tarifa;
        private String puesto;

        public Employee(int identificador, String apellido, String nombre)
        {
            this.identificador = identificador;
            this.apellido = apellido;
            this.nombre = nombre;
            this.puesto = setPuesto();
            this.tarifa = setTarifa();
        }
        public Employee(int identificador, String apellido, String nombre, String puesto,Double tarifa)
        {
            this.identificador = identificador;
            this.apellido = apellido;
            this.nombre = nombre;
            this.puesto = puesto;
            this.tarifa = tarifa;
        }

        public int getIdentificador()
        {
            return identificador;
        }

        public void setIdentificador(int identificador)
        {
            this.identificador = identificador;
        }

        public String getApellido()
        {
            return apellido;
        }

        public void setApellido(String apellido)
        {
            this.apellido = apellido;
        }

        public String getNombre()
        {
            return nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public Double getTarifa()
        {
            return tarifa;
        }

        public abstract Double setTarifa();

        public String getPuesto()
        {
            return puesto;
        }

        public abstract String setPuesto();

        
        public String toString()
        {
            return String.Format("Nombre: {0} {1}       Identificador: {2}        Puesto: {3}       Cobra: ${4} por hora", nombre, apellido, identificador, puesto, tarifa);
        }

    }
}
