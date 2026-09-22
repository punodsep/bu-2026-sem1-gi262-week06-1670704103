using UnityEngine;

namespace MidtermExam.Prob01
{
    public class BossMonster : Monster
    {
        // TODO: Implement inheritance, fields and methods according to Class Diagram
        public int phase;
        private bool isEnraged;

        public override void Attack(GameEntity target)
        {
            base.Attack(target);
        }

        protected override void Roar()
        {
            base.Roar();
        }

        public void TriggerPhaseTransition()
        {
            phase++;
            isEnraged = true;
        }
    }
}
