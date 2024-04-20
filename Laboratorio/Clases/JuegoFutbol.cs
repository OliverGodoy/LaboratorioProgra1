using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio.Clases
{
    internal class JuegoFutbol: VideoJuego 
    {
        private string nombreEuipo {  get; set; }
        private string posicion { get; set; }
        private int numJugador { get; set; }

        //Constructor
        public JuegoFutbol (string nombreEuipo, string posicion, int numJugador)
        {
            this.nombreEuipo = nombreEuipo;
            this.posicion  = posicion ;
            this.numJugador = numJugador;
        }

        public string MostrarInfoFutbol()
        {
            MostrarInformacion();
            return $"El No. del jugador es: {numJugador}" + $"Juega para el equipo: {nombreEuipo}" + $"Y juega de: {posicion}";
        }
    }
}
