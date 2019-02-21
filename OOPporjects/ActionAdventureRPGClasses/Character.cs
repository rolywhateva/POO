using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActionAdventureRPGClasses
{
    public abstract class Character
    {
       
           public WeaponBehaviour Weapon { get; set; }
        public void Fight()
        {
            Weapon.UseWeapon();
        }
        
    }
}