using System;

namespace doggydoggy {

    

    public interface IHealth
    {
        int health { get; set; }
        int maxhealth { get; set; }
        float healthPercent();
        void restorehealth();
    }


    public class Healthclass:IHealth
    {
        public int health { get; set; }
        public int maxhealth { get; set; }

        public Healthclass()
        {
            health = 5;
            maxhealth = 10;
        }

        public float healthPercent()
        {
            return (health / (float)maxhealth )*100;
        }
    public virtual void restorehealth()
        {
            health = maxhealth;
        }
            

    }
}