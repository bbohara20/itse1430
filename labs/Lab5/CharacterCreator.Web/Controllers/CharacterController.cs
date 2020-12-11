/*Name: Bam Bohara
 *Course: ITSE 1430
 *Lab: Character Creator
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

using CharacterCreator.Web.Models;
namespace CharacterCreator.Web.Controllers
{
    public class CharacterController : Controller
    {
        // GET: Character
        public ActionResult Index ()
        {
            var characters = s_memoryDatabase.GetAll();
            IEnumerable<CharacterModel> model = characters.Select(x => new CharacterModel(x))
                                                          .OrderBy(x => x.Name);
            return View("List", model);
        }

        public ActionResult Details ( int id )
        {
            var character = s_memoryDatabase.Get(id);
            if (character == null)
                return HttpNotFound(); //404

            return View(new CharacterModel(character));
        }

        public ActionResult Edit ( int id )
        {
            var character = s_memoryDatabase.Get(id);
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
                    s_memoryDatabase.Update(model.Id, model.ToCharacter());
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
                    var character = s_memoryDatabase.Add(model.ToCharacter());

                    return RedirectToAction(nameof(Details), new { id = character.Id });
                } catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                };
            };
            return View(model);
        }

        // GET: Delete/{id}
        public ActionResult Delete ( int id )
        {
            var character = s_memoryDatabase.Get(id);
            if (character == null)
                return HttpNotFound(); //404

            return View(new CharacterModel(character));
        }

        [HttpPost]
        public ActionResult Delete ( CharacterModel model )
        {
            //   Post, Redirect, Get
            try
            {
                s_memoryDatabase.Delete(model.Id);

                //Redirect to list
                return RedirectToAction(nameof(Index));
            } catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            };

            return View(model);
        }

        private static readonly ICharacterRoster s_memoryDatabase = new MemoryCharacterRoster();
    }

}
