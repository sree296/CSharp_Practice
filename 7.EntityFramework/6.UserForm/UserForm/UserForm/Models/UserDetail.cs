using DataAccess.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UserFormApp.Models
{
    public class UserDetail
    {
        [Key]
        public int UserId { get; set; }
        [DisplayName("Name")]
        public string UserName { get; set; }

        [DisplayName("Gender")]
        public int GId { get; set; }

        [DisplayName("Country")]
        public int CountryId { get; set; }
        public List<CountryDetail> CountriesInfo { get; set; }

        [DisplayName("Languages Known")]
        public int LangId { get; set; }
        public List<LanguageDetail> LanguagesInfo { get; set; }
    }
}
