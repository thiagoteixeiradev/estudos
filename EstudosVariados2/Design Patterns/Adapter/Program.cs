using Adapter.Adapter;
using Adapter.Lib;

Console.WriteLine("Informe o arquvido de mídia que deseja executar: ");
string file = Console.ReadLine();

var file_Parte = file.Split(".");


//Solução sem o adapter
/*
switch (file_Parte[1])
{
    case "mp3":
        {
            Mp3Player mp3 = new (file);
            mp3.Run();
            break;
        }
    case "mp4":
        {
            Mp4Player.Executar(file);
            break;
        }
    default:
        {
            Console.WriteLine("Arquivo de mídia incompatível.");
            break;
        }
}
*/

//Solução com o adapter

IPlayer player;
switch (file_Parte[1])
{
    case "mp3":
        {
         player = new Mp3PlayerAdapter();
            player.Play(file);
            break;
        }
    case "mp4":
        {
            player = new Mp4PlayerAdapter();
            player.Play(file);
            break;
        }
    default:
        {
            Console.WriteLine("Arquivo de mídia incompatível.");
            break;
        }
    }
