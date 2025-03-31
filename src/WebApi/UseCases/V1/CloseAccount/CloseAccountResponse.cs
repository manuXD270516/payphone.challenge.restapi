using payphone.challenge.restapi.Application.Boundaries.CloseAccount;
using System.ComponentModel.DataAnnotations;

namespace payphone.challenge.restapi.WebApi.UseCases.V1.CloseAccount;


/// <summary>
/// Close Account Response
/// </summary>
public sealed class CloseAccountResponse
{
    /// <summary>
    /// Account ID
    /// </summary>
    [Required]
    public Guid AccountId { get; }

    public CloseAccountResponse(CloseAccountOutput output)
    {
        AccountId = output.AccountId;
    }
}