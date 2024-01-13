namespace DesignPatterns2.Memento
{
    internal class Estado
    {
        public Contrato Contrato { get; private set; }
        public Estado(Contrato contrato)
        {
            this.Contrato = contrato;
        }
    }
}