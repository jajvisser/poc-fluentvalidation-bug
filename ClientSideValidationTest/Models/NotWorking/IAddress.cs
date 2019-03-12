using ClientSideValidationTest.Models.NotWorking.Validators;
using FluentValidation.Attributes;

namespace ClientSideValidationTest.Models.NotWorking
{
    public interface IAddress
    {
        string Postcode { get; set; }
        string Street { get; set; }
    }
}