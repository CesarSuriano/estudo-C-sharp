namespace solid.ocp
{
    public class Frete : IServicoDeEntrega
    {
        public double para(string cidade)
        {
            if("SAO PAULO".Equals(cidade.ToUpper()))
            {
                return 15;
            }
            return 30;
        }
    }
}