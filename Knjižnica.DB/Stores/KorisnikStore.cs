using Knjižnica.Abstract.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjižnica.DB.Stores
{
    public class KorisnikStore
    {
        SqlConnectionFactory _connectionManager = new SqlConnectionFactory();
        public Korisnik AutorizacijaKorisnika(string username, string password, string email)
        {
            Korisnik korisnik = new Korisnik();
            using (var connection = _connectionManager.GetNewConnection())
            {
                if (connection != null)
                {
                    string upit = String.Format("SELECT k.Ime, k.Prezime, k.Email, kp.ID_pravo FROM korisnik as k " +
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
                                korisnik.Ime = reader.GetString("Ime");
                                korisnik.Prezime = reader.GetString("Prezime");
                                korisnik.Email = reader.GetString("Email");
                                korisnik.Pravo = (Abstract.Enums.PravaEnums)reader.GetInt32("ID_pravo");
                            }    
                        }
                    }
                    _connectionManager.CloseConnection(connection);
                }
            }
            return korisnik;
        }

        public List<Korisnik> GetKorisnik()
        {
            var connectionManager = new SqlConnectionFactory();
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
    }
    
}
