using System;

namespace SchoolProject.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    public class LogInViewModel
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
    }
}