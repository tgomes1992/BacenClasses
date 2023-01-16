using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacenClasses
{
    public static class ExportacaoArquivos
    {


        public static void ExportacaoCsv(string path ,  IEnumerable<Registro> lista)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("dataCotacao;fatorDiario;media");
                foreach (Registro registro in lista)
                {
                    sw.WriteLine($"{ registro.dataCotacao }; { registro.fatorDiario} ; {registro.media}");
                }
            }
        }





    }
}
