﻿using Institucion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion.Misc
{
  public class TransmisorDeDatos
    {
        public delegate string Formatter(string input);

        public void FormatearYEnviar(IEnteInstituto ente, Formatter localFormatter , string nombre)
        {

            var rawString = $"{ente.CodigoInterno}:{ente.ConstruirLlaveSecreta(nombre)}" ;

            rawString = localFormatter(rawString);

            Enviar(rawString);
        }

        private void Enviar(string rawString)
        {
            Console.WriteLine("Transmitiendo datos:" + rawString);

            if (InformacionEnviada != null)

                InformacionEnviada(this , new EventArgs());
        }

        //eventHandler

        public event EventHandler InformacionEnviada;

        //public string MyFormatter(string input)
        //{

        //}
    }
}
