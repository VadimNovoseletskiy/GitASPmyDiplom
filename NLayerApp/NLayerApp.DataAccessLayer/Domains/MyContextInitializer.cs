
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.DataAccessLayer.Domains.Models;

namespace NLayerApp.DataAccessLayer.Domains
{
    public class MyContextInitializer:DropCreateDatabaseAlways<MyContext>
    {

        protected override void Seed(MyContext dbContext)
        {
            //add village
            Village v0 = new Village { VillageName = "г.Черкассы" };
            Village v1 = new Village { VillageName = "с.Вергуны" };
            Village v2 = new Village { VillageName = "с.Леськи" };
            Village v3 = new Village { VillageName = "с.Хуторы" };

            dbContext.Villages.AddRange(new List<Village> {v0, v1, v2, v3 });

            //add region
            Region r0 = new Region { RegionName = "Черкасский р-н" };
            Region r1 = new Region { RegionName = "р-н Центр(м.Черкаси)" };
            Region r2 = new Region { RegionName = "р-н Митниця(м.Черкаси)" };
            Region r3 = new Region { RegionName = "р-н Казбет(м.Черкаси)" };
            dbContext.Regions.AddRange(new List<Region> {r0, r1,r2,r3});

            //add street
            Street s0 = new Street {StreetName = "Шевченка"};
            Street s1 = new Street {StreetName = "Л.Українки"};
            Street s2 = new Street { StreetName ="Соборна" };
            Street s3 = new Street { StreetName ="Франка" };
            Street s4 = new Street { StreetName = "Сумгаїтська"};
            dbContext.Streets.AddRange(new List<Street> {s0,s1,s2,s3,s4});

            //add wall material
            WallMaterial w0 = new WallMaterial { NameWallMaterils = "цегла" };
            WallMaterial w1 = new WallMaterial { NameWallMaterils = "панель" };
            WallMaterial w2 = new WallMaterial { NameWallMaterils = "моноліт" };
            WallMaterial w3 = new WallMaterial { NameWallMaterils = "дерево" };
            WallMaterial w4 = new WallMaterial { NameWallMaterils = "дерево-цегла" };
            dbContext.WallMaterials.AddRange(new List<WallMaterial> {w0, w1, w2, w3, w4});

            //Add floor material
            FloorMaterial fm0 = new FloorMaterial { NameFloorMaterils = "паркет" };
            FloorMaterial fm1 = new FloorMaterial { NameFloorMaterils = "ламінат" };
            FloorMaterial fm2 = new FloorMaterial { NameFloorMaterils = "лінолеум" };
            FloorMaterial fm3 = new FloorMaterial { NameFloorMaterils = "кахель" };
            FloorMaterial fm4 = new FloorMaterial { NameFloorMaterils = "ковралін" };
            FloorMaterial fm5 = new FloorMaterial { NameFloorMaterils = "дошка" };
            FloorMaterial fm6 = new FloorMaterial { NameFloorMaterils = "ДВП" };
            FloorMaterial fm7 = new FloorMaterial { NameFloorMaterils = "бетон" };
            dbContext.FloorMaterials.AddRange(new List<FloorMaterial> {fm0, fm1, fm2, fm3, fm4, fm5, fm6, fm7}); 
            
            ////add info
            //Info i0=new Info
            //{
            //    NameCaptionLink = "Заголовок: Продаж квартири",
            //    NameInfo = "Коротко:Продам 1 но кімнатну квартиру ",
            //    DetailsInfo = "Детально: Квартира знаходиться у 10 секції на 4 поверсі, на стадії будівництва було перепланування у якому була збільшена кухня",
            //    PrivateInfo = "Приватна інформація Приватна інформація Приватна інформація Приватна інформація Приватна інформація Приватна інформація",
            //    Type = PropertyType.Apartment,
            //    OperationType = TypeOfOperation.Lease,
            //    DollarPrice = 10000,
            //    GrnPrice = 250000,
            //    TotalAreaInfo = 60,
            //    Village= v0,
            //    Region = r1,
            //    Street = s0,
            //    AddressNumber = "11"

            //};
            //Info i1=new Info
            //{
            //    NameCaptionLink = "Заголовок: Продаж будинку ",
            //    NameInfo = "Коротко:Продам хороший будинок біля лісу",
            //    DetailsInfo = "Детально: Продам гарний будинок в їорошому районі, з усіма удобствами, готовий до проживаня. Можливий торг.",
            //    PrivateInfo = "Приватна інформація Приватна інформація Приватна інформація Приватна інформація Приватна інформація Приватна інформація",
            //    Type = PropertyType.House,
            //    OperationType = TypeOfOperation.Sale,
            //    DollarPrice = 15000,
            //    GrnPrice = 375000,
            //    TotalAreaInfo = 120.5f,
            //    Village = v1,
            //    Region = r0,
            //    Street = s1,
            //    AddressNumber = "22"
            //};

            //Info i2=new Info
            //{
            //    NameCaptionLink = "Заголовок: Продаж  комерційної неоухомості",
            //    NameInfo = "Коротко:Продам Крммерційну нерухомість",
            //    DetailsInfo = "Детально: Інформація про коммерційну нерухомість ",
            //    PrivateInfo = "Приватна інформація Приватна інформація Приватна інформація Приватна інформація Приватна інформація Приватна інформація",
            //    Type = PropertyType.Commercial,
            //    OperationType = TypeOfOperation.Sale,
            //    DollarPrice = 20000,
            //    GrnPrice = 500000,
            //    TotalAreaInfo = 756.4f,
            //    Village = v0,
            //    Region = r3,
            //    Street = s2,
            //    AddressNumber = "33"
            //};

            //Info i3=new Info
            //{
            //    NameCaptionLink = "Заголовок:Продаж землі",
            //    NameInfo = "Коротко: Повідомлення про продаж  земельної ділянки ",
            //    DetailsInfo = "Детально: Інформація про продаж зеельної ділянки ",
            //    PrivateInfo = "Приватна інформація Приватна інформація Приватна інформація Приватна інформація Приватна інформація Приватна інформація",
            //    Type = PropertyType.Land,
            //    OperationType = TypeOfOperation.Sale,
            //    DollarPrice = 2000,
            //    GrnPrice = 50000,
            //    TotalAreaInfo = 956.4f,
            //    Village = v2,
            //    Region = r0,
            //    Street = s3,
            //    AddressNumber = "44"
            //};

            //dbContext.Infos.AddRange(new List<Info> {i0,i1,i2,i3});

            ////add apartments 
            //Apartment ap0=new Apartment
            //{
            //    Id =i0.Id, 
            //    TotalFloorApartment = 10,
            //    BalconyApartment = 1,
            //    BathRoomApartment = "смежная",
            //    FloorApartment = 4,
            //    KitchenAreaApartment = 40.7f,
            //    LivingAreaApartment = 80.6f,
            //    TypeRoom = SpecialTypeRoom.SeparateRooms,
            //    RoomsApartment = 5,
            //    ReadinessApartment = "готовность к вселению",
            //    Info = i0


            //};


            //dbContext.Apartments.AddRange(new List<Apartment> {ap0});


            ////add House
            //House h0=new House
            //{
            //    Id = i1.Id,
            //    TypeHouse = "Будинок",
            //    FloorHouse = 2,
            //    KitchenAreaHouse = 25.4f,
            //    LandAreaHouse = 50.4f,
            //    LivingAreaHouse = 100.4f,
            //    PartHouse = "1",
            //    RoomsHouse = 12,
            //    Info = i1
            //};

            //dbContext.Houses.Add(h0);

            ////add Commercial
            //Commercial c0=new Commercial
            //{   Id=i2.Id,
            //    TypeCommercial = "Офісно-адміністративне",
            //    EffectiveAreaCommercial = 25.7f,
            //    LandAreaCommercial = 46.5f,
            //    FloorCommercial = 1,
            //    StateCommercial = "відмінний",
            //    TotalFloorCommercial = 2,
            //    Info = i2

            //};

            //dbContext.Commercials.Add(c0);

            //Land l0=new Land
            //{
            //    Id=i3.Id,
            //    Info = i3,
            //    LandArea = 120.4f,
            //    SpecialLand = SpecialTypeLand.Agricultural

            //};

            //dbContext.Land.Add(l0);


            ////add Communication
            //Communication cm0=new Communication
            //{
            //    Id = l0.Id,
            //    AutonomousWaterCommunications = true,
            //    AutonomousSewerageCommunications = false,
            //    AutonomusHeatingCommunications = false,
            //    CentralHeatingCommunications = false,
            //    CentralSewerageCommunications = false,
            //    CentralWaterCommunications = true,
            //    ElectricityCommunications = true,
            //    GasCommunications = false,
            //    RailWay = true,
            //    //Land = l0

            //};

            //Communication cm1=new Communication
            //{
            //    Id = c0.Id,
            //    AutonomousWaterCommunications = false,
            //    AutonomousSewerageCommunications = false,
            //    AutonomusHeatingCommunications = true,
            //    CentralHeatingCommunications = false,
            //    CentralSewerageCommunications =true,
            //    CentralWaterCommunications = true,
            //    ElectricityCommunications = true,
            //    GasCommunications = true,
            //    RailWay = false,
            //    //Commercial = c0

            //};

            //Communication cm2=new Communication
            //{
            //    Id = h0.Id,
            //    AutonomousWaterCommunications = true,
            //    AutonomousSewerageCommunications = true,
            //    AutonomusHeatingCommunications = true,
            //    CentralHeatingCommunications = true,
            //    CentralSewerageCommunications = true,
            //    CentralWaterCommunications = true,
            //    ElectricityCommunications = true,
            //    GasCommunications = true,
            //    RailWay = true,
            //    //House = h0
            //};

            //Communication cm3=new Communication
            //{
            //    Id = ap0.Id,
            //    AutonomousWaterCommunications = true,
            //    AutonomousSewerageCommunications = true,
            //    AutonomusHeatingCommunications = true,
            //    CentralHeatingCommunications = true,
            //    CentralSewerageCommunications = true,
            //    CentralWaterCommunications = true,
            //    ElectricityCommunications = true,
            //    GasCommunications = true,
            //    RailWay = false,
            //    //Apartment = ap0
            //};
            //dbContext.Communications.AddRange(new List<Communication> {cm0,cm1,cm2,cm3});

            ////add OutBuildigs
            //OutBuilding otbl0=new OutBuilding
            //{
            //    Id=h0.Id,
            //    BahtHouseOutBuilding = true,
            //    BarnOutBuildings = false,
            //    GarageOutBuildings = true,
            //    GreenHouseOutBuildings = false,
            //    SummerKitchenOutBuildings = true,
            //    SwimmingOutBuildings = false,
            //    Well1OutBuildings = true,
            //    WellOutBuildings = false,
            //    //House = h0

            //};
            //dbContext.OutBuildings.Add(otbl0);

            ////add AdditionalEquipment

            //AdditionalEquipment ad0=new AdditionalEquipment
            //{
            //    Id = ap0.Id,
            //    AirConditioningAdditionalEquipment = true,
            //    BoilerAdditionalEquipment = true,
            //    CableTVadditionalEquipment = false,
            //    FirePlaceAdditionalEquipment = false,
            //    IntercomAdditionalEquipment = false,
            //    InternetAdditionalEquipment = true,
            //    SatelliteTVadditionalEquipment = true,
            //    SignalingAdditionalEquipment = false,
            //    Apartment = ap0
            //};

            //AdditionalEquipment ad1=new AdditionalEquipment
            //{
            //    Id = h0.Id,
            //    AirConditioningAdditionalEquipment = true,
            //    BoilerAdditionalEquipment = true,
            //    CableTVadditionalEquipment = false,
            //    FirePlaceAdditionalEquipment = false,
            //    IntercomAdditionalEquipment = false,
            //    InternetAdditionalEquipment = true,
            //    SatelliteTVadditionalEquipment = true,
            //    SignalingAdditionalEquipment = false,
            //    House= h0
            //};

            //AdditionalEquipment ad2=new AdditionalEquipment
            //{
            //    Id = c0.Id,
            //    AirConditioningAdditionalEquipment = true,
            //    BoilerAdditionalEquipment = true,
            //    CableTVadditionalEquipment = false,
            //    FirePlaceAdditionalEquipment = false,
            //    IntercomAdditionalEquipment = false,
            //    InternetAdditionalEquipment = false,
            //    SatelliteTVadditionalEquipment = false,
            //    SignalingAdditionalEquipment = false,
            //    Commercial= c0
            //};
            //dbContext.AdditionalEquipments.AddRange(new List<AdditionalEquipment> {ad0,ad1,ad2});




            ////add Material 
            //Material m0=new Material
            //{
            //    Id=ap0.Id,
            //    Apartment = ap0

            //};

            //Material m1=new Material
            //{
            //    Id = h0.Id,
            //    House = h0
            //};

            //Material m2=new Material
            //{
            //    Id=c0.Id,
            //    Commercial = c0
            //};

            //dbContext.Materials.AddRange(new List<Material> {m0,m1,m2});

            ////add WallMaterial
            //WallMaterial w0 = new WallMaterial { NameWallMaterils = "NameWallMaterils_0", Material =m2};
            //WallMaterial w1 = new WallMaterial { NameWallMaterils = "NameWallMaterils_1", Material = m2};
            //WallMaterial w2 = new WallMaterial { NameWallMaterils = "NameWallMaterils_2", Material = m2};
            //WallMaterial w3 = new WallMaterial { NameWallMaterils = "NameWallMaterils_3", Material = m1};
            //WallMaterial w4 = new WallMaterial { NameWallMaterils = "NameWallMaterils_4", Material = m1};
            //WallMaterial w5 = new WallMaterial { NameWallMaterils = "NameWallMaterils_5", Material = m0};
            //WallMaterial w6 = new WallMaterial { NameWallMaterils = "NameWallMaterils_6", Material = m0};
            //WallMaterial w7 = new WallMaterial { NameWallMaterils = "NameWallMaterils_7", Material = m0};
            //WallMaterial w8 = new WallMaterial { NameWallMaterils = "NameWallMaterils_8", Material = m0};

            //dbContext.WallMaterials.AddRange(new List<WallMaterial> { w0, w1, w2,w4,w5,w6,w7,w8 });


            ////add floor materials 
            //FloorMaterial fm0 =new FloorMaterial {NameFloorMaterils = "NameFloorMaterils_0", Material = m0};
            //FloorMaterial fm1 = new FloorMaterial { NameFloorMaterils = "NameFloorMaterils_1", Material = m0};
            //FloorMaterial fm2 = new FloorMaterial { NameFloorMaterils = "NameFloorMaterils_2", Material = m0};
            //FloorMaterial fm3 = new FloorMaterial { NameFloorMaterils = "NameFloorMaterils_3", Material = m0};
            //FloorMaterial fm4 = new FloorMaterial { NameFloorMaterils = "NameFloorMaterils_4", Material = m2};
            //FloorMaterial fm5 = new FloorMaterial { NameFloorMaterils = "NameFloorMaterils_5", Material = m2};
            //FloorMaterial fm6 = new FloorMaterial { NameFloorMaterils = "NameFloorMaterils_6", Material = m1};
            //FloorMaterial fm7 = new FloorMaterial { NameFloorMaterils = "NameFloorMaterils_7", Material = m1};

            //dbContext.FloorMaterials.AddRange(new List<FloorMaterial> {fm1, fm2, fm3, fm4, fm5, fm6, fm7});


            dbContext.SaveChanges();
        }
    }
}
