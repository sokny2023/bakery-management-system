using bakery_management_system.Models;
using bakery_management_system.Utils;
using MySql.Data.MySqlClient;
using System.Data;

namespace bakery_management_system.Services
{
    public class CustomerSerive
    {
        public Customer GetCustomerByPhone(string phone)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT customer_id, customer_name, phone, email, address FROM Customers WHERE phone = @phone LIMIT 1";
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@phone", phone);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Customer
                                {
                                    CustomerId = reader.GetInt32("customer_id"),
                                    Name = reader.GetString("customer_name"),
                                    Phone = reader.GetString("phone"),
                                    Email = reader.IsDBNull("email") ? null : reader.GetString("email"),
                                    Address = reader.IsDBNull("address") ? null : reader.GetString("address")
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error fetching customer by phone: {ex.Message}");
                }
            }

            return null;
        }
    }
}
