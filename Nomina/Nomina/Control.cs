using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Nomina
{
    class Control
    {
        public string ctrlRegistro(Usuarios usuario)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if(string.IsNullOrEmpty(usuario.Usuario) || string.IsNullOrEmpty(usuario.Password) || string.IsNullOrEmpty(usuario.ConPassword)|| string.IsNullOrEmpty(usuario.Nombre))
            {
                respuesta = "Llene todos los campos para continuar";
            }else
            {
                if(usuario.Password == usuario.ConPassword)
                {
                    if (modelo.existeUsuario(usuario.Usuario))
                    {
                        respuesta = "El usuario ya existe";
                    }else
                    {
                        usuario.Password = generarSHA1(usuario.Password);
                        usuario.Id_tipo = 2;
                        modelo.registro(usuario);
                    }
                }else
                {
                    respuesta = "Las contraseñas no coinciden";
                }
            }
            return respuesta;
        }

        public string ctrlLogin(string usuario, string password)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            Usuarios datosUsuario = null;


            if(string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                respuesta = "Llene todos los campos para continuar";
            }else
            {
                datosUsuario = modelo.porUsuario(usuario);


                if(datosUsuario == null)
                {
                    respuesta = "No existe el usuario";
                }
                else
                {
                    if (datosUsuario.Password != generarSHA1(password))
                    {
                        respuesta = "Usuario o Contraseña no coinciden";
                    }
                }
            }
            return respuesta;
        }

        
        private string generarSHA1(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {

                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }

            return sb.ToString();
        }
    }
}

//José Andrés Verón Canel 