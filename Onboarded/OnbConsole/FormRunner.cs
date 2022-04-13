using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnbConsole
{
    class FormRunner
    {

        public CnhForm ExtractForm(string filepath)
        {
            var x = new CnhForm();

            x.Name = "Daniel";
            x.Cpf = "12312312";

            return x;
        }

        public void ValidateCnh(CnhForm x)
        {
            if (x.Cpf == "23422123-7")
            {
                SaveCnhDatabase();
                SaveCnhStorage();
                Console.WriteLine("CNH validada e registrada com sucesso!");
            }
                
            else
            {
                Console.WriteLine("CNH não é valida, repita o processo");
            }
                
        }

        public void SaveCnhStorage()
        {
            Console.WriteLine("salvo no cosmos");
        }

        public void SaveCnhDatabase()
        {
            Console.WriteLine("salvo no storage");
        }

    }
}
