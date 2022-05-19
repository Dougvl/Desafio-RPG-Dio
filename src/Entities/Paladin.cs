namespace RGP_Dio.src.Entities
{
    public class Paladin:Hero
    {
        public Paladin(string nome, int level, string tipoHeroi, int hp, int mp) : base(nome, level, tipoHeroi, hp, mp)
        {
            this.nome=nome;
            this.level=level;
            this.tipoHeroi=tipoHeroi;
            this.hp=hp;
            this.mp=mp;
            
        }
        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return this.nome+ "Atacou com a espada com bonus " + (this.hp *0.05+this.mp *0.08) +  " de critico ataque de "+ bonus;
            } 
            else
            {
                return this.nome+ " Atacou com a espada com " + (this.hp *0.05+this.mp *0.08) +  "bonus de ataque de "+ bonus;
            }
            
        }
    }
}