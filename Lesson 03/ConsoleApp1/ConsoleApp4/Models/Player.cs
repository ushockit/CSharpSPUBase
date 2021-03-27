using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    public abstract class Player
    {
        public const int MAX_HEALTH = 100;

        public int Health { get; set; } = MAX_HEALTH;
        public Position Position { get; set; } = new Position();

        public abstract void AddHealth();
        public virtual void MoveUp()
        {
            Position.Y--;
        }
        public virtual void MoveDown()
        {
            Position.Y++;
        }
        public virtual void MoveLeft()
        {
            Position.X--;
        }
        public virtual void MoveRight()
        {
            Position.X++;
        }

        public override string ToString()
        {
            return $"Health: {Health} Position: x = {Position.X} y = {Position.Y}";
        }
    }
}
