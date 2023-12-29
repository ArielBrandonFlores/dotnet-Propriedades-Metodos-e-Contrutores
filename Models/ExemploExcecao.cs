using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_DIO_Propriedades_Métodos_e_Contrutores.Models
{
    public class ExemploExcecao
    {
        public void Metodo1()
        {
            try
            {
                Metodo2();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Exceção tratada: " + ex.Message);
            }
        }
        public void Metodo2()
        {
            Metodo3();
        }

        public void Metodo3()
        {
            Metodo4();
        }
        public void Metodo4()
        {
            throw new Exception("Ocorreu um erro de exceção");
        }

    }



}