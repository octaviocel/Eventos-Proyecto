using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioEventos
{
    [Serializable]
    class Event
    {
        private String[] TIPO = {"BODA","BAUTIZO","CUMPLEAÑOS","REUNION","OTROS" };
        private String noEvento;
        private int invitados;
        private int precio;
        private String tipoEvent;

        public string NoEvento { get => noEvento; set => noEvento = value; }
        public int Invitados { get => invitados; set => invitados = value; }
        public int Precio { get => precio; set => precio = value; }
        public string TipoEvent { get => tipoEvent; set => tipoEvent = value; }

        public Event(String n, int invita, string tipoEvent)
        {
            this.NoEvento = n;
            this.Invitados = invita;
            this.tipoEvent = tipoEvent;
            setPrecio();
        }

        private Boolean isLargo()
        {
            return Invitados >= 50;
        }

        private void setPrecio()
        {
            if (isLargo())
            {
                this.precio = 50 * Invitados;
            }
            else
            {
                this.precio = 25 * Invitados;
            }
        }

        public void setTipoevento(int tipoevento)
        {
            switch (tipoevento)
            {
                case 1:
                    this.tipoEvent = TIPO[0];
                    break;
                case 2:
                    this.tipoEvent = TIPO[1];
                    break;
                case 3:
                    this.tipoEvent = TIPO[2];
                    break;
                case 4:
                    this.tipoEvent = TIPO[3];
                    break;
                case 5:
                    this.tipoEvent = TIPO[4];
                    break;
                default:
                    break;
            }
        }
    }
}
