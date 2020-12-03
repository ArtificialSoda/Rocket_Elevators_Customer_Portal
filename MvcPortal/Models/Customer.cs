using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{

    [Table("customers")]
    public partial class Customer
    {

        [Column("customer_creation_date")]
        public DateTime CustomerCreationDate { get; set; }

        [Column("company_name")]
        public string CompanyName { get; set; }

        [Column("company_headquarter_address")]
        public string CompanyHQAddress { get; set; }

        [Column("full_name_company_contact")]
        public string NameCompanyContact { get; set; }

        [Column("company_contact_phone")]
        public string PhoneCompanyContact { get; set; }

        [Column("email_company_contact")]
        public string EmailCompanyContact { get; set; }

        [Column("company_description")]
        public string CompanyDesc { get; set; }

        [Column("full_name_service_technical_authority")]
        public string ServiceTechName { get; set; }

        [Column("technical_authority_phone")]
        public string TechAuthorityPhone { get; set; }

        [Column("technical_manager_email")]
        public string TechMngrEmail { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

    }
}