using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfWettbewerb
{
    class Spieler
    {
        public string Name { get; set; }
        public int Leben { get; set; }
        public int Schlag { get; set; }

        Random rnd = new Random();
        public Spieler(string name)
        {
            Name = name;
            Leben = 0;
            Schlag = 0;
        }

        public void Hauen()
        {
            
        }
    }
}
