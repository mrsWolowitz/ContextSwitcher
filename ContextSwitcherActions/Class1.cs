using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ContextSwitcherActions
{
    public class Class1
    {
        public string DBPath { get; set; }
        public string Issue { get; set; }

        private string DBName { get; set; }

        public Class1(string dbPath, string issue)
        {
			//TODO validate input parameters
			DBPath = dbPath;
            Issue = issue;
        }

        public void RestoreDB()
        {
			string DBNameString = $"on_{Issue}";
            string ConnectionString = $"Data Source= msk-sql-1; Initial Catalog ={DBNameString}; Integrated Security = true;;";

			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				string sqlQuery = @"RESTORE FILELISTONLY FROM DISK = @DBPath";
				connection.Open();
				using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
				{
					cmd.CommandType = System.Data.CommandType.Text;
					cmd.Parameters.AddWithValue("@DBPath", DBPath);
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						Tuple<string, string> fileList = new Tuple<string, string>();
					}
				}
			}

			DBName = DBNameString;

		}

        public void GetVersion()
        { }

        public void GitCheckout()
        { }

        public void ReplaceWebConfig()
        {
            string WebConfigPath = "WebSites\\Pure\\Site\\Web.config_";
            string MyWebConfigPath = "WebSites\\Pure\\Site\\Web.config";

            File.Copy(WebConfigPath, MyWebConfigPath, true);

            XDocument config = XDocument.Load(MyWebConfigPath);
            XElement configuration = config.Element("configuration");
            XElement connectionStrings = configuration.Element("connectionStrings");

            connectionStrings.RemoveNodes();
            XElement projectx = new XElement("add",
                new XAttribute("name", "ProjectX"),
                new XAttribute("providerName", "System.Data.SqlClient"),
                new XAttribute("connectionStrings", $"Data Source= msk-sql-1; Initial Catalog ={DBName}; Integrated Security = true;;"));
            connectionStrings.Add(projectx);

            XElement appSettings = config.Element("appSettings");

            XElement customizationTempFilesPath = new XElement("add",
                new XAttribute("key", "CustomizationTempFilesPath"),
                new XAttribute("value", "C:\\Temp"));
            appSettings.Add(customizationTempFilesPath);

			config.Save(MyWebConfigPath);
          
        }

        public void ReplaceConnection()
        { }

        public void Build()
        { }
        
    }
}
