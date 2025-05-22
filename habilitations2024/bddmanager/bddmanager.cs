using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace habilitations2024.bddmanager
{
    public class BddManager
    {
        // Propriété qui contiendra l'unique instance de la classe
        private static BddManager instance = null;

        // Objet de connexion à la BDD à partir d'une chaîne de connexion
        private readonly MySqlConnection connection;

        // Constructeur privé pour créer la connexion à la BDD et l'ouvrir
        private BddManager(string stringConnect)
        {
            this.connection = new MySqlConnection(stringConnect);
            this.connection.Open(); // Pas de try/catch ici
        }

        // Méthode statique pour créer une seule instance de la classe
        public static BddManager GetInstance(string stringConnect)
        {
            if (instance == null)
            {
                
                instance = new BddManager(stringConnect);
            }
            return instance;
        }

        // Exécution d'une requête autre que "select"
        public void ReqUpdate(string stringQuery, Dictionary<string, object> parameters = null)
        {
            MySqlCommand command = new MySqlCommand(stringQuery, this.connection);
            if (parameters != null)
            {
                foreach (KeyValuePair<string, object> parameter in parameters)
                {
                    command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                }
            }
            command.Prepare();
            command.ExecuteNonQuery(); 
        }
    }
}