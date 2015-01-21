﻿using System;
using System.Collections.Generic;

namespace Portaria.Core.Model.CadastroMorador
{
    public class Funcionario : IModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Fone { get; set; }

        public string Descricao { get; set; }

        public string Documento { get; set; }

        public bool AutorizadaSemPresenca { get; set; }

        public string Frequencia { get; set; }

        public DateTime? HorarioEntrada { get; set; }

        public DateTime? HorarioSaida { get; set; }

        public byte[] Foto { get; set; }

        public virtual Unidade Unidade { get; set; }
    }
}