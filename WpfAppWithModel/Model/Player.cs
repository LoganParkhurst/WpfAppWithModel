using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppWithModel.Model
{
    public class Player
    {
        public string Name { get; set; }
        public int Cash { get; set; }

        public void harvest(Crop plant, List<Crop> plants)
        {
            for (int i = 0; i <= plants.Count; i++)
            {
                if (plant == plants[i])
                {
                    plants.RemoveAt(i);
                }
            }
        }
    }
}
