using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Core
{
    public enum TipoConfiguracao
    {
        DuracaoReservaDias = 1,
        DuracaoReservaHora = 2,
        PermitirEscolherFimReserva = 3,
        PrazoAntecedenciaReservaDias = 4,
        SemRestricaoAntecedencia = 5,
        EmailResponsavel = 6,
        ServidorSMTP = 7,
        PortaSMTP = 8,
        ConexaoSeguraSMTP = 9,
        UsuarioSMTP = 10,
        SenhaSMTP = 11
    }
}
