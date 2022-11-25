using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana05
{
    static class Extensions
    {
        public static bool HasOnlyDigits(this string valor)
        {
            const string digitos = "0123456789";
            foreach (char c in valor) //para cada caractere presente na string:
            {//se algum caractere não tiver contido em "0123456789"
                if (!digitos.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
