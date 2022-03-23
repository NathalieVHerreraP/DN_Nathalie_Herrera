using GymManager.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.DataAccess
{
    public class ProceduresCall : iProceduresCall
    {
        const string mysqlConnectionString = "server=localhost;port=3306;database=gymmanager;user=root;";


        public List<ProductTypes> GetInventory(int productId)
        {
            List<ProductTypes> productTypes = new List<ProductTypes>();

            MySqlConnector.MySqlConnection connection = new MySqlConnector.MySqlConnection(mysqlConnectionString);

            connection.Open();

            try
            {
                MySqlConnector.MySqlCommand command = new MySqlConnector.MySqlCommand("GetInventory", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("_productid", productId);


                var reader = command.ExecuteReader();

                while (reader.Read())
                {

                    ProductTypes productType = new ProductTypes
                    {
                        idproductTypes = (int)reader["ID"],
                        name = reader["name"] as string,
                        brand = reader["brand"] as string,
                        quantity = (int)reader["quantity"]
                    };

                    productTypes.Add(productType);

                }
            }
            finally
            {
                connection.Close();


            }

            return productTypes;             
        }

        public List<Members> GetNewMembers()
        {
            List<Members> members = new List<Members>();

            MySqlConnector.MySqlConnection connection = new MySqlConnector.MySqlConnection(mysqlConnectionString);

            connection.Open();

            try
            {
                MySqlConnector.MySqlCommand command = new MySqlConnector.MySqlCommand("GetNewMembers", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;


                var reader = command.ExecuteReader();

                while (reader.Read())
                {

                    Members member = new Members
                    {
                        IdMembers = (int)reader["idmembers"],
                        MemberSince = (DateTime)reader["membersince"],
                        Type = reader["type"] as string
                    };

                    members.Add(member);

                }
            }
            finally
            {
                connection.Close();


            }

            return members;
        }

        public void NewSale(NewSaleIds newSaleIds)
        {
            MySqlConnector.MySqlConnection connection = new MySqlConnector.MySqlConnection(mysqlConnectionString);

            connection.Open();

            try
            {
                MySqlConnector.MySqlCommand command = new MySqlConnector.MySqlCommand("NewSale", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("_productid", newSaleIds.ProductId);
                command.Parameters.AddWithValue("_userid", newSaleIds.UserId);



                command.ExecuteNonQuery();

            }
            finally
            {
                connection.Close();


            }

        }
    }
}
