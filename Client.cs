using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using System.Net.Mail;
using System.Data;




namespace Base_projet;

[Table("detail")]
public class Detail;
public class Car;
public class Client
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }


    [Required]
    // relation n..n vers Detail
    public ICollection<Car> Cars { get; set; } = new List<Car>();

    [Required]
    public String LastName { get; set; }
    [Required]
    public String FirstName { get; set; }
    [Required]
    public DateTime BirthDate { get; set; }
    [Required]
    public String PhoneNumber {  get; set; }
    [Required]
    public String Mail { get; set; }

    public Client(String LastName, String FirstName, DateTime BirthDate, String PhoneNumber, String Mail)
    {
        this.LastName = LastName;
        this.FirstName = FirstName;
        this.BirthDate = BirthDate;
        this.PhoneNumber = PhoneNumber;
        this.Mail = Mail;
    }

  

}





