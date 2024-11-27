namespace projeto_DIO
{
    public class Healer : Hero
    {
         public Healer(string name, int level, string typeHero, string weapon)
            : base(name, level, typeHero, weapon) 
        {
        }


            public  string Atack(int num)
        {
            return name+" give a critical atack with: "+weapon+" and heal your allies ";
        }
    }
    }
