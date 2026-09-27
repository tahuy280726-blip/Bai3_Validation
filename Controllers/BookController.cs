using Bai3_Validation.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bai3_Validation.Controllers;

public class BookController : Controller
{
    [HttpGet]
    public IActionResult Create()
    {
        return View(new Book());
    }

    [HttpPost]
    public IActionResult Create(Book book)
    {
        if (!ModelState.IsValid)
        {
            return View(book);
        }

        ViewBag.Message = "Dữ liệu hợp lệ - thêm sách thành công!";
        return View(book);
    }
}
