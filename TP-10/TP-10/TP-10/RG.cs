using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RG
{
    public class ClsTitulo
    {
        public static Boolean ValidaTitulo(string titulo)
        {

            titulo = titulo.Trim().Replace(".", "").Replace("-", "").Trim();
            if(titulo.Length > 12)
            {
                return false;
            }
            string numSequencial = titulo.Substring(0, 8);
            string uf = titulo.Substring(8, 2);
            string digVerificadores = titulo.Substring(10, 2);

            bool dv1 = false;
            bool dv2 = false;

            Console.WriteLine($"{numSequencial}{uf}{digVerificadores}");

            int somaProduto = 0;
            
            for(int i = 0; i < 8; i++)
            {
                somaProduto += int.Parse($"{numSequencial[i]}") * (i + 2);
            }

            if (somaProduto % 11 != 10)
            {
                if (somaProduto % 11 == int.Parse($"{digVerificadores[0]}"))
                {
                    dv1 = true;
                }
            }
            else
            {
                if(0 == int.Parse($"{digVerificadores[0]}"))
                {
                    dv1 = true;
                }
            }

            somaProduto = 0;

            for(int i = 0; i < 3; i++)
            {
                somaProduto += int.Parse($"{titulo[i + 8]}") * (i + 7);
            }


            if (somaProduto % 11 != 10)
            {
                if (somaProduto % 11 == int.Parse($"{digVerificadores[1]}"))
                {
                    dv2 = true;
                }
            }
            else if (somaProduto % 11 == 0 && (uf[1] == '1' || uf[1] == '2'))
            {
                if (1 == int.Parse($"{digVerificadores[1]}"))
                {
                    dv2 = true;
                }
            }
            else
            {
                if (0 == int.Parse($"{digVerificadores[1]}"))
                {
                    dv2 = true;
                }
            }

            if(dv1 && dv2)
            {
                return true;
            }
            return false;
        }
    }
}
