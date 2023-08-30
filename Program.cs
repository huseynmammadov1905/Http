

using HTTP;
using System.Text.Json;
//////Post
//HttpClient client = new();

//Post post = new()
//{
//    UserId = 1,
//    Id = 1,
//    Title = "Hello",
//    Body = "World",
//};

//Uri uri = new Uri(@"https://jsonplaceholder.typicode.com/posts");

//string json = JsonSerializer.Serialize(post);

//StringContent stringContent = new(json);

//HttpResponseMessage httpResponse = await client.PostAsync(uri, stringContent);

//Console.WriteLine((int)httpResponse.StatusCode);

//var jsonResponse = await httpResponse.Content.ReadAsStringAsync();

//Console.WriteLine(jsonResponse);

//////Put

//HttpClient client = new();

//Post post = new()
//{
//    UserId = 1,
//    Id = 1,
//    Title = "Hello",
//    Body = "World",
//};

//Uri uri = new Uri(@"https://jsonplaceholder.typicode.com/posts/1");

//string json = JsonSerializer.Serialize(post);

//StringContent stringContent = new(json);

//HttpResponseMessage httpResponse = await client.PutAsync(uri, stringContent);

//Console.WriteLine((int)httpResponse.StatusCode);

//var jsonResponse = await httpResponse.Content.ReadAsStringAsync();

//Console.WriteLine(jsonResponse);



//////Delete
///



HttpClient client = new();

Post post = new()
{
    UserId = 1,
    Id = 1,
    Title = "Hello",
    Body = "World",
};

Uri uri = new Uri(@"https://jsonplaceholder.typicode.com/posts/1");

string json = JsonSerializer.Serialize(post);

StringContent stringContent = new(json);

HttpResponseMessage httpResponse = await client.DeleteAsync(uri);

Console.WriteLine((int)httpResponse.StatusCode);

var jsonResponse = await httpResponse.Content.ReadAsStringAsync();

Console.WriteLine(jsonResponse);