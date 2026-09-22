using UnityEngine;

namespace MidtermExam.Prob01
{
    public class BossMonster : Monster
    {
        public int phase;
        private bool isEnraged;
        // TODO: Implement inheritance, fields and methods according to Class Diagram

        public override void Attack(GameEntity target) 
        {
            
        }

        protected override void Roar() 
        {
            
        }
        public void TriggerPhaseTransition() 
        {
            phase++;
            isEnraged = true;
        }
    }
}
