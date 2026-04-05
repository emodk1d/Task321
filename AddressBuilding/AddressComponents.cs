namespace AddressBuilding;

public class SubjectInfo : ValueObject<SubjectType>
{
    public SubjectInfo(SubjectType type, string value) : base(type, value)
    {
    }

    public override string ToString()
    {
        string typeName = Type switch
        {
            SubjectType.Republic => "Республика",
            SubjectType.Territories => "Край",
            SubjectType.Regions => "Область",
            SubjectType.AutonomousRegion => "Автономная область",
            SubjectType.AutonomousTerritories => "Автономный округ",
            _ => ""
        };
        return $"{typeName} {Value}";
    }
}

public class RoadInfo : ValueObject<RoadType>
{
    public RoadInfo(RoadType type, string value) : base(type, value)
    {
    }

    public override string ToString()
    {
        string typeName = Type switch
        {
            RoadType.Alley => "аллея",
            RoadType.Boulevard => "бульвар",
            RoadType.Highway => "магистраль",
            RoadType.Lane => "переулок",
            RoadType.Square => "площадь",
            RoadType.Drive => "проезд",
            RoadType.Avenue => "проспект",
            RoadType.Byway => "проулок",
            RoadType.Crossing => "разъезд",
            RoadType.Descent => "спуск",
            RoadType.Tract => "тракт",
            RoadType.CulDeSac => "тупик",
            RoadType.Street => "улица",
            RoadType.Motorway => "шоссе",
            _ => ""
        };
        return $"{typeName} {Value}";
    }
}

public class BuildingInfo : ValueObject<BuildingType>
{
    public BuildingInfo(BuildingType type, string number) : base(type, number)
    {
    }

    public override string ToString()
    {
        string typeName = Type switch
        {
            BuildingType.House => "дом",
            BuildingType.Block => "корпус",
            BuildingType.Structure => "строение",
            BuildingType.Shaft => "шахта",
            _ => ""
        };
        return $"{typeName} {Value}";
    }
}

public class PremiseInfo : ValueObject<PremiseType>
{
    public PremiseInfo(PremiseType type, string number) : base(type, number)
    {
    }

    public override string ToString()
    {
        string typeName = Type switch
        {
            PremiseType.Apartment => "квартира",
            PremiseType.Room => "комната",
            PremiseType.Office => "офис",
            PremiseType.Pavilion => "павильон",
            PremiseType.Premise => "помещение",
            PremiseType.WorkArea => "рабочий участок",
            PremiseType.Warehouse => "склад",
            PremiseType.SalesFloor => "торговый зал",
            PremiseType.Workshop => "цех",
            _ => ""
        };
        return $"{typeName} {Value}";
    }
}

public class ParkingSpaceInfo : ValueObject<ParkingSpaceType>
{
    public ParkingSpaceInfo(ParkingSpaceType type, string number) : base(type, number)
    {
    }

    public override string ToString()
    {
        string typeName = Type switch
        {
            ParkingSpaceType.ParkingSpace => "машино-место",
            ParkingSpaceType.Garage => "гараж",
            ParkingSpaceType.GarageBox => "гаражный бокс",
            _ => ""
        };
        return $"{typeName} {Value}";
    }
}

public class LandParcelInfo : ValueObject<LandParcelType>
{
    public LandParcelInfo(LandParcelType type, string number) : base(type, number)
    {
    }

    public override string ToString()
    {
        string typeName = Type switch
        {
            LandParcelType.LandPlot => "земельный участок",
            LandParcelType.GardenPlot => "садовый участок",
            LandParcelType.AgriculturalPlot => "сельскохозяйственный участок",
            LandParcelType.ForestPlot => "лесной участок",
            LandParcelType.WaterPlot => "водный участок",
            LandParcelType.SpeciallyProtectedPlot => "особо охраняемая территория",
            LandParcelType.IndustrialPlot => "участок промышленного назначения",
            _ => ""
        };
        return $"{typeName} {Value}";
    }
}