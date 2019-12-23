using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebFight.Models
{
    
    public class Categoria
    {
        [Key]
        public Guid Id_Categoria { get; set; }
        

        public enum FaixaJuvenil
        {
            Branca = 0,
            Cinza_Branca = 1,
            Cinza_Preto = 2,
            Cinza = 3,
            Amarelo_Branca = 4,
            Amarelo_preto = 5,
            Amarelo = 6,
            Laranja_Branco = 7,
            Laranja_Preto = 8,
            Laranja = 9,
            Verde_Branco = 10,
            Verde_Preto = 11,
            Verde = 12
        }

        public enum FaixaAdulto
        {
            Branca = 0,
            Azul = 1,
            Roxo = 2,
            Marrom = 3,
            Preta = 4,
            Coral_Preta = 5,
            Coral_Branca = 6,
            Vermelha = 7
        }

        public enum PesoCategoria
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

        public enum Grau
        {
            G1 = 0,
            G2 = 1,
            G3 = 2,
            G4 = 3,
            Dan1 = 4,
            Dan2 = 5,
            Dan3 = 6,
            Dan4 = 7
        }

        public enum IdadeCategoria
        {
            Pre_Mirim1 = 0,
            Pre_Mirim2 = 1,
            Pre_Mirim3 = 2,
            Mirim1 = 4,
            Mirim2 = 5,
            Mirim3 = 6,
            Infantil1 = 7,
            Infantil2 = 8,
            Infantil3 = 9,
            Infanto_Juvenil1 = 10,
            Infanto_Juvenil2 = 11,
            Infanto_Juvenil3 = 12,
            Juvenil1 = 13,
            Juvenil2 = 14,
            Juvenil3 = 15,
            Adulto = 16,
            Master1 = 17,
            Master2 = 18,
            Master3 = 19,
            Master4 = 20,
            Master5 = 21,
            Master6 = 22,
            Master7 = 23
        }
    }
}
