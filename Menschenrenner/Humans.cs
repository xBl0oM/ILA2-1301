using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menschenrenner
{
    public class Humans
    {
        private string _name;
        private int _speed;
        private string _feature;

        public Humans(string name, int speed, string feature)
        {
            _name = name;
            _speed = speed;
            _feature = feature;
        }
    }
}
