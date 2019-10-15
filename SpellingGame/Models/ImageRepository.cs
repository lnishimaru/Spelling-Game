using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpellingGame.Models
{
    public static class ImageRepository
    {
        private static List<Image> images = new List<Image>()
        {
            new Image { Images = "pig" },
            new Image { Images = "pie" },
            new Image { Images = "pen" }
        };

        public static IEnumerable<Image> Images
        {
            get
            {
                return images;
            }
        }
        private static List<string> answers = new List<String>() { "pig", "pie", "pen" };
        
        public static IEnumerable<string> Answers
        {
            get
            {
                return answers;
            }
        }
    }
}
