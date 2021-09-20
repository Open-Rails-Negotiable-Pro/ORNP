// COPYRIGHT 2021 by the ORNP project.
// 
// This file is part of Open Rails Negotiable Pro Client.
// 
// ORNP is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// ORNP is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with ORNP.  If not, see <http://www.gnu.org/licenses/>.

using Ornp.Formats.Msts;
using System.IO;

namespace Ornp.Simulation.Signalling
{
    public class SpeedPostWorldObject
    {
        public string SFileName { get; }

        public SpeedPostWorldObject(SpeedPostObj speedPostItem)
        {
            // get filename in Uppercase
            SFileName = Path.GetFileName(speedPostItem.FileName).ToUpperInvariant();
        }
    }
}
