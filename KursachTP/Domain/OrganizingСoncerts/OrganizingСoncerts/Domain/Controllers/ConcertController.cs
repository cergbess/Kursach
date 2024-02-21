using Microsoft.EntityFrameworkCore;
using OrganizingСoncerts_Classes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Net.Http;
using Azure;

namespace OrganizingСoncerts.Domain.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("api/Domain/Concert")]
    public class ConcertController : ControllerBase
    {
        private readonly string? _dalUrl;

        public ConcertController(IConfiguration concertRepository)
        {
            _dalUrl = concertRepository.GetValue<string>("DalUrl");
        }

        [HttpGet]
        public async Task<IEnumerable<Concert>?> GetConcerts()
        {
            var client = new HttpClient();
            var response = await client.GetAsync($"{_dalUrl}/Concert");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<IEnumerable<Concert>>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }

        [HttpGet("{Id}")]
        public async Task<IEnumerable<Concert>?> GetConcertsById(int ConcertId)
        {
            var client = new HttpClient();
            var response = await client.GetAsync($"{_dalUrl}/Concert?ConcertId={ConcertId}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadFromJsonAsync<IEnumerable<Concert>>();
            return content;
        }

        [HttpGet("ConcertTitle")]
        public async Task<IEnumerable<Concert>?> GetConcertByTitle(string? ConcertTitle)
        {
            var client = new HttpClient();
            var response = await client.GetAsync($"{_dalUrl}/Concert?ConcertTitle={ConcertTitle}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadFromJsonAsync<IEnumerable<Concert>>();
            return content;
        }

        [HttpGet("ConcertArtist")]
        public async Task<IEnumerable<Concert>?> GetConcertsByArtistId(int ArtistId)
        {
            var client = new HttpClient();
            var response = await client.GetAsync($"{_dalUrl}/Concert?ArtistId={ArtistId}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadFromJsonAsync<IEnumerable<Concert>>();
            return content;
        }

        [HttpGet("ConcertScene")]
        public async Task<IEnumerable<Concert>?> GetConcertsBySceneId(int SceneId)
        {
            var client = new HttpClient();
            var response = await client.GetAsync($"{_dalUrl}/Concert?SceneId={SceneId}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadFromJsonAsync<IEnumerable<Concert>>();
            return content;
        }
        [HttpPost("Add")]
        public async Task<ActionResult<Concert>> PostProduct(Concert Concert)
        {
            var client = new HttpClient();
            JsonContent response = JsonContent.Create(Concert);
            using var result = await client.PostAsync($"{_dalUrl}/Concert", response);
            var content = await result.Content.ReadFromJsonAsync<Concert>();

            if (content == null)
                return BadRequest();
            else
                return content;
        }
        [HttpDelete("Delete")]
        public async Task<bool> DeleteConcertsById(int ConcertId)
        {
            var client = new HttpClient();
            var response = await client.DeleteAsync($"{_dalUrl}/Concert/delete?ConcertId={ConcertId}");
            return true;
        }
    }
}
