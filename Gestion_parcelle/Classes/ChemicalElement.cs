using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_parcelle.Classes
{
    internal class ChemicalElement
    {
        #region attribut
        private string _elementCode;
        private string _elementTag;
        private string _elementUnit;
        #endregion
        #region getter setter
        public string ElementCode { get => _elementCode; }
        public string ElementTag { get => _elementTag; }
        public string ElementUnit { get => _elementUnit; }
        #endregion
        #region constructor
        public ChemicalElement(string elementCode, string elementTag, string elementUnit)
        {
            _elementCode = elementCode;
            _elementTag = elementTag;
            _elementUnit = elementUnit;
        }
        #endregion
        #region methode
        public static List<ChemicalElement>? FetchDataBaseList() 
        {
            string sqlRequestCommandString = "SELECT * FROM chemical_element";
            string sqlRequestConnetionString = "server=localhost; user id=root; database=app_gestion_parcelle";
            List<ChemicalElement> listOutput = new List<ChemicalElement>();
            MySqlConnection sqlRequestConnection = new MySqlConnection(sqlRequestConnetionString);
            try
            {
                sqlRequestConnection.Open();
                MySqlCommand sqlRequestCommand = new MySqlCommand(sqlRequestCommandString, sqlRequestConnection);
                MySqlDataReader sqlDataReader = sqlRequestCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string elementCodeFetched = (string)sqlDataReader[0],
                           elementTagFetched = (string)sqlDataReader[1],
                           elementUnitFetched = (string)sqlDataReader[2];
                    listOutput.Add(new ChemicalElement(elementCodeFetched, elementTagFetched, elementUnitFetched));
                }
                sqlDataReader.Close();
                sqlRequestConnection.Close();
                return listOutput;
            }
            catch(Exception ex)
            {
                sqlRequestConnection.Close();
                Console.WriteLine(ex.ToString());
                return null;
            }            
        }
        #endregion
    }
}
