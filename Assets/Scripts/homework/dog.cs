using System;
using UnityEngine;

namespace doggydoggy
{

    public class Dogclass : IHealth
    {
        Healthclass manager = new Healthclass();

        public int health
        {
            get
            {
                return manager.health;
            }
            set
            {
                manager.health = value;
            }
        }
        public int maxhealth
        {
            get
            {
                return manager.maxhealth;
            }
            set
            {
                manager.maxhealth = value;
            }
        }

        public string[] dogname = { "baek", "sehun", "kai" };

        public Dogclass(){
        restorehealth();

        }
        public void restorehealth()
        {
           for (int i= health; i <= maxhealth; i++)
            {
                health = i;
                Debug.Log("health"+health);
            }
        }

        public float healthPercent()
        {
            return ((IHealth)manager).healthPercent();
        }
    }
}