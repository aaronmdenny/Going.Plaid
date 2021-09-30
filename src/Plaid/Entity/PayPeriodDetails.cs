namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details about the pay period.</para>
/// </summary>
public record PayPeriodDetails
{
	/// <summary>
	/// <para>The pay period start date, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format: "yyyy-mm-dd".</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateOnly? StartDate { get; init; } = default!;

	/// <summary>
	/// <para>The pay period end date, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format: "yyyy-mm-dd".</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateOnly? EndDate { get; init; } = default!;

	/// <summary>
	/// <para>The date on which the paystub was issued, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format ("yyyy-mm-dd").</para>
	/// </summary>
	[JsonPropertyName("pay_day")]
	public DateOnly? PayDay { get; init; } = default!;

	/// <summary>
	/// <para>Total earnings before tax.</para>
	/// </summary>
	[JsonPropertyName("gross_earnings")]
	public decimal? GrossEarnings { get; init; } = default!;

	/// <summary>
	/// <para>The net amount of the paycheck.</para>
	/// </summary>
	[JsonPropertyName("check_amount")]
	public decimal? CheckAmount { get; init; } = default!;
}