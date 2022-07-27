using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public class Evento
    {
        public delegate void TiempoFinalizadoHandler();

        public event TiempoFinalizadoHandler OntiempoFinalizado;
        public event Action<int> OntiempoRestante;

        public void MensajeTiempoFinalizado(int segundos)
        {
            Task.Run(() => 
            {
                while (segundos > 0) 
                { 
                    if(OntiempoRestante is not null)
                    {
                        OntiempoRestante.Invoke(segundos);
                    }
                    Thread.Sleep(1000);
                    segundos--;
                }
                if(OntiempoFinalizado is not null)
                {
                    OntiempoFinalizado();
                }
            });
        }
    }
}
