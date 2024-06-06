using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace CCSD_Job_Search.Models
{
    public class Job
    {
        
        public enum Category
        {
            Admin,
            Support,
            Licensed
        }

        public int Id { get; set; }
        [DisplayName("Class Code")]
        [Required(ErrorMessage ="Class Code is Required")]
        public string  ClassCode { get; set; }

        [DisplayName("Job Title")]
        [Required(ErrorMessage ="Job Title is Required")]
        public string JobTitle { get; set; }

        [DisplayName("Job Category")]
        [Required(ErrorMessage ="Job Category is Required")]
        public string JobCategory { get; set; }

        [DisplayName("Job Family")]
        [Required(ErrorMessage = "Job Family is Required")]
        public string JobFamily { get; set; }

        [DisplayName("Classification")]
        [Required(ErrorMessage ="Classification is Required")]
        public string Classification { get; set; }

        //TODO: Turn into enum
        [DisplayName("Terms of Employment")]
        [Required(ErrorMessage = "Terms of Employment is Required")]
        public string TermsOfEmployment { get; set; }

        [DisplayName("FLSA STATUS")]
        [Required(ErrorMessage = "FLSA Status is Required")]
        public string FLSAStatus { get; set; }

        [AllowHtml]
        [DisplayName("Position Summary")]
        [Required(ErrorMessage = "Position Summary is Required")]
        [Column(TypeName = "text")]
        public string PositionSummary { get; set; }

        [AllowHtml]
        [DisplayName("Essential Duties and Responsibilities")]
        [Required(ErrorMessage ="Essential Duties and Responsibilities is Required")]
        [Column(TypeName = "text")]
        public string EssentialDutiesAndResponsibilities { get; set; }

        [AllowHtml]
        [DisplayName("Distinguishing Characteristics")]
        [Column(TypeName = "text")]
        public string? DistinguishingCharacteristics { get; set; }

        [AllowHtml]
        [DisplayName("Knowledge, Skills, and Abilities (Position Expectations)")]
        [Column(TypeName = "text")]
        public string? KnowledgeSkillsandAbilities { get; set; }

        [AllowHtml]
        [DisplayName("Position Requirements")]
        [Required(ErrorMessage ="Position Requirements are Required")]
        [Column(TypeName = "text")]
        public string PositionRequirements { get; set; }

        [AllowHtml]
        [DisplayName("Document(s) Required at Time of Application")]
        [Column(TypeName = "text")]
        public string DocumentsRequiredAtTimeOfApplication { get; set; }

        [DisplayName("Examples of Assigned Work Areas")]
        [Column(TypeName = "text")]
        public string ExamplesOfAssignedWorkAreas { get; set; }

        [DisplayName("Examples of Assigned Work Areas")]
        [Column(TypeName = "text")]
        public string ExamplesOfEquipmentSupplies { get; set; }

        [AllowHtml]
        [DisplayName("Work Environment")]
        [Column(TypeName = "text")]
        public string WorkEnvironment { get; set; }

        public string? ApplyLink { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
