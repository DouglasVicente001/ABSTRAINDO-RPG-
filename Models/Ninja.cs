using static System.Console;
namespace AbstraindoRPG.Models
{
    public class Ninja : Hero
    {
        public Ninja (string Name,int Level,string HeroType,int Hp,int MaxHp,int Mp,int MaxMp) : base(Name, Level, HeroType, Hp, MaxHp,Mp, MaxMp)
        {
            
        }
        public override string Attack(int Bonus)
        {   
            if (Bonus > 50)
            {
                WriteLine("Ninja ataque especial - Destruction Churikem!");
            }
            else
            {
                WriteLine ("Ninja ataque normal!");
            }

            return this.Name + "Ataca o inimigo causando " + Bonus + " points de dano.";
        }
    }
}