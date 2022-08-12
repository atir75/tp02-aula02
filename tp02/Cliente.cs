using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp02
{
    internal class Cliente
    {
        private static String cnpj;
        private static String nome;

        public static void setCNPJ(String _cnpj) { cnpj = _cnpj; }
        public static void setNome(String _nome) { nome = _nome; }
        public static String getCNPJ() { return cnpj; }
        public static String getNome() { return nome; }
    }
}
