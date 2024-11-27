namespace projeto_DIO
{
    public class Enemy : Hero
    {
         public Enemy(string name, int level, string typeHero, string weapon)
            : base(name, level, typeHero, weapon) 
        {
        }

        public  string Atack()
        {
            return name+" Atack a ally with "+weapon;
        }

            public  string Atack(int num)
        {
            return name+" give a critical atack in a ally with "+weapon;
        }
    } 
    
}