using Knjižnica.Abstract.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjižnica.DB.Stores
{
    public class KnjigaStore
    {

        private KnjigaStore _knjigaStore;
        public List<Knjiga> GetDostupneKnjige(int id_korisnika)
        {
            SqlConnectionFactory connectionManager = new SqlConnectionFactory();
            List<Knjiga> bookList = new List<Knjiga>();

            using (var connection = connectionManager.GetNewConnection())
            {
                if (connection != null)
                {
                    string upit = String.Format("SELECT k.id as Id, k.naslov as Naslov, k.autor as Autor, k.izdavac as Izdavac," +
                        " j.jezik as Jezik, g.naziv as Gradja, c.naziv as Kategorija, k.kolicina as Kolicina " +
                        "FROM knjiga k " +
                        "JOIN jezik_izdanja j ON j.id = k.id_jezik " +
                        "JOIN gradja g on g.id = k.id_gradja " +
                        "JOIN kategorija c ON c.id = k.id_kategorija " +
                        "LEFT JOIN rezervacija r ON r.id_knjige = k.id AND r.id_korisnika = @id_korisnika " +
                        "WHERE k.dostupnost = 1 AND (r.id_knjige IS NULL OR r.id_status = 2);");

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
                                    Kategorija = reader.GetString("Kategorija"),
                                    Kolicina = reader.GetInt32("Kolicina")
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
        public List<Knjiga> GetSveKnjige()
        {
                SqlConnectionFactory connectionManager = new SqlConnectionFactory();
                List<Knjiga> bookList = new List<Knjiga>();

                using (var connection = connectionManager.GetNewConnection())
                {
                    if (connection != null)
                    {
                        string upit = String.Format("SELECT k.*," +
                            " j.jezik as Jezik, g.naziv as Gradja, c.naziv as Kategorija " +
                            "FROM knjiga k " +
                            "JOIN jezik_izdanja j ON j.id = k.id_jezik " +
                            "JOIN gradja g on g.id = k.id_gradja " +
                            "JOIN kategorija c ON c.id = k.id_kategorija");

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
                                        Mjesto_izdavanja = reader.GetString("Mjesto_izdavanja"),
                                        Izdavac = reader.GetString("Izdavac"),
                                        Jezik = reader.GetString("Jezik"),
                                        Gradja = reader.GetString("Gradja"),
                                        Kategorija = reader.GetString("Kategorija"),
                                        Kolicina = reader.GetInt32("Kolicina"),
                                        Dostupnost = reader.GetBoolean("Dostupnost")
                                    };

                                    bookList.Add(knjiga);
                                }
                            }
                        }
                    }
                    connectionManager.CloseConnection(connection);
                }
                return bookList.OrderBy(knjiga => knjiga.ID).ToList();
        }

        public void PosudiKnjigu(int id_korisnika, int id_knjiga)
        {

            SqlConnectionFactory connectionManager = new SqlConnectionFactory();
            using (var connection = connectionManager.GetNewConnection())
            {
                if (connection != null)
                {
                    string upit_kolicina = String.Format("UPDATE knjiga " +
                        "SET Kolicina = Kolicina - 1 " +
                        "WHERE id = @id_knjiga;");

                    using (var command = new MySqlCommand(upit_kolicina, connection))
                    {
                        command.Parameters.AddWithValue("@id_knjiga", id_knjiga);
                        command.ExecuteNonQuery();
                    }

                    string upit_dostupnost = String.Format("UPDATE knjiga " +
                        "SET dostupnost = CASE " +
                        "WHEN Kolicina = 0 THEN 0 " +
                        "ELSE dostupnost " +
                        "END " +
                        "WHERE id = @id_knjiga;");

                    using (var command = new MySqlCommand(upit_dostupnost, connection))
                    {
                        command.Parameters.AddWithValue("@id_knjiga", id_knjiga);
                        command.ExecuteNonQuery();
                    }

                    string upit_rezervacija = String.Format("INSERT INTO rezervacija (id_knjige,id_korisnika,datum_posudbe, datum_vracanja) " +
                        "VALUES (@id_knjige, @id_korisnika, NOW(), DATE_ADD(NOW(), INTERVAL 7 DAY))");

                    using (var command = new MySqlCommand(upit_rezervacija, connection))
                    {
                        command.Parameters.AddWithValue("@id_korisnika", id_korisnika);
                        command.Parameters.AddWithValue("@id_knjige", id_knjiga);
                        command.ExecuteNonQuery();
                    }

                }
                connectionManager.CloseConnection(connection);
            }
        }

        public void VratiKnjigu(int id_knjige, int id_korisnika)
        {
            var connectionManager = new SqlConnectionFactory();
            using (var connection = connectionManager.GetNewConnection())
            {
                if (connection != null)
                {
                    string upit_kolicina = String.Format("UPDATE knjiga " +
                        "SET Kolicina = Kolicina + 1 " +
                        "WHERE id = @id_knjige;");

                    using (var command = new MySqlCommand(upit_kolicina, connection))
                    {
                        command.Parameters.AddWithValue("@id_knjige", id_knjige);
                        command.ExecuteNonQuery();
                    }

                    string upit_status = String.Format("UPDATE rezervacija r " +
                        "SET r.id_status = (SELECT s.id FROM status_rezervacije s WHERE s.naziv = 'Vraceno') " +
                        "WHERE r.id_knjige = @id_knjige AND r.id_korisnika = @id_korisnika;");

                    using (var command = new MySqlCommand(upit_status, connection))
                    {
                        command.Parameters.AddWithValue("@id_knjige", id_knjige);
                        command.Parameters.AddWithValue("@id_korisnika", id_korisnika);
                        command.ExecuteNonQuery();
                    }

                }
                connectionManager.CloseConnection(connection);
            }
        }

        public List<Jezik_izdanja> GetJezik()
        {
            SqlConnectionFactory connectionManager = new SqlConnectionFactory();
            List<Jezik_izdanja> lista_jezika = new List<Jezik_izdanja>();

            using (var connection = connectionManager.GetNewConnection())
            {
                if (connection != null)
                {
                    string upit = String.Format("SELECT * FROM jezik_izdanja");

                    using (var command = new MySqlCommand(upit, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Jezik_izdanja jezik = new Jezik_izdanja()
                                {
                                    ID = reader.GetInt32("ID"),
                                    Jezik = reader.GetString("Jezik")
                                };
                                

                                lista_jezika.Add(jezik);
                            }
                        }
                    }
                }
                connectionManager.CloseConnection(connection);
            }
            return lista_jezika;
        }
        public List<Kategorija> GetKategorija()
        {
            SqlConnectionFactory connectionManager = new SqlConnectionFactory();
            List<Kategorija> lista_kateg = new List<Kategorija>();

            using (var connection = connectionManager.GetNewConnection())
            {
                if (connection != null)
                {
                    string upit = String.Format("SELECT * FROM kategorija");

                    using (var command = new MySqlCommand(upit, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Kategorija kategorija = new Kategorija
                                {
                                    ID = reader.GetInt32("ID"),
                                    Naziv = reader.GetString("Naziv")
                                };

                                lista_kateg.Add(kategorija);
                            }
                        }
                    }
                }
                connectionManager.CloseConnection(connection);
            }

            return lista_kateg;
        }
        public List<Gradja> GetGradja()
        {
            SqlConnectionFactory connectionManager = new SqlConnectionFactory();
            List<Gradja> lista_gradje = new List<Gradja>();

            using (var connection = connectionManager.GetNewConnection())
            {
                if (connection != null)
                {
                    string upit = String.Format("SELECT * FROM gradja");

                    using (var command = new MySqlCommand(upit, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Gradja gradja = new Gradja()
                                {
                                    ID = reader.GetInt32("ID"),
                                    Naziv = reader.GetString("Naziv")
                                };

                                lista_gradje.Add(gradja);
                            }
                        }
                    }
                }
                connectionManager.CloseConnection(connection);
            }

            return lista_gradje;
        }


        public void AzurirajGradju(Knjiga knjiga)
        {
            var connectionManager = new SqlConnectionFactory();

            using (var connection = connectionManager.GetNewConnection())
            {
                if (connection != null)
                {
                    string upit = "UPDATE knjiga SET Naslov = @Naslov," +
                        " Autor = @Autor," +
                        " Mjesto_izdavanja = @Mjesto_izdavanja," +
                        " Izdavac = @Izdavac," +
                        " ID_jezik = @ID_jezik," +
                        " ID_gradja = @ID_gradja," +
                        " ID_kategorija = @ID_kategorija," +
                        " Kolicina = @Kolicina," +
                        " Dostupnost = @Dostupnost" +
                        " WHERE ID = @Id";

                    using (var command = new MySqlCommand(upit, connection))
                    {
                        command.Parameters.AddWithValue("@Id", knjiga.ID);
                        command.Parameters.AddWithValue("@Naslov", knjiga.Naslov);
                        command.Parameters.AddWithValue("@Autor", knjiga.Autor);
                        command.Parameters.AddWithValue("@Mjesto_izdavanja", knjiga.Mjesto_izdavanja);
                        command.Parameters.AddWithValue("@Izdavac", knjiga.Izdavac);
                        command.Parameters.AddWithValue("@ID_jezik", knjiga.Jezik);
                        command.Parameters.AddWithValue("@ID_gradja", knjiga.Gradja);
                        command.Parameters.AddWithValue("@ID_kategorija", knjiga.Kategorija);
                        command.Parameters.AddWithValue("@Kolicina", knjiga.Kolicina);
                        command.Parameters.AddWithValue("@Dostupnost", knjiga.Dostupnost);

                        command.ExecuteNonQuery();
                    }

                    connectionManager.CloseConnection(connection);
                }
            }
        }
        public void DodajGradju(Knjiga knjiga) {
            var connectionManager = new SqlConnectionFactory();

            using (var connection = connectionManager.GetNewConnection())
            {
                if (connection != null)
                {
                    string upit = "INSERT INTO knjiga(Naslov, Autor, Mjesto_izdavanja, Izdavac, ID_jezik, ID_gradja, ID_kategorija, Kolicina, Dostupnost) " +
                                  "VALUES(@Naslov, @Autor, @Mjesto_izdavanja, @Izdavac, @ID_jezik, @ID_gradja, @ID_kategorija, @Kolicina, @Dostupnost )";

                    using (var command = new MySqlCommand(upit, connection))
                    {
                        command.Parameters.AddWithValue("@Id", knjiga.ID);
                        command.Parameters.AddWithValue("@Naslov", knjiga.Naslov);
                        command.Parameters.AddWithValue("@Autor", knjiga.Autor);
                        command.Parameters.AddWithValue("@Mjesto_izdavanja", knjiga.Mjesto_izdavanja);
                        command.Parameters.AddWithValue("@Izdavac", knjiga.Izdavac);
                        command.Parameters.AddWithValue("@ID_jezik", knjiga.Jezik);
                        command.Parameters.AddWithValue("@ID_gradja", knjiga.Gradja);
                        command.Parameters.AddWithValue("@ID_kategorija", knjiga.Kategorija);
                        command.Parameters.AddWithValue("@Kolicina", knjiga.Kolicina);
                        command.Parameters.AddWithValue("@Dostupnost", knjiga.Dostupnost);

                        command.ExecuteNonQuery();
                    }

                    connectionManager.CloseConnection(connection);
                }
            }
        }
        public void ObrisiGradju(int id_knjige) {
            var connectionManager = new SqlConnectionFactory();
            using (var connection = connectionManager.GetNewConnection())
            {
                if (connection != null)
                {
                    string upit = "DELETE FROM knjiga WHERE ID = @Id";

                    using (var command = new MySqlCommand(upit, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id_knjige);
                        command.ExecuteNonQuery();
                    }

                    connectionManager.CloseConnection(connection);
                }
            }
        }


        public List<Rezervacija> GetRezervacija(int id_korisnika) {

            SqlConnectionFactory connectionManager = new SqlConnectionFactory();
            List<Rezervacija> rezervacija_list = new List<Rezervacija>();

            using (var connection = connectionManager.GetNewConnection())
            {
                if (connection != null)
                {
                    string upit = String.Format("SELECT r.id AS ID, b.id AS ID_knjige, b.naslov AS Naslov, b.autor AS Autor," +
                        " r.datum_posudbe AS Datum_posudbe, r.datum_vracanja AS Datum_vracanja, s.naziv AS Status FROM knjiga b " +
                        "JOIN rezervacija r ON b.id = r.id_knjige AND r.id_korisnika = @id_korisnika " +
                        "JOIN status_rezervacije s ON s.id= r.id_status;");
                    using (var command = new MySqlCommand(upit, connection))
                    {
                        command.Parameters.AddWithValue("@id_korisnika", id_korisnika);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Rezervacija rezervacija = new Rezervacija()
                                {
                                    ID = reader.GetInt32("ID"),
                                    ID_knjige = reader.GetInt32("ID_knjige"),
                                    Naslov = reader.GetString("Naslov"),
                                    Autor = reader.GetString("Autor"),
                                    Datum_posudbe = reader.GetDateTime("Datum_posudbe"),
                                    Datum_vracanja = reader.GetDateTime("Datum_vracanja"),
                                    Status = reader.GetString("Status")
                                };
                                rezervacija_list.Add(rezervacija);
                            }
                        }
                    }
                    connectionManager.CloseConnection(connection);
                }
            }
            return rezervacija_list;
        }

        public List<Rezervacija> GetEvidencijaZaduzenja() 
        {
            SqlConnectionFactory connectionManager = new SqlConnectionFactory();
            List <Rezervacija> evidencijaList = new List <Rezervacija>();
            using (var connection = connectionManager.GetNewConnection()) 
            {
                if (connection != null)
                {
                    string upit = String.Format("SELECT r.id AS ID, b.id AS ID_knjige,r.id_korisnika AS ID_korisnika,k.ime AS Ime, k.prezime AS Prezime," +
                        " b.naslov AS Naslov, b.autor AS Autor," +
                        " r.datum_posudbe AS Datum_posudbe, r.datum_vracanja AS Datum_vracanja, s.naziv AS Status FROM knjiga b " +
                        "JOIN rezervacija r ON b.id = r.id_knjige " +
                        "JOIN status_rezervacije s ON s.id= r.id_status " +
                        "JOIN korisnik k ON k.id = r.id_korisnika;");
                    using (var command = new MySqlCommand(upit, connection))
                    {

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Rezervacija rezervacija = new Rezervacija()
                                {
                                    ID = reader.GetInt32("ID"),
                                    ID_knjige = reader.GetInt32("ID_knjige"),
                                    ID_korisnika = reader.GetInt32("ID_korisnika"),
                                    Naslov = reader.GetString("Naslov"),
                                    Autor = reader.GetString("Autor"),
                                    Korisnik = reader.GetString("Ime") + " " + reader.GetString("Prezime"),
                                    Datum_posudbe = reader.GetDateTime("Datum_posudbe"),
                                    Datum_vracanja = reader.GetDateTime("Datum_vracanja"),
                                    Status = reader.GetString("Status")
                                };
                                evidencijaList.Add(rezervacija);
                            }
                        }
                    }
                    connectionManager.CloseConnection(connection);
                }
            }
            return evidencijaList.OrderBy(evidencija => evidencija.Status).ToList();

        }


        
    }
}

