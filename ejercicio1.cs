using System;

class Program
{
    public static void Main2(string[] args)
    {
        Auto a = new Auto("Toyota", "Corolla", 2020, 4, true);
        Camioneta c = new Camioneta("Ford", "Ranger", 2022, 4, true);
        Moto m = new Moto("Yamaha", "FZ", 2019, "Deportivo");

        a.CambiarMarcha();
        c.CambiarMarcha();
        m.CambiarMarcha();

        a.MostrarInformacion();
        m.MostrarInformacion();
        c.MostrarInformacion();
    }

    class Vehiculo
    {
        public string marca;
        public string modelo;
        public int anio;

        public Vehiculo(string marca, string modelo, int anio)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.anio = anio;
        }

        public void CambiarMarcha()
        {
            Console.WriteLine("la marcha se cambio");
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"la marca: {marca} el modelo: {modelo} el año: {anio}");
        }
    }

    class Auto : Vehiculo
    {
        private int cantidadPuertas;
        public bool esAutomatico;
        public int CantidadPuertas
        {
            get { return cantidadPuertas; }
            set { cantidadPuertas = value; }
        }

        public Auto(string marca, string modelo, int anio, int cant, bool esAutomatico) : base(marca, modelo, anio)
        {
            this.esAutomatico = esAutomatico;
            this.cantidadPuertas = cant;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"la marca: {marca} el modelo: {modelo} el año: {anio} cantidad de puertas: {cantidadPuertas} automatico: {esAutomatico}");
        }
    }

    class Camioneta : Vehiculo
    {
        public int cantidadPuertas;
        public bool es4x4;

        public Camioneta(string marca, string modelo, int anio, int cantidadPuertas, bool es4x4) : base(marca, modelo, anio)
        {
            this.cantidadPuertas = cantidadPuertas;
            this.es4x4 = es4x4;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"la marca: {marca} el modelo: {modelo} el año: {anio} cantidad de puertas: {cantidadPuertas} es 4x4?: {es4x4}");
        }
    }

    class Moto : Vehiculo
    {
        private string tipoManubrio;
        public string TipoManubrio
        {
            get { return tipoManubrio; }
            set { tipoManubrio = value; }
        }

        public Moto(string marca, string modelo, int anio, string tipoManubrio) : base(marca, modelo, anio)
        {
            this.tipoManubrio = tipoManubrio;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"la marca: {marca} el modelo: {modelo} el año: {anio} tipo de manubrio: {tipoManubrio}");
        }
    }
}
