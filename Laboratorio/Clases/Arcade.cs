using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace LaboratorioProgra1.Laboratorio.Clases
{
    internal class Arcade : VideoJuego
    {
        private int vidas;
        private int nivel {  get; set; }

        //Constructor
        public Arcade (int vidas, int nivel)
        {
            this.vidas = vidas;
            this.nivel = nivel;
        }

        public int Vidas
        { 
            get { return vidas; }
            set 
            {
                if(value > 0)
                {
                    vidas = value;
                }
                else
                {
                    Console.WriteLine("Se agotaron las vidas");
                }
            }
        } 
        
        public string MostrarInfoArc()
        {
            MostrarInformacion();
            return $"El nivel de dificultad es: {nivel}" + $"Tienes {vidas} vidas";
        }
    }
}
