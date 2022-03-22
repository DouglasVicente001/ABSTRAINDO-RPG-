using static System.Console;
namespace AbstraindoRPG.Models
{
    public class Boss : Character
    {
        public Boss (string Name,int Level,string HeroType,int Hp,int MaxHp,int Mp,int MaxMp): base(Name, Level, HeroType, Hp, MaxHp,Mp, MaxMp)
        {

        }


        public override string Attack(int Bonus)
        {   
            if (Bonus > 50)
            {
                WriteLine("Boss ataca com ataque super eficaz  - Destruction of Planets!!!");
            }
            else
            {
                WriteLine ("você usou ataque normal");
            }

            return this.Name +" Ataca os Herois com precisão causando " + Bonus + " fucking points de dano.";

        }
    }
}