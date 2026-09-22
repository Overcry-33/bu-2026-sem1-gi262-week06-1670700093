using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Mage : Hero
    {
        public int mana;
        private int spellPower;
        // TODO: Implement inheritance, fields and methods according to Class Diagram
        public override void Attack(GameEntity target) 
        {
            
        }
        public void CastSpell(GameEntity target) 
        {
            target.TakeDamage(mana);
        }
    }
}
