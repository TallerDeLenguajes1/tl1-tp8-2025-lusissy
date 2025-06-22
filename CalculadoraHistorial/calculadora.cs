namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato;

        public List<Operacion> Operaciones { get; set; } = [];

        
        public Calculadora()
        {
            dato = 0;
        }

        
        public double Resultado
        {
            get
            {
                return dato;
            }
        }

        public void Sumar(double termino)
        {
            var operacion = new Operacion(dato, termino, TipoOperacion.Suma);

            dato = dato + termino;

            Operaciones.Add(operacion);
        }

        public void Restar(double termino)
        {
            var operacion = new Operacion(dato, termino, TipoOperacion.Restar);

            dato = dato - termino;

            Operaciones.Add(operacion);
        }

        public void Multiplicar(double termino)
        {
            var operacion = new Operacion(dato, termino, TipoOperacion.Multiplicar);
            dato = dato * termino;
            Operaciones.Add(operacion);
        }

        public void Dividir(double termino)
        {
            if (termino != 0)
            {
                var operacion = new Operacion(dato, termino, TipoOperacion.Dividir);

                dato = dato / termino;

                Operaciones.Add(operacion);
            }
            else
            {
                dato = -9999;
            }
        }

        public void Limpiar()
        {
            dato = 0;
        }

    }
}

/*
Cree la clase Calculadora que permita encadenar
operaciones sobre un mismo resultado guardado en un atributo llamado dato,
utilizando los siguientes métodos.
● void Sumar(double termino)
● void Restar(double termino)
● void Multiplicar(double termino)
● void Dividir(double termino)
● void Limpiar()
Cree también una propiedad llamada Resultado para obtener el valor del atributo
dato. (Es decir solo defina el get).

*/