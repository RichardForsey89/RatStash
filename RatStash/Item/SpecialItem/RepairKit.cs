﻿namespace RatStash;

public class RepairKit : SpecialItem
{
	[JsonProperty("MaxRepairResource")]
	public int MaxRepairResource { get; set; }

	[JsonProperty("TargetItemFilter")]
	public string[] TargetItemFilter { get; set; }

	[JsonProperty("RepairQuality")]
	public float RepairQuality { get; set; }

	[JsonProperty("RepairType")]
	public string RepairType { get; set; } = "";
}
