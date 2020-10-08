/* This file is part of OpenSubtitles Handler
   A library that handle OpenSubtitles.org XML-RPC methods.

   Copyright © Ala Ibrahim Hadid 2013

   This program is free software: you can redistribute it and/or modify
   it under the terms of the GNU General Public License as published by
   the Free Software Foundation, either version 3 of the License, or
   (at your option) any later version.

   This program is distributed in the hope that it will be useful,
   but WITHOUT ANY WARRANTY; without even the implied warranty of
   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
   GNU General Public License for more details.

   You should have received a copy of the GNU General Public License
   along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System.Collections.Generic;

namespace OpenSubtitlesHandler
{
    /// <summary>
    /// Response to SearchSubtitle successed call.
    /// </summary>
    [MethodResponseDescription("SubtitleSearch method response",
         "SubtitleSearch method response hold all expected values from server.")]
    public class MethodResponseSubtitleSearch : IMethodResponse
    {
        public MethodResponseSubtitleSearch()
            : base()
        {
            results = new List<SubtitleSearchResult>();
        }
        public MethodResponseSubtitleSearch(string name, string message)
            : base(name, message)
        {
            results = new List<SubtitleSearchResult>();
        }

        private List<SubtitleSearchResult> results;
        public List<SubtitleSearchResult> Results
        { get { return results; } set { results = value; } }
    }
}
