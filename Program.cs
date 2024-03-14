using Delegate_task.Models;

Console.WriteLine("Please enter your license key (basic, pro, expert): ");
string key = Console.ReadLine().ToLower();

DocumentProgram docProgram;

switch (key)
{
    case "basic":
        docProgram = new DocumentProgram();
        break;
    case "pro":
        docProgram = new ProDocumentProgram();
        break;
    case "expert":
        docProgram = new ExpertDocument();
        break;
    default:
        Console.WriteLine("Invalid license key.");
        return;
}

docProgram.OpenDocument();
docProgram.EditDocument();
docProgram.SaveDocument();
    