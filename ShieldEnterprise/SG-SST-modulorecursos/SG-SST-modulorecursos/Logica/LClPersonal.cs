using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SG_SST_modulorecursos.Entidades;
using SG_SST_modulorecursos.Datos; 

namespace SG_SST_modulorecursos.Logica
{
    class LClPersonal
    {
        DClPersonal objDPersonal = new DClPersonal();

        public object mtddatos( EClPersonal objEPersonal)
        {

            return  objDPersonal.mtdRegPer(objEPersonal); 
        }
        public object mtdlistar()
        {
            return objDPersonal.mtdlistar(); 
        }

        public object mtdlistardocu (string docu)
        {
          return objDPersonal.mtdlistar(docum: docu); 
        }
        public object mtdlistarnom(string nom)
        {
            return objDPersonal.mtdlistar(nombre: nom); 
        }
        public object mtdlistarape(string ape)
        {
            return objDPersonal.mtdlistar(apelli: ape);
        }
        public object mtdlistartel(string tel)
        {
            return objDPersonal.mtdlistar(tel: tel);
        }
        public object mtdlistaremail (string emai)
        {
            return objDPersonal.mtdlistar(email: emai);
        }
        public object mtdlistardic (string direc)
        {
            return objDPersonal.mtdlistar(direccion: direc);
        }
        public object mtdlistargru (string grup)
        {
            return objDPersonal.mtdlistar(grup: grup);
        }
    }
}
