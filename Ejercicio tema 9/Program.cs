using System;

namespace Ejercicio_tema_9
{
    /*Crea una clase Persona con las siguientes variables:

        La edad
        El nombre
        El teléfono

        Una vez creada la clase, crea una nueva clase Cliente que herede de Persona, esta nueva clase tendrá la variable credito solo para esa clase.
        Crea ahora un objeto de la clase Cliente que debe tener como propiedades la edad, el telefono, el nombre y el credito, tienes que darles valor y mostrarlas por pantalla.
        Una vez hecho esto, haz lo mismo con la clase Trabajador que herede de Persona, y con una variable salario que solo tenga la clase Trabajador.
             */
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente
            Console.WriteLine("Cliente ");
            Cliente cliente = new Cliente();
            cliente.setName("Juan Carlos Lopez");
            cliente.setEdad(29);
            cliente.setTelefono(11111222);
            cliente.setCredito(2000000);
            Console.WriteLine("Nombre: "+cliente.getName());
            Console.WriteLine("Edad: "+cliente.getEdad());
            Console.WriteLine("Telefono: "+cliente.getTelefono());
            Console.WriteLine("Credito: "+cliente.getCredito());

            //Trabajador
            Console.WriteLine(" ");
            Console.WriteLine("Trabajador ");
            Trabajador trabajador = new Trabajador();
            trabajador.setName("Pedro Martinez");
            trabajador.setEdad(29);
            trabajador.setTelefono(11111222);
            trabajador.setSalario(6200);
            Console.WriteLine("Nombre: "+trabajador.getName());
            Console.WriteLine("Edad: "+trabajador.getEdad());
            Console.WriteLine("Telefono: "+trabajador.getTelefono());
            Console.WriteLine("Salario"+trabajador.getSalario());
        }

    }

    public class Persona
    {
        int edad;
        String name;
        int telefono;

        public int getEdad()
        {
            return this.edad;
        }

        public String getName()
        {
            return this.name;
        }

        public int getTelefono()
        {
            return this.telefono;
        }

        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void setTelefono(int telefono)
        {
            this.telefono = telefono;
        }
    }


    public class Cliente : Persona
    {
        int credito;
        public int getCredito()
        {
            return this.credito;
        }

        public void setCredito(int credito)
        {
            this.credito = credito;
        }
    }

    public class Trabajador : Persona
    {
        int salario;

        public int getSalario()
        {
            return this.salario;
        }
        public void setSalario(int salario)
        {
            this.salario = salario;
        }
    }

    
}
