using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAMC.Objetos
{
    class FormatacoesDeCampos
    {
        public static string FormatCpf(string CPF)
        {
            return Convert.ToUInt64(CPF).ToString(@"000\ 000\ 000\ 00");
        }
        public static string FormatarCnpj(string CPF)
        {
            return Convert.ToUInt64(CPF).ToString(@"00\ 000\ 000\ 0000 \ 00");
        }
        public static string Maiusculo(string texto)
        {
            return texto.ToUpper();
        }
        public static string FormatTel(string tel)
        {
            string telefoneFormatado="";

            switch (tel.Length)
            {
                case 8:
                    if(tel.Substring(0,1) == "3" || tel.Substring(0, 1) == "3" || tel.Substring(0, 1) == "3")
                    {
                        telefoneFormatado = Convert.ToUInt64(tel).ToString(@"31\ 0000\ 0000");
                    }
                    else
                    {
                        telefoneFormatado = Convert.ToUInt64(tel).ToString(@"31\ \90000\ 0000");
                    }
                   
                    break;
                case 9:
                    telefoneFormatado = Convert.ToUInt64(tel).ToString(@"31\ 0000\ 0000");
                    break;
                case 10:
                telefoneFormatado= Convert.ToUInt64(tel).ToString(@"00\ 0000\ 0000");
                    break;

                case 11:
                    telefoneFormatado = Convert.ToUInt64(tel).ToString(@"00\ 0000\ 0000");
                    break;
            }

            return telefoneFormatado;
        }
    }
}