using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
    
    static async Task Main()
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/2");
        
        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();
            
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            
            Post post = JsonSerializer.Deserialize<Post>(json, options);
            Console.WriteLine("Post Title: " + post.Title);
            Console.WriteLine("Post ID: " + post.Id);
        }
        else
        {
            Console.WriteLine("Error: " + response.StatusCode);
        }
    }
}
