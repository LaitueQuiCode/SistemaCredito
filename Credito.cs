namespace SistemaCredito
{
    public class Credito
    {
        private const int minCuotas = 6, maxCuotas = 48;
        private float _interes = 0.03f;
        private readonly int _id; // num crédito
        private readonly Cliente _cliente;
        private float _monto;
        private int _cuotas;

        public Credito(int id, float monto, int cuotas, Cliente cliente)
        {
            _id = id;
            _cliente = cliente;
            Monto = monto;
            Cuotas = cuotas;
        }

        public int Id => _id;
        public float Monto
        {
            get => _monto;
            set {
                if (value <= _cliente.Sueldo * (1 + 1.5f))
                    _monto = value;
            }
        }
        public int Cuotas { get => _cuotas;
            set {
                if (value >= minCuotas && value <= maxCuotas)
                {
                    _interes = 0.03f;
                    _cuotas = value;
                }
                else if (value > maxCuotas)
                {
                    _interes = 0.0185f;
                    _cuotas = value;
                }
            }
        }

        public float ObtenerTotal()
        {
            float total = .0f;
            for (int c = 0; c < Cuotas; c++)
            {
                //https://www.rankia.cl/blog/mejores-creditos-becas-prestamos/3338184-como-calcular-intereses-prestamo-bancario
            }
            return total;
        }
    }
}
