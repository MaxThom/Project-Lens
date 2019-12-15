using Model.Unsplash;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService.Abstract
{
    public interface IImageService
    {
        Task<List<Picture>> FetchImagesAsync(string searchKey);
    }
}