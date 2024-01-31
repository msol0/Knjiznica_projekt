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
    public class KorisnikStore
    {
        
        private KorisnikStore _korisnikStore;
        public Korisnik AutorizacijaKorisnika(string username, string password, string email)
        {
            SqlConnectionFactory connectionManager = new SqlConnectionFactory();
            Korisnik korisnik = new Korisnik();
            using (var connection = connectionManager.GetNewConnection())
            {
                if (connection != null)
                {
                    string upit = String.Format("SELECT k.*, kp.ID_pravo FROM korisnik as k " +
                        "LEFT JOIN korisnik_prava AS kp ON k.ID = kp.ID_korisnik " +
                        "WHERE k.Korisnicko_ime = '" + username + "' " +
                        "AND k.Lozinka='" + password + "' " +
                        "AND k.Email='" + email + "'");
                    using (var command = new MySqlCommand(upit, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                korisnik.ID = reader.GetInt32("ID");
                                korisnik.Korisnicko_ime = reader.GetString("Korisnicko_ime");
                                korisnik.Ime = reader.GetString("Ime");
                                korisnik.Prezime = reader.GetString("Prezime");
                                korisnik.Email = reader.GetString("Email");

                                if (!reader.IsDBNull(reader.GetOrdinal("Datum_clanarine")))
                                {
                                    MySqlDateTime mySqlDateTime = reader.GetMySqlDateTime("Datum_clanarine");

                                    if (mySqlDateTime.IsValidDateTime)
                                    {
                                        korisnik.Datum_clanarine = mySqlDateTime.GetDateTime();
                                    }
                                    else
                                    {
                                        korisnik.Datum_clanarine = DateTime.MinValue;
                                    }
                                }
                                else
                                {
                                    korisnik.Datum_clanarine = DateTime.MinValue;
                                }

                                korisnik.Pravo = (Abstract.Enums.PravaEnums)reader.GetInt32("ID_pravo");
                            }    
                        }
                    }
                    connectionManager.CloseConnection(connection);
                }
            }
            return korisnik;
        }

        public List<Korisnik> GetKorisnik()
        {
            SqlConnectionFactory connectionManager = new SqlConnectionFactory();
            List<Korisnik> userList = new List<Korisnik>();

            using (var connection = connectionManager.GetNewConnection())
            {
                if (connection != null)
                {
                    string upit = String.Format("SELECT k.*, kp.id_pravo FROM korisnik AS k " +
                        "JOIN korisnik_prava AS kp ON k.id = kp.id_korisnik " +
                        "JOIN pravo AS p ON kp.id_pravo = p.id WHERE kp.id_pravo = 2;");

                    using (var command = new MySqlCommand(upit, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                Korisnik korisnik = new Korisnik
                                {
                                    ID = reader.GetInt32("Id"),
                                    Korisnicko_ime = reader.GetString("Korisnicko_ime"),
                                    Ime = reader.GetString("Ime"),
                                    Prezime = reader.GetString("Prezime"),
                                    Email = reader.GetString("Email"),
                                    Datum_clanarine = reader.GetDateTime("Datum_clanarine"),
                                    Pravo = (Abstract.Enums.PravaEnums)reader.GetInt32("ID_pravo")
                                };

                                userList.Add(korisnik);
                            }
                        }
                    }
                }
                connectionManager.CloseConnection(connection);
            }
            return userList.OrderBy(korisnik => korisnik.Prezime).ToList();
        }

        public void AzurirajPodatke(Korisnik korisnik)
        {
            var connectionManager = new SqlConnectionFactory();

            using (var connection = connectionManager.GetNewConnection())
            {
                if (connection != null)
                {
                    string upit = String.Format("UPDATE korisnik SET Korisnicko_ime = @Korisnicko_ime, Ime = @Ime, Prezime = @Prezime, Email = @Email WHERE id = @Id");

                    using (var command = new MySqlCommand(upit, connection))
                    {
                        command.Parameters.AddWithValue("@Id", korisnik.ID);
                        command.Parameters.AddWithValue("@Korisnicko_ime", korisnik.Korisnicko_ime);
                        command.Parameters.AddWithValue("@Ime", korisnik.Ime);
                        command.Parameters.AddWithValue("@Prezime", korisnik.Prezime);
                        command.Parameters.AddWithValue("@Email", korisnik.Email);

                        command.ExecuteNonQuery();
                    }

                    connectionManager.CloseConnection(connection);
                }
            }
        }

        public bool ProvjeraLozinke(string unos, int id_korisnika)
        {
            var connectionManager = new SqlConnectionFactory();
            bool count = false;

            using (var connection = connectionManager.GetNewConnection())
            {
                if (connection != null)
                {
                    string upit = String.Format("SELECT COUNT(*) FROM korisnik WHERE id = '" + id_korisnika + " ' " + " AND lozinka = '" + unos + "'");

                    using (var command = new MySqlCommand(upit, connection))
                    {
                        int result = Convert.ToInt32(command.ExecuteScalar());
                        count = result > 0;
                    }
                }
                connectionManager.CloseConnection(connection);
            }
            return count;
        }
        public void PromjenaLozinke(string novaLozinka, int id_korisnika){
            var connectionManager = new SqlConnectionFactory();
            using(var connection = connectionManager.GetNewConnection()) 
            { 
                if (connection != null) 
                {
                    string upit = String.Format("UPDATE korisnik SET Lozinka = @Lozinka WHERE id = @id_korisnika");

                    using(var command = new MySqlCommand(upit, connection))
                    {
                        command.Parameters.AddWithValue("@Lozinka", novaLozinka);
                        command.Parameters.AddWithValue("@id_korisnika", id_korisnika);

                        command.ExecuteNonQuery();
                    }
                    connectionManager.CloseConnection(connection);
                } 
            }
        }
    }

}
