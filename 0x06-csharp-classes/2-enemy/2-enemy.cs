using System;

namespace Enemies
{
    /// <summary> a public class Zombie that defines a zombie </summary>
    class Zombie
    {
        /// <summary> public field health</summary>
        public int health;
        /// <summary> public constructor: public Zombie()</summary>
        public Zombie()
        {
            health = 0;
        }
        /// <summary> public constructor: public Zombie(value) </summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }
    }    
}