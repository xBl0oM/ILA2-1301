using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Menschenrenner
{
    public class Humans
    {
        private string _name;
        private int _speed;
        private string _feature;
        private Image _image;

        public Humans(string name, int speed, string feature, Image image)
        {
            _name = name;
            _speed = speed;
            _feature = feature;
            _image = image;
        }
    }
}
