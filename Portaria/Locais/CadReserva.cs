using Portaria.Core.Model;
using Portaria.Framework.Forms;

namespace Portaria.Locais
{
    public partial class CadReserva : FormBaseWindow
    {
        private Reserva reserva;

        public Reserva Reserva
        {
            get
            {
                return reserva; 
            }

            set
            {
                reserva = value;
            }
        }

        public CadReserva()
        {
            InitializeComponent();

            Reserva = new Reserva();
        }

        public CadReserva(Reserva reserva)
        {
            InitializeComponent();

            Reserva = reserva;
        }
    }
}
