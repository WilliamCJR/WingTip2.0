using System.Collections.Generic;
using System.Data.Entity;

namespace WingtipToys.Models
{
      public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    //public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Carros"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Aviones"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Camiones"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Botes"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Maquinas"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Automóvil Convertible",
                    Description = "¡Este automóvil convertible es rápido! El motor está alimentado por una batería basada en neutrinos (no incluida). " +
                                  "¡Enciéndelo y déjalo ir!",
                    ImagePath = "carconvert.png",
                    UnitPrice = 22.50,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Automóvil Antiguo",
                    Description = "No hay nada viejo en este automóvil de juguete, excepto su apariencia. Compatible con otros automóviles antiguos de juguete.",
                    ImagePath = "carearly.png",
                    UnitPrice = 15.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Automóvil Rápido",
                    Description = "Sí, este automóvil es rápido, pero también flota en el agua.",
                    ImagePath = "carfast.png",
                    UnitPrice = 32.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Automóvil Súper Rápido",
                    Description = "Utiliza este automóvil súper rápido para entretener a tus invitados. ¡Las luces y las puertas funcionan!",
                    ImagePath = "carfaster.png",
                    UnitPrice = 8.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Corredor de Estilo Antiguo",
                    Description = "Este corredor de estilo antiguo puede volar (con ayuda del usuario). La gravedad controla la duración del vuelo. " +
                                  "No se requieren pilas.",
                    ImagePath = "carracer.png",
                    UnitPrice = 34.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Avión As",
                    Description = "Juguete de avión auténtico. Con detalles y colores realistas.",
                    ImagePath = "planeace.png",
                    UnitPrice = 95.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Planeador",
                    Description = "Este divertido planeador está hecho de auténtica madera balsa. Requiere cierto ensamblaje.",
                    ImagePath = "planeglider.png",
                    UnitPrice = 4.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Avión de Papel",
                    Description = "Este avión de papel no es como ningún otro avión de papel. Requiere algo de plegado.",
                    ImagePath = "planepaper.png",
                    UnitPrice = 2.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Avión de Hélice",
                    Description = "Avión impulsado por una banda de goma con dos ruedas.",
                    ImagePath = "planeprop.png",
                    UnitPrice = 32.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Camión Antiguo",
                    Description = "Este camión de juguete tiene un motor de gasolina real. Requiere revisiones regulares.",
                    ImagePath = "truckearly.png",
                    UnitPrice = 15.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Camión de Bomberos",
                    Description = "Te divertirás sin límites con este camión de bomberos a escala de un cuarto.",
                    ImagePath = "truckfire.png",
                    UnitPrice = 26.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Camión Grande",
                    Description = "Este divertido camión de juguete se puede utilizar para remolcar otros camiones que no sean tan grandes.",
                    ImagePath = "truckbig.png",
                    UnitPrice = 29.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Barco Grande",
                    Description = "¿Es un barco o un buque? ¡Deja que este vehículo flotante decida utilizando su " +
                                  "inteligencia artificial computarizada!",
                    ImagePath = "boatbig.png",
                    UnitPrice = 95.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Barco de Papel",
                    Description = "¡Diversión flotante para todos! Este barco de juguete se puede ensamblar en segundos. ¡Flota durante minutos! " +
                                  "Requiere algo de plegado.",
                    ImagePath = "boatpaper.png",
                    UnitPrice = 4.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Velero",
                    Description = "¡Pon este divertido velero de juguete en el agua y déjalo ir!",
                    ImagePath = "boatsail.png",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "Cohete",
                    Description = "Este divertido cohete alcanzará una altura de hasta 200 pies.",
                    ImagePath = "rocket.png",
                    UnitPrice = 122.95,
                    CategoryID = 5
                }
            };

            return products;
        }
    }
}