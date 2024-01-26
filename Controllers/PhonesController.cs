using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MVC_Telefon_Kayit.Infrastructure.Services.Interface;
using MVC_Telefon_Kayit.Models.DTO_s;
using MVC_Telefon_Kayit.Models.Entities.Concrete;
using MVC_Telefon_Kayit.Models.ViewModels;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MVC_Telefon_Kayit.Controllers
{
    public class PhonesController : Controller
    {
        private readonly IPhoneRepository _phoneRepo;

        public PhonesController(IPhoneRepository phoneRepo)
        {
            _phoneRepo = phoneRepo;
        }

        public IActionResult Index()
        {
            var phones = _phoneRepo.GetAll();
            List<GetPhoneVM> model = new List<GetPhoneVM>();

            foreach (var phone in phones)
            {
                var viewModel = new GetPhoneVM
                {
                    Id = phone.Id,
                    Brand = phone.Brand,
                    Modelo = phone.Modelo,
                    BataryCapasity = phone.BataryCapasity,
                    Piece = phone.Piece,
                    CreatedDate = phone.CreatedDate,
                    UpdatedDate = phone.UpdatedDate,
                    Status = phone.Status,
                };
                model.Add(viewModel);
            }
            return View(model);
        }
        public IActionResult CreatePhone() => View();

        [HttpPost]
        public IActionResult CreatePhone(CreatePhoneDTO model)
        {
            if (ModelState.IsValid)
            {
                var phone = new Phone
                {
                    Brand = model.Brand,
                    Modelo = model.Modelo,
                    BataryCapasity = model.BataryCapasity,
                    Piece = model.Piece
                };
                _phoneRepo.Add(phone);
                TempData["Success"] = $"{phone.Brand} {phone.Modelo} marka telefon sisteme kaydedilmiştir!";
                return RedirectToAction("Index");
            }
            TempData["Error"] = "Lütfen aşağıdaki kurallara uyunuz!";
            return View(model);
        }

        [HttpGet]
        public IActionResult UpdatePhone(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            var phone = _phoneRepo.GetById(id);
            if (phone == null)
            {
                return NotFound();
            }

            var model = new UpdatePhoneDTO
            {
                Id = phone.Id,
                Brand = phone.Brand,
                Modelo = phone.Modelo,
                BataryCapasity = phone.BataryCapasity,
                Piece = phone.Piece
            };
            return View(model);

        }

        [HttpPost]
        public IActionResult UpdatePhone(UpdatePhoneDTO model)
        {
            if (ModelState.IsValid)
            {
                var phone = _phoneRepo.GetById(model.Id);
                if (phone is null)
                {
                    return NotFound();
                }
                phone.Brand = model.Brand;
                phone.Modelo = model.Modelo;
                phone.BataryCapasity = model.BataryCapasity;
                phone.Piece = model.Piece;
                _phoneRepo.Update(phone);
                TempData["Success"] = $"{phone.Brand} {phone.Modelo} markalı telefon güncellenmiştir!";
                return RedirectToAction("Index");
            }
            TempData["Error"] = "Lütfen aşağıdaki kurallara uyunuz!";
            return View(model);
        }

        public IActionResult DeletePhone(int id) 
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            var phone = _phoneRepo.GetById(id);
            if (phone == null)
            {
                return NotFound();
            }
            
            TempData["Success"] = $"{phone.Brand} {phone.Modelo} markalı telefon silinmiştir!";
            return RedirectToAction("Index");
        }
        
    }
}
