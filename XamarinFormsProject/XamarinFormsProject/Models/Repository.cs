using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace XamarinFormsProject.Models
{
    public class Repository
    {
        public async Task<List<Cat>> GetCats()
        {
            List<Cat> Cats;
            var URLWebAPI = "http://demos.ticapacitacion.com/cats";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = await Client.GetStringAsync(URLWebAPI);
                Cats = JsonConvert.DeserializeObject<List<Cat>>(JSON);
            }
            return Cats;
        }
    }
}
