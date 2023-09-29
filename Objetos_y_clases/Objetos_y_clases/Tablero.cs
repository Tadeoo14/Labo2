using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_y_clases
{
    internal class Tablero
    {
        private int[][] p_matriz;
        private string p_color_casilla;

        public Tablero(int[][] p_matriz, string p_color_casilla)
        {
            this.Matriz = p_matriz;
            this.Color_casilla = p_color_casilla;
        }

        public int[][] Matriz
        {
            get { return p_matriz; }
            set { p_matriz = value; }
        }
        
        public string Color_casilla
        {
            get { return p_color_casilla; }
            set { p_color_casilla = value; }
        }
    }
}
