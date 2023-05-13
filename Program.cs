using CatBD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System.Reflection.PortableExecutable;


//using (ApplicationDBcontext db = new ApplicationDBcontext())
//{
//    Console.WriteLine("Добавление");
//    Famyly famylys = new Famyly() { FamylyName = "Эльф" };
//    db.famylies.Add(famylys);
//    InformationAboutTheBreed inf = new InformationAboutTheBreed()
//    {
//        CountryOfOrigin = "США",
//        LifeExpectancy = "12-16",
//        Size = "Средний",
//        Weight_kg = 4.5,
//        CoatType = "Безшерстная",
//        Color = "Любой",
//        Lifestyle = "в помещении",
//        Group = "редкие, бесшерстные (лысые), гипоаллергенные",
//        Price = "2000 - 3000$",
//        famyly = famylys
//    };
//    db.infoAboutTheBreeds.Add(inf);

//    BreedCharacteristics bc = new BreedCharacteristics()
//    {
//        Adaptabiliti = 7,
//        AttachmentTofamily = 8,
//        GameActivity = 9,
//        Intelligence = 9,
//        GeneralHealth = 8,
//        HairLoss = 1,
//        FriendlinessForChildren = 8,
//        FriendlyToDogs = 7,
//        LoveForMeow = 5,
//        famyly = famylys

//    };
//    db.breedCharacteristics.Add(bc);




//    db.SaveChanges();
//}

//using (ApplicationDBcontext db = new ApplicationDBcontext())
//{
//    Famyly? fid = db.famylies.Where(f=>f.FamylyName == "Эльф").FirstOrDefault();
//    int idf = fid.Id;
//    BreedCharacteristics? cs = db.breedCharacteristics.Where(c => c.Id == idf).FirstOrDefault();
//    if(cs != null)
//    {

//            cs.FriendlinessForChildren = 0;
//            cs.Adaptabiliti = 0;
//            cs.AttachmentTofamily = 0;
//            cs.GameActivity = 0;
//            cs.GeneralHealth = 0;
//            cs.HairLoss = 0;
//            cs.FriendlyToDogs = 0;
//            cs.Intelligence = 0;
//            cs.LoveForMeow = 0;

//        db.famylies.Update(fid);
//        db.SaveChanges();
//        Console.WriteLine($"Харрактеристики породы {fid.FamylyName} обновлены!");
//    }
//    else
//    {
//        Console.WriteLine("Породы не существует!");
//    }

//}
using (ApplicationDBcontext db = new ApplicationDBcontext())
{
    
    
       Famyly? fl = db.famylies.FirstOrDefault();
        Console.WriteLine(fl.FamylyName);
        if (fl != null) {
        db.breedCharacteristics.Where(ch => ch.FamylyId == fl.Id).Load();
        db.infoAboutTheBreeds.Where(inf => inf.FamylyId == fl.Id).Load();
        Console.WriteLine("Характеристики породы");
        foreach (BreedCharacteristics bc in db.breedCharacteristics)
        {
            if (bc.FamylyId == fl.Id)
                Console.WriteLine(bc.ToString());
        }
        Console.WriteLine("Информация");
        foreach (InformationAboutTheBreed inf in db.infoAboutTheBreeds)
        {
            if (inf.FamylyId == fl.Id)
                Console.WriteLine(inf.ToString());
        }
    }
    
    
}