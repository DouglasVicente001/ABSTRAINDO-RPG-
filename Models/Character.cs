using static System.Console;
namespace AbstraindoRPG.Models
{
    public abstract class Character
    {
        public string Name;
        public int Level;

        public string HeroType;

        public int Hp;

        public int MaxHp;

        public int Mp;

        public int MaxMp;

        public Character (string Name,int Level,string HeroType,int Hp,int MaxHp,int Mp,int MaxMp)
        {
        this.Name = Name;
        this.HeroType = HeroType;
        this.Level = Level;
        this.Hp = Hp;
        this.MaxHp = MaxHp;
        this.Mp = Mp;
        this.MaxMp = MaxMp;

        }

        public override string ToString()
        {   
        return this.Name + "Lv." + this.Level + this.HeroType + "HP:" + this.Hp + "/ "+this.MaxHp + "   MP:"+this.Mp + "/ "+this.MaxMp;
        }

        public virtual string Attack(int Bonus)
        {   
            if (Bonus > 50)
            {
                WriteLine("Você atacou com força total.");
            }
            else
            {
                WriteLine ("você usou ataque normal");
            }

            return this.Name +" Ataca o inimigo causando" + Bonus + " de dano.";

        }

        
    }
}