using System;
using System.Data.SqlClient;


class Program
{
    static void Main()
    {
        string connectionString = "Server=localhost; Database=BDProject; User Id=sa; Password=20186947Ismael";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {

            connection.Open();
            Console.WriteLine("Conexión exitosa");

            string Salir = "N", tipodocumento, documento, nombres, apellidos, sexo, fechanacimiento, nota;

            while (Salir == "N")
            {
            Console.Write("Tipo Documento: ");
            tipodocumento = Console.ReadLine();
            Console.Write("Documento: ");
            documento = Console.ReadLine();
            Console.Write("Nombres: ");
            nombres = Console.ReadLine();
            Console.Write("Apellidos: ");
            apellidos = Console.ReadLine();
            Console.Write("Sexo: ");
            sexo = Console.ReadLine();
            Console.Write("Fecha Nacimiento: ");
            fechanacimiento = Console.ReadLine();
            Console.Write("Nota: ");
            nota = Console.ReadLine();
            
            // Insertar datos en la tabla
            using (SqlCommand insertDataCommand = new SqlCommand(
                $"INSERT INTO TuTablaBD (tipodocumento, documento, nombres, apellidos, sexo, fechanacimiento, nota) VALUES " +
                $"({tipodocumento}, {documento}, '{nombres}', '{apellidos}', '{sexo}', '{fechanacimiento}', '{nota}')", connection))
            {
                insertDataCommand.ExecuteNonQuery();
                Console.WriteLine("Datos insertados exitosamente");
                Console.WriteLine("Y/N");
                Salir = Console.ReadLine();
            }
            }
        }
    }
}

/*
CREATE TABLE [dbo].[TuTablaBD] (
    [id]              INT           IDENTITY (1, 1) NOT NULL,
    [tipodocumento]   INT           NULL,
    [documento]       INT           NULL,
    [nombres]         VARCHAR (100) NULL,
    [apellidos]       VARCHAR (100) NULL,
    [sexo]            VARCHAR (10)  NULL,
    [fechanacimiento] DATE          NULL,
    [nota]            VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);
*/

/* try
            {
                connection.Open();
                Console.WriteLine("Conexión exitosa");

                // // Insertar datos en la tabla
                 using (SqlCommand insertDataCommand = new SqlCommand(
                     "INSERT INTO Empleados (IdEmpleado, Nombre, Apellido, Edad, Cargo) VALUES " +
                     "(1, 'Ismael', 'Martinez', 24, 'Jefe' )", connection))
                  {
                    insertDataCommand.ExecuteNonQuery();
                    Console.WriteLine("Datos insertados exitosamente");
                  }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al conectar: {ex.Message}");
            }
*/