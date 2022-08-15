using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FlagRace
{
    public class Flag
    {

        public int NumberReal { get; set; }

        public int NumberWrong { get; set; }

        public int CountCorrectAnswer { get; set; }

        public int CountWrongAnswer { get; set; }

        public string Continent { get; set; }
        
        public string IndexReal { get; set; }

        public string IndexFake { get; set; }

        public string[] Files { get; set; }

    }
}
