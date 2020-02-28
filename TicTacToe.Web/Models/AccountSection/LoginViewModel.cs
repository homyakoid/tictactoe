using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.Web.Models.AccountSection
{
    public class LoginViewModel
    {
        [Required]
        public string NickName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
