using System;

namespace doggydoggy { 

    public class health : dog
    {
        public int health = 5;
        public int maxhealth = 10;
        public float healthPercent()
        {
            return (health / maxhealth)*100;
        }
        

    }
}