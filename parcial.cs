using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace colaParcial{
    class Parcial {
        class Nodo {
            public string nombre;
            public string apellido;
            public int identificacion;
            public double horasTrabajadas;
            public double horasExtra;
            public Nodo sig;
        }
        private Nodo raiz,fondo;
        public Parcial() {
            raiz=null;
            fondo=null;
        }
        
        public bool Vacia () {
            if (raiz == null)
            return true;
            else
            return false;
        }

        public void InsertarInfo (string nombre, string apellido, int identificacion, double horasTrabajadas, double horasExtra) {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.nombre = nombre;
            nuevo.apellido = apellido;
            nuevo.identificacion = identificacion;
            nuevo.horasTrabajadas = horasTrabajadas;
            nuevo.horasExtra = horasExtra;
            nuevo.sig = null;

            if (Vacia ()){
                    raiz = nuevo;
                    fondo = nuevo;
            } else {
                    fondo.sig = nuevo;
                    fondo = nuevo;
            }
        }
        public void Imprimir() {
            Nodo inf = raiz;
            Console.WriteLine("\nListado de trabajadores de la empresa: \n");
            while (inf!=null) {
                Console.WriteLine("Nombre: " + inf.nombre+"\n" + 
                                "Apellido: " + inf.apellido+"\n"+
                                "Identificación: " + inf.identificacion+"\n"+
                                "Horas trabajadas durante el mes: " + inf.horasTrabajadas + " horas \n"+
                                "Horas extra trabajadas: " + inf.horasExtra + " horas ");
                Console.WriteLine("---------------------------------------");
                inf = inf.sig;
            }
            Console.WriteLine();
        }
        double salarioMensual;
        public void salario(){
            Nodo sal = raiz;
            Console.WriteLine("Salario de los trabajadores: \n");
            while(sal != null){
                salarioMensual = sal.horasTrabajadas * 3657;
                Console.WriteLine("Salario de " + sal.nombre + " es: " + salarioMensual);
                Console.WriteLine("---------------------------------------");
                sal = sal.sig;
            }
        }
        double salarioExtra;
        public void pagoExtra(){
            Nodo ext = raiz;
            Console.WriteLine("\nPago de horas extra: \n");
            while(ext != null){
                salarioExtra = ext.horasExtra * 7316;
                Console.WriteLine("El pago extra de " + ext.nombre + " es: " + salarioExtra);
                Console.WriteLine("---------------------------------------");
                ext = ext.sig;                
            }

        }
        static void Main(string[] args) {
            Parcial colaEmpresa=new Parcial();
            colaEmpresa.InsertarInfo("Juan", "Perez", 57496, 180, 7);
            colaEmpresa.InsertarInfo("Maria", "Daseira", 60716, 175, 10);
            colaEmpresa.InsertarInfo("Oscar", "Herrera", 27072, 109, 0);
            colaEmpresa.Imprimir();
            colaEmpresa.salario();
            colaEmpresa.pagoExtra();
        }
    }
}
// C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe parcial.cs