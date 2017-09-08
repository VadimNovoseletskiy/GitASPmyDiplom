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
            Village v0 = new Village { VillageName = "VillageName_0" };
            Village v1 = new Village { VillageName = "VillageName_1" };
            Village v2 = new Village { VillageName = "VillageName_2" };
            Village v3 = new Village { VillageName = "VillageName_3" };

            dbContext.Villages.AddRange(new List<Village> {v0, v1, v2, v3 });

            //add region
            Region r0 = new Region { RegionName = "RegionName_0" };
            Region r1 = new Region { RegionName = "RegionName_1" };
            dbContext.Regions.AddRange(new List<Region> {r0, r1});

            //add info
            Info i0=new Info
            {
                NameInfo = "Продам 1 но кімнатну квартиру ",
                DetailsInfo = " Квартира знаходиться у 10 секції на 4 поверсі, на стадії будівництва було перепланування у якому була збільшена кухня",
                Type = 1,
                DollarPrice = 3400000,
                GrnPrice = 101001093,
                TotalAreaInfo = 123,
                Village= v0,
                Region = r1
            };
            Info i1=new Info
            {
                NameInfo = "Продам 2 во кімнатну квартиру ",
                DetailsInfo = "Продам гарну 2 кімнатну квартиру в новобуді ЖК Європейський квартал 9 секця 64.99 м кв по 8450 за 1м кв",
                Type = 1,
                DollarPrice = 3500000,
                GrnPrice = 202001093,
                TotalAreaInfo = 356,
                Village = v2,
                Region = r1
            };

            dbContext.Infos.AddRange(new List<Info> {i1, i0});

            //add wall materials
            //WallMaterial w0=new WallMaterial {NameWallMaterils = "NameWallMaterils_0" };
            //WallMaterial w1 = new WallMaterial { NameWallMaterils = "NameWallMaterils_1" };
            //WallMaterial w2 = new WallMaterial { NameWallMaterils = "NameWallMaterils_2" };

            //add floor materials 
            //FloorMaterial fm0=new FloorMaterial {NameFloorMaterils = "NameFloorMaterils_0" };
            //FloorMaterial fm1 = new FloorMaterial { NameFloorMaterils = "NameFloorMaterils_1" };
            //FloorMaterial fm2 = new FloorMaterial { NameFloorMaterils = "NameFloorMaterils_2" };



            dbContext.SaveChanges();
        }
    }
}
