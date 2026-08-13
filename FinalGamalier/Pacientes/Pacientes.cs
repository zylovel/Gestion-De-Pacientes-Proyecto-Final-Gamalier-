using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalGamalier.NewFolder.Pacientes
{
    public class Pacientes
    {
        public enum Sexo
        {
            Masculino,
            Femenino
        }
        public enum EstadoPaciente
        {
            Ingresado,
            EnObservacion,
            DeAlta,
            Hospitalizado
        }
        public class Paciente
        {
            public string Id { get; set; }
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public Sexo Sexo { get; set; }
            public string Diagnostico { get; set; }
            public EstadoPaciente Estado { get; set; }
            public DateTime FechaIngreso { get; set; }
            public Paciente() { FechaIngreso = DateAndTime.Now; }
            public override string ToString()
            {
                return $"{Id} - {Nombre} ({Edad}Años)";
            }
        }
    }
}
