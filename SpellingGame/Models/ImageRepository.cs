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
            new Image { Images = "pen" },
            new Image { Images = "nap" },
            new Image { Images = "now" },
            new Image { Images = "new" },
            new Image { Images = "name" },
            new Image { Images = "house" }
        };

        public static IEnumerable<Image> Images
        {
            get
            {
                return images;
            }
        }
        private static List<string> answers = new List<String>() { "pig", "pie", "pen","nap","now","new","name","house" };
        
        public static IEnumerable<string> Answers
        {
            get
            {
                return answers;
            }
        }
    }
}
