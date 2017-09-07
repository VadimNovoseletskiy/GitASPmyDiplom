using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.DataAccessLayer.Domains.Models;

namespace NLayerApp.DataAccessLayer.Domains
{
    public class MyConntextInitializer:DropCreateDatabaseAlways<MyContext>
    {
        protected override void Seed(MyContext dbContext)
        {
            //add village
            Village v0 = new Village { VillageName = "VillageName_0" };
            Village v1 = new Village { VillageName = "VillageName_1" };
            Village v2 = new Village { VillageName = "VillageName_2" };
            Village v3 = new Village { VillageName = "VillageName_3" };



            //add region 
            //Region r0=new Region {RegionName = "RegionName_0" };
            //Region r1 = new Region { RegionName = "RegionName_1" };

            //add wall materials
            //WallMaterial w0=new WallMaterial {NameWallMaterils = "NameWallMaterils_0" };
            //WallMaterial w1 = new WallMaterial { NameWallMaterils = "NameWallMaterils_1" };
            //WallMaterial w2 = new WallMaterial { NameWallMaterils = "NameWallMaterils_2" };

            //add floor materials 
            //FloorMaterial fm0=new FloorMaterial {NameFloorMaterils = "NameFloorMaterils_0" };
            //FloorMaterial fm1 = new FloorMaterial { NameFloorMaterils = "NameFloorMaterils_1" };
            //FloorMaterial fm2 = new FloorMaterial { NameFloorMaterils = "NameFloorMaterils_2" };

            dbContext.Villages.Add(v0);

            dbContext.SaveChanges();
        }
    }
}
