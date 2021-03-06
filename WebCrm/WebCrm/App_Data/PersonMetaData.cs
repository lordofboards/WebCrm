﻿using System;
using System.ComponentModel.DataAnnotations;
using WebCrm.Models;

namespace WebCrm.App_Data
{
	[MetadataType(typeof(PersonMetaData))]
	public partial class Person
	{
		public ApplicationUser CreateUserObject { get; set; }
	}
	class PersonMetaData
	{
		[Display(Name = "Ime")]
		[Required(ErrorMessage = "Obavezan unos")]
		public string Forename { get; set; }
		[Display(Name = "Prezime")]
		[Required(ErrorMessage = "Obavezan unos")]
		public string Surname { get; set; }
		[Display(Name = "Email")]
		[EmailAddress(ErrorMessage = "Unešena Email adresa nije validna")]
		public string Email { get; set; }
		[Display(Name = "Telefon")]
		[Phone(ErrorMessage = "Unešeni broj nije validan")]
		public string Phone { get; set; }
		[Display(Name = "Korisnik koje je napravio unos")]
		public string CreateUser { get; set; }
		[Display(Name = "Firma")]
		[Required(ErrorMessage = "Obavezan unos")]
		public int CompanyId { get; set; }
		[Display(Name = "Firma")]
		public int Company { get; set; }
	}
}