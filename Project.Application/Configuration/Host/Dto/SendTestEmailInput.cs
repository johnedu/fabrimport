using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Project.Authorization.Users;

namespace Project.Configuration.Host.Dto
{
    public class SendTestEmailInput
    {
        [Required]
        [MaxLength(User.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
    }
}