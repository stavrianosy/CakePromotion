using CakePromo.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakePromo.DataAccess
{
    public class DropCreateDBWithSeedData : DropCreateDatabaseAlways<EntityContext>
    {
        protected override void Seed(EntityContext context)
        {
            #region IDENTITY ON
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Users] ON");
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Cakes] ON");
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[CakePhotoes] ON");
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Rates] ON");
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Ingredients] ON");
            #endregion

            #region User
            //## User ##//
            context.User.Add(new User { UserID = 1, Username = "Anonymous", TimeStamp = DateTime.Now });
            #endregion

            #region CakePhoto
            //## CakePhoto ##//
            context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 1,
                PhotoURL_Small = "~/images/cakes/DSCN0761.jpg",
                PhotoURL_Large = "~/images/cakes/DSCN0761.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 2,
                PhotoURL_Small = "~/images/cakes/DSCN0762.jpg",
                PhotoURL_Large = "~/images/cakes/DSCN0762.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 3,
                PhotoURL_Small = "~/images/cakes/DSCN0845.jpg",
                PhotoURL_Large = "~/images/cakes/DSCN0845.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 4,
                PhotoURL_Small = "~/images/cakes/DSCN0846.jpg",
                PhotoURL_Large = "~/images/cakes/DSCN0846.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 5,
                PhotoURL_Small = "~/images/cakes/DSCN0849.jpg",
                PhotoURL_Large = "~/images/cakes/DSCN0849.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 6,
                PhotoURL_Small = "~/images/cakes/SNC00643.jpg",
                PhotoURL_Large = "~/images/cakes/SNC00643.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 7,
                PhotoURL_Small = "~/images/cakes/SNC00645.jpg",
                PhotoURL_Large = "~/images/cakes/SNC00645.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 8,
                PhotoURL_Small = "~/images/cakes/SNC00955.jpg",
                PhotoURL_Large = "~/images/cakes/SNC00955.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 9,
                PhotoURL_Small = "~/images/cakes/DSCN1326.jpg",
                PhotoURL_Large = "~/images/cakes/DSCN1326.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 10,
                PhotoURL_Small = "~/images/cakes/DSCN1327.jpg",
                PhotoURL_Large = "~/images/cakes/DSCN1327.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 11,
                PhotoURL_Small = "~/images/cakes/DSCN1328.jpg",
                PhotoURL_Large = "~/images/cakes/DSCN1328.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 12,
                PhotoURL_Small = "~/images/cakes/SNC00414.jpg",
                PhotoURL_Large = "~/images/cakes/SNC00414.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 13,
                PhotoURL_Small = "~/images/cakes/SNC00415.jpg",
                PhotoURL_Large = "~/images/cakes/SNC00415.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 14,
                PhotoURL_Small = "~/images/cakes/SNC00416.jpg",
                PhotoURL_Large = "~/images/cakes/SNC00416.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 15,
                PhotoURL_Small = "~/images/cakes/DSCN0847.jpg",
                PhotoURL_Large = "~/images/cakes/DSCN0847.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 16,
                PhotoURL_Small = "~/images/cakes/DSCN0879.jpg",
                PhotoURL_Large = "~/images/cakes/DSCN0879.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 17,
                PhotoURL_Small = "~/images/cakes/DSCN0880.jpg",
                PhotoURL_Large = "~/images/cakes/DSCN0880.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 18,
                PhotoURL_Small = "~/images/cakes/DSCN0881.jpg",
                PhotoURL_Large = "~/images/cakes/DSCN0881.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 19,
                PhotoURL_Small = "~/images/cakes/DSCN0882.jpg",
                PhotoURL_Large = "~/images/cakes/DSCN0882.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 20,
                PhotoURL_Small = "~/images/cakes/DSCN0883.jpg",
                PhotoURL_Large = "~/images/cakes/DSCN0883.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 21,
                PhotoURL_Small = "~/images/cakes/DSCN1322.jpg",
                PhotoURL_Large = "~/images/cakes/DSCN1322.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 22,
                PhotoURL_Small = "~/images/cakes/DSCN1324.jpg",
                PhotoURL_Large = "~/images/cakes/DSCN1324.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 23,
                PhotoURL_Small = "~/images/cakes/SNC00301.jpg",
                PhotoURL_Large = "~/images/cakes/SNC00301.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            }); context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 24,
                PhotoURL_Small = "~/images/cakes/SNC00302.jpg",
                PhotoURL_Large = "~/images/cakes/SNC00302.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            }); context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 25,
                PhotoURL_Small = "~/images/cakes/SNC00303.jpg",
                PhotoURL_Large = "~/images/cakes/SNC00303.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            }); context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 26,
                PhotoURL_Small = "~/images/cakes/SNC00304.jpg",
                PhotoURL_Large = "~/images/cakes/SNC00304.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            }); context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 27,
                PhotoURL_Small = "~/images/cakes/SNC00488.jpg",
                PhotoURL_Large = "~/images/cakes/SNC00488.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            }); context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 28,
                PhotoURL_Small = "~/images/cakes/SNC00489.jpg",
                PhotoURL_Large = "~/images/cakes/SNC00489.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            }); context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 29,
                PhotoURL_Small = "~/images/cakes/SNC00490.jpg",
                PhotoURL_Large = "~/images/cakes/SNC00490.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            }); context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 30,
                PhotoURL_Small = "~/images/cakes/SNC00620.jpg",
                PhotoURL_Large = "~/images/cakes/SNC00620.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            }); context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 31,
                PhotoURL_Small = "~/images/cakes/SNC00621.jpg",
                PhotoURL_Large = "~/images/cakes/SNC00621.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            }); context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 32,
                PhotoURL_Small = "~/images/cakes/SNC00622.jpg",
                PhotoURL_Large = "~/images/cakes/SNC00622.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            }); context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 33,
                PhotoURL_Small = "~/images/cakes/SNC00628.jpg",
                PhotoURL_Large = "~/images/cakes/SNC00628.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            }); context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 34,
                PhotoURL_Small = "~/images/cakes/SNC00629.jpg",
                PhotoURL_Large = "~/images/cakes/SNC00629.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            }); context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 35,
                PhotoURL_Small = "~/images/cakes/SNC00630.jpg",
                PhotoURL_Large = "~/images/cakes/SNC00630.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            }); context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 36,
                PhotoURL_Small = "~/images/cakes/SNC00652.jpg",
                PhotoURL_Large = "~/images/cakes/SNC00652.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            }); context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 37,
                PhotoURL_Small = "~/images/cakes/SNC00653.jpg",
                PhotoURL_Large = "~/images/cakes/SNC00653.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            }); context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 38,
                PhotoURL_Small = "~/images/cakes/SNC00681.jpg",
                PhotoURL_Large = "~/images/cakes/SNC00681.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            }); context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 39,
                PhotoURL_Small = "~/images/cakes/SNC00686.jpg",
                PhotoURL_Large = "~/images/cakes/SNC00686.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            }); context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 40,
                PhotoURL_Small = "~/images/cakes/SNC00694.jpg",
                PhotoURL_Large = "~/images/cakes/SNC00694.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            }); context.CakePhoto.Add(new CakePhoto
            {
                CakePhotoID = 41,
                PhotoURL_Small = "~/images/cakes/SNC00969.jpg",
                PhotoURL_Large = "~/images/cakes/SNC00969.jpg",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
#endregion

            #region Rate
            //## Rate ##//
            context.Rate.Add(new Rate()
            {
                RateID = 1,
                Comments = "cmt 1",
                Design = 5,
                Facilitate = 4,
                Taste = 5,
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Rate.Add(new Rate()
            {
                RateID = 2,
                Comments = "cmt 2",
                Design = 5,
                Facilitate = 3,
                Taste = 5,
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Rate.Add(new Rate()
            {
                RateID = 3,
                Comments = "cmt 3",
                Design = 5,
                Facilitate = 4,
                Taste = 5,
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Rate.Add(new Rate()
            {
                RateID = 4,
                Comments = "cmt 4",
                Design = 4,
                Facilitate = 5,
                Taste = 5,
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Rate.Add(new Rate()
            {
                RateID = 5,
                Comments = "cmt 5",
                Design = 5,
                Facilitate = 5,
                Taste = 5,
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Rate.Add(new Rate()
            {
                RateID = 7,
                Comments = "cmt 7",
                Design = 4,
                Facilitate = 3,
                Taste = 5,
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Rate.Add(new Rate()
            {
                RateID = 8,
                Comments = "cmt 8",
                Design = 4,
                Facilitate = 3,
                Taste = 5,
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Rate.Add(new Rate()
            {
                RateID = 9,
                Comments = "cmt 9",
                Design = 4,
                Facilitate = 3,
                Taste = 5,
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Rate.Add(new Rate()
            {
                RateID = 10,
                Comments = "cmt 10",
                Design = 3,
                Facilitate = 3,
                Taste = 4,
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Rate.Add(new Rate()
            {
                RateID = 11,
                Comments = "cmt 11",
                Design = 4,
                Facilitate = 3,
                Taste = 5,
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });

            context.Rate.Add(new Rate()
            {
                RateID = 12,
                Comments = "cmt 12",
                Design = 5,
                Facilitate = 5,
                Taste = 5,
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Rate.Add(new Rate()
            {
                RateID = 13,
                Comments = "cmt 12",
                Design = 5,
                Facilitate = 5,
                Taste = 5,
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Rate.Add(new Rate()
            {
                RateID = 14,
                Comments = "cmt 12",
                Design = 5,
                Facilitate = 5,
                Taste = 5,
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Rate.Add(new Rate()
            {
                RateID = 15,
                Comments = "cmt 12",
                Design = 5,
                Facilitate = 5,
                Taste = 5,
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Rate.Add(new Rate()
            {
                RateID = 16,
                Comments = "cmt 12",
                Design = 5,
                Facilitate = 5,
                Taste = 5,
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Rate.Add(new Rate()
            {
                RateID = 17,
                Comments = "cmt 12",
                Design = 5,
                Facilitate = 5,
                Taste = 5,
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Rate.Add(new Rate()
            {
                RateID = 18,
                Comments = "cmt 12",
                Design = 5,
                Facilitate = 5,
                Taste = 5,
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Rate.Add(new Rate()
            {
                RateID = 19,
                Comments = "cmt 12",
                Design = 5,
                Facilitate = 5,
                Taste = 5,
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Rate.Add(new Rate()
            {
                RateID = 20,
                Comments = "cmt 12",
                Design = 5,
                Facilitate = 5,
                Taste = 5,
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Rate.Add(new Rate()
            {
                RateID = 21,
                Comments = "cmt 12",
                Design = 5,
                Facilitate = 5,
                Taste = 5,
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Rate.Add(new Rate()
            {
                RateID = 22,
                Comments = "cmt 12",
                Design = 5,
                Facilitate = 5,
                Taste = 5,
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Rate.Add(new Rate()
            {
                RateID = 23,
                Comments = "cmt 12",
                Design = 5,
                Facilitate = 5,
                Taste = 5,
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Rate.Add(new Rate()
            {
                RateID = 24,
                Comments = "cmt 12",
                Design = 5,
                Facilitate = 5,
                Taste = 5,
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Rate.Add(new Rate()
            {
                RateID = 25,
                Comments = "cmt 12",
                Design = 5,
                Facilitate = 5,
                Taste = 5,
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Rate.Add(new Rate()
            {
                RateID = 26,
                Comments = "cmt 12",
                Design = 5,
                Facilitate = 5,
                Taste = 5,
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Rate.Add(new Rate()
            {
                RateID = 27,
                Comments = "cmt 12",
                Design = 5,
                Facilitate = 5,
                Taste = 5,
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            #endregion

            #region Unit
            //## Unit ##//
            context.Unit.Add(new Unit()
            {
                UnitID = 1,
                Name = "grammar",
                ShortName = "gr",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Unit.Add(new Unit()
            {
                UnitID = 2,
                Name = "tea spoon",
                ShortName = "sp",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Unit.Add(new Unit()
            {
                UnitID = 3,
                Name = "piece",
                ShortName = "ps",
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
#endregion

            #region Ingredient
            //## Ingredient ##//
            context.Ingredient.Add(new Ingredient()
            {
                IngredientID = 1,
                Name = "sugar",
                Quantity = 25,
                Unit = context.Unit.Local.Single(u => u.UnitID == 1),
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Ingredient.Add(new Ingredient()
            {
                IngredientID = 2,
                Name = "baking powder",
                Quantity = 3.5,
                Unit = context.Unit.Local.Single(u => u.UnitID == 2),
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Ingredient.Add(new Ingredient()
            {
                IngredientID = 3,
                Name = "caramel",
                Quantity = 2,
                Unit = context.Unit.Local.Single(u => u.UnitID == 3),
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            #endregion

            #region Cake
            //## Cake ##//
            context.Cake.Add(new Cake
            {
                CakeID = 1,
                Name = "Cake 1",
                Recipie = "Recipie 1",
                Rate = context.Rate.Local.Where(r => r.RateID == 1 || r.RateID == 2).ToList(),
                Ingredient = context.Ingredient.Local.Where(i => i.IngredientID < 5).ToList(),
                CakePhoto = context.CakePhoto.Local.Where(p => p.CakePhotoID == 1 || p.CakePhotoID == 2).ToList(),
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });

            context.Cake.Add(new Cake
            {
                CakeID = 2,
                Name = "Cake 2",
                Recipie = "Recipie 2",
                Rate = context.Rate.Local.Where(r => r.RateID >= 3 && r.RateID <= 5).ToList(),
                Ingredient = context.Ingredient.Local.Where(i => i.IngredientID < 5).ToList(),
                CakePhoto = context.CakePhoto.Local.Where(p => p.CakePhotoID >= 3 && p.CakePhotoID <= 5).ToList(),
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });

            context.Cake.Add(new Cake
            {
                CakeID = 3,
                Name = "Cake 3",
                Recipie = "Recipie 3",
                Rate = context.Rate.Local.Where(r => r.RateID == 6 || r.RateID == 7).ToList(),
                Ingredient = context.Ingredient.Local.Where(i => i.IngredientID < 3).ToList(),
                CakePhoto = context.CakePhoto.Local.Where(p => p.CakePhotoID == 6 || p.CakePhotoID == 7).ToList(),
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });

            context.Cake.Add(new Cake
            {
                CakeID = 4,
                Name = "Cake 4",
                Recipie = "Recipie 4",
                Rate = context.Rate.Local.Where(r => r.RateID == 8).ToList(),
                Ingredient = context.Ingredient.Local.Where(i => i.IngredientID < 2).ToList(),
                CakePhoto = context.CakePhoto.Local.Where(p => p.CakePhotoID >= 8 && p.CakePhotoID <= 8).ToList(),
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });

            context.Cake.Add(new Cake
            {
                CakeID = 5,
                Name = "Football",
                Recipie = "Recipie 5",
                Rate = context.Rate.Local.Where(r => r.RateID >= 9 && r.RateID <= 11).ToList(),
                Ingredient = context.Ingredient.Local.Where(i => i.IngredientID < 5).ToList(),
                CakePhoto = context.CakePhoto.Local.Where(p => p.CakePhotoID >= 9 && p.CakePhotoID <= 14).ToList(),
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });

            context.Cake.Add(new Cake
            {
                CakeID = 6,
                Name = "Panna Cotta",
                Recipie = "Recipie 6",
                Rate = context.Rate.Local.Where(r => r.RateID == 13).ToList(),
                Ingredient = context.Ingredient.Local.Where(i => i.IngredientID < 5).ToList(),
                CakePhoto = context.CakePhoto.Local.Where(p => p.CakePhotoID >= 15 && p.CakePhotoID <= 15).ToList(),
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Cake.Add(new Cake
            {
                CakeID = 7,
                Name = "Unknown name",
                Recipie = "Recipie 7",
                Rate = context.Rate.Local.Where(r => r.RateID == 14).ToList(),
                Ingredient = context.Ingredient.Local.Where(i => i.IngredientID < 5).ToList(),
                CakePhoto = context.CakePhoto.Local.Where(p => p.CakePhotoID >= 16 && p.CakePhotoID <= 17).ToList(),
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Cake.Add(new Cake
            {
                CakeID = 8,
                Name = "Unknown name",
                Recipie = "Recipie 8",
                Rate = context.Rate.Local.Where(r => r.RateID == 15).ToList(),
                Ingredient = context.Ingredient.Local.Where(i => i.IngredientID < 5).ToList(),
                CakePhoto = context.CakePhoto.Local.Where(p => p.CakePhotoID >= 18 && p.CakePhotoID <= 19).ToList(),
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Cake.Add(new Cake
            {
                CakeID = 9,
                Name = "Unknown name",
                Recipie = "Recipie 9",
                Rate = context.Rate.Local.Where(r => r.RateID == 16).ToList(),
                Ingredient = context.Ingredient.Local.Where(i => i.IngredientID < 5).ToList(),
                CakePhoto = context.CakePhoto.Local.Where(p => p.CakePhotoID >= 20 && p.CakePhotoID <= 20).ToList(),
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Cake.Add(new Cake
            {
                CakeID = 10,
                Name = "Unknown name - 10",
                Recipie = "Recipie 10",
                Rate = context.Rate.Local.Where(r => r.RateID == 17).ToList(),
                Ingredient = context.Ingredient.Local.Where(i => i.IngredientID < 5).ToList(),
                CakePhoto = context.CakePhoto.Local.Where(p => p.CakePhotoID >= 21 && p.CakePhotoID <= 22).ToList(),
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Cake.Add(new Cake
            {
                CakeID = 11,
                Name = "Unknown name",
                Recipie = "Recipie 11",
                Rate = context.Rate.Local.Where(r => r.RateID == 18).ToList(),
                Ingredient = context.Ingredient.Local.Where(i => i.IngredientID < 5).ToList(),
                CakePhoto = context.CakePhoto.Local.Where(p => p.CakePhotoID >= 23 && p.CakePhotoID <= 24).ToList(),
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Cake.Add(new Cake
            {
                CakeID = 12,
                Name = "Unknown name",
                Recipie = "Recipie 10",
                Rate = context.Rate.Local.Where(r => r.RateID == 19).ToList(),
                Ingredient = context.Ingredient.Local.Where(i => i.IngredientID < 5).ToList(),
                CakePhoto = context.CakePhoto.Local.Where(p => p.CakePhotoID >= 25 && p.CakePhotoID <= 26).ToList(),
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Cake.Add(new Cake
            {
                CakeID = 13,
                Name = "Unknown name",
                Recipie = "Recipie 13",
                Rate = context.Rate.Local.Where(r => r.RateID == 20).ToList(),
                Ingredient = context.Ingredient.Local.Where(i => i.IngredientID < 5).ToList(),
                CakePhoto = context.CakePhoto.Local.Where(p => p.CakePhotoID >= 27 && p.CakePhotoID <= 29).ToList(),
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Cake.Add(new Cake
            {
                CakeID = 14,
                Name = "Unknown name",
                Recipie = "Recipie 10",
                Rate = context.Rate.Local.Where(r => r.RateID == 21).ToList(),
                Ingredient = context.Ingredient.Local.Where(i => i.IngredientID < 5).ToList(),
                CakePhoto = context.CakePhoto.Local.Where(p => p.CakePhotoID >= 30 && p.CakePhotoID <= 32).ToList(),
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Cake.Add(new Cake
            {
                CakeID = 15,
                Name = "Unknown name",
                Recipie = "Recipie 15",
                Rate = context.Rate.Local.Where(r => r.RateID == 22).ToList(),
                Ingredient = context.Ingredient.Local.Where(i => i.IngredientID < 5).ToList(),
                CakePhoto = context.CakePhoto.Local.Where(p => p.CakePhotoID >= 33 && p.CakePhotoID <= 35).ToList(),
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Cake.Add(new Cake
            {
                CakeID = 16,
                Name = "Unknown name",
                Recipie = "Recipie 16",
                Rate = context.Rate.Local.Where(r => r.RateID == 23).ToList(),
                Ingredient = context.Ingredient.Local.Where(i => i.IngredientID < 5).ToList(),
                CakePhoto = context.CakePhoto.Local.Where(p => p.CakePhotoID >= 36 && p.CakePhotoID <= 37).ToList(),
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Cake.Add(new Cake
            {
                CakeID = 17,
                Name = "APOEL",
                Recipie = "Recipie 17",
                Rate = context.Rate.Local.Where(r => r.RateID == 24).ToList(),
                Ingredient = context.Ingredient.Local.Where(i => i.IngredientID < 5).ToList(),
                CakePhoto = context.CakePhoto.Local.Where(p => p.CakePhotoID >= 38 && p.CakePhotoID <= 38).ToList(),
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Cake.Add(new Cake
            {
                CakeID = 18,
                Name = "Unknown name",
                Recipie = "Recipie 18",
                Rate = context.Rate.Local.Where(r => r.RateID == 25).ToList(),
                Ingredient = context.Ingredient.Local.Where(i => i.IngredientID < 5).ToList(),
                CakePhoto = context.CakePhoto.Local.Where(p => p.CakePhotoID >= 39 && p.CakePhotoID <= 39).ToList(),
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Cake.Add(new Cake
            {
                CakeID = 19,
                Name = "Unknown name",
                Recipie = "Recipie 19",
                Rate = context.Rate.Local.Where(r => r.RateID == 26).ToList(),
                Ingredient = context.Ingredient.Local.Where(i => i.IngredientID < 5).ToList(),
                CakePhoto = context.CakePhoto.Local.Where(p => p.CakePhotoID >= 40 && p.CakePhotoID <= 40).ToList(),
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            context.Cake.Add(new Cake
            {
                CakeID = 20,
                Name = "Unknown name",
                Recipie = "Recipie 20",
                Rate = context.Rate.Local.Where(r => r.RateID == 27).ToList(),
                Ingredient = context.Ingredient.Local.Where(i => i.IngredientID < 5).ToList(),
                CakePhoto = context.CakePhoto.Local.Where(p => p.CakePhotoID >= 41 && p.CakePhotoID <= 41).ToList(),
                TimeStamp = DateTime.Now,
                User = context.User.Local.Single(u => u.UserID == 1)
            });
            #endregion

            #region IDENTITY OFF
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Users] OFF");
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Cakes] OFF");
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[CakePhotoes] OFF");
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Rates] OFF");
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Ingredients] OFF");
            #endregion
        }
    }
}
