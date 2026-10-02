using Microsoft.AspNetCore.Mvc;
using GearGo.Models;

namespace GearGo.Controllers
{
    public class EquipmentController : Controller
    {
        
        private static readonly List<Equipment> _mockInventory = new()
        {
            new Equipment { Id = 1, Name = "4-Person Camping Tent", Description = "Premium waterproof double-layer outdoor tent.", Category = "Camping", DailyRate = 220.00m, IsAvailable = true },
            new Equipment { Id = 2, Name = "Industrial Rotary Hammer Drill", Description = "Heavy-duty electric concrete drill machine.", Category = "Power Tools", DailyRate = 350.00m, IsAvailable = false },
            new Equipment { Id = 3, Name = "Professional Sound PA System", Description = "Dual active 15-inch speakers with microphones.", Category = "Event Equipment", DailyRate = 850.00m, IsAvailable = true }
        };

        
        public IActionResult Index()
        {
            return View(_mockInventory);
        }

        
        public IActionResult Details(int id)
        {
            var item = _mockInventory.FirstOrDefault(e => e.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }
    }
}
