using ITMCollegeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMCollegeService.Identity
{
    public enum ErrCode
    {
        Successfully = 0,
        NotExists,
        Looked,
        LoginEmpty,
        UserExist,
        Denied,
        PassWrong,
        RoleNotExist,
        Unknown = -1
    };
    public class LoginReturnDTO
    {
        public static Dictionary<ErrCode, string> dictCodeMsgErr
            = new Dictionary<ErrCode, string>()
            {
                {ErrCode.NotExists, "The login name is not exists." },
                {ErrCode.Looked, "The user is locked." },
                {ErrCode.LoginEmpty, "At least one of Username and Email and Phone number must not be empty." },
                {ErrCode.UserExist, "The user already exists." },
                {ErrCode.Denied, "Access denied."},
                {ErrCode.PassWrong, "Password wrong." },
                {ErrCode.RoleNotExist, "The role is not exists." },
            };
        public LoginReturnDTO()
        {

        }
        public LoginReturnDTO(ErrCode errCode, string msg = "")
        {
            ErrorCode = (int)errCode;
            if (msg == "") Msg = dictCodeMsgErr[errCode];
        }
        public int ErrorCode { get; set; } = 0;
        public string Msg { get; set; } = "";
        public string Token { get; set; } = "";
        public string Setting { get; set; } = "";
        public User Info { get; set; }
    }
}
