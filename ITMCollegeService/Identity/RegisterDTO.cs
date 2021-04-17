using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ITMCollegeService.Identity
{
    public class RegisterDTO
    {
        /// <summary>
        /// initialize registry info
        /// </summary>
        public RegisterDTO()
        {
            Email = "";
            //  UserName = "";
            PhoneNumber = "";
        }
        //disable đi cho đỡ nhầm lẫn, sẽ dùng email hoac mobile la chính
        ///// <summary>
        ///// username
        ///// </summary>
        // public string UserName { get; set; }

        /// <summary>
        /// email 
        /// </summary>
        /// 
        public string Username { get; set; }
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        [Required(AllowEmptyStrings = true)]
        public string Email { get; set; }

        /// <summary>
        /// phone number
        /// </summary>
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "PhoneNumber")]
        //[Required(AllowEmptyStrings = true)]
        //[DisplayFormat(ConvertEmptyStringToNull = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        [Required]
        [StringLength(100, ErrorMessage = "PASSWORD_MIN_LENGTH", MinimumLength = 6)]
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string AvatarLink { get; set; }
        public string Rolename { get; set; }
    }
}
