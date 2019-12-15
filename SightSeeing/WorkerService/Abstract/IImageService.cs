using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerService.Abstract
{
    public interface IImageService
    {
        void FetchImages(string searchKey);
    }
}
