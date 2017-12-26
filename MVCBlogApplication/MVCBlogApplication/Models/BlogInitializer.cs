using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCBlogApplication.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category() { KategoriAdi="C#" },
                new Category() { KategoriAdi="Asp.Net MVC" },
                new Category() { KategoriAdi="Asp.Net WebForm" },
                new Category() { KategoriAdi="Windows Form" },

            };

            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();

            List<Blog> bloglar = new List<Blog>()
            {
                new Blog() {Baslik = "C# Delegates Hakkında", Aciklama = "5 temel tipten biri olan delegelerin kullanım amaçları, metot adresi saklamaktır. Bazen metotlarımızı, ihtiyacımız olduğu anda çalıştırmak isteyebiliriz. Olay(event) tabanlı programlama ve asenkron programlama yaparken, anonim metot yazarken delegelerden faydalanırız. Bir diğer kullanım amacı da, bir metoda parametre olarak başka bir metot verebilmektir.", EklenmeTarihi = DateTime.Now.AddDays(-15), Anasayfa=true, Onay = true, Icerik = "5 temel tipten biri olan delegelerin kullanım amaçları, metot adresi saklamaktır. Bazen metotlarımızı, ihtiyacımız olduğu anda çalıştırmak isteyebiliriz. Olay(event) tabanlı programlama ve asenkron programlama yaparken, anonim metot yazarken delegelerden faydalanırız. Bir diğer kullanım amacı da, bir metoda parametre olarak başka bir metot verebilmektir. Bu yazımızda temel olarak delegenin ne olduğununu, nasıl tanımlandığını, nasıl kullanıldığını ve nasıl bir mantıkla çalıştığını inceleyeceğiz.Delegeler referans türlü bir tiptir. Dolayısı ile nesneleri heap’de durur. Girişte bahsettiğimiz gibi, görevleri metot adresi tutmaktır. Burada dikkat edilmesi gereken nokta; delegenin imzası, tuttuğu metodun imzası ile aynı olmalıdır.İmzadan kastımız, geriye dönüş tipi ve aldığı parametrelerdir.Bir delege, birden fazla metot adresi tutabilir. Bu durumda FIFO(ilk giren ilk çıkar) prensibi geçerlidir. Yani metotlar, delegeye bağlanma sırasına göre çalışırlar. Sonuç almak istediğimiz zaman, en son eklenen metodun yaptığı işi görürüz.", Resim = "/img/delegate.jpg", CategoryId = 1  },

                new Blog() {Baslik = "C# Generic List Hakkında", Aciklama = "Generic’ler tasarlandığımız interface, class, metod yada parametrelerin (argümanların) belirli bir tip için değil bir şablon yapısına uyan her tip için çalışmasını sağlayan bir yapıdır.", EklenmeTarihi = DateTime.Now.AddDays(-5), Anasayfa=true, Onay = true, Icerik ="Generic List olarak adlandırılan bu sınıf System.Collections.Generic altında bulunur. List sınıfı koleksiyon türündendir. Dizi mantığında çalışan bu sınıf dizilerden daha gelişmiş özelliklere sahiptir. Standart bir diziyi tanımlarken boyutunu da tanımlama sırasında belirlemek gerekir. Fakat koleksiyonlar için bu durum söz konusu değildir. Listeye eleman ekledikçe boyutu artmaya devam eder.List sınıfı tanımlanırken T tip değişkenini alır. Yani listenin içeriğinde hangi türden nesne yada değişkenlerin olacağını belirler. Bu tanımlama sonucunda artık tanımlanan tipten farklı bir tür listenin içine eklenemez.", Resim = "/img/genericlist.jpg", CategoryId = 1  },

                new Blog() {Baslik = "Layout Page Hakkında", Aciklama = "Asp.NET Web Form platformunda sayfa tasarımı için kullandığımız Master Page yapıları, projemizde ki diğer .aspx sayfaları için tasarım karmaşıklığına engel olmakla birlikte işimizi oldukça kolaylaştırmaktadır.Mevzu Asp.NET MVC Razor View Engine olayına gelince, Web Formlarda ki Master Page yapısına benzer “_Layout.cshtml” sayfalarını kullanmaktayız.Bu makalemiz de, Layout sayfasıyla ilgili teferruatları inceleyeceğiz.", EklenmeTarihi = DateTime.Now.AddDays(-30), Anasayfa=false, Onay = true, Icerik ="Asp.NET Web Form platformunda sayfa tasarımı için kullandığımız Master Page yapıları, projemizde ki diğer .aspx sayfaları için tasarım karmaşıklığına engel olmakla birlikte işimizi oldukça kolaylaştırmaktadır.Mevzu Asp.NET MVC Razor View Engine olayına gelince, Web Formlarda ki Master Page yapısına benzer “_Layout.cshtml” sayfalarını kullanmaktayız.Bu makalemiz de, Layout sayfasıyla ilgili teferruatları inceleyeceğiz.MVC Razor View Engine mimarisinde çalışırken, sayfa tasarımımızı ister her sayfa da teker teker hazırlayabiliriz, istersekte Layout sayfasında tek seferlik hazırlayarak, sayfalarımızı Layout şablonundan türetebiliriz.", Resim = "/img/layoutpages.jpg", CategoryId = 2  },

                new Blog() {Baslik = "WebForm Hakkında", Aciklama = "ASP.NET ile programlama yaparken Web Formlarını kullanırız, web formları iki bileşenden oluşurlar, görsel kısım ve kod kısmı. Görsel kısmı .aspx dosyaları teşkil eder ve içlerinde HTML elemanlarını ve Web Form kontrollerini barındırır.", EklenmeTarihi = DateTime.Now.AddDays(-30), Anasayfa=false, Onay = true, Icerik ="ASP.NET ile programlama yaparken Web Formlarını kullanırız, web formları iki bileşenden oluşurlar, görsel kısım ve kod kısmı. Görsel kısmı .aspx dosyaları teşkil eder ve içlerinde HTML elemanlarını ve Web Form kontrollerini barındırır.ASP.NET ile programlama yaparken Web Formlarını kullanırız, web formları iki bileşenden oluşurlar, görsel kısım ve kod kısmı. Görsel kısmı .aspx dosyaları teşkil eder ve içlerinde HTML elemanlarını ve Web Form kontrollerini barındırır.ASP.NET ile programlama yaparken Web Formlarını kullanırız, web formları iki bileşenden oluşurlar, görsel kısım ve kod kısmı. Görsel kısmı .aspx dosyaları teşkil eder ve içlerinde HTML elemanlarını ve Web Form kontrollerini barındırır.", Resim = "/img/webforms.jpg", CategoryId = 3  },

                new Blog() {Baslik = "WinForm Hakkında", Aciklama = "Windows Forms Application, Microsoft Windows'un programlarda kullandığı form sisteminin adıdır. C,C++ Vb. dillerde bu tür formları kullanmak için yada tamamen bu formlara dayalı olarak program yapmak için windows kütüphaneleri kullanılır.", EklenmeTarihi = DateTime.Now.AddDays(-25), Anasayfa=true, Onay = true, Icerik ="Windows Forms Application, Microsoft Windows'un programlarda kullandığı form sisteminin adıdır.C,C++ Vb. dillerde bu tür formları kullanmak için yada tamamen bu formlara dayalı olarak program yapmak için windows kütüphaneleri kullanılır.Windows Forms Application deyimi en çok .net platformuna bağlı programlama dillerinin derleyicilerinde görülür.Visual Studio, VB6 , C# gibi dillerin, microsoft tarafından geliştirilen derleyicilerinde, bu seçeneği kullanarak Form tabanlı programlar yazılabilir.Windows'ta bulunan hemen hemen tüm programlar, Form sistemini kullanılır.Windows Forms Application, Microsoft Windows'un programlarda kullandığı form sisteminin adıdır.C,C++ Vb. dillerde bu tür formları kullanmak için yada tamamen bu formlara dayalı olarak program yapmak için windows kütüphaneleri kullanılır.Windows Forms Application deyimi en çok .net platformuna bağlı programlama dillerinin derleyicilerinde görülür.Visual Studio, VB6 , C# gibi dillerin, microsoft tarafından geliştirilen derleyicilerinde, bu seçeneği kullanarak Form tabanlı programlar yazılabilir.Windows'ta bulunan hemen hemen tüm programlar, Form sistemini kullanılır.", Resim = "/img/form.jpg", CategoryId = 4  },
            };

            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}