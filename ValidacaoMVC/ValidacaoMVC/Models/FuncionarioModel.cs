using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValidacaoMVC.Models
{
    public class FuncionarioModel
    {
        int codigo;
        string nomeFuncionario, cargo;

        [Required(ErrorMessage = "O Codigo deve ser informado !")]
        [Range(0, 200, ErrorMessage = "O Codigo deve ser entre 0 e 200")]
        [DisplayName("Codigo")]
        public int Codigo { get => codigo; set => codigo = value; }


        [Required(ErrorMessage = "O Nome do Funcionario deve ser informado !")]
        [DisplayName("Nome do Funcionario")]
        public string NomeFuncionario { get => nomeFuncionario; set => nomeFuncionario = value; }


        [Required(ErrorMessage = "O Cargo deve ser informado !")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O cargo deve Ter entre 3 a 50 Caracteres")]
        [DisplayName("Cargo")]
        public string Cargo { get => cargo; set => cargo = value; }

    }
}