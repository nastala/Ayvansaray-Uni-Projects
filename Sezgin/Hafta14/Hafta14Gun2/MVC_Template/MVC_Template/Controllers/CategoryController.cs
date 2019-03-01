using MVC_Template.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Template.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        NorthwindContext ctx = new NorthwindContext();
        // GET: Category
        public ActionResult Index()
        {
            List<Category> ktg = ctx.Categories.ToList();
            return View(ktg);
        }
        // GET (Ekranı getiriyor.)
        public ActionResult Ekle()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Ekle([Bind(Include = "CategoryName,Description")] Category ktg, HttpPostedFileBase picture)
        {
            if (picture == null)
                return View();

            ktg.Picture = ConvertToBytes(picture);

            if (ModelState.IsValid)
            {
                ctx.Categories.Add(ktg);
                ctx.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }
        //Category Picture nesnesi DataBase'de byte[] şeklinde tutulduğu için seçilen resmi byte[]'e çevrilmesini sağlayan method.
        public byte[] ConvertToBytes(HttpPostedFileBase image)
        {
            byte[] imageBytes = null;
            BinaryReader reader = new BinaryReader(image.InputStream);
            imageBytes = reader.ReadBytes((int)image.ContentLength);
            byte[] bytes = new byte[imageBytes.Length + 78];
            Array.Copy(imageBytes, 0, bytes, 78, imageBytes.Length);
            return bytes;
        }
        //Silme işlemi için 3 farklı yöntem kullanabiliriz.
        //1-silme işlemi için ayrı bir sayfaya yönlendirilir. Orada soru sorulur. Evet ise silinir,hayır ise silme işlemi yapılmaz
        //2-Silme kutusuna basılınca browser'ın kendi ayar kutusu kullanılır. bu ayar kutusunda kayıt silinsin mi? diye sordurulur. tamam denilirse silinir. hayır denilirse silme işlemi yapılmaz. bu işlem asenkron bir işlemdir. Buradaki sıkıntı browser tarafındaki allert kutusu (ayar) 3-4 kez çıkınca bir daha gösterme checkbox'ı eklenir ve check edilirse, bir daha silme işlemi yapılamaz. (checkbox ayar kutusuna girilip nereden kaldırılıyorsa oradan kaldırana kadar)
        //3-yöntemde asenkron bir yöntemdir. Modal kutusu kullanılır. Bizim çalışmamızda Template'imizin hazır modal kutuları var bunlardan birini seçeceğiz. sil butonuna Tıklayınca silme işlemi için bu modal kutucuğu açılacak ve silme işlemi orada yapılacak. Bunun için ve 2. yöntem için ajax yöntemini kullanmamız gerekiyor.(AJAX_ Asynchronous JavaScript and XML) 
        //Ajax kullanmadığınızda Web sayfanızda bir butona tıkladığınızda cursor dönmeye başlar. web sayfanızın hepsi server'a gider,işlenir. Sonuç html olarak gelir ve browser'da gösterilir.
        [HttpPost]
        public void Sil(int id)
        {
            Category k = ctx.Categories.FirstOrDefault(x => x.CategoryID == id);
            ctx.Categories.Remove(k);
            ctx.SaveChanges();
        }

        public ActionResult Guncelle(int? id)
        {
            if (id == null)
                return RedirectToAction("Index");

            Category category = ctx.Categories.Find(id);

            if (category == null)
                return HttpNotFound();

            return View(category);
        }

        [HttpPost]
        public ActionResult Guncelle([Bind(Include = "CategoryID, CategoryName, Description")] Category ktg, HttpPostedFileBase picture)
        {
            if (ModelState.IsValid)
            {
                Category category = ctx.Categories.Find(ktg.CategoryID);
                category.CategoryName = ktg.CategoryName;
                category.Description = ktg.Description;

                if (picture != null)
                    category.Picture = ConvertToBytes(picture);

                ctx.Entry(category).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}