namespace solid.decorator
{
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }

            return MinimaTaxacao(orcamento);
        }

        protected abstract double MinimaTaxacao(Orcamento orcamento);
        protected abstract double MaximaTaxacao(Orcamento orcamento);
        protected abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
    }
}