﻿using LazZiya.ImageResize;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rental.Data;
using Rental.Data.Data.Areas.Identity.Data;
using Rental_Data.Data.Rental;
using Rental_PI_KF.Controllers.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

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
        public async Task<IActionResult> Index(string generalType, string search, int? exactType, int? gearBox, int? engineType, 
                                               int? enginePower,int? rentalItemBrand, string cut, bool active = true, bool table = false)
        {
            var applicationDbContext = _context.Vehicles.
                Include(v => v.Brand).
                Include(v => v.Colour).
                Include(v => v.EngineType).
                Include(v => v.ExactType).
                Include(v => v.GearBox).
                Include(v => v.GeneralType).
                Include(v => v.VehicleModel).
                Include(v => v.WheelDrive).
                Include(v => v.Pictures).
                Include(v => v.Equipment).
                Include(v => v.RentalVehicles).
                Include(v => v.AirConditioning).
                Include(v => v.CurrentPrices).
                Where(w => w.IsActive == active).
                ToList();
            
            if(generalType != null)
            {
                applicationDbContext = applicationDbContext.Where(w => w.GeneralType.Name == generalType).ToList();
            }

            ViewBag.EQNameList = await _context.EquipmentNames.ToListAsync();
            ViewBag.GeneraltypeNow = generalType;
            ViewBag.Active = active;
            ViewBag.Table = table;
            ViewBag.Generaltypes = await _context.GeneralTypes.ToListAsync();

            #region dodatkowe opcje wyszukiwania

            if (search != null)
            {
                List<string> searchList = search.ToLower().Split(" ").ToList();

                if (cut != null)
                    searchList.Remove(cut);

                applicationDbContext = applicationDbContext.Where(w =>
                searchList.Contains(w.Brand.Name.ToLower()) ||
                searchList.Contains(w.VehicleModel.Name.ToLower()) ||
                searchList.Contains(w.Colour.Name.ToLower()) ||
                searchList.Contains(w.WheelDrive.Name.ToLower())
                ).ToList();
                ViewBag.Search = searchList;
                ViewBag.SearchString = string.Join(" ", searchList);
            }


            if (exactType != null)
            {
                applicationDbContext = applicationDbContext.Where(w => w.ExactTypeID == exactType).ToList();
                ViewBag.ExactType = new SelectList(applicationDbContext.Select(s => s.ExactType).Distinct(), "ExactTypeID", "Name", exactType);
            }
            else
            {
                ViewBag.ExactType = new SelectList(applicationDbContext.Select(s => s.ExactType).Distinct(), "ExactTypeID", "Name");
            }

            if (gearBox != null)
            {
                applicationDbContext = applicationDbContext.Where(w => w.GearBoxID == gearBox ).ToList();
                ViewBag.GearBox = new SelectList(_context.GearBoxes, "GearBoxID", "Name", gearBox);
            }
            else
            {
                ViewBag.GearBox = new SelectList(_context.GearBoxes, "GearBoxID", "Name");
            }

            if (engineType != null)
            {
                applicationDbContext = applicationDbContext.Where(w => w.EngineTypeID == engineType).ToList();
                ViewBag.EngineType = new SelectList(_context.EngineTypes, "EngineTypeID", "Name", engineType);
            }
            else
            {
                ViewBag.EngineType = new SelectList(_context.EngineTypes, "EngineTypeID", "Name");
            }

            if (enginePower != null)
            {
                applicationDbContext = applicationDbContext.Where(w => w.EnginePower >= enginePower).ToList();
                ViewBag.EnginePower = enginePower;
            }


            if (rentalItemBrand != null)
            {
                applicationDbContext = applicationDbContext.Where(w => w.BrandID == rentalItemBrand).ToList();
                ViewBag.RentalItemBrand = new SelectList(_context.Brands, "BrandID", "Name", rentalItemBrand);
            }
            else
            {
                ViewBag.RentalItemBrand = new SelectList(_context.Brands, "BrandID", "Name", rentalItemBrand);
            }

            #endregion dodatkowe opcje wyszukiwania

            return View(applicationDbContext);
        }

        // GET: Vehicles/Create
        public IActionResult Create()
        {
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
            ViewBag.ListOfBrads = brandList;

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
        public async Task<IActionResult> Create(Vehicle v, IFormFile file, List<int> Equipments,
                                                decimal price_Day, decimal price_Weekend, decimal price_Week, decimal price_Long)
        {
            if (ModelState.IsValid)
            {
                //dodawanie pojazu
                v.GeneralTypeID = _context.ExactTypes.FirstOrDefaultAsync(f => f.ExactTypeID == v.ExactTypeID).Result.GeneralTypeID;
                v.Blockade = false;
                v.IsActive = true;
                v.RentalAgencyID = GetUser().RentalAgencyID;
                _context.Add(v);

                //dodanie zdjecia do bazy sql
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
                            Check = true
                        });
                    }
                }

                _context.CurrentPrices.Add(new CurrentPrice
                {
                    Vehicle = v,
                    PriceDay = price_Day,
                    PriceWeekend = price_Weekend,
                    PriceWeek = price_Week,
                    PriceLong = price_Long,
                    DateTimeFrom = DateTime.Now.Date
                });

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
            ViewBag.AirConditioningID = new SelectList(_context.AirConditionings, "AirConditioningID", "Type");
            ViewBag.ListOfBrads = _context.Brands.ToList();
            sendYear();
            ViewBag.EquipmentsNameList = _context.EquipmentNames;

            return View(v);
        }

        //GET: Vehicles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicles.
                Include(i => i.Brand).
                Include(i => i.VehicleModel).
                Include(i => i.Equipment).
                Include(i => i.Pictures).
                Include(i => i.CurrentPrices).
                FirstOrDefaultAsync(m => m.VehicleID == id);
            
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
            ViewBag.ListOfBrads = _context.Brands.ToList();
            //30 lat do wyboru
            sendYear();
            ViewBag.AirConditioningID = new SelectList(_context.AirConditionings, "AirConditioningID", "Type");
            ViewBag.ModelList = new SelectList(_context.VehicleModels.Where(w=>w.BrandID == vehicle.BrandID), "VehicleModelID", "Name", vehicle.VehicleModelID); //lista Modeli do danego auta
            await sendEquipmentList(id);

            return View(vehicle);
        }

        //POST: Vehicles/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VehicleID,BrandID,VehicleModelID,YearOfProduction,YearOfCarProduction,RentalAgencyID,EngineCapacity,AirConditioningID,Description,GeneralTypeID,ExactTypeID,EngineTypeID,Mileage,ColourID,VIN,DateIn,DateOut,NumberPlate,EnginePower,GearBoxID,WheelDriveID,NumberOfSeats,NumberOfDoors,Image,Blockade")] Vehicle vehicle, 
                                              List<int> Equipments, IFormFile file, decimal? price_Day, decimal? price_Weekend, decimal? price_Week,
                                              decimal? price_Long, DateTime? datetime_to, List<int> removePrice)
        {
            if (id != vehicle.VehicleID)
            {
                return NotFound();
            }

            //ustawiam typ generalny po typie dokladnym
            vehicle.GeneralTypeID = _context.ExactTypes.FirstOrDefault(w => w.ExactTypeID == vehicle.ExactTypeID).GeneralTypeID;
            vehicle.IsActive = true;
            vehicle.RentalAgencyID = GetUser().RentalAgencyID;

            if (ModelState.IsValid)
            {
                try
                {
                    //dodanie zdjecia do sql
                    if (file != null)
                    {
                        vehicle.Image = ImgToSQLAsync(file).Result.ToArray();
                    }
                    _context.Update(vehicle);

                    //Wyposazenie
                    //odejmuje 
                    //nowa kolekcja nie zawiera elementu starej
                    foreach (var oldCollectionItem in _context.Equipment.Where(w => w.VehicleID == vehicle.VehicleID))
                    {
                        if (!Equipments.Contains((int)oldCollectionItem.EquipmentNameID))
                        {
                            _context.Remove(oldCollectionItem);
                        }
                    }
                    //await _context.SaveChangesAsync();

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
                    
                    //usuwam wybrane zaplanowane ceny
                    if(removePrice.Count > 0)
                    {
                        foreach (var itemRemove in removePrice)
                        {
                            var rezultItemRemove = _context.CurrentPrices.FirstOrDefault(f => f.CurrentPriceID == itemRemove);
                            _context.CurrentPrices.RemoveRange(rezultItemRemove);
                        }
                    }

                    if (price_Day != null && price_Weekend != null && price_Week != null && price_Long != null && datetime_to != null)
                    {
                        //usuwam - jesli data jest ta sama
                        var sameDate = _context.CurrentPrices.Where(w => w.VehicleID == vehicle.VehicleID && w.DateTimeFrom.Value.Date.CompareTo(datetime_to.Value.Date) == 0).ToList();
                        if (sameDate.Count() > 0)
                        {
                            _context.CurrentPrices.RemoveRange(sameDate);
                            _context.SaveChanges();
                        }

                        //dodaje nowy
                        _context.CurrentPrices.Add(new CurrentPrice
                        {
                            Vehicle = vehicle,
                            PriceDay = price_Day,
                            PriceWeekend = price_Weekend,
                            PriceWeek = price_Week,
                            PriceLong = price_Long,
                            DateTimeFrom = datetime_to
                        });
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

            ViewData["ColourID"] = new SelectList(_context.Colours, "ColourID", "Name", vehicle.ColourID);
            ViewData["EngineTypeID"] = new SelectList(_context.EngineTypes, "EngineTypeID", "Name", vehicle.EngineTypeID);
            ViewData["ExactTypeID"] = new SelectList(_context.ExactTypes, "ExactTypeID", "Name", vehicle.ExactTypeID);
            ViewData["GearBoxID"] = new SelectList(_context.GearBoxes, "GearBoxID", "Name", vehicle.GearBoxID);
            ViewData["GeneralTypeID"] = new SelectList(_context.GeneralTypes, "GeneralTypeID", "Name", vehicle.GeneralTypeID);
            ViewData["WheelDriveID"] = new SelectList(_context.WheelDrives, "WheelDriveID", "Name", vehicle.WheelDriveID);
            //dodane
            //Lista Marek
            ViewBag.ListOfBrads = _context.Brands.ToList();
            //30 lat do wyboru
            sendYear();
            ViewBag.EquipmentsNameList = _context.EquipmentNames;
            ViewBag.AirConditioningID = new SelectList(_context.AirConditionings, "AirConditioningID", "Type");
            await sendEquipmentList(id);
            
            return View(vehicle);
        }

        // POST: Vehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicle = await _context.Vehicles.FindAsync(id);
            vehicle.IsActive = false;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // POST: Vehicles/Restore/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Restore(int id)
        {
            var vehicle = await _context.Vehicles.FindAsync(id);
            vehicle.IsActive = true;
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
            var v = await _context.Vehicles.FindAsync(id);
            if (v.Blockade == null)
                v.Blockade = false;
            v.Blockade = !v.Blockade;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private async Task sendEquipmentList(int? id)
        {
            //lista wszystkich nazw equipment
            var eqNameList = await _context.EquipmentNames.ToListAsync();

            //Iteracja po nazwach wyposazenia
            //List Wyposazenia do wyswietlanie TEMP
            List<Equipment> TempList = new List<Equipment>();
            bool trueOrfalse;
            foreach (var name in eqNameList)
            {
                //tu jest problem - is activ mozna wywalic !! nie jest tu potrzebne
                //zaznaczamy te ktore posiada juz pojazd
                if (_context.Equipment.FirstOrDefault(f =>
                    f.EquipmentNameID == name.EquipmentNameID &&
                    f.Check == true &&
                    f.VehicleID == id
                    ) == null)
                    trueOrfalse = false;
                else
                    trueOrfalse = true;

                //dodaje do listy temp
                TempList.Add(new Equipment()
                {
                    EquipmentNameID = name.EquipmentNameID,
                    Name = name.Name,
                    Check = trueOrfalse
                });
            }

            ViewBag.TempList = TempList;
        }

        //js 
        public async Task<ActionResult> GetGeneraltypes()
        {
            var GeneralTypesList = await _context.GeneralTypes.Select(s => s.Name).ToListAsync();
            return Json(GeneralTypesList);
        }
    }
}
