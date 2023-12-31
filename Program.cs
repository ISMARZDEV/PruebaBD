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

            // Insertar datos en la tabla
            using (SqlCommand insertDataCommand = new SqlCommand(
                "INSERT INTO Empleados (IdEmpleado, Nombre, Apellido, Edad, Cargo) VALUES " +
                "(1, 'Ismael', 'Martinez', 24, 'Jefe' )", connection))
            {
            insertDataCommand.ExecuteNonQuery();
            Console.WriteLine("Datos insertados exitosamente");
            }
        }
    }
}

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