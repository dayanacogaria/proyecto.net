using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SG_SST_modulorecursos.Entidades;
using SG_SST_modulorecursos.Datos;

 namespace SG_SST_modulorecursos.Logica
{
    class LClDependencia
    {
        DClDependencia objDdependencia = new DClDependencia(); 

        public object mtddatos (EClDependencia objEDependencia)
        {
            return objDdependencia.mtdregdep(objEDependencia); 
        }

        public object mtdlistar()
        {
            return objDdependencia.mtdlisdep(); 
        }
        public object mtdlistardep(string dep)
        {
            return objDdependencia.mtdlisdep(nom: dep); 
        }


    }
    
}
