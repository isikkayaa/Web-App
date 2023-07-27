using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json.Serialization;
using Project.Entities;
using Project.Models;

namespace Project.Controllers
{
    public class UserController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        private readonly IMapper _mapper;
        public UserController(DatabaseContext databaseContext, IMapper mapper = null)
        {

            _databaseContext = databaseContext;
            _mapper = mapper;
        }

        public IActionResult Index()

        {
            List<UserViewModel> users =
                _databaseContext.UserData.ToList().Select(x => _mapper.Map<UserViewModel>(x)).ToList();



            return View(users);
        }

        //Index var action yok o yüzden hemen olustruduk create
        public IActionResult Create()

        {
           

            return View();
        }


        [HttpPost]
        public IActionResult Create(CreateUserModel model)

        {
            if (ModelState.IsValid)
            {
                if (_databaseContext.UserData.Any(x => x.Username.ToLower() == model.Username.ToLower()))
                {
                    ModelState.AddModelError(nameof(model.Username), "Username is already exists.");
                    return View(model);
                }

                User user = _mapper.Map<User>(model);
                _databaseContext.UserData.Add(user);
                _databaseContext.SaveChanges();

                return RedirectToAction(nameof(Index));

            }


            return View(model);
        }

        public IActionResult Edit(Guid id)

        {
            User user = _databaseContext.UserData.Find(id);
            EditUserModel model = _mapper.Map<EditUserModel>(user);


            return View(model);
        }


        [HttpPost]
        public IActionResult Edit(Guid id,EditUserModel model)

        {
            if (ModelState.IsValid)
            {
                if (_databaseContext.UserData.Any(x => x.Username.ToLower() == model.Username.ToLower() && x.Id != id))
                {
                    ModelState.AddModelError(nameof(model.Username), "Username is already exists.");
                    return View(model);
                }
                User user = _databaseContext.UserData.Find(id);

                /*datavalidse userı bul update etcez tüm özelliklerini modelden usera*/

                _mapper.Map(model, user); 

                _databaseContext.SaveChanges();

                return RedirectToAction(nameof(Index));

            }


            return View(model);
        }



        
        public IActionResult Delete(Guid id)

        {
            
                User user = _databaseContext.UserData.Find(id);

            /*datavalidse userı bul update etcez tüm özelliklerini modelden usera*/


            if (user != null)
            {

                _databaseContext.UserData.Remove(user);

                _databaseContext.SaveChanges();
            }
           

                return RedirectToAction(nameof(Index));

            }

        }
    }




        

