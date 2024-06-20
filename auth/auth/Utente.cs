using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auth
{
    internal class Utente
    {
        private static string username = null;
        private static DateTime? loginTime = null;
        private static List<string> accessi = new List<string>();

        public static bool Login(string user, string password, string confermaPassword)
        {
            if (!string.IsNullOrEmpty(user) && password == confermaPassword)
            {
                username = user;
                loginTime = DateTime.Now;
                accessi.Add($"{username} - {loginTime}");
                return true;
            }
            return false;
        }

        public static bool Logout()
        {
            if (username != null)
            {
                username = null;
                loginTime = null;
                return true;
            }
            return false;
        }

        public static string VerificaLogin()
        {
            if (username != null && loginTime != null)
            {
                return $"Utente {username} loggato alle {loginTime}";
            }
            return "Nessun utente loggato.";
        }

        public static string[] ListaAccessi()
        {
            return accessi.ToArray();
        }
    }
}
