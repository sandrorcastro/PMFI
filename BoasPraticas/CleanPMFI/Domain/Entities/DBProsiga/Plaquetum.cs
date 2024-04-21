using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Plaquetum
    {
        public Plaquetum()
        {
            Veiculos = new HashSet<Veiculo>();
        }

        public string PlaqCnpjmembro { get; set; } = null!;
        public long PlaquetaId { get; set; }
        /// <summary>
        /// Data do Emplaquetamento do bem
        /// </summary>
        public DateTime? PlaqData { get; set; }
        /// <summary>
        /// Servidor que efetuou o emplaquetamento do bem
        /// </summary>
        public long? PlaqServidorId { get; set; }
        public int? PlaqQtdeBensEmplaq { get; set; }
        public byte[]? PlaqImgCodBarras { get; set; }
        public string? PlaqUsuarioCria { get; set; }
        public DateTime? PlaqDataCria { get; set; }

        public virtual ICollection<Veiculo> Veiculos { get; set; }
    }
}
