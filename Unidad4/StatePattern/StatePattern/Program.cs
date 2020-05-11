using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ServidorContext oServior = new ServidorContext();
            oServior.State = new DisponibleServerState();

            oServior.AtenderSolicitud();

            oServior.State = new SaturadoServerState();
            oServior.AtenderSolicitud();
            oServior.AtenderSolicitud();

            oServior.State = new SuperSaturadoServerState();
            oServior.AtenderSolicitud();
            oServior.AtenderSolicitud();

            oServior.State = new CaidoServerState();
            oServior.AtenderSolicitud();
            oServior.AtenderSolicitud();

            oServior.State = new DisponibleServerState();
            oServior.AtenderSolicitud();
            oServior.AtenderSolicitud();

            Console.WriteLine("Modificado Por Mallcu Lisarazu Yerson Lucio");
        }
    }
}
