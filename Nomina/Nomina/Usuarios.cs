using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina
{
    public class Usuarios
    {
        public static int id, id_tipo;
        public static string usuario, password, conPassword, nombre;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public string ConPassword { get => conPassword; set => conPassword = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }
        public int Id_tipo { get => id_tipo; set => id_tipo = value; }

        
        /*int id_emp;
        string nombreE, apellido, sexo, telefono, direccion, email, depto, puesto;
        //DateTime fechai;
        float salario;
        
        public string Nombree { get => nombreE; set => nombreE = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Email { get => email; set => email = value; }
        public string Depto { get => depto; set => depto = value; }
        //public DateTime Fecha { get => fechai; set => fechai = value; }
        public float Salario { get => salario; set => salario = value; }
        public string Puesto { get => puesto; set => puesto = value; }*/
        


        int id_emp, hrsDiarias, hrsExtra, diasLbrds;
        string fecha;
        decimal ttlDvngdo, slrioDiario, slrioMensual, slrioExtra;


        public int ID { get => id_emp; set => id_emp = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int HrsDiarias { get => hrsDiarias; set => hrsDiarias = value; }
        public decimal TtlDvngdo { get => ttlDvngdo; set => ttlDvngdo = value; }
        public int HrsExtra { get => hrsExtra; set => hrsExtra = value; }
        public decimal SlrioDiario { get => slrioDiario; set => slrioDiario = value; }
        public int DiasLbrds { get => diasLbrds; set => diasLbrds = value; }
        public decimal SlrioMensual { get => slrioMensual; set => slrioMensual = value; }
        public decimal SlrioExtra { get => slrioExtra; set => slrioExtra = value; }



    }

    
}


//Jose Andres Veron Canel