using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character 
    {
        public Race CharacterRace { get; set; }
        public Weapon EquippedWeapon { get; set; }//CONTAINMENT 

        public Player(string name, int hitChance, int block, int maxLife, int life, Race characterRace, Weapon equippedWeapon) : base(name, hitChance, block, maxLife, life)
        {
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
            //Potential Expansion - modify prop values based on the chosen race or weapon 
            switch (CharacterRace)
            {
                case Race.Commoner:
                    break;
                case Race.DogOwner:
                    break;
                case Race.StreetPreacher:
                    break;
                case Race.FastFoodWorker:
                    break;
                case Race.Barista:
                    break;
                case Race.WebDeveloper:
                    break;
            }
        }

        public override string ToString()
        {
            string description = "";
            switch (CharacterRace)
            {
                case Race.Commoner:
                    description = "Commoner";
                    break;
                case Race.DogOwner:
                    description = "DogOwner";
                    break;
                case Race.StreetPreacher:
                    description = "StreetPreacher";
                    break;
                case Race.FastFoodWorker:
                    description = "FastFoodWorker";
                    break;
                case Race.Barista:
                    description = "Barista";
                    break;
                case Race.WebDeveloper:
                    description = "Web Developer";
                    break;
            }
            return base.ToString() + $"\nWeapon: {EquippedWeapon.Name}\n" +
                                     $"Total Hit Chance: {CalcHitChance()}\n " +
                                     $"Description: {description}";
        }

        public override int CalcDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            return damage;
        }

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.BonustHitChance;
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DungeonLibrary
//{
//    public class Player : Character
//    {
//        public Race CharacterRace { get; set; }
//        public Weapon EquippedWeapon { get; set; }//CONTAINMENT

//        public Player(string name, int hitChance, int block, int maxLife, int life, Race characterRace, Weapon equippedWeapon) : base(name, hitChance, block, maxLife, life)
//        {
//            CharacterRace = characterRace;
//            EquippedWeapon = equippedWeapon;
//            //Potential Expansion - Modify prop values based on the chosen Race
//            switch (CharacterRace)
//            {
//                case Race.Human:
//                    break;
//                case Race.Orc:
//                    break;
//                case Race.Elf:
//                    HitChance += 5;
//                    break;
//                case Race.Halfling:
//                    break;
//                case Race.Gnome:
//                    break;
//                case Race.Dwarf:
//                    break;
//                case Race.Demon:
//                    break;
//                default:
//                    break;
//            }
//        }//FQ Ctor

//        public override string ToString()
//        {
//            string description = "";
//            switch (CharacterRace)
//            {
//                case Race.Human:
//                    description = "Human";
//                    break;
//                case Race.Orc:
//                    description = "Orc";
//                    break;
//                case Race.Elf:
//                    description = "Elf";
//                    break;
//                case Race.Halfling:
//                    description = "Halfling";
//                    break;
//                case Race.Gnome:
//                    description = "Gnome";
//                    break;
//                case Race.Dwarf:
//                    description = "Dwarf";
//                    break;
//                case Race.Demon:
//                    description = "Demon";
//                    break;
//            }//end switch

//            return base.ToString() + $"\nWeapon: {EquippedWeapon.Name}\n" +
//                                     $"Total Hit Chance: {CalcHitChance()}\n" +
//                                     $"Description: {description}";
//        }//end ToString();

//        public override int CalcDamage()
//        {
//            Random rand = new Random();
//            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
//            return damage;
//        }//end CalcDamage() override
//        public override int CalcHitChance()
//        {
//            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
//        }
//    }
//}
