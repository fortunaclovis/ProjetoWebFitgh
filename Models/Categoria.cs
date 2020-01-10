using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebFight.Models
{
    public enum Idade
    {
        Pre_Mirim1,
        Pre_Mirim2,
        Pre_Mirim3,
        Mirim1,
        Mirim2,
        Mirim3,
        Infantil1,
        Infantil2,
        Infantil3,
        Infanto_Juvenil1,
        Infanto_Juvenil2,
        Infanto_Juvenil3,
        Juvenil1,
        Juvenil2,
        Juvenil3,
        Adulto,
        Master1,
        Master2,
        Master3,
        Master4,
        Master5,
        Master6,
        Master7
    }

    public enum Peso
    {
        Galo = 0,
        Pluma = 1,
        Pena = 2,
        Leve = 3,
        Medio = 4,
        Meio_Pesado = 5,
        Pesado = 6,
        Super_Pesado = 7,
        Pesadissimo = 8
    }

    public enum Faixas
    {
        Branca,
        Cinza_Branca,
        Cinza_Preto,
        Cinza,
        Amarelo_Branca,
        Amarelo_preto,
        Amarelo,
        Laranja_Branco,
        Laranja_Preto,
        Laranja,
        Verde_Branco,
        Verde_Preto,
        Verde,
        Azul,
        Roxo,
        Marrom,
        Preta,
        Coral_Preta,
        Coral_Branca,
        Vermelha
    }

    public enum Grau
    {

        G0 = 0,
        G1 = 1,
        G2 = 2,
        G3 = 3,
        G4 = 4,
        Dan1 = 5,
        Dan2 = 6,
        Dan3 = 7,
        Dan4 = 8
    }

    public class Categoria
    {
        [Key]
        public Guid Id_Categoria { get; set; }

        [Required]
        public Idade? Idade { get; set; }
        [Required]
        public Peso? Peso { get; set; }
        [Required]
        public Faixas? Faixa { get; set; }
        [Required]
        public Grau? Grau { get; set; }
    }
}
