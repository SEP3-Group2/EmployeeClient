using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace EmployeeClient.Data.ImageService
{
    interface IImageService
    {
        Task UploadImage(Image image, int id);
    }
}
