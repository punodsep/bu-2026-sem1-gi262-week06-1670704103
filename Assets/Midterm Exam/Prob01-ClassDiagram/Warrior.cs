using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Warrior : Hero
    {
        // TODO: Implement inheritance, fields and methods according to Class Diagram
        public int shieldDefense;
        private float rage;

        public override void Attack(GameEntity target)
        {
            base.Attack(target);
        }

        public void ShieldBash(GameEntity target)
        {
            target.TakeDamage(shieldDefense);
        }
    }
}
