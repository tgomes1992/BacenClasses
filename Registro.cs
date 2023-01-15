using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BacenClasses
{

    public class Registro
    {


        public int id;
        [JsonInclude]
        public string dataCotacao { get; set; }
        [JsonInclude]
        public decimal fatorDiario { get; set; }
        [JsonInclude]
        public decimal media { get; set; }
        [JsonInclude]
        public decimal mediana { get; set; }
        [JsonInclude]
        public decimal moda { get; set; }
        [JsonInclude]
        public decimal desvioPadrao { get; set; }

        [JsonInclude]
        public decimal indiceCurtose { get; set; }

        [JsonInclude]
        public decimal financeiro { get; set; }

        [JsonInclude]
        public decimal qtdOperacoes { get; set; }

        [JsonInclude]
        public decimal taxaAnual { get; set; }


    }

}
