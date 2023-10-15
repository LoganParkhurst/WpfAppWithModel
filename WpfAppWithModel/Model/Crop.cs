using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppWithModel.Model
{
    public class Crop
    {
        protected string _name;
        protected int _hight;

        public string Name { get; set; }
        public int Height { get; set; }
        public Crop(string name) { 
            Name = name;
            Height = 0;
        }

        public void grow()
        {
            Height++;
        }

        public void grow(int hight)
        {
            for(int i = 0; i < hight; i++)
            {
                this.grow();
            }
        }
    }
}