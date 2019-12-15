using Model.Unsplash;
using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerService.Abstract
{
    public interface IWallpaperService
    {
        void SetWallpapers(List<Picture> pictures, int monitorsCount);
    }
}