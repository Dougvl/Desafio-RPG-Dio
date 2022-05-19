namespace RGP_Dio.src.Entities
{
    public class Knight:Hero
    {
        public Knight(string nome, int level, string tipoHeroi, int hp, int mp) : base(nome, level, tipoHeroi, hp, mp)
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
                return this.nome+ "Atacou com a espada com bonus " + (this.hp *0.1 ) +  " de critico ataque de "+ bonus;
            } 
            else
            {
                return this.nome+ " Atacou com a espada com " + (this.hp *0.1 ) +  "bonus de ataque de "+ bonus;
            }
            
        }
    }
}