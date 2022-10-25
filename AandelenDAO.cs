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
        public List<int> deletedIds = new List<int>();



        public List<Aandeel> getAlleAandelen ()
        {
            List<Aandeel> aandelen = new List<Aandeel>();


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

        internal void setAllAandelen()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            
            foreach (Aandeel aandeel in Aandelen)
            {
                if (aandeel.werdToegevoegd())
                {
                    SqlCommand command = new SqlCommand("INSERT INTO Aandelen (Id, Naam, Omschrijving) VALUES ('" 
                                        + aandeel.Id 
                                        + "','" 
                                        + aandeel.Naam 
                                        + "','" 
                                        + aandeel.MijnOmschrijving 
                                        + "')", connection);
                    command.ExecuteNonQuery();
      
                    aandeel.Toevoegen(false);
                }
                if (aandeel.isGewijzigd)
                {
                    SqlCommand command = new SqlCommand("UPDATE Aandelen SET Naam = '"
                                            + aandeel.Naam 
                                            + "',Omschrijving = '" 
                                            + aandeel.MijnOmschrijving
                                            + "' WHERE Id = "
                                            + aandeel.Id,
                                            connection);
                    command.ExecuteNonQuery();

                    aandeel.isGewijzigd = false;

                }
            }

            foreach (int aandeelId in deletedIds)
            {
                SqlCommand command = new SqlCommand("DELETE FROM Aandelen WHERE ID = "
                                        + aandeelId,
                                        connection);
                command.ExecuteNonQuery();
            }

            deletedIds.Clear();

            connection.Close();
        }
    }
}
