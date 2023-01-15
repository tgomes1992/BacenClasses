using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http;


namespace BacenClasses
{
    public class BacenRequests
    {


        public  async Task<List<Registro>> ConsultaBacen(string data_inicial, string data_final)
        {

            string endereco = "https://www3.bcb.gov.br/novoselic/rest/taxaSelicApurada/pub/search?parametrosOrdenacao=%5B%5D&page=1&pageSize=4000";

            HttpClient client = new HttpClient();

            var body = new
            {
                dataInicial = data_inicial,
                dataFinal = data_final

            };

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            string jsonString = JsonSerializer.Serialize(body);
            StringContent data = new StringContent(jsonString, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(endereco, data);

            string result = await response.Content.ReadAsStringAsync();

            var registros = JsonDocument.Parse(result).RootElement.GetProperty("registros");



            List<Registro> registros_bacen = JsonSerializer.Deserialize<List<Registro>>(registros);

            return registros_bacen;

        }






    }
}
