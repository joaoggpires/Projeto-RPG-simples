namespace projeto_DIO
{
    public class Hero
    {
        public string name { get; set; }
        public int level { get; set; }
        public string typeHero { get; set; }
        public string weapon { get; set; }

        public Hero(string name, int level, string typeHero, string weapon)
        {
            this.name = name;
            this.level = level;
            this.typeHero = typeHero;
            this.weapon = weapon;
        }

        public  string Atack()
        {
            return $"Attack with: {weapon}";
        }

        public override string ToString()
        {
            return $"Name: {this.name}, Level: {this.level}, Type: {this.typeHero}";
        }
    }
}