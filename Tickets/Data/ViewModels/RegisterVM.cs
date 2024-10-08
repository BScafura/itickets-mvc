﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Tickets.Data.ViewModels
{
    public class RegisterVM
    {
        [Display (Name= "Email adress")][Required (ErrorMessage = "Campo obrigatorio")] public string? EmailAddress { get; set;}

        [Display(Name = "Password")][DataType(DataType.Password)][Required(ErrorMessage = "Campo obrigatorio")] public string? Password { get; set;}


    }
}