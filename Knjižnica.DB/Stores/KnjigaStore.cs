using Knjižnica.Abstract.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjižnica.DB.Stores
{
    public class KnjigaStore
    {

        private KnjigaStore _knjigaStore;
        public List<Knjiga> DostupneKnjige(int id_korisnika)
        {
            SqlConnectionFactory connectionManager = new SqlConnectionFactory();
            List<Knjiga> bookList = new List<Knjiga>();

            using (var connection = connectionManager.GetNewConnection())
            {
                if (connection != null)
                {
                    string upit = String.Format("SELECT k.id as Id, k.naslov as Naslov, k.autor as Autor, k.izdavac as Izdavac," +
                        " j.jezik as Jezik, g.naziv as Gradja, c.naziv as Kategorija " +
                        "FROM knjiga k " +
                        "JOIN jezik_izdanja j ON j.id = k.id_jezik " +
                        "JOIN gradja g on g.id = k.id_gradja " +
                        "JOIN kategorija c ON c.id = k.id_kategorija " +
                        "LEFT JOIN rezervacija r ON r.id_knjige = k.id AND r.id_korisnika = @id_korisnika " +
                        "WHERE k.dostupnost = 1 AND r.id_knjige IS NULL;");

                    using (var command = new MySqlCommand(upit, connection))
                    {
                        command.Parameters.AddWithValue("@id_korisnika", id_korisnika);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Knjiga knjiga = new Knjiga()
                                {
                                    ID = reader.GetInt32("Id"),
                                    Naslov = reader.GetString("Naslov"),
                                    Autor = reader.GetString("Autor"),
                                    Izdavac = reader.GetString("Izdavac"),
                                    Jezik = reader.GetString("Jezik"),
                                    Gradja = reader.GetString("Gradja"),
                                    Kategorija = reader.GetString("Kategorija")
                                };

                                bookList.Add(knjiga);
                            }
                        }
                    }
                }
                connectionManager.CloseConnection(connection);
            }
            return bookList;
        }

        public List<Knjiga> SveKnjige()
        {
            {
                SqlConnectionFactory connectionManager = new SqlConnectionFactory();
                List<Knjiga> bookList = new List<Knjiga>();

                using (var connection = connectionManager.GetNewConnection())
                {
                    if (connection != null)
                    {
                        string upit = String.Format("SELECT k.id as Id, k.naslov as Naslov, k.autor as Autor, k.izdavac as Izdavac," +
                            " j.jezik as Jezik, g.naziv as Gradja, c.naziv as Kategorija " +
                            "FROM knjiga k " +
                            "JOIN jezik_izdanja j ON j.id = k.id_jezik " +
                            "JOIN gradja g on g.id = k.id_gradja " +
                            "JOIN kategorija c ON c.id = k.id_kategorija " +
                            "LEFT JOIN rezervacija r ON r.id_knjige = k.id AND r.id_korisnika = @id_korisnika ");

                        using (var command = new MySqlCommand(upit, connection))
                        {
                            using (var reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Knjiga knjiga = new Knjiga()
                                    {
                                        ID = reader.GetInt32("Id"),
                                        Naslov = reader.GetString("Naslov"),
                                        Autor = reader.GetString("Autor"),
                                        Izdavac = reader.GetString("Izdavac"),
                                        Jezik = reader.GetString("Jezik"),
                                        Gradja = reader.GetString("Gradja"),
                                        Kategorija = reader.GetString("Kategorija")
                                    };

                                    bookList.Add(knjiga);
                                }
                            }
                        }
                    }
                    connectionManager.CloseConnection(connection);
                }
                return bookList;
            }
        }

        public void PosudiKnjigu(int id_korisnika, int id_knjige)
        {

            SqlConnectionFactory connectionManager = new SqlConnectionFactory();

            using (var connection = connectionManager.GetNewConnection())
            {
                if (connection != null)
                {
                    var upit = String.Format("INSERT INTO rezervacija (id_knjige,id_korisnika,datum_posudbe, datum_vracanja) " +
                        "VALUES (@id_knjige, @id_korisnika, NOW(), DATE_ADD(NOW(), INTERVAL 7 DAY))");

                    using (var command = new MySqlCommand(upit, connection))
                    {
                        command.Parameters.AddWithValue("@id_korisnika", id_korisnika);
                        command.Parameters.AddWithValue("@id_knjige", id_knjige);
                        command.ExecuteNonQuery();
                    }
                }
                connectionManager.CloseConnection(connection);
            }
        }

        
    }
}

