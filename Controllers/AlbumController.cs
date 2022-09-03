using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Spotify_Album.Models;

namespace Spotify_Album.Controllers
{
    public class AlbumController : Controller
    {
        public List<Album> lsAlbum = null;
        public AlbumController()
        {
            var JsonAlbum = System.IO.File.ReadAllText("Models/Album.json");
            lsAlbum = JsonConvert.DeserializeObject<List<Album>>(JsonAlbum);
        }

        public IActionResult Index()
        {
            return View(lsAlbum);
        }
        public IActionResult view_album(string id){
            List<Album> lstResul = new List<Album>();
            int valor = Int32.Parse(id);
            foreach(var item in lsAlbum){
                if(id.Equals(item.id.ToString())){
                    lstResul.Add(item);
                }
            }
            return View(lstResul);
        }
        public IActionResult Search(string album){
            if(album==null){
                return View("Index", lsAlbum);
            }
            List<Album> result = new List<Album>();
            foreach(var item in lsAlbum){
                if(item.nombre.ToLower().Contains(album.ToLower())){
                    result.Add(item);
                }
            }
            return View("Index", result);
        }
    }
}