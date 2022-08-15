using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagRace
{
    public class GetFiles
    {
        public void GetPicture(Flag f)
        {
            f.Files = Directory.GetFiles(string.Format(@"C:\Users\ilyas.bayram\source\repos\FlagRace\FlagRace\Image\{0}", f.Continent));
        }

    }
}
