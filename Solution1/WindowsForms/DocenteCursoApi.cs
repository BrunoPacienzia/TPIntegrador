using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    public class DocenteCursoApiClient
    {
        private static HttpClient client = new HttpClient();
        static DocenteCursoApiClient()
        {
            client.BaseAddress = new Uri("https://localhost:7271/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public static async Task<DocenteCurso> GetAsync(int id)
        {
            DocenteCurso docenteCurso = null;
            HttpResponseMessage response = await client.GetAsync("docentesCursos/" + id);
            if (response.IsSuccessStatusCode)
            {
                docenteCurso = await response.Content.ReadAsAsync<DocenteCurso>();
            }
            return docenteCurso;
        }

        public static async Task<IEnumerable<DocenteCurso>> GetAllAsync()
        {
            IEnumerable<DocenteCurso> docentesCursos = null;
            HttpResponseMessage response = await client.GetAsync("docentesCursos");
            if (response.IsSuccessStatusCode)
            {
                docentesCursos = await response.Content.ReadAsAsync<IEnumerable<DocenteCurso>>();

            }
            return docentesCursos;
        }


        public async static Task AddAsync(DocenteCurso docenteCurso)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("docentesCursos", docenteCurso);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("docentesCursos/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(DocenteCurso docenteCurso)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("docentesCursos", docenteCurso);
            response.EnsureSuccessStatusCode();
        }
    }
}
