using UnityEngine;

namespace MidtermExam.Prob01
{
    public class MinionMonster : Monster
    {
        public int swarmBonus;
        private bool isAlerted;
        // TODO: Implement inheritance, fields and methods according to Class Diagram

        public void CallReinforcements() 
        {
            isAlerted = true;
        }
    }
}
