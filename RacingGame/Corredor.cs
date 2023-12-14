using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame
{   
        public class Corredor
        {
            private static readonly Random rnd = new Random();

            private string nome;

            public Corredor()
            {
                Nome = "";
            }

            public Corredor(string nome)
            {
                Nome = nome;
            }

            public string Nome
            {
                get { return nome; }
                set
                {
                    
                    nome = value.ToLower();
                    if (value.Length > 1) nome = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
                    if (value.Length == 0) nome = "Desconhecido";
                }
            }

            public int Correr()
            {
                return rnd.Next(1, 10);
            }
        }
    }
