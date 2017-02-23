using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recursos_Humanos.Entity;
using Recursos_Humanos.Data;

namespace Recursos_Humanos.BusinessLogic
{
    class LArl
    {
        ClArl clarl = new ClArl();

        public object mttdatos(EArl objEARL)
        {

            return clarl.mtdRegistArl(objEARL);
        }


        public object mtdlistar()
        {
            return clarl.mtdlistararl(); 
        }
    }
}
