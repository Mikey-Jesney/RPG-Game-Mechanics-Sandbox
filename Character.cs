using System;

namespace Project_Practice
{
    // Weapon
    // Spell
    // Enemy
    // Hero

    public class Character
    {
        private int _strength;
        private int _luck;
        public int Stamina { get; set; } = 30;
        private int _health = 30;
        
        public int Health 
        { 
            get => _health;
            set 
            { 
                _health = Math.Max(_health - value, 0);
                if(_health == 0) Die();
            }
        }

        public bool IsDead { get; set; } = false;

        public void Die()
        {
            IsDead = true;
        }

    }
}
