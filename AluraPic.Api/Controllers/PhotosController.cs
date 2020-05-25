using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace AluraPic.Api.Controllers
{
    [ApiController]
    [Route("{user}/[controller]")]
    public class PhotosController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Photo> Get(/*[FromQuery]string page*/)
        {
            var photos = new List<Photo>
            {
                new Photo { 
                 id = 1,
                 allowComments = true,
                 comments = 22,
                 description = "farol",
                 likes = 21,
                 postDate = DateTime.Now,
                 url = "https://www.aier.org/wp-content/uploads/2019/02/privatelighthouse.jpg",
                 userId = 1
                },
                new Photo {
                 id = 1,
                 allowComments = true,
                 comments = 22,
                 description = "farol",
                 likes = 21,
                 postDate = DateTime.Now,
                 url = "https://www.aier.org/wp-content/uploads/2019/02/privatelighthouse.jpg",
                 userId = 1
                },
                 new Photo {
                 id = 1,
                 allowComments = true,
                 comments = 22,
                 description = "farol",
                 likes = 21,
                 postDate = DateTime.Now,
                 url = "https://www.aier.org/wp-content/uploads/2019/02/privatelighthouse.jpg",
                 userId = 1
                },
                  new Photo {
                 id = 1,
                 allowComments = true,
                 comments = 22,
                 description = "barco",
                 likes = 21,
                 postDate = DateTime.Now,
                 url = "https://www.aier.org/wp-content/uploads/2019/02/privatelighthouse.jpg",
                 userId = 1
                },
                   new Photo {
                 id = 1,
                 allowComments = true,
                 comments = 22,
                 description = "barco",
                 likes = 21,
                 postDate = DateTime.Now,
                 url = "https://www.aier.org/wp-content/uploads/2019/02/privatelighthouse.jpg",
                 userId = 1
                },
                    new Photo {
                 id = 1,
                 allowComments = true,
                 comments = 22,
                 description = "barco",
                 likes = 21,
                 postDate = DateTime.Now,
                 url = "https://www.aier.org/wp-content/uploads/2019/02/privatelighthouse.jpg",
                 userId = 1
                },
                     new Photo {
                 id = 1,
                 allowComments = true,
                 comments = 22,
                 description = "asasasasas",
                 likes = 21,
                 postDate = DateTime.Now,
                 url = "https://www.aier.org/wp-content/uploads/2019/02/privatelighthouse.jpg",
                 userId = 1
                },
                      new Photo {
                 id = 1,
                 allowComments = true,
                 comments = 22,
                 description = "asasasasas",
                 likes = 21,
                 postDate = DateTime.Now,
                 url = "https://www.aier.org/wp-content/uploads/2019/02/privatelighthouse.jpg",
                 userId = 1
                },
                       new Photo {
                 id = 1,
                 allowComments = true,
                 comments = 22,
                 description = "asasasasas",
                 likes = 21,
                 postDate = DateTime.Now,
                 url = "https://www.aier.org/wp-content/uploads/2019/02/privatelighthouse.jpg",
                 userId = 1
                },
                        new Photo {
                 id = 1,
                 allowComments = true,
                 comments = 22,
                 description = "asasasasas",
                 likes = 21,
                 postDate = DateTime.Now,
                 url = "https://www.aier.org/wp-content/uploads/2019/02/privatelighthouse.jpg",
                 userId = 1
                },
                         new Photo {
                 id = 1,
                 allowComments = true,
                 comments = 22,
                 description = "asasasasas",
                 likes = 21,
                 postDate = DateTime.Now,
                 url = "https://www.aier.org/wp-content/uploads/2019/02/privatelighthouse.jpg",
                 userId = 1
                },
                          new Photo {
                 id = 1,
                 allowComments = true,
                 comments = 22,
                 description = "asasasasas",
                 likes = 21,
                 postDate = DateTime.Now,
                 url = "https://www.aier.org/wp-content/uploads/2019/02/privatelighthouse.jpg",
                 userId = 1
                },
                           new Photo {
                 id = 1,
                 allowComments = true,
                 comments = 22,
                 description = "asasasasas",
                 likes = 21,
                 postDate = DateTime.Now,
                 url = "https://www.aier.org/wp-content/uploads/2019/02/privatelighthouse.jpg",
                 userId = 1
                },
                            new Photo {
                 id = 1,
                 allowComments = true,
                 comments = 22,
                 description = "asasasasas",
                 likes = 21,
                 postDate = DateTime.Now,
                 url = "https://www.aier.org/wp-content/uploads/2019/02/privatelighthouse.jpg",
                 userId = 1
                },
            };
            return photos;
        }
    }
}