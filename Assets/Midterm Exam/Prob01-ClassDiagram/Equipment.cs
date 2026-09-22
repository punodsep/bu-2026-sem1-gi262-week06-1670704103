using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Equipment : InventoryItem
    {
        // TODO: Implement inheritance, fields and methods according to Class Diagram
        public int durability;
        protected bool isEquipped;

        public virtual void Equip(Hero hero)
        {
            isEquipped = true;
        }

        public override void Use(Character user)
        {
            base.Use(user);
        }
    }
}
