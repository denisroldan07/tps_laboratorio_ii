using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Evento
    {
        public delegate void TiempoFinalizadoHandler();

        public event TiempoFinalizadoHandler tiempoFinalizado;
        public event Action<int> tiempoRestante;

        public void MensajeTiempoFinalizado(int segundos)
        {
            Task.Run(() => 
            {

                while (segundos > 0) 
                { 
                    if(tiempoRestante is not null)
                    {
                        tiempoRestante.Invoke(segundos);
                    }
                    Thread.Sleep(1000);
                    segundos--;
                }
                if(tiempoFinalizado is not null)
                {
                    tiempoFinalizado.Invoke();
                }
            });
        }
    }
}
