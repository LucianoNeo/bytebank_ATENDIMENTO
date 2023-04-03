namespace bytebank.Modelos.ADM.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(2000, cpf)
        {
        }

        
        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }

        /// <summary>
        /// Método que retorna a bonificação.
        /// </summary>
        /// <returns> Retorna um double com o salário * 0.2 </returns>
        protected internal override double getBonificacao()
        {
            return Salario * 0.2;
        }
    }
}
