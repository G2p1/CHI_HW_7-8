using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HW_7_8
{
    public class Expenses
    {
        [Key]
        public int Id { set; get; }

        public int CatId { set; get; }

        public string Comment { set; get; }

        public DateTime DateOfMake { set; get; }
    }
}
