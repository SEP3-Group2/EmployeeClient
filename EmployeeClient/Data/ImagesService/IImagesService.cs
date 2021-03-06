﻿using EmployeeClient.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeClient.Data.ImagesService
{
    interface IImagesService
    {
        Task UploadImage(SaveFile files);

        Task<SaveFile> GetImages(string quantity, int productID);
    }
}
