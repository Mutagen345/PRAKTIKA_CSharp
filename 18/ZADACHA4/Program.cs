using System;
using System.Collections;

namespace MusicCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicCatalog catalog = new MusicCatalog();

            catalog.AddCD("CD1");
            catalog.AddCD("CD2");

            catalog.AddSong("CD1", "Song1");
            catalog.AddSong("CD1", "Song2");
            catalog.AddSong("CD2", "Song3");
            catalog.AddSong("CD2", "Song4");

            catalog.DisplayCatalog();

            catalog.RemoveCD("CD1");

            catalog.DisplayCatalog();
        }
    }

    class MusicCatalog
    {
        private Hashtable catalog = new Hashtable();

        public void AddCD(string cdName)
        {
            if (catalog.ContainsKey(cdName))
            {
                Console.WriteLine($"CD {cdName} already exists in the catalog.");
            }
            else
            {
                catalog.Add(cdName, new ArrayList());
                Console.WriteLine($"CD {cdName} added to the catalog.");
            }
        }

        public void RemoveCD(string cdName)
        {
            if (catalog.ContainsKey(cdName))
            {
                catalog.Remove(cdName);
                Console.WriteLine($"CD {cdName} removed from the catalog.");
            }
            else
            {
                Console.WriteLine($"CD {cdName} does not exist in the catalog.");
            }
        }

        public void AddSong(string cdName, string songName)
        {
            if (catalog.ContainsKey(cdName))
            {
                ArrayList songs = (ArrayList)catalog[cdName];

                if (songs.Contains(songName))
                {
                    Console.WriteLine($"Song {songName} already exists in CD {cdName}.");
                }
                else
                {
                    songs.Add(songName);
                    Console.WriteLine($"Song {songName} added to CD {cdName}.");
                }
            }
            else
            {
                Console.WriteLine($"CD {cdName} does not exist in the catalog.");
            }
        }

        public void RemoveSong(string cdName, string songName)
        {
            if (catalog.ContainsKey(cdName))
            {
                ArrayList songs = (ArrayList)catalog[cdName];

                if (songs.Contains(songName))
                {
                    songs.Remove(songName);
                    Console.WriteLine($"Song {songName} removed from CD {cdName}.");
                }
                else
                {
                    Console.WriteLine($"Song {songName} does not exist in CD {cdName}.");
                }
            }
            else
            {
                Console.WriteLine($"CD {cdName} does not exist in the catalog.");
            }
        }

        public void DisplayCatalog()
        {
            if (catalog.Count == 0)
            {
                Console.WriteLine("The catalog is empty.");
            }
            else
            {
                Console.WriteLine("Catalog Contents:");
                foreach (string cdName in catalog.Keys)
                {
                    Console.WriteLine($"CD: {cdName}");
                    ArrayList songs = (ArrayList)catalog[cdName];
                    if (songs.Count == 0)
                    {
                        Console.WriteLine("No songs in this CD.");
                    }
                    else
                    {
                        Console.WriteLine("Songs:");
                        foreach (string songName in songs)
                        {
                            Console.WriteLine(songName);
                        }
                    }
                }
            }
        }
    }
}
