namespace DungeonLibrary
{

    //abstract means it can only be inherited from; you cannot create one.
    public abstract class Character
    {

        //Funny - Fields

        /*
         * life - int
         * name - string
         * hitChance - int
         * block - int
         * maxLife - int
         */
        private int _life;
        private int _maxLife;
        private string _name;
        private int _hitChance;
        private int _block;

        //People - Properties (props)
        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }
        //public int MaxLife { get; set; }
        public int Life
        {
            get { return _life; }
            set
            {
                //Business rule: life should not be more than MaxLife
                if (value <= MaxLife)
                {
                    _life = value;
                }
                else
                {
                    _life = MaxLife;
                }
            }
        }//end life prop

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }

        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }

        //Collect - Constructors (Ctors)
        //1 fully qualified constructor
        public Character(string name, int hitChance, int block, int maxLife, int life)
        {
            MaxLife = maxLife;
            Life = life;
            Name = name;
            HitChance = hitChance;
            Block = block;
        }

        public Character()
        {

        }

        public override string ToString()
        {
            return string.Format("-----{0}-------\n" +
                "Life: {1} of {2}\nHit Chance: {3}%\n" +
                "Block: {4}",
                Name,
                Life,
                MaxLife,
                HitChance,
                Block);
        }


        public virtual int CalcBlock()
        {
            return Block;
        }

        public virtual int CalcHitChance()
        {
            return HitChance;
        }

        public virtual int CalcDamage()
        {
            return 0;

            //Starting this just with 0. Will override it in monster and player child class
        }

        //Monkeys - Methods
        //ToString()
        //CalcBlock() -> return block
        //CalcHitChance() -> return HitChance
        //CalcDamage() -> Return 0;
    }
}