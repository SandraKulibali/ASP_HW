using NuGet.Packaging.Signing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ASP_HW.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public string SoundUrl { get; set; } 

        public string GetImageUrl(string path)
        {
            return path + ".jpg";
        }

        public string GetSoundUrl(string path)
        {
            return path + ".mp3";
        }

    }



}
