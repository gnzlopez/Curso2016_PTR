using System;

using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        public Guid IDLibro { get; set; }
        public string Isbn { get; set; }
        public string Isbn10 { get; set; }
        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public int Paginas { get; set; }
        public string DatosEnvio { get; set; }
        public Image Portada { get; set; }
        
        public virtual Editorial Editorial { get; set; }
        }
    }
}
