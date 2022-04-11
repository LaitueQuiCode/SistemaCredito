using SistemaCredito;
namespace InicioPrograma
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Ingrese su rut, sin puntos y con guión.");
                Console.WriteLine("Si su rut termina con K, remplacelo por un 1");
                string[] mantizaYDigito = new string[2];
                mantizaYDigito = Console.ReadLine().Split('-');
                if (mantizaYDigito[0] == null || mantizaYDigito[1] == null)
                {
                    Console.WriteLine(Mensajes.ERROR_RUT);
                    return;
                }
                if (mantizaYDigito[0].Length == 0)
                {
                    Console.WriteLine(Mensajes.ERROR_RUT);
                    return;
                }
                int rut, digito;
                rut = digito = -1;
                int.TryParse(mantizaYDigito[0], out rut);
                int.TryParse(mantizaYDigito[1], out digito);
                Cliente cliente = new Cliente(rut);
                cliente.Sueldo = 500.0f;
                bool resultadoValidacion = cliente.ValidarRut(digito);
                Console.WriteLine(resultadoValidacion ? Mensajes.VAL_RUT : Mensajes.ERROR_RUT);

                Credito credito = new Credito(0, 1000.0f, 12, cliente);
                Console.WriteLine(credito.ObtenerTotal());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }
    }
}
