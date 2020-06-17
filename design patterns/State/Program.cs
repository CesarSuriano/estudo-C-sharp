namespace solid.state
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Orcamento reforma = new Orcamento(500);

            reforma.AplicaDescontoExtra();
            reforma.Reprova();
            reforma.Aprova();
        }
    }    
}