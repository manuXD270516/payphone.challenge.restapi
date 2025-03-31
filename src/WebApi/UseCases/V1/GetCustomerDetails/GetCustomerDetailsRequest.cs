using System.ComponentModel.DataAnnotations;

namespace payphone.challenge.restapi.WebApi.UseCases.V1.GetCustomerDetails;

/// <summary>
/// The Get Customer Details Request.
/// </summary>
public sealed class GetCustomerDetailsRequest
{
    /// <summary>
    /// Customer ID.
    /// </summary>
    [Required]
    public Guid CustomerId { get; set; }
}