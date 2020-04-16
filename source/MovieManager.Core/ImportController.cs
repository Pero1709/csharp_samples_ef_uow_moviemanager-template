using MovieManager.Core.Entities;
using System;
using System.Collections.Generic;

namespace MovieManager.Core
{
    public class ImportController
    {
        const string Filename = "movies.csv";

        /// <summary>
        /// Liefert die Movies mit den dazugehörigen Kategorien
        /// </summary>
        public static IEnumerable<Movie> ReadFromCsv()
        {
            string filePath = MyFile.GetFullFolderNameInApplicationTree(Filename);
            string[] lines = File.ReadAllLines(filePath);
            IDictionary<string, Category> categories = new Dictionary<string, Category>();
            IList<Movie> movies = new List<Movie>();

            foreach (var item in lines)
            {
                string[] parts = item.Split(';');
                string title = parts[0];
                int year = Convert.ToInt32(parts[1]);
                string[] catergoryName = new string[] { "Action", "Adventure", "Animation", "Biography", "Comedy", "Crime","Documentary","Drama","Fantasy","Horror","Thriller"};
                
                int duration = Convert.ToInt32(parts[3]);
                Category category;
                Movie movie = new Movie
                {
                    Title = title,
                    Year = year,
                    Duration = duration
                };

                Category action;
                if(categories.TryGetValue(catergoryName[1],out action))
                {

                }

                
              
            }
            return movies;
        }

    }
}
