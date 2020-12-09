using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CharacterCreator.Web.Models;
using System.ComponentModel.DataAnnotations;


namespace CharacterCreator.Web.Controllers
{
    public class CharacterController : Controller
    {
        // GET: Character
        public ActionResult Index()
        {
            var characters = _memoryDatabase.GetAll();
            IEnumerable<CharacterModel> model = characters.Select(x => new CharacterModel(x));

              return View("List", model);
        }
       
        public ActionResult Details ( int id )
        {
            var character = _memoryDatabase.Get(id);
            if (character == null)
                return HttpNotFound(); //404

            return View(new CharacterModel(character));
        }
        
        public ActionResult Edit ( int id )
        {
            var character = _memoryDatabase.Get(id);
            if (character == null)
                return HttpNotFound(); //404

            return View(new CharacterModel(character));
        }
       
        // POST: Edit
        [HttpPost]
        public ActionResult Edit ( CharacterModel model )
        {
            
          //Check for model validity
            if (ModelState.IsValid)
            {
                try
                {
                    _memoryDatabase.Update(model.Id, model.ToCharacter());
                    return RedirectToAction(nameof(Details), new { id = model.Id });
                } catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);

                };
            };

            return View(model);
        }
        public ActionResult Create () => View(new CharacterModel());

        // POST: Create
        [HttpPost]
        public ActionResult Create ( CharacterModel model )
        {
            //Check for model validity
            if (ModelState.IsValid)
            {
                try
                {
                    var character = _memoryDatabase.Add(model.ToCharacter());
                   return RedirectToAction(nameof(Details), new { id = character.Id });
                } catch (Exception e)
                {
                     ModelState.AddModelError("", e.Message);
                };
            };
                      return View(model);
        }
          private readonly ICharacterRoster _memoryDatabase = new MemoryCharacterRoster();
    }

 }
