using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrnekSite.Entity
{
    public class DataInitilazer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){Name="KAMERA",Description="KAMERA ÜRÜNLERİ"},
                new Category(){Name="TELEFON",Description="TELEFON ÜRÜNLERİ"},
                new Category(){Name="BİLGİSAYAR",Description="BİLGİSAYAR ÜRÜNLERİ"}
            };
            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}