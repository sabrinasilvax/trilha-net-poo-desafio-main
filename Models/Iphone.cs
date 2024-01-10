namespace DesafioPOO.Models
{
    public class Iphone : Smartphone {
        public override void InstalarAplicativo( string NomeApp) {
             Console.WriteLine($"Instalando o aplicativo {NomeApp} no iPhone.");
        }
    }
}