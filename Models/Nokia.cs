namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string emei, string modelo, int memoria) : base(numero, emei, modelo, memoria)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"intalando o  {nomeApp} no Nokia ");
        }
    }
}