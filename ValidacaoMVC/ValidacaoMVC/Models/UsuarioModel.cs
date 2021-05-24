using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ValidacaoMVC.Models
{
    public class UsuarioModel
    {
        int codigo;
        string nomeUser, observacao, email, login, senha, confirmaSenha;
        DateTime dtNascimento;

        [Required(ErrorMessage = "O Codigo deve ser informado !")]
        [Range(0, 200, ErrorMessage = "O Codigo deve ser entre 0 e 200")]
        [DisplayName("Codigo")]
        public int Codigo { get => codigo; set => codigo = value; }


        [Required(ErrorMessage = "O Nome de Usuário deve ser informado !")]
        [DisplayName("Nome de Usuario")]
        public string NomeUser { get => nomeUser; set => nomeUser = value; }


        [Required (ErrorMessage = "A Observação é Obrigatório !", AllowEmptyStrings = true)]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "A observação deve ser de 5 a 50 Caracteres")]
        [DisplayName("Observação")]
        public string Observacao { get => observacao; set => observacao = value; }


        [Required(ErrorMessage = "A Data é Obrigatória !")]
        [DataType(DataType.Date)]
        [DisplayName("Data de Nascimento")]
        public DateTime DtNascimento { get => dtNascimento; set => dtNascimento = value; }


        [Required(ErrorMessage = "O Email é Obrigatório !")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Insria um E-mail Valido!")]
        [DisplayName("Email")]
        public string Email { get => email; set => email = value; }



        [Required(ErrorMessage = "O Login é Obrigatório !")]
        [StringLength(50, MinimumLength = 5)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "O Login deve ter apenas Letras de A-Z (Maiusculas e Minusculas)")]
        [DisplayName("Login")]
        public string Login { get => login; set => login = value; }


        [DataType(DataType.Password)]
        [Display(Name = "Confirmar a senha")]
        [Required(ErrorMessage = "A Senha é Obrigatória !")]
        [DisplayName("Senha")]
        public string Senha { get => senha; set => senha = value; }


        [Required(ErrorMessage = "A Confirmação de Senha é Obrigatória !")]
        [DataType(DataType.Password)]
        [Compare("Senha", ErrorMessage = "A senhe e a Confirmação da Senha são diferentes")]
        [Display(Name = "Confirmar a senha")]
        public string ConfirmaSenha { get => confirmaSenha; set => confirmaSenha = value; }

    }
}