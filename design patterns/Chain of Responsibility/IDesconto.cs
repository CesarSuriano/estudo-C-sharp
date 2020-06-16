namespace solid.chain
{
    public interface IDesconto
    {
        double Aplica(Orcamento orcamento);
        IDesconto Proximo {get; set;}
    }
}