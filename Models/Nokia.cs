namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.Write($"Instalando aplicativo ");
            Console.Write('"');
            Console.Write(nomeApp);
            Console.Write('"');
            Console.Write(" no Nokia");
        }
    }
}