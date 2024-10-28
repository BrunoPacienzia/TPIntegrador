using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    public class AlumnoInscripccionApiClient
    {
        private static HttpClient client = new HttpClient();
        static AlumnoInscripccionApiClient()
        {
            client.BaseAddress = new Uri("https://localhost:7271/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public static async Task<AlumnoInscripccion> GetAsync(int id)
        {
            AlumnoInscripccion alumnoInscripccion = null;
            HttpResponseMessage response = await client.GetAsync("alumnoInscripcciones/" + id);
            if (response.IsSuccessStatusCode)
            {
                alumnoInscripccion = await response.Content.ReadAsAsync<AlumnoInscripccion>();
            }
            return alumnoInscripccion;
        }

        public static async Task<IEnumerable<AlumnoInscripccion>> GetAllAsync()
        {
            IEnumerable<AlumnoInscripccion> alumnoInscripcciones = null;
            HttpResponseMessage response = await client.GetAsync("alumnoInscripcciones");
            if (response.IsSuccessStatusCode)
            {
                alumnoInscripcciones = await response.Content.ReadAsAsync<IEnumerable<AlumnoInscripccion>>();

            }
            return alumnoInscripcciones;
        }


        public async static Task AddAsync(AlumnoInscripccion alumnoInscripccion)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("alumnoInscripcciones", alumnoInscripccion);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("alumnoInscripcciones/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(AlumnoInscripccion alumnoInscripccion)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("alumnoInscripcciones", alumnoInscripccion);
            response.EnsureSuccessStatusCode();
        }
    }
}
