class Address {
    var country: String = ""
    var subject: SubjectInfo? = null
    var municipalDistrict: String? = null
    var settlement: String? = null
    var locality: String? = null
    var planningStructure: String? = null
    var roadNetwork: RoadInfo? = null
    var addressObjectType: AddressObjectType? = null
    var building: BuildingInfo? = null
    var landParcel: LandParcelInfo? = null
    var premise: PremiseInfo? = null
    var parkingSpace: ParkingSpaceInfo? = null

    fun generateFullAddress(): String {
        val parts = mutableListOf<String>()

        if (country.isNotEmpty()) parts.add(country)
        subject?.let { parts.add(it.toString()) }
        if (!municipalDistrict.isNullOrEmpty()) parts.add(municipalDistrict!!)
        if (!settlement.isNullOrEmpty()) parts.add(settlement!!)
        if (!locality.isNullOrEmpty()) parts.add(locality!!)
        if (!planningStructure.isNullOrEmpty()) parts.add(planningStructure!!)
        roadNetwork?.let { parts.add(it.toString()) }

        building?.let { parts.add(it.toString()) }
        landParcel?.let { parts.add(it.toString()) }
        premise?.let { parts.add(it.toString()) }
        parkingSpace?.let { parts.add(it.toString()) }

        return parts.joinToString(", ")
    }
}