using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class EnviarCorreoElectronico<Tdata> : IEnviarCorreos<Tdata>
    {
        public void EnviarCorreo(Tdata data)
        {
            Console.WriteLine("especificamos que correo deseamos enviar");
        }
    }
}
