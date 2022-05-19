namespace RGP_Dio.src.Entities
{
    public abstract class Hero
    {
        public Hero(string nome, int level, string tipoHeroi, int hp, int mp)
        {
            this.nome=nome;
            this.level=level;
            this.tipoHeroi=tipoHeroi;
            this.hp=hp;
            this.mp=mp;

        }

        public string nome { get; set; }
        public int level { get; set; }
        public string tipoHeroi { get; set; }
        public int hp { get; set; }
        public int mp { get; set; }

        public override string ToString()
        {
            return "Nome: " + this.nome + " Nivel: " + this.level + " Tipo: " + this.tipoHeroi + " Vida: " + this.hp + " Mana Points " + this.mp;
        }

        public virtual string Attack ()
        {
            return this.nome + " Atacou com sua espada";
        }
        

    }
}