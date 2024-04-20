using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio.Clases
{
    internal class Rompecabezas : VideoJuego 
    {
        private int niveles {  get; set; }

       private string dificultad { get; set; }

        //Constructor
        public Rompecabezas (int niveles, string dificultad)
        {
            this.niveles = niveles;
            this.dificultad = dificultad;
        }


        //Metodos 
        public string MostrarInformacionR()
        {
            MostrarInformacion();
            return $"La dificultad es: {dificultad}" + $"El nivel es: {niveles}";
        }
    }
}
