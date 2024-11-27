namespace projeto_DIO
{
    public class SwordFighter : Hero
    {
        public SwordFighter(string name, int level, string typeHero, string weapon)
            : base(name, level, typeHero, weapon) 
        {
        }

        public  string Atack()
        {
            return name+" give a slash Atack with: "+weapon;
        }

            public  string Atack(int num)
        {
            return name+" give a critical Slash with: "+weapon;
        }
    }
}