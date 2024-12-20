﻿using PetCareConnect.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareConnect.Business.Interfaces
{
    public interface IPrestadorRepository : IBaseRepository<Prestador>
    {
        Task<Prestador> ObterPorIdComEndereco(Guid id);


    }
}
