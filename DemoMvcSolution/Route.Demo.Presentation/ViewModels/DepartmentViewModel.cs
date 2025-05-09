﻿namespace Route.Demo.Presentation.ViewModels
{
    public class DepartmentViewModel
    {
        public string Name { get; set; }  = string.Empty;  // since name and code does not allow null we intialze them with empty string
        public string Code { get; set; }  = string.Empty ;
        public string? Description { get; set; }
        public DateOnly DateOfCreation { get; set; }
    }
}
