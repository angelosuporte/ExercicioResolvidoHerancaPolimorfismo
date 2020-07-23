namespace ExercioResolvidoHerancaPolimorfismo.Entidades
{
    class EmpregadoTerceirizado : Empregado
    {
        public double DespesaAdicional { get; set; }

        public EmpregadoTerceirizado()
        {
        }

        public EmpregadoTerceirizado(string nome, int horas, double valorPorHora, double despesaAdicional) 
            : base (nome, horas, valorPorHora) //<--Aproveitando o construtor da superclasse
        {
            DespesaAdicional = despesaAdicional;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * DespesaAdicional;
        }
    }
}
