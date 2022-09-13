namespace WebApi.Models.Users;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using backend.Common;
using backend.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

public class CreateRequest : ValidationAttribute
{

   
    [Required(ErrorMessage = Constants.DOCUMENT_NUMBER_REQUIRED_MSG)]
    [StringLength(20, ErrorMessage = Constants.DOCUMENT_NUMBER_MAX_LENGTH_MSG, MinimumLength = 1)]
    public string DocumentNumber { get; set; }

    [Required(ErrorMessage = Constants.FIRST_NAME_REQUIRED_MSG)]
    [RegularExpression(Constants.ONLY_LETTERS_REGEX, ErrorMessage = Constants.ONLY_LETTERS_MSG)]
    [StringLength(40, ErrorMessage = Constants.FIRST_NAME_MAX_LENGTH_MSG, MinimumLength = 1)]
    public string FirstName { get; set; }

    [StringLength(40, ErrorMessage = Constants.MIDDLE_NAME_MAX_LENGTH_MSG, MinimumLength = 1)]
    [RegularExpression(Constants.ONLY_LETTERS_REGEX, ErrorMessage = Constants.ONLY_LETTERS_MSG)]
    public string? MiddleName { get; set; }

    [Required(ErrorMessage = Constants.FIRST_SURNAME_REQUIRED_MSG)]
    [StringLength(40, ErrorMessage = Constants.FIRST_SURNAME_MAX_LENGTH_MSG, MinimumLength = 1)]
    [RegularExpression(Constants.ONLY_LETTERS_REGEX, ErrorMessage = Constants.ONLY_LETTERS_MSG)]
    public string FirstSurname { get; set; }

    [StringLength(40, ErrorMessage = Constants.SECOND_SURNAME_MAX_LENGTH_MSG, MinimumLength = 1)]
    [RegularExpression(Constants.ONLY_LETTERS_REGEX, ErrorMessage = Constants.ONLY_LETTERS_MSG)]
    public string? SecondSurname { get; set; }

    [MaxLength(20, ErrorMessage = Constants.PHONE_NUMBER_MAX_LENGTH_MSG)]
    public string? PhoneNumber { get; set; }

    [EmailAddress(ErrorMessage = Constants.EMAIL_FORMAT_MSG)]
    [StringLength(200, ErrorMessage = Constants.EMAIL_MAX_LENGTH_MSG, MinimumLength = 1)]
    public string? Email { get; set; }

    [Required(ErrorMessage = Constants.ADDRESS_REQUIRED_MSG)]
    public string Address { get; set; }

    [Required(ErrorMessage = Constants.AGE_REQUIRED_MSG)]
    //[Range(1, int.MaxValue, ErrorMessage = Constants.AGE_REQUIRED_MSG)]
    //[MaxLength(3, ErrorMessage = Constants.AGE_MAX_LENGTH)]
    public int Age { get; set; }

    [Required(ErrorMessage = Constants.GENDER_REQUIRED_MSG)]
    //[EnumDataType(typeof(Gender), ErrorMessage = Constants.AGE_ENUM_MSG)]
    public int GenderId { get; set; }    

}
