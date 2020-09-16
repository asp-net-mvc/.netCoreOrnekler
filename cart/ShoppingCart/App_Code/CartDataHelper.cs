using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for CartDataHelper
/// </summary>
public class CartDataHelper
{
	public CartDataHelper()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    /// <summary>
    /// Get an item from the databes into a cart item
    /// </summary>
    /// <param name="itemId">Item Id of item to add</param>
    public static CartItemInfo getCartItemInfo(int productID)
    {
        CartItemInfo item = new CartItemInfo();
        item.ProductId = -1;

        SqlParameter productIDSqlParameter = new SqlParameter("@ProductID", SqlDbType.Int);
        productIDSqlParameter.Value = productID;

        using (SqlDataReader rdr = SqlHelper.ExecuteReader(SqlHelper.mainConnectionString, CommandType.StoredProcedure, "GetProduct", productIDSqlParameter))
        {
            
            while (rdr.Read())
            {
                item.ProductId = productID;
                item.ProductName = rdr["ProductName"].ToString();
                item.Quantity = 1;
                item.Price = Convert.ToDecimal(rdr["Price"]);
                item.CategoryId = Convert.ToInt32(rdr["CategoryID"]);
                item.CategoryName = rdr["CategoryName"].ToString();
            }
        }

        return item;
    }
}
