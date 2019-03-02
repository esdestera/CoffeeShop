using System;
using System.Text;

public partial class Pages_Coffee : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }

    private void FillPage()
    {
        var coffees = ConnectionClass.GetCoffeeByType(DropDownList1.SelectedValue);
        var sb = new StringBuilder();

        foreach (var coffee in coffees)
        {
            sb.Append(string.Format(@"<table class = 'coffeeTable'> 
                        <tr> 
                               <th rowspan='8' width = '150px'><img runat= 'server' src = {6}> </th> 
                               <td width = '50px'>Name: </td>
                               <td>{0} </td> 
                        </tr> 
                        <tr> 
                               <th>Type:  </th> 
                               <td>{1} </td> 
                        </tr>
                        <tr> 
                               <th>Price: </th> 
                               <td>{2} </td> 
                        </tr>
                        <tr> S
                               <th>Roast: </th> 
                               <td>{3} </td> 
                        </tr>
                        <tr> 
                               <th>Origin: </th> 
                               <td>{4} </td> 
                        </tr>
                        <tr>
                            <td colspan = '2'>{5}</td>
                        </tr>
                </table>", coffee.Name, coffee.Type, coffee.Price, coffee.Price, coffee.Country, coffee.Review, coffee.Image));
            Label1.Text = sb.ToString();
        }

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillPage();
    }
}