using DatebaseFirstDemo.Models;
using DatebaseFirstDemo.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Webcenter.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewsCategoryController : BaseController
    {
        INewsCategoryRepository newsCatogoryRepository = null;
        public NewsCategoryController()
        {
            newsCatogoryRepository = new NewsCategoryRepository();
        }
        public IActionResult Index()
        {
            var result = newsCatogoryRepository.GetAll();
            return View(result);
        }
        // GET: Admin/Roles/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Create(NewsCategory  newcategory)
        {
            try
            {
               /* if (ModelState.IsValid)
                { */
                   newsCatogoryRepository.Insert(newcategory);
                    SetAlert("Insert Data is success!","success");
                    return Json(new { success = true });
               /* } */
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
            return Json(new { success = false });
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            NewsCategory newCategory = newsCatogoryRepository.GetById(id);
            var data = new
            {
                Id = newCategory.Id,
                Name = newCategory.CategoryName
                //các trường khác
            };
            return new JsonResult(new { success= true, data = data });
        }

        [HttpPost]
        public JsonResult Edit(NewsCategory newcategory)
        {
            try
            {
               /* if (ModelState.IsValid)
                {*/
                    newsCatogoryRepository.Update(newcategory);
                    SetAlert("Update Data is success!", "success");
              /*  } */
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
            return Json(new { success = true });
        }
        [HttpPost]
        public JsonResult Delete(NewsCategory newcategory)
        {
            try
            {
                /* if (ModelState.IsValid)
                 { */
                newsCatogoryRepository.Insert(newcategory);
                SetAlert("Insert Data is success!", "success");
                
                /* } */
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
            return Json(new { success = true });
        }
    }
}

