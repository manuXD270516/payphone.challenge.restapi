using System.ComponentModel.DataAnnotations;

namespace payphone.challenge.restapi.WebApi.UseCases.V1.CloseAccount;

/// <summary>
/// The Close Account Request.
/// </summary>
public sealed class CloseAccountRequest
{
    /// <summary>
    /// Account ID.
    /// </summary>
    [Required]
    public Guid AccountId { get; set; }
}