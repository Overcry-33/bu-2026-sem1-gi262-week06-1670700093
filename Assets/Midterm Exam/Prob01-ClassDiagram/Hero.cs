using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Hero : Character
    {
        public int currentExp;
        private int gold;
        // TODO: Implement inheritance, fields and methods according to Class Diagram

        public override void Attack(GameEntity target) 
        { 
            
        }
        public void CollectGold(int amount) 
        {
            amount += 10;
        }

        protected override void LevelUp() 
        {
            currentExp = 0;
        }
    }
}
