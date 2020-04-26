using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mvc_Imagem.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        public int CategoriaId { get; set; }
        [Display(Name = "Nome da Categoria")]
        public String CategoriaNome { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}