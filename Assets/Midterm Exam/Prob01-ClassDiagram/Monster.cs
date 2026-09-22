using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Monster : Character
    {
        // TODO: Implement inheritance, fields and methods according to Class Diagram
        public int baseDamage;
        protected int aggroRange;

        public override void Attack(GameEntity target)
        {
            base.Attack(target);
            target.TakeDamage(baseDamage);
        }

        protected virtual void Roar()
        {

        }
    }
}
