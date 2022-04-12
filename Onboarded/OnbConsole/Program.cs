// See https://aka.ms/new-console-template for more information
using OnbConsole;

Console.WriteLine("Onboarded App");

var x = ExtractForm();
var validCnh = ValidateCnh(x);

if (validCnh == true)
{
    SaveCnhDatabase();
    SaveCnhStorage();
    Console.WriteLine("CNH validada e processo de onboard realizado com sucesso!");
}
else if (validCnh == false)
{
    Console.WriteLine("CNH não é valida, repita o processo");
}


CnhForm ExtractForm()
{
    var cnhForm = new CnhForm
    {
        Name  = "Daniel",
        IdCnh = "12223424",
        Cpf   = "23422123-8"       
    };

    return cnhForm;
}

Boolean ValidateCnh(CnhForm x)
{
    if (x.Cpf == "23422123-7")
    return true;
    else
    return false;
}

void SaveCnhStorage()
{
    Console.WriteLine("salvo no cosmos");
}

void SaveCnhDatabase()
{
    Console.WriteLine("salvo no storage");
}

