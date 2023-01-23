using System;
using System.Collections.Generic;

namespace WebAPIUsingEntityFramework.Models;

public partial class Student
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public decimal PhoneNumber { get; set; }

    public int Age { get; set; }
}
