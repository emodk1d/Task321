class AddressBuilder {
    private val address = Address()

    fun setCountry(country: String): AddressBuilder {
        address.country = country
        return this
    }

    fun setSubject(type: SubjectType, name: String): AddressBuilder {
        address.subject = SubjectInfo(type, name)
        return this
    }

    fun setMunicipalDistrict(district: String): AddressBuilder {
        address.municipalDistrict = district
        return this
    }

    fun setSettlement(settlement: String): AddressBuilder {
        address.settlement = settlement
        return this
    }

    fun setLocality(locality: String): AddressBuilder {
        address.locality = locality
        return this
    }

    fun setPlanningStructure(structure: String): AddressBuilder {
        address.planningStructure = structure
        return this
    }

    fun setRoad(type: RoadType, name: String): AddressBuilder {
        address.roadNetwork = RoadInfo(type, name)
        return this
    }

    fun setBuilding(type: BuildingType, number: String): AddressBuilder {
        address.addressObjectType = AddressObjectType.Building
        address.building = BuildingInfo(type, number)
        return this
    }

    fun setLandParcel(type: LandParcelType, number: String): AddressBuilder {
        address.addressObjectType = AddressObjectType.LandParcel
        address.landParcel = LandParcelInfo(type, number)
        return this
    }

    fun setParkingSpace(type: ParkingSpaceType, number: String): AddressBuilder {
        address.addressObjectType = AddressObjectType.ParkingSpace
        address.parkingSpace = ParkingSpaceInfo(type, number)
        return this
    }

    fun setPremise(type: PremiseType, number: String): AddressBuilder {
        address.addressObjectType = AddressObjectType.Premise
        address.premise = PremiseInfo(type, number)
        return this
    }

    fun build(): String {
        return address.generateFullAddress()
    }

    fun getAddress(): Address {
        return address
    }

    fun reset() {
        address.country = ""
        address.subject = null
        address.municipalDistrict = null
        address.settlement = null
        address.locality = null
        address.planningStructure = null
        address.roadNetwork = null
        address.addressObjectType = null
        address.building = null
        address.landParcel = null
        address.premise = null
        address.parkingSpace = null
    }
}