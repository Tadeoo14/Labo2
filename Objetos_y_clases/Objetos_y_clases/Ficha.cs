using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_y_clases
{
    internal class Ficha
    {
        private string p_color;
        private string p_movimiento;
        private string p_tipo;
        private string p_seleccionado;

        public Ficha(string p_color,string p_movimiento,string p_tipo, string p_seleccionado)
        {
            this.Color = p_color;
            this.Movimiento = p_movimiento;
            this.Tipo = p_tipo; 
            this.Seleccionado = p_seleccionado;
        }
        public string Color
        {
            get { return p_color; }
            set { p_color = value; }
        }
        public string Movimiento
        {
            get { return p_movimiento; }
            set { p_movimiento = value; }
        }
        public string Tipo
        {
            get { return p_tipo; }
            set { p_tipo = value; }
        }
        public string Seleccionado
        {
            get { return p_seleccionado; }
            set { p_seleccionado = value; }
        }
        public void Seleccionar()
        {

        }
        public void Deseleccionar()
        {

        }
    }
}
