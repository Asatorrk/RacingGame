using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame
{
    public class Pista
    {

        
        public Pista(int tamanho,Corredor atleta)
        {
			Tamanho = tamanho;
			Atleta = atleta;
			posAtleta = 0;
			
        }
        public int Tamanho { get; set; }

		private int posAtleta;

		public int PosAtleta
		{
			get { return posAtleta; }
			//set { posAtleta = value; }
		}

        public Corredor Atleta { get; set; }

		

		public Boolean AtualizarCorrida()
		{
            Boolean ganhou = false;
            if (posAtleta < Tamanho)
            {
                posAtleta += Atleta.Correr();
            }
            if (posAtleta >= Tamanho)
            {
                ganhou = true;
                posAtleta = Tamanho;
            }
            return ganhou;
		}


		public void ExibirPista()
		{
            //Monta a imagem do corredor na pista no pos atual 
           String pista = "";
           String corredorPista = "";
            for (int i = 1; i <= Tamanho; i++)
            {
                pista += "_";
                if (i == posAtleta)
                {
                    corredorPista += Atleta.Nome;
                }
                else
                {
                    corredorPista += " ";
                }
            }

            //exibir pista e corredor

            Console.WriteLine(corredorPista);
            Console.WriteLine(pista);
        }
    }
}
