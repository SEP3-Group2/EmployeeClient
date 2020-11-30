using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Drawing;
using System.Threading.Tasks;

namespace EmployeeClient.Data.ImageService
{
    public class ImageService : IImageService
    {
        HttpClient client = new HttpClient();

        public async Task UploadImage(Image image, int id)
        {
            throw new NotImplementedException();
            
        }
    }
}
