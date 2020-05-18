using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta1
{
    class Documentos
    {
        public void setDatos(string fecha, string origen, string asunto, string de, string para)
        {
            this.fecha = fecha;
            this.origen = origen;
            this.asunto = asunto;
            this.de = de;
            this.para = para;
        }

        public string fecha { get; set; }
        public string origen { get; set; }
        public string asunto { get; set; }
        public string de { get; set; }
        public string para { get; set; }
  

    }
}
