using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HW_7_8

{

    public class Category
    {
    [Key]
    public int Id { get; set; }
    public string ExpensesCategory { set; get; }

    }
}
