using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_y_clases
{
    internal class Jugador
    {
        private string p_color;
        private string p_puntaje;
        private string p_tiempo;
        private string p_nombre;

        public Jugador(string p_color,string p_puntaje,string p_tiempo,string p_nombre)
        {
            this.Color = p_color;
            this.Puntaje = p_puntaje;
            this.Tiempo = p_tiempo;
            this.nombre = p_nombre;
        }
        public string Color
        {
            get { return p_color; }
            set { p_color = value; }
        }
        public string Puntaje
        {
            get { return p_puntaje; }
            set { p_puntaje = value; }
        }
        
        public string Tiempo
        {
            get { return p_tiempo;}
            set { p_tiempo = value;}
        }
        public string nombre
        {
            get { return p_nombre; }
            set { p_nombre = value; }
        }
    }
}
