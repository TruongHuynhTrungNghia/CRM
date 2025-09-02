using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;

namespace CRM.Customer.Application.Models;

public class Customer : Identifiable<int>
{
    [Attr(Capabilities = AttrCapabilities.AllowView)]
    public required string CustomerId { get; init; }

    [Attr(Capabilities = AttrCapabilities.AllowView | AttrCapabilities.AllowFilter | AttrCapabilities.AllowSort)]
    public required string Name { get; init; }

    [Attr(Capabilities = AttrCapabilities.AllowView | AttrCapabilities.AllowFilter | AttrCapabilities.AllowSort)]
    public string? Email { get; init; }

    [Attr(Capabilities = AttrCapabilities.AllowView | AttrCapabilities.AllowFilter | AttrCapabilities.AllowSort)]
    public string? PhoneNumber { get; init; }
}