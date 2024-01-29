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
                                korisnik.Ime = reader.GetString("ime");
                                korisnik.Prezime = reader.GetString("prezime");
                                korisnik.Email = reader.GetString("email");
                                korisnik.Pravo = (Abstract.Enums.PravaEnums)reader.GetInt32("ID_pravo");
                            }
                            
                        }

                    }
                    _connectionManager.CloseConnection(connection);
                }
            }
            return korisnik;
        }
    }
    
}
