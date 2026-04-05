namespace AddressBuilding;


public class AddressBuilder
{
    private Address _address = new Address();

    public AddressBuilder SetCountry(string country)
    {
        _address.Country = country;
        return this;
    }

    public AddressBuilder SetSubject(SubjectType type, string name)
    {
        _address.Subject = new SubjectInfo(type, name);
        return this;
    }

    public AddressBuilder SetMunicipalDistrict(string district)
    {
        _address.MunicipalDistrict = district;
        return this;
    }

    public AddressBuilder SetSettlement(string settlement)
    {
        _address.Settlement = settlement;
        return this;
    }

    public AddressBuilder SetLocality(string locality)
    {
        _address.Locality = locality;
        return this;
    }

    public AddressBuilder SetPlanningStructure(string structure)
    {
        _address.PlanningStructure = structure;
        return this;
    }

    public AddressBuilder SetRoad(RoadType type, string name)
    {
        _address.RoadNetwork = new RoadInfo(type, name);
        return this;
    }

    public AddressBuilder SetBuilding(BuildingType type, string number)
    {
        _address.AddressObjectType = AddressObjectType.Building;
        _address.Building = new BuildingInfo(type, number);
        return this;
    }

    public AddressBuilder SetLandParcel(LandParcelType type, string number)
    {
        _address.AddressObjectType = AddressObjectType.LandParcel;
        _address.LandParcel = new LandParcelInfo(type, number);
        return this;
    }

    public AddressBuilder SetParkingSpace(ParkingSpaceType type, string number)
    {
        _address.AddressObjectType = AddressObjectType.ParkingSpace;
        _address.ParkingSpace = new ParkingSpaceInfo(type, number);
        return this;
    }

    public AddressBuilder SetPremise(PremiseType type, string number)
    {
        _address.AddressObjectType = AddressObjectType.Premise;
        _address.Premise = new PremiseInfo(type, number);
        return this;
    }

    public string Build()
    {
        return _address.GenerateFullAddress();
    }
}