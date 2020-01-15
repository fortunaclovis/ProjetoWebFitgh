using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebFight.Models
{
    public class Certificado
    {
        [Key]
        public Guid IdCertificado { get; set; }
        [ForeignKey("Graduacao")]
        public int Graduacao_Id { get; set; }
        public byte[] CertificadoPDF { get; set; }
    }
}
