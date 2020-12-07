using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcPortal.Models
{

    public partial class Customer
    {


        // Properties
        [Key]
        public ulong id { get; set; }

        /*

        [ForeignKey("admin_user_id")]
        public ulong AdminUser_Id { get; set; }

        [ForeignKey("address_id")]
        public ulong Address_Id { get; set; }

        [ForeignKey("employee_id")]
        public ulong Employee_Id { get; set; }

        */


        [Column("customer_creation_date")]
        public DateTime customerCreationDate { get; set; }

        [Column("company_name")]
        public string companyName { get; set; }

        [Column("company_headquarter_address")]
        public string companyHQAddress { get; set; }

        [Column("full_name_company_contact")]
        public string nameCompanyContact { get; set; }

        [Column("company_contact_phone")]
        public string phoneCompanyContact { get; set; }

        [Column("email_company_contact")]
        public string emailCompanyContact { get; set; }

        [Column("company_description")]
        public string companyDesc { get; set; }

        [Column("full_name_service_technical_authority")]
        public string serviceTechName { get; set; }

        [Column("technical_authority_phone")]
        public string techAuthorityPhone { get; set; }

        [Column("technical_manager_email")]
        public string techMngrEmail { get; set; }

        [Column("created_at")]
        public DateTime createdAt { get; set; }

        [Column("updated_at")]
        public DateTime updatedAt { get; set; }
    }
}