using System;
using System.Collections.Generic;
using System.Text;

namespace Jellyfin.Plugin.Subscene.Models
{
    public class FindMovie
    {
        public IEnumerable<TvEpisodeResult> tv_episode_results { get; set; }
    }
}
