using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects;

public class Campaign : ValueObject
{
    public Campaign(
        string source,
        string medium,
        string name,
        string? id = null,
        string? term = null,
        string? content = null)
    {
        Source = source;
        Medium = medium;
        Name = name;
        Id = id;
        Term = term;
        Content = content;
        
        InvalidCampaignException.ThrowIfNull(source, "UTM Source is invalid");
        InvalidCampaignException.ThrowIfNull(medium, "UTM Medium is invalid");
        InvalidCampaignException.ThrowIfNull(name, "UTM Name is invalid");
    }


    /// <summary>
    /// The ads campaign id.
    /// </summary>
    public string? Id { get; }

    /// <summary>
    /// The referrer (e.g. google, newsletter)
    /// </summary>
    public string Source { get; }

    /// <summary>
    /// Marketing medium (e.g. cpc, banner, email)
    /// </summary>
    public string Medium { get; }

    /// <summary>
    /// Product, promo code, or slogan (e.g. spring_sale) One of campaign name or campaign id are required.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Identify the paid keywords
    /// </summary>
    public string? Term { get; }

    /// <summary>
    /// Use to differentiate ads
    /// </summary>
    public string? Content { get; }
}