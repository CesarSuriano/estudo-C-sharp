namespace solid.ocp
{
    public class CalculadoraDePrecos
    {
        private ITabelaDePreco tabela;
        private IServicoDeEntrega entrega;

        public CalculadoraDePrecos(ITabelaDePreco tabela, IServicoDeEntrega entrega)
        {
            this.tabela = tabela;
            this.entrega = entrega;
        }

        public double Calcula(Compra produto)
        {
            TabelaDePrecoPadrao tabela = new TabelaDePrecoPadrao();
            Frete correios = new Frete();

            double desconto = this.tabela.DescontoPara(produto.Valor);
            double frete = correios.para(produto.Cidade);

            return produto.Valor * (1 - desconto) + frete;
        }
    }
}