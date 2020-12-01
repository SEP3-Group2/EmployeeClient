using EmployeeClient.Models;
using ImageServer.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EmployeeClient.Data.ImagesService
{
    public class ImagesService : IImagesService
    {
        HttpClient client = new HttpClient();
        string uri = "https://localhost:44319/images";

        public async Task UploadImage(SaveFile files)
        {
            string filesSerialized = JsonSerializer.Serialize(files);

            HttpContent payload = new StringContent(
                filesSerialized,
                Encoding.UTF8,
                "application/json"
                );

            Console.WriteLine(filesSerialized);

            var response = await client.PostAsync($"{uri}", payload);

            /*
            Console.WriteLine("Upload image called");
            var content = new MultipartFormDataContent();
            content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data");

            string fileFormatted = JsonSerializer.Serialize(file);
            Console.WriteLine(fileFormatted);

            var buffer = new byte[file.Length];
            Console.WriteLine("Read stream");
            //await file.OpenReadStream().ReadAsync(buffer);
            Console.WriteLine("read stream over");
            var imageData = Convert.ToBase64String(buffer);

            var imageSerialized = JsonSerializer.Serialize(imageData);
            var idSerialized = JsonSerializer.Serialize(id);

            HttpContent part1 = new StringContent(
                fileFormatted,
                Encoding.UTF8,
                "application/json"
                );

            HttpContent part2 = new StringContent(
                idSerialized,
                Encoding.UTF8,
                "application/json"
                );

            Console.WriteLine("Adding content");
            content.Add(part1);
            content.Add(part2);

            Console.WriteLine("Sending image");
            Console.WriteLine(fileFormatted);
            Console.WriteLine("----------------------");
            Console.WriteLine(idSerialized);

            
            var response = await client.PostAsync($"{uri}", content);

            /*
            var fileStream = new MemoryStream()
            content.Add(new ByteArrayContent(file.))
            */
        }
    }
}
