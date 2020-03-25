using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LazZiya.ImageResize;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Rental.Data;
using Rental.Data.Data.Areas.Identity.Data;
using Rental.Data.Data.Rental;
using Rental_Data.Data.Rental;
using Rental_PI_KF.Controllers.Abstract;

namespace Rental_PI_KF.Controllers
{
    public class VehiclesController : BasicControllerAbstract
    {

        IHostingEnvironment _env;

        public VehiclesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IHostingEnvironment environment)
        :base(context,userManager)
        {
            _env = environment;
        }

        // GET: Vehicles
        public async Task<IActionResult> Index()
        {
            UserProfile();

            var applicationDbContext = _context.Vehicles
                .Include(v => v.Brand)
                .Include(v => v.Colour)
                .Include(v => v.EngineType)
                .Include(v => v.ExactType)
                .Include(v => v.GearBox)
                .Include(v => v.GeneralType)
                .Include(v => v.VehicleModel)
                .Include(v => v.WheelDrive)
                .Include(v => v.Pictures)
                .Include(v => v.Equipment)
                .Include(v => v.RentalVehicles)
                .Include(v => v.AirConditioning);

           
            ViewBag.EquipmentName = _context.EquipmentNames;

            List<EquipmentName> eqNameList = new List<EquipmentName>();
            foreach (var item in _context.EquipmentNames.ToList())
            {
                eqNameList.Add(item);
            }

            ViewBag.EQNameList = eqNameList;

            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Vehicles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicles
                .Include(v => v.Brand)
                .Include(v => v.Colour)
                .Include(v => v.EngineType)
                .Include(v => v.ExactType)
                .Include(v => v.GearBox)
                .Include(v => v.GeneralType)
                .Include(v => v.VehicleModel)
                .Include(v => v.WheelDrive)
                .FirstOrDefaultAsync(m => m.VehicleID == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // GET: Vehicles/Create
        public IActionResult Create()
        {
            UserProfile();
            ViewData["ColourID"] = new SelectList(_context.Colours, "ColourID", "Name");
            ViewData["EngineTypeID"] = new SelectList(_context.EngineTypes, "EngineTypeID", "Name");
            ViewData["ExactTypeID"] = new SelectList(_context.ExactTypes, "ExactTypeID", "Name");
            ViewData["GearBoxID"] = new SelectList(_context.GearBoxes, "GearBoxID", "Name");
            ViewData["GeneralTypeID"] = new SelectList(_context.GeneralTypes, "GeneralTypeID", "Name");
            
            ViewData["WheelDriveID"] = new SelectList(_context.WheelDrives, "WheelDriveID", "Name");

            //dodane
            ViewBag.AirConditioningID = new SelectList(_context.AirConditionings, "AirConditioningID", "Type");
            sendYear();
            //dodawanie wyposaznia wersja 2
            ViewBag.EquipmentsNameList = _context.EquipmentNames;
            //Model JS
            List<Brand> brandList = new List<Brand>();
            brandList = _context.Brands.ToList();
            //brandList.Insert(0, new Brand { BrandID = 0, Name = "Select first" });
            ViewBag.ListOfBrads = brandList;
            
            //ViewBag.ModelList = new SelectList(_context.VehicleModels, "VehicleModelID", "Name"); //na chwile

            return View();
        }

        //JS 
        public JsonResult GetModel( int BrandID)
        {
            List<VehicleModel> vehicleModelsList = new List<VehicleModel>();
            vehicleModelsList = _context.VehicleModels.Where(x => x.BrandID == BrandID).ToList();
            //vehicleModelsList.Insert(0, new VehicleModel { VehicleModelID = 0, Name = "select" });
            return Json(new SelectList(vehicleModelsList, "VehicleModelID", "Name"));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("VehicleID,BrandID,VehicleModelID,YearOfProduction,EngineCapacity,Description,GeneralTypeID,ExactTypeID,EngineTypeID,Mileage,ColourID,VIN,DateIn,DateOut,NumberPlate,EnginePower,GearBoxID,WheelDriveID,NumberOfSeats,NumberOfDoors,IsActive")] Vehicle vehicle)
        //public async Task<IActionResult> Create([Bind("VehicleID,BrandID,VehicleModelID,YearOfProduction,EngineCapacity,Description,ExactTypeID,EngineTypeID,Mileage,ColourID,VIN,NumberPlate,EnginePower,GearBoxID,WheelDriveID,NumberOfSeats,NumberOfDoors,IsActive")] Vehicle vehicle)
        public async Task<IActionResult> Create(Vehicle v, IFormFile file, List<int> Equipments)
        {
            if (ModelState.IsValid)
            {

                //dodawanie pojazu
                v.Blockade = false;
                _context.Add(v);

                #region stara wersja zjecia w folderze
                //stara wersja z img w folderze

                //ladowanie zdjecia
                //sprawdzam czy zdjecie jest dodane, jesli nie ustawiam na noimg.jpg
                //string tempURL;
                //if (file == null)
                //{
                //    tempURL = "..\\Upload\\Images\\noimg.png";
                //}
                //else
                //{
                //    tempURL = await ImageUpload(file);
                //}


                //Picture p = new Picture()
                //{
                //    URL = tempURL,
                //    IsActive = true,
                //};

                //dodanie pojazdu do zdjecia 
                //p.Vehicle = v;
                //dodanie zdjecia
                //_context.Pictures.Add(p);

                #endregion

                //dodanie zdjecia do sql
                v.Image = ImgToSQLAsync(file).Result.ToArray();



                //dodanie wyposazenia i przypisanie pojazdy do elementu wyposazenia
                //wyposazenie nowa wersja
                if (Equipments.Count > 0)
                {
                    foreach (var item in Equipments)
                    {
                        _context.Equipment.Add(new Equipment
                        {
                            Vehicle = v,
                            EquipmentNameID = item,
                            //Name = _context.EquipmentNames.FirstOrDefault(f => f.EquipmentNameID == item).Name,
                            Check = true
                        });
                    }
                }
                
                await _context.SaveChangesAsync();
            
                return RedirectToAction(nameof(Index));
            }

            ViewData["ColourID"] = new SelectList(_context.Colours, "ColourID", "ColourID", v.ColourID);
            ViewData["EngineTypeID"] = new SelectList(_context.EngineTypes, "EngineTypeID", "EngineTypeID", v.EngineTypeID);
            ViewData["ExactTypeID"] = new SelectList(_context.ExactTypes, "ExactTypeID", "ExactTypeID", v.ExactTypeID);
            ViewData["GearBoxID"] = new SelectList(_context.GearBoxes, "GearBoxID", "GearBoxID", v.GearBoxID);
            ViewData["GeneralTypeID"] = new SelectList(_context.GeneralTypes, "GeneralTypeID", "GeneralTypeID", v.GeneralTypeID);
            ViewData["VehicleModelID"] = new SelectList(_context.VehicleModels, "VehicleModelID", "VehicleModelID", v.VehicleModelID);
            ViewData["WheelDriveID"] = new SelectList(_context.WheelDrives, "WheelDriveID", "WheelDriveID", v.WheelDriveID);

            ViewBag.AirConditioningID = new SelectList(_context.AirConditionings, "AirConditioningID", "Type"/*, v.Equipment.AirConditioning.AirConditioningID*/);


            //dopisane
            List<Brand> brandList = new List<Brand>();
            brandList = _context.Brands.ToList();
            ViewBag.ListOfBrads = brandList;
            sendYear();
            ViewBag.EquipmentsNameList = _context.EquipmentNames;
            UserProfile();

            return View();
        }

        //GET: Vehicles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            UserProfile();
            if (id == null)
            {
                return NotFound();
            }

            //var vehicle = await _context.Vehicles.FindAsync(id);
            var vehicle = await _context.Vehicles.Include(i => i.Equipment).Include(i => i.Pictures).FirstOrDefaultAsync(m => m.VehicleID == id); ;
            if (vehicle == null)
            {
                return NotFound();
            }
            ViewData["ColourID"] = new SelectList(_context.Colours, "ColourID", "Name", vehicle.ColourID);
            ViewData["EngineTypeID"] = new SelectList(_context.EngineTypes, "EngineTypeID", "Name", vehicle.EngineTypeID);
            ViewData["ExactTypeID"] = new SelectList(_context.ExactTypes, "ExactTypeID", "Name", vehicle.ExactTypeID);
            ViewData["GearBoxID"] = new SelectList(_context.GearBoxes, "GearBoxID", "Name", vehicle.GearBoxID);
            ViewData["GeneralTypeID"] = new SelectList(_context.GeneralTypes, "GeneralTypeID", "Name", vehicle.GeneralTypeID);
            ViewData["WheelDriveID"] = new SelectList(_context.WheelDrives, "WheelDriveID", "Name", vehicle.WheelDriveID);

            //dodane

            //Lista Marek
            List<Brand> brandList = new List<Brand>();
            brandList = _context.Brands.ToList();
            ViewBag.ListOfBrads = brandList;
            //30 lat do wyboru
            sendYear();
            ViewBag.EquipmentsNameList = _context.EquipmentNames;
            ViewBag.AirConditioningID = new SelectList(_context.AirConditionings, "AirConditioningID", "Type");
            ViewBag.Equipments = _context.Equipment.Include(i => i.EquipmentName).Where(w => w.VehicleID == id);
            ViewBag.ModelList = new SelectList(_context.VehicleModels.Where(w=>w.BrandID == vehicle.BrandID), "VehicleModelID", "Name", vehicle.VehicleModelID); //lista Modeli do danego auta
            // wywalic modele z include !!


            //**************************************************** Equioment

            List<EquipmentName> eqNameList = new List<EquipmentName>();
            foreach (var item in _context.EquipmentNames.ToList())
            {
                eqNameList.Add(item);
            }
            ViewBag.EQNameList = eqNameList;

            List<EquipmentName> equipmentNameList = new List<EquipmentName>();
            eqNameList = await _context.EquipmentNames.ToListAsync();

            //Iteracja po nazwach wyposazenia
            //List Wyposazenia do wyswietlanie TEMP
            List<Equipment> TempList = new List<Equipment>();
            bool trueOrfalse;
            foreach (var name in eqNameList)
            {
                    //tu jest problem - is activ mozna wywalic !! nie jest tu potrzebne
                    if (_context.Equipment.FirstOrDefault(f => f.EquipmentNameID == name.EquipmentNameID && f.Check == true) == null)
                        trueOrfalse = false;
                    else
                        trueOrfalse = true;

                    TempList.Add(new Equipment()
                    {
                        EquipmentNameID = name.EquipmentNameID,
                        Name = name.Name,
                        Check = trueOrfalse
                    }
                    );
            }

            ViewBag.TempList = TempList;

            //**************************************************** Equioment Koniec
           
            
            
            return View(vehicle);
        }

