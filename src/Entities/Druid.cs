namespace RGP_Dio.src.Entities
{
    public class Druid: Hero
    {
        public Druid(string nome, int level, string tipoHeroi, int hp, int mp) : base(nome, level, tipoHeroi, hp, mp)
        {
            this.nome=nome;
            this.level=level;
            this.tipoHeroi=tipoHeroi;
            this.hp=hp;
            this.mp=mp;
        }

        public override string Attack()
        {
            return this.nome+ " Lancou magia";
        }
        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return this.nome+ " Lancou magia Elemental " + (this.mp*0.2 ) +  " com critico de "+ bonus;
            }
            else
            {
                return this.nome+ " Lancou magia Elemental " + (this.mp*0.2 )  + " com bonus de ataque de "+ bonus;
            }
            
        }
    }
}