using static System.Console;
namespace AbstraindoRPG.Models
{
    public class Knight : Character
    {
        public Knight (string Name,int Level,string HeroType,int Hp,int MaxHp,int Mp,int MaxMp): base(Name, Level, HeroType, Hp, MaxHp,Mp, MaxMp)
        {

        }


        public override string Attack(int Bonus)
        {   
            if (Bonus > 50)
            {
                WriteLine("Knight ataque especial - Silver Sword!");
            }
            else
            {
                WriteLine ("Knight ataque normal");
            }

            return this.Name + "Ataca o inimigo causando " + Bonus + " points de dano.";

        }
    }
}