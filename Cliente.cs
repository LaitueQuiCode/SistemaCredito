namespace SistemaCredito
{
    internal class Cliente
    {
        private readonly int _rut;
        private string _primerNombre, _primerApellido, _segundoApellido;
        private int _telefono;
        private string _direccionParticular, _direccionLaboral;
        private double _sueldo;

        public Cliente(int rut)
        {
            // validar.. previamente
            _rut = rut;
            _primerNombre = "Sin nombre.";
            _primerApellido = "Sin Apellido.";
            _segundoApellido = "Sin apellido.";
            _telefono = 0;
            _direccionParticular = "Sin dirección particular.";
            _direccionLaboral = "Sin dirección laboral.";
            _sueldo = 0.0;
        }

        public Cliente(int rut,
                       string primerNombre, string primerApellido, string segundoApellido, 
                       int telefono, 
                       string direccionParticular, string direccionLaboral,
                       double sueldo) : this(rut)
        {
            PrimerNombre = primerNombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Telefono = telefono;
            DireccionParticular = direccionParticular;
            DireccionLaboral = direccionLaboral;
            Sueldo = sueldo;
        }

        // Encapsulamiento
        public int Rut { get => _rut; }
        public string PrimerNombre { get => _primerNombre; set => _primerNombre = value; }
        public string PrimerApellido { get => _primerApellido; set => _primerApellido = value; }
        public string SegundoApellido { get => _segundoApellido; set => _segundoApellido = value; }
        public int Telefono { get => _telefono; set => _telefono = value; }
        public string DireccionParticular { get => _direccionParticular; set => _direccionParticular = value; }
        public string DireccionLaboral { get => _direccionLaboral; set => _direccionLaboral = value; }
        public double Sueldo { get => _sueldo; set => _sueldo = value; }

        // Customers
        public bool ValidarRut(out int digito)
        {
            string strRut = _rut.ToString();
            for (int indice = strRut.Length-1 ; indice >= 0 ; indice--)
            {

            }

            digito = -1;
            return false;
        }
    }
}
