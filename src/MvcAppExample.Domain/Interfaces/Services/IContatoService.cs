﻿using MvcAppExample.Domain.Entities;
using System;
using System.Collections.Generic;

namespace MvcAppExample.Domain.Interfaces.Services
{
    public interface IContatoService : IServiceBase<Contato>
    {
        Contato ObterPorEmail(string email);
        IEnumerable<Contato> ObterAtivos();

        Telefone AdicionarTelefone(Telefone telefone);
        Telefone AtualizarTelefone(Telefone telefone);
        Telefone ObterTelefonePorId(Guid id);
        void RemoverTelefone(Guid id);
    }
}