        //POST: Vehicles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
 
        [HttpPost]
        [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(int id, [Bind("VehicleID,BrandID,VehicleModelID,YearOfProduction,YearOfCarProduction,RentalAgencyID,EngineCapacity,AirConditioningID,Description,GeneralTypeID,ExactTypeID,EngineTypeID,Mileage,ColourID,VIN,DateIn,DateOut,NumberPlate,EnginePower,GearBoxID,WheelDriveID,NumberOfSeats,NumberOfDoors,IsActive")] Vehicle vehicle, List<int> Equipments, IFormFile file)
            {
                if (id != vehicle.VehicleID)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                    
                    //dodanie zdjecia do sql
                    if(file != null)
                    vehicle.Image = ImgToSQLAsync(file).Result.ToArray();

                    //update vehicle
                    _context.Update(vehicle);

                    await _context.SaveChangesAsync();



                    //await _context.SaveChangesAsync();

                    //string tempURL;
                    //if (file == null)
                    //{
                    //    tempURL = "..\\Upload\\Images\\noimg.png";
                    //}
                    //else
                    //{
                    //    tempURL = await ImageUpload(file);
                    //}
                    //Picture p = new Picture()
                    //{
                    //    URL = await ImageUpload(file),
                    //    IsActive = true,
                    //};

                    //dodanie pojazdu do zdjecia 



                    ////Wyposazenie

                    //odejmuje 
                    //nowa kolekcja nie zawiera elementu starej
                    foreach (var oldCollectionItem in _context.Equipment.Where(w => w.VehicleID == vehicle.VehicleID))
                    {
                        if (!Equipments.Contains((int)oldCollectionItem.EquipmentNameID))
                        {
                            _context.Remove(oldCollectionItem);
                        }
                    }
                    await _context.SaveChangesAsync();
                    

                    //dodaje
                    //stara kolekcja nie posiada elementu nowej 
                    foreach (var newCollectionItem in Equipments)
                    {
                        var rezult = _context.Equipment.FirstOrDefault(f => f.EquipmentNameID == newCollectionItem && f.VehicleID == vehicle.VehicleID);
                        if ( rezult == null)
                        {
                            _context.Equipment.Add(new Equipment
                            {
                                Vehicle = vehicle,
                                EquipmentNameID = newCollectionItem,
                                Check = true
                            });

                        }                        
                    }

                    await _context.SaveChangesAsync();

                }
                catch (DbUpdateConcurrencyException)
                    {
                        if (!VehicleExists(vehicle.VehicleID))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return RedirectToAction(nameof(Index));
                }

                //*************************************************************************************************************************************88

            ViewData["ColourID"] = new SelectList(_context.Colours, "ColourID", "Name", vehicle.ColourID);
            ViewData["EngineTypeID"] = new SelectList(_context.EngineTypes, "EngineTypeID", "Name", vehicle.EngineTypeID);
            ViewData["ExactTypeID"] = new SelectList(_context.ExactTypes, "ExactTypeID", "Name", vehicle.ExactTypeID);
            ViewData["GearBoxID"] = new SelectList(_context.GearBoxes, "GearBoxID", "Name", vehicle.GearBoxID);
            ViewData["GeneralTypeID"] = new SelectList(_context.GeneralTypes, "GeneralTypeID", "Name", vehicle.GeneralTypeID);
            ViewData["WheelDriveID"] = new SelectList(_context.WheelDrives, "WheelDriveID", "Name", vehicle.WheelDriveID);


            //dodane

            //Lista Marek
            List<Brand> brandList = new List<Brand>();
            brandList = _context.Brands.ToList();
            ViewBag.ListOfBrads = brandList;
            //30 lat do wyboru
            sendYear();
            ViewBag.EquipmentsNameList = _context.EquipmentNames;
            ViewBag.AirConditioningID = new SelectList(_context.AirConditionings, "AirConditioningID", "Type");
            // ViewBag.AirConditioningID = new SelectList(_context.AirConditionings, "AirConditioningID", "Type", vehicle.AirConditioning.AirConditioningID) ;


            //**************************************************** Equioment

            List<EquipmentName> eqNameList = new List<EquipmentName>();
            foreach (var item in _context.EquipmentNames.ToList())
            {
                eqNameList.Add(item);
            }
            ViewBag.EQNameList = eqNameList;

            List<EquipmentName> equipmentNameList = new List<EquipmentName>();
            eqNameList = await _context.EquipmentNames.ToListAsync();

            //Iteracja po nazwach wyposazenia
            //List Wyposazenia do wyswietlanie TEMP
            List<Equipment> TempList = new List<Equipment>();
            bool trueOrfalse;
            foreach (var name in eqNameList)
            {
                //tu jest problem - is activ mozna wywalic !! nie jest tu potrzebne
                if (_context.Equipment.FirstOrDefault(f => f.EquipmentNameID == name.EquipmentNameID && f.Check == true) == null)
                    trueOrfalse = false;
                else
                    trueOrfalse = true;

                TempList.Add(new Equipment()
                {
                    EquipmentNameID = name.EquipmentNameID,
                    Name = name.Name,
                    Check = trueOrfalse
                }
                );
            }

            ViewBag.TempList = TempList;

            //**************************************************** Equioment Koniec



            //*************************************************************************************************************************************88

            UserProfile();
            return View(vehicle);
        }

