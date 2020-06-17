namespace solid.template
{
    public abstract class TemplateDeImpostoCondicional : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao();
            }

            return MinimaTaxacao(orcamento);
        }

        protected abstract double MinimaTaxacao(Orcamento orcamento);
        protected abstract double MaximaTaxacao(Orcamento orcamento);
        protected abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
    }
}