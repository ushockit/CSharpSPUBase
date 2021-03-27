using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    public class HeroPlayer : Player
    {
        public override void AddHealth()
        {
            Health += 25;
        }

        public static HeroPlayer CreateInstance(Player player)
        {
            return new HeroPlayer
            {
                Health = player.Health,
                Position = player.Position
            };
        }
    }
}
