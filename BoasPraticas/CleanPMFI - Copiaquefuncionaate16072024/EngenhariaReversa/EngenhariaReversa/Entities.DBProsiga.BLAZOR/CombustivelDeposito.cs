﻿using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class CombustivelDeposito
    {
        public CombustivelDeposito()
        {
            CombustivelEntrada = new HashSet<CombustivelEntradum>();
            CombustivelSaida = new HashSet<CombustivelSaidum>();
        }

        public long CodDeposito { get; set; }
        /// <summary>
        /// Responsável pelo Depósito
        /// </summary>
        public long ConId { get; set; }
        public int? CombustivelId { get; set; }
        /// <summary>
        /// Bomba Própria ou Crédito Terceiro
        /// </summary>
        public string TipoDeposito { get; set; } = null!;
        public decimal QtdeLitrosEntrada { get; set; }
        public decimal? QtdeLitrosReserva { get; set; }
        public decimal? CapacidadeLitros { get; set; }
        public decimal? EstoqueMinimo { get; set; }
        public string? Descricao { get; set; }
        public string? Logradouro { get; set; }
        public int? NumLogradouro { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cep { get; set; }

        public virtual Combustivel? Combustivel { get; set; }
        public virtual Contribuinte Con { get; set; } = null!;
        public virtual ICollection<CombustivelEntradum> CombustivelEntrada { get; set; }
        public virtual ICollection<CombustivelSaidum> CombustivelSaida { get; set; }
    }
}
