namespace DungeonLibrary
{
    public class Character
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

        //Collect - Constructors (Ctors)
        //1 fully qualified constructor

        //Monkeys - Methods
        //ToString()
        //CalcBlock() -> return block
        //CalcHitChance() -> return HitChance
        //CalcDamage() -> Return 0;
    }
}