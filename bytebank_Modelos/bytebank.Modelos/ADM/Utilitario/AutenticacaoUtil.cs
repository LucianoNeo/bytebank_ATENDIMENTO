using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_Modelos.bytebank.Modelos.ADM.Utilitario
{
    /// <summary>
    /// Geração de documentação, neste caso usado para identificar o comportamento da Classe AutenticacaoUtil que realiza a checagem de senha passada pelo usuario.
    /// </summary>
    public class AutenticacaoUtil
    {
        public bool ValidarSenha(string senhaverdadeira, string senhatentativa)
        {
            return senhaverdadeira.Equals(senhatentativa);
        }
    }
}
