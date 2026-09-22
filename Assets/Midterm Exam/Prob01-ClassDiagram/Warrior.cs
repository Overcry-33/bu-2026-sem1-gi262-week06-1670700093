using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Warrior : Hero
    {
        public int shieldDefense;
        private float rage;
        // TODO: Implement inheritance, fields and methods according to Class Diagram

        public override void Attack(GameEntity target) 
        {
            
        }
        public void ShieldBash(GameEntity target) 
        {
            target.TakeDamage(shieldDefense);
        }
    }
}
