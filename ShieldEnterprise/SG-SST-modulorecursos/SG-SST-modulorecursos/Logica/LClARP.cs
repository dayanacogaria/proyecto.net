using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SG_SST_modulorecursos.Entidades;
using SG_SST_modulorecursos.Datos;

namespace SG_SST_modulorecursos.Logica
{
    class LClARP
    {
        DClARP objDARP = new DClARP(); 

        public object mtddatos (EClARP objARP)
        {
            return objDARP.mtdARP(objARP); 
        }

        public object mtdlistar()
        {
            return objDARP.mtdlistararp(); 
        }

        public object mtdlistararp (string arp)
        {
            return objDARP.mtdlistararp(Arp: arp); 
        }


    }
}
