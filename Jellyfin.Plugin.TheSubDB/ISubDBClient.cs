﻿using System.Threading.Tasks;
using Jellyfin.Plugin.TheSubDB.Http;

namespace Jellyfin.Plugin.TheSubDB
{
    public interface ISubDBClient
    {
        Task<Response> DownloadSubtitleAsync(string hash, params string[] languages);
        Task<Response> GetAvailableLanguagesAsync();
        Task<Response> SearchSubtitleAsync(string hash, bool getVersions);
        Task<Response> UploadSubtitleAsync(string subtitle, string movie);
    }
}