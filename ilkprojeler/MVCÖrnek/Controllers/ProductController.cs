using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCÖrnek.Models;
using MVCÖrnek.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCÖrnek.Controllers
{
  //  [NonController] bu ne diye bakma aşağıda yazıyor.
    public class ProductController : Controller
    {


        //Action türleri dönüş tipleri
        /*
          Bildiğimiz üzere client'ten gelen requesti controller karşılayıp
        uygun actiona yönlendiriyordu..
        Actionda ihtiyaca göre operasyonu yönetiyordu
        İşte bu durumlarda action içindeki döndürülen dönen kısımların farklı türleri mevcut.

         */
        #region ViewResult
        /* public ViewResult GetProducts()
         {
             //Response olarak bir view dosyasını(cshtml) render yapmamı sağlar.
             ViewResult result = View();
             return result;
         }*/
        #endregion

        #region PartialViewResult
        /*
        public PartialViewResult GetProducts()
        {
            //  Respone olarak bir view dosyasını (cshtml) render (düzenleme işleme) yapmamı sağlar.
            //  Diğeri bir bütün olarak web sayfasını ele alırken buna belli bir kısım üzerinde işlem yapar.
            PartialViewResult result =  PartialView();
            return result;

        }
        */
        #endregion

        #region JsonResult
        //Üretilen datayı json türüne dönüştürüp döndüren bir action tipidir.
        /*
                public JsonResult GetProducts()
                {
                    JsonResult result = Json(new Product
                    {
                        ID=3,
                        ProductName="SPhone",
                        ProductPrince=130
                    });
                    return result;
                }*/
        #endregion

        #region EmptyResult
        /*
        public EmptyResult GetProducts()
        {
            return new EmptyResult();

        }*/
        #endregion

        #region ContentResult
        /*
                public ContentResult GetProducts()
                {

                    ContentResult result = Content("Haftaya Berivanların Düğününe Herkes Davetlidir");

                    return result;

               }*/
        #endregion

        #region ActionResult 

        //diğer bütün hepsini burada kullanabiliyoruz

        /*  public ActionResult GetProducts()
          {
              //gelen isteğe göre geriye döndürülecek action türleri farklılık gösterdiğinde kullanılır.
             if(true)
              {
                  return Json(new object());
              }
             else if(false)
              {
                  return Content("Ben Bir Contentimm");
              }
          }*/
        #endregion


        //Nonaction - Noncontroller Kavramları****//
        /*
           Kontroller iş yapan değil işi yönetenlerdir 
        Actionlarda onların yardımcıları gibi çalışırlar 
        Onlarda iş yapmaz yönetir (servisleri çağırır yönlendirmeler yapar vb)
        NOT: Kontrolırlar sınıfın içerisindeki metod türü ne olursa olsun Actiondur.
         */

        #region Örnek
        //[NonAction] bunu kullanırsam yazdığımız yeri iptal eder.
        /*
         public IActionResult Index()
         {
             Y();
             return View();
         }

         //NOT: Kontrolırlar sınıfın içerisindeki metod türü ne olursa olsun action 
         //yani dışarıdan request(istek) karşılarlar 
         public void Y()
         {

         }
        */
        #endregion
        /*
           public IActionResult IndexText()  //idextest oluşturmak
           {
               return View();//sayfayı görüntülemek için
           }

          VİEWE VERİ TAŞIMA - VERİ YAPILANMASI//
        */
        /* 
           Css html jscript gibi yapılar evrenseldir.
        Ancak cshtml dosyaları sadece bu teknolojiye özeldir ve bunu html olarak olarak görür.

          */

        public IActionResult Index()
        {
/*
            var products = new List<Product>
            {
                new Product{ID=1,ProductName="IPhone",ProductPrince=400},
                new Product{ID=2,ProductName="Samsung",ProductPrince=300},
                new Product{ID=4,ProductName="Vestel",ProductPrince=250},
            };
       */
            #region MODEL ESASLI VERİ GÖNDERİMİ

            // return View(products);
            #endregion

            #region VİEWBAG
            //Taşınacak olan veriyi dinamik bir şekilde taşımamızı sağlayan kontroldür(değişkenle)
           // ViewBag.products = products;

            #endregion

            #region VİEWDATA

            //Bu kontrolde viewbag de olduğu gibi veri taşımamızı sağlar

            // ViewData["products"] = products;
            #endregion

            #region TEMDATA
            //Buda bir çeşit veri taşıma kontrolüdür..
          //  TempData["products"] = products;

            #endregion

            return View();
        }


        /*VİEWE BİRDEN FAZLA VERİ GÖNDERİMİ */
        /* public IActionResult GetProducts()
         {
             Product product = new Product
             {
                 ID = 5,
                 ProductName = "Alcatel",
                 ProductPrince = 200
             };

             Customer customer = new Customer()
             {
                 ID=5,
                 Name="Aybike",
                 Surname="Akgün"
             };

             CustomerProduct customerProduct = new CustomerProduct
             {
                 Customer = customer,
                 Product = product
             };
             return View(customerProduct);
          }
            */

        public IActionResult GetProducts()
        {
           //ViewBag Bildiğiniz bizim veri taşıma metodlarımdan birisi mesajımı dinamik bir nesneyle gönderdim
            ViewBag.Mesaj = "Deneme Mesajı";
            //Customer nesnesini model bazlı göndermiş oldum
            //customerdan türettiğim nesnemi model bazlı göndermiş oldum
            Customer c = new Customer
            {
                Name = "Ömer" 
            };
            return View(c);
        }

        public IActionResult CreateCustomer()
        {
            return View();
        }

        //View(cshtml) üzerinden oluşturduğumuz formumuzdan 
        //post ettiğimiz verileri controller tarafında yine post attık.
        //belirleidğimiz method içerisinde yakaldık ve break pointle kontrol ettik.

        [HttpPost]
        public IActionResult CreateCustomer(string txtName, string txtSurname)
        {
            return View();
        }

        //Modeldeki Sınıfımı kullanarak post işlemini gerçekleştirdim
        //Ama bunu yaparken viewle bağlantılı olan default metodumuda eklmeyi unutmamalıyım.
        
        public IActionResult MusteriOlustur()
        {
            return View();
        }
        //metoduma post özelliğimi ekleyebilmem için aşağıdaki atrribute kullandım.
        [HttpPost] //attribute 
        public IActionResult MusteriOlustur(Customer customer)
        {
            return View();
        }

        public IActionResult MusteriVeliNimettir ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MusteriVeliNimettir(IFormCollection deger)
        {
            var deg1 = deger["txtVal1"].ToString();
            var deg2 = deger["txtVal2"].ToString();
            return View();
        }

       /* public IActionResult TakeData(string c,string m, string l)
        {
            return View();
        }
        */
        public IActionResult TakeData()
        {
            var queryString = Request.QueryString;

            var c = Request.Query["c"].ToString();
            var m = Request.Query["m"].ToString();
            var l = Request.Query["l"].ToString();

            return View();
        }


        public IActionResult UrunDogrulama()
        {
            var tuple = (new Customer(), new Product());
            return View();
        }

        [HttpPost]
        public IActionResult UrunDogrulama(Customer model)
        {
            if(ModelState.IsValid)
            {
                //Kullanıcı işlemleri
                //log işlemleri 
                //veri taşıma vb
              //  ViewBag.HMesaji = ModelState.Values.FirstOrDefault(x => x.ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid).Errors[0000].ErrorMessage;
                return null;
            }


            return View();
        }
    }
}
