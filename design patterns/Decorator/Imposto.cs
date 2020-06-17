namespace solid.decorator
{
    public abstract class Imposto
    {
        public Imposto OutroImposto {get; set;}

        public Imposto (Imposto OutroImposto)
        {
            this.OutroImposto = OutroImposto;
        }

        public Imposto()
        {
            this.OutroImposto = null;
        }

        public abstract double Calcula(Orcamento orcamento);
        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null) 
            {
                return 0;
            }

            return OutroImposto.Calcula(orcamento);
        }
    }
}