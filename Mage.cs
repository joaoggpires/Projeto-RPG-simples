namespace projeto_DIO
{
    public class Mage : Hero
    {
        public Mage(string name, int level, string typeHero, string weapon)
            : base(name, level, typeHero, weapon) 
        {
        }

        public  string Atack()
        {
            return name+" give a magical atack with "+weapon;
        }

            public  string Atack(int num)
        {
            return name+" give a elemental critical magic atack with "+weapon;
        }
    } 
    }
