using System;

namespace Enemies
{
    /// <summary> a public class Zombie that defines a zombie </summary>
    class Zombie
    {
        private int health;
        private string name = "(No name)";
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

        /// <summary> public method public int GetHealth() that returns the value of health of the Zombie object </summary>
        public int GetHealth()
        {
            return health;
        }
        /// <summary> public property Name</summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name=value;
            }
        }
    }    
}