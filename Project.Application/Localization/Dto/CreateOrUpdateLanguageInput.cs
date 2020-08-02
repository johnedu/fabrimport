using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace Project.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}