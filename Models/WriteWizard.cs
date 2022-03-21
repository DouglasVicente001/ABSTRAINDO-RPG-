using static System.Console;
namespace AbstraindoRPG.Models
{
    public class WriteWizard : Hero
    {
        public WriteWizard (string Name, int Level, string HeroType, int Hp, int MaxHp, int Mp, int MaxMp) : base(Name, Level, HeroType, Hp, MaxHp,Mp, MaxMp)
        {
        
        }

        public override string Attack(int Bonus)
        {   
            if (Bonus > 50)
            {
                WriteLine("WriteWizard ataque especial - Storm Blaster!");
            }
            else
            {
                WriteLine ("WriteWizard ataque normal!");
            }

            return this.Name +" Ataca o inimigo causando " + Bonus + " points de dano.";

        }
    }
}