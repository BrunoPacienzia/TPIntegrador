using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    public class AlumnoInscripcionApiClient
    {
        private static HttpClient client = new HttpClient();
        static AlumnoInscripcionApiClient()
        {
            client.BaseAddress = new Uri("https://localhost:7271/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public static async Task<AlumnoInscripcion> GetAsync(int id)
        {
            AlumnoInscripcion alumnoInscripcion = null;
            HttpResponseMessage response = await client.GetAsync("alumnoInscripciones/" + id);
            if (response.IsSuccessStatusCode)
            {
                alumnoInscripcion = await response.Content.ReadAsAsync<AlumnoInscripcion>();
            }
            return alumnoInscripcion;
        }

        public static async Task<IEnumerable<AlumnoInscripcion>> GetAllAsync()
        {
            IEnumerable<AlumnoInscripcion> alumnoInscripciones = null;
            HttpResponseMessage response = await client.GetAsync("alumnoInscripciones");
            if (response.IsSuccessStatusCode)
            {
                alumnoInscripciones = await response.Content.ReadAsAsync<IEnumerable<AlumnoInscripcion>>();

            }
            return alumnoInscripciones;
        }


        public async static Task AddAsync(AlumnoInscripcion alumnoInscripcion)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("alumnoInscripciones", alumnoInscripcion);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("alumnoInscripciones/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(AlumnoInscripcion alumnoInscripcion)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("alumnoInscripciones", alumnoInscripcion);
            response.EnsureSuccessStatusCode();
        }
    }
}
