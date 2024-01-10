namespace DesafioPOO.Models
{
    public class Nokia : Smartphone {
         public override void InstalarAplicativo( string NomeApp) {
             Console.WriteLine($"Instalando o aplicativo {NomeApp} no Nokia.");
        }
    }
}