namespace projeto_DIO
{
    public class Fighter : Hero
    {
       public Fighter(string name, int level, string typeHero, string weapon)
            : base(name, level, typeHero, weapon) 
        {
        }

        public  string Atack()
        {
            return name+" give a Puch with: "+weapon;
        }

            public  string Atack(int num)
        {
            return name+" Give a Critical Punch with "+weapon;
        }
    }  
    }
