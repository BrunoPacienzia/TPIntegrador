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
            AlumnoInscripcion alumnoInscripccion = null;
            HttpResponseMessage response = await client.GetAsync("alumnoInscripcciones/" + id);
            if (response.IsSuccessStatusCode)
            {
                alumnoInscripccion = await response.Content.ReadAsAsync<AlumnoInscripcion>();
            }
            return alumnoInscripccion;
        }

        public static async Task<IEnumerable<AlumnoInscripcion>> GetAllAsync()
        {
            IEnumerable<AlumnoInscripcion> alumnoInscripcciones = null;
            HttpResponseMessage response = await client.GetAsync("alumnoInscripcciones");
            if (response.IsSuccessStatusCode)
            {
                alumnoInscripcciones = await response.Content.ReadAsAsync<IEnumerable<AlumnoInscripcion>>();

            }
            return alumnoInscripcciones;
        }


        public async static Task AddAsync(AlumnoInscripcion alumnoInscripccion)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("alumnoInscripcciones", alumnoInscripccion);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("alumnoInscripcciones/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(AlumnoInscripcion alumnoInscripccion)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("alumnoInscripcciones", alumnoInscripccion);
            response.EnsureSuccessStatusCode();
        }
    }
}
