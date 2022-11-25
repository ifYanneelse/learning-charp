using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    /*
    //class vazia, trocar o modificador pra public
    //classe invisivel, ninguem consegue chamar
    class Conta
    {
    }
    */

    public class Conta
    {
        //atributo
        public double Saldo { get; set; } //get pode ser buscado | set pode adicionar valor ao atributo saldo

        public double Limite { get; set; }

        public int Numero { get; set; }

    }

}
