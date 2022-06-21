using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
        private int _minDamage;
        public int MaxDamage { get; set; }
        public string Description { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set 
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }//end else
            }//end set
        }//end MinDamage

        //FQ CTOR -> 
        public Monster()
        {

        }

        public Monster(string name, int life, int maxLife, int hitChance,
            int block, int maxDamage, int minDamage, string description) : base(name, hitChance, block, maxLife, life)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }//end fq ctor

        public override string ToString()
        {
            return $"\n*******MONSTER*********\n{Name}\nLife: {Life} of {MaxLife}\nDamage: {MinDamage} to {MaxDamage}\nBlock: {Block}\nDescription:\n{Description}\n";
        }

        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1);
        }

        //RETURN HERE ONCE CREATED MONSTERS
        public static Monster GetMonster()
        {
            ZombieCop z = new("Zombie Cop", 25, 15, 12, 20, 17, 9, "It's red, blue and rotten green!", 17, 10);
        }
    }//end class
}//end namespace