        // GET: Vehicles/Delete/
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicles
                .Include(v => v.Brand)
                .Include(v => v.Colour)
                .Include(v => v.EngineType)
                .Include(v => v.ExactType)
                .Include(v => v.GearBox)
                .Include(v => v.GeneralType)
                .Include(v => v.VehicleModel)
                .Include(v => v.WheelDrive)
                .FirstOrDefaultAsync(m => m.VehicleID == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // POST: Vehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicle = await _context.Vehicles.FindAsync(id);
            _context.Vehicles.Remove(vehicle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleExists(int id)
        {
            return _context.Vehicles.Any(e => e.VehicleID == id);
        }

        private async Task<MemoryStream> ImgToSQLAsync(IFormFile file)
        {
            int w = 650;
            int h = 399;

            var stream = new MemoryStream();
            await file.CopyToAsync(stream);
            var image = Image.FromStream(stream);
            Image imageR = ImageResize.ScaleAndCrop(image,w,h);
            var streamToReturn = new MemoryStream();
            imageR.Save(streamToReturn, image.RawFormat);
            return streamToReturn;
        }
        


        //Funkcja uzywana przez Create
        private async Task<string> ImageUpload(IFormFile file)
        {
            if(file != null && file.Length > 0)
            {
                var imagePath = @"\Upload\Images\";
                var uploadPath = _env.WebRootPath + imagePath;

                //Sprawdzam katalog
                if(!Directory.Exists(uploadPath))
                {
                    Directory.CreateDirectory(uploadPath);
                }

                //Tworze unikalną nazwe pliku
                var uniqFileName = Guid.NewGuid().ToString();
                var filename = Path.GetFileName(uniqFileName + "." + file.FileName.Split(".")[1].ToLower());
                string fullPath = uploadPath + filename;

                imagePath = imagePath + @"\";
                var filePath = @".." + Path.Combine(imagePath, filename);

                using (var fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }

                //ViewData["FileLocation"] = filePath;
                return filePath;
            }
            //return RedirectToAction(nameof(Create));
            //return View("Create");

            //*********************************************  tu powninno zwracac domysle ustwione zdjecie albo pusty string..
            return "";
        }

        private void sendYear()
        {
            //Funkcja generuje 30 ostatnich lat do wyboru rocznika pojazdu
            List<int> listYear = new List<int>();
            int yearNow = DateTime.Now.Year;
            for (int i = 0; i < 30; i++)
            {
                listYear.Add(yearNow--);
            }
            ViewBag.YearOfProduction = new SelectList(listYear);

        }

        public async Task<IActionResult> Activation(int? id)
        {
            var v = _context.Vehicles.FirstOrDefault(f => f.VehicleID == id);
            v.Blockade = !v.Blockade;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
