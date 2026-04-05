class SubjectInfo(type: SubjectType, name: String) : ValueObject<SubjectType>(type, name) {
    override fun toString(): String {
        val typeName = when (type) {
            SubjectType.Republic -> "Республика"
            SubjectType.Territories -> "Край"
            SubjectType.Regions -> "Область"
            SubjectType.AutonomousRegion -> "Автономная область"
            SubjectType.AutonomousTerritories -> "Автономный округ"
        }
        return "$typeName $value"
    }
}

class RoadInfo(type: RoadType, name: String) : ValueObject<RoadType>(type, name) {
    override fun toString(): String {
        val typeName = when (type) {
            RoadType.Alley -> "аллея"
            RoadType.Boulevard -> "бульвар"
            RoadType.Highway -> "магистраль"
            RoadType.Lane -> "переулок"
            RoadType.Square -> "площадь"
            RoadType.Drive -> "проезд"
            RoadType.Avenue -> "проспект"
            RoadType.Byway -> "проулок"
            RoadType.Crossing -> "разъезд"
            RoadType.Descent -> "спуск"
            RoadType.Tract -> "тракт"
            RoadType.CulDeSac -> "тупик"
            RoadType.Street -> "улица"
            RoadType.Motorway -> "шоссе"
        }
        return "$typeName $value"
    }
}

class BuildingInfo(type: BuildingType, number: String) : ValueObject<BuildingType>(type, number) {
    override fun toString(): String {
        val typeName = when (type) {
            BuildingType.House -> "дом"
            BuildingType.Block -> "корпус"
            BuildingType.Structure -> "строение"
            BuildingType.Shaft -> "шахта"
        }
        return "$typeName $value"
    }
}

class PremiseInfo(type: PremiseType, number: String) : ValueObject<PremiseType>(type, number) {
    override fun toString(): String {
        val typeName = when (type) {
            PremiseType.Apartment -> "квартира"
            PremiseType.Room -> "комната"
            PremiseType.Office -> "офис"
            PremiseType.Pavilion -> "павильон"
            PremiseType.Premise -> "помещение"
            PremiseType.WorkArea -> "рабочий участок"
            PremiseType.Warehouse -> "склад"
            PremiseType.SalesFloor -> "торговый зал"
            PremiseType.Workshop -> "цех"
        }
        return "$typeName $value"
    }
}

class ParkingSpaceInfo(type: ParkingSpaceType, number: String) : ValueObject<ParkingSpaceType>(type, number) {
    override fun toString(): String {
        val typeName = when (type) {
            ParkingSpaceType.ParkingSpace -> "машино-место"
            ParkingSpaceType.Garage -> "гараж"
            ParkingSpaceType.GarageBox -> "гаражный бокс"
        }
        return "$typeName $value"
    }
}

class LandParcelInfo(type: LandParcelType, number: String) : ValueObject<LandParcelType>(type, number) {
    override fun toString(): String {
        val typeName = when (type) {
            LandParcelType.LandPlot -> "земельный участок"
            LandParcelType.GardenPlot -> "садовый участок"
            LandParcelType.AgriculturalPlot -> "сельскохозяйственный участок"
            LandParcelType.ForestPlot -> "лесной участок"
            LandParcelType.WaterPlot -> "водный участок"
            LandParcelType.SpeciallyProtectedPlot -> "особо охраняемая территория"
            LandParcelType.IndustrialPlot -> "участок промышленного назначения"
        }
        return "$typeName $value"
    }
}