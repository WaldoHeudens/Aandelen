using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_8_3
{
    internal class AandelenDAO
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                    "AttachDbFilename=C:\\Users\\Waldo\\source\\repos\\Lessen\\Les_8_3\\Aandelen.mdf;" +
                                    "Integrated Security=True;" +
                                    "Connect Timeout=30";

        public List<Aandeel> Aandelen { get; set; }


        public List<Aandeel> getAlleAandelen ()
        {
            List<Aandeel> aandelen = new List<Aandeel>();

            //// Even een paar dummy aandelen
            //aandelen.Add(new Aandeel() { Id = 1, MijnOmschrijving = "nonsens", Naam = "XX1" });
            //aandelen.Add(new Aandeel() { Id = 2, MijnOmschrijving = "omschrijving 2", Naam = "XX2" });
            //aandelen.Add(new Aandeel() { Id = 3, MijnOmschrijving = "omschrijving 3", Naam = "XX3" });

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT Id, Naam, Omschrijving FROM Aandelen WHERE InGebruik = 1", connection);
            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    aandelen.Add(new Aandeel()
                    {
                        Id = reader.GetInt32(0),
                        Naam = reader.GetString(1),
                        MijnOmschrijving = reader.GetString(2)
                    });

                }
            }


            connection.Close();
            return aandelen;
        }
    }
}
