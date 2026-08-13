using System;
using System.Collections.Generic;
using System.Linq;
using static ProyectoFinalGamalier.NewFolder.Pacientes.Pacientes;

namespace ProyectoFinalGamalier.NewFolder
{
    public class GestorPacientes
    {
        private List<Paciente> listaPacientes = new List<Paciente>();

        public List<Paciente> Pacientes
        {
            get { return listaPacientes; }
        }

        // Método para validar los datos antes de guardar
        private bool ValidarPaciente(Paciente p)
        {
            try
            {
                if (p == null)
                {
                    Console.WriteLine("Error: el paciente esta vacio.");
                    return false;
                }
                if (string.IsNullOrWhiteSpace(p.Id))
                {
                    Console.WriteLine("Error: el ID del paciente es obligatorio.");
                    return false;
                }
                if (string.IsNullOrWhiteSpace(p.Nombre))
                {
                    Console.WriteLine("Error: el nombre del paciente es obligatorio.");
                    return false;
                }
                if (p.Edad <= 0 || p.Edad > 150)
                {
                    Console.WriteLine("Error: la edad debe ser un numero valido.");
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error validando el paciente: " + ex.Message);
                return false;
            }
        }

        // Crear (Agregar)
        public void AgregarPaciente(Paciente nuevo)
        {
            try
            {
                if (!ValidarPaciente(nuevo))
                {
                    return;
                }

                bool existe = listaPacientes.Any(x => x.Id.ToLower() == nuevo.Id.ToLower());
                if (existe)
                {
                    Console.WriteLine("Ya existe un paciente con ese ID.");
                    return;
                }

                listaPacientes.Add(nuevo);
                Console.WriteLine("Paciente agregado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar paciente: " + ex.Message);
            }
        }

        // Leer: obtener todos los pacientes
        public List<Paciente> ObtenerTodos()
        {
            try
            {
                return new List<Paciente>(listaPacientes);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener pacientes: " + ex.Message);
                return new List<Paciente>();
            }
        }

        // Buscar por ID
        public Paciente BuscarPorId(string id)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(id))
                {
                    Console.WriteLine("Debes escribir un ID para buscar.");
                    return null;
                }

                Paciente encontrado = listaPacientes.FirstOrDefault(x => x.Id.ToLower() == id.ToLower());

                if (encontrado == null)
                {
                    Console.WriteLine("No se encontro ningun paciente con ese ID.");
                }

                return encontrado;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar paciente: " + ex.Message);
                return null;
            }
        }

        // Buscar por nombre
        public List<Paciente> BuscarPorNombre(string nombre)
        {
            try
            {
                List<Paciente> resultado = new List<Paciente>();

                if (string.IsNullOrWhiteSpace(nombre))
                {
                    return resultado;
                }

                foreach (Paciente p in listaPacientes)
                {
                    if (p.Nombre != null && p.Nombre.ToLower().Contains(nombre.ToLower()))
                    {
                        resultado.Add(p);
                    }
                }

                return resultado;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar por nombre: " + ex.Message);
                return new List<Paciente>();
            }
        }

        // Actualizar paciente
        public void ActualizarPaciente(Paciente actualizado)
        {
            try
            {
                if (!ValidarPaciente(actualizado))
                {
                    return;
                }

                int indice = listaPacientes.FindIndex(x => x.Id.ToLower() == actualizado.Id.ToLower());

                if (indice < 0)
                {
                    Console.WriteLine("No se encontro el paciente para actualizar.");
                    return;
                }

                listaPacientes[indice] = actualizado;
                Console.WriteLine("Paciente actualizado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar paciente: " + ex.Message);
            }
        }

        // Eliminar paciente por ID
        public void EliminarPaciente(string id)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(id))
                {
                    Console.WriteLine("Debes escribir un ID para eliminar.");
                    return;
                }

                Paciente p = listaPacientes.FirstOrDefault(x => x.Id.ToLower() == id.ToLower());

                if (p == null)
                {
                    Console.WriteLine("No se encontro el paciente para eliminar.");
                    return;
                }

                listaPacientes.Remove(p);
                Console.WriteLine("Paciente eliminado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar paciente: " + ex.Message);
            }
        }

        // Limpiar lista
        public void Limpiar()
        {
            try
            {
                listaPacientes.Clear();
                Console.WriteLine("Lista de pacientes limpiada.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al limpiar la lista: " + ex.Message);
            }
        }
    }
}