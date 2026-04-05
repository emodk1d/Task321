namespace AddressBuilding;

using System.Collections.Generic;

public class Address
{
    public string Country { get; set; }
    public SubjectInfo? Subject { get; set; }
    public string? MunicipalDistrict { get; set; }
    public string? Settlement { get; set; }
    public string? Locality { get; set; }
    public string? PlanningStructure { get; set; }
    public RoadInfo? RoadNetwork { get; set; }
    public AddressObjectType? AddressObjectType { get; set; }
    public BuildingInfo? Building { get; set; }
    public LandParcelInfo? LandParcel { get; set; }
    public PremiseInfo? Premise { get; set; }
    public ParkingSpaceInfo? ParkingSpace { get; set; }

    public string GenerateFullAddress()
    {
        var parts = new List<string>();
        
        if (!string.IsNullOrEmpty(Country)) parts.Add(Country);
        if (Subject != null) parts.Add(Subject.ToString());
        if (!string.IsNullOrEmpty(MunicipalDistrict)) parts.Add(MunicipalDistrict);
        if (!string.IsNullOrEmpty(Settlement)) parts.Add(Settlement);
        if (!string.IsNullOrEmpty(Locality)) parts.Add(Locality);
        if (!string.IsNullOrEmpty(PlanningStructure)) parts.Add(PlanningStructure);
        if (RoadNetwork != null) parts.Add(RoadNetwork.ToString());
        
        if (Building != null) parts.Add(Building.ToString());
        if (LandParcel != null) parts.Add(LandParcel.ToString());
        if (Premise != null) parts.Add(Premise.ToString());
        if (ParkingSpace != null) parts.Add(ParkingSpace.ToString());
        
        return string.Join(", ", parts);
    }
}