﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public interface IEnviarCorreos <Tdata>
    {
        public void EnviarCorreo(Tdata data);
    }
}
