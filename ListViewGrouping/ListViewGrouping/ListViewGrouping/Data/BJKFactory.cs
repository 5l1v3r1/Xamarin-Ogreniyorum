using ListViewGrouping.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ListViewGrouping.Data
{
    public class BJKFactory
    {
        public class Player
        {
            public string FullName { get; set; }
            public string Image { get; set; }
            public string Country { get; set; }
            public Position Position { get; set; }
            public DateTime BirthDate { get; set; }
            public float Height { get; set; }
            public int Weight { get; set; }
        }

        public enum Position
        {
            GoalKeeper,
            Defence,
            Midfield,
            Striker
        }

        public static int refreshCount { get; set; } = 0;

        private static IList<Player> Players { get; set; }

        static BJKFactory()
        {
            Players = new ObservableCollection<Player>
            {
                new Player { FullName = "Tolga Zengin", Image = "tolgazengin.jpg", Country = "Turkey.png",
                    Position = Position.GoalKeeper,
                    BirthDate = new DateTime(1983, 10, 10), Height = 1.92f, Weight = 90 },

                new Player { FullName = "Günay Güvenç", Image = "gunayguvenc.jpg", Country = "Turkey.png",
                    Position = Position.GoalKeeper,
                    BirthDate = new DateTime(1991, 06, 25), Height = 1.88f, Weight = 85 },

                new Player { FullName = "Denys Boyko", Image = "denysboyko.jpg", Country = "Ukraine.png",
                    Position = Position.GoalKeeper,
                    BirthDate = new DateTime(1988, 01, 29), Height = 1.94f, Weight = 82 },

                new Player { FullName = "Veysel Sapan", Image = "veyselsapan.jpg", Country = "Turkey.png",
                    Position = Position.GoalKeeper,
                    BirthDate = new DateTime(1996, 01, 11), Height = 1.97f, Weight = 85 },

                new Player { FullName = "İsmail Köybaşı", Image = "ismailkoybasi.jpg", Country = "Turkey.png",
                    Position = Position.Defence,
                    BirthDate = new DateTime(1989, 07, 10), Height = 1.77f, Weight = 75 },

                new Player { FullName = "Marcelo Antonio Guedes Filho", Image = "marcelo.jpg", Country = "Brazil.png",
                    Position = Position.Defence,
                    BirthDate = new DateTime(1987, 05, 20), Height = 1.91f, Weight = 90 },

                new Player { FullName = "Serdar Kurtuluş", Image = "serdarkurtulus.jpg", Country = "Turkey.png",
                    Position = Position.Defence,
                    BirthDate = new DateTime(1987, 07, 23), Height = 1.84f, Weight = 79 },

                new Player { FullName = "Dusko Tosic", Image = "duskotosic.jpg", Country = "Serbia.png",
                    Position = Position.Defence,
                    BirthDate = new DateTime(1985, 01, 19), Height = 1.85f, Weight = 85 },

                new Player { FullName = "Alexis Ruano Delgado", Image = "delgado.jpg", Country = "Spain.png",
                    Position = Position.Defence,
                    BirthDate = new DateTime(1985, 08, 04), Height = 1.85f, Weight = 80 },

                new Player { FullName = "Andreas Beck", Image = "andreasbeck.jpg", Country = "Germany.png",
                    Position = Position.Defence,
                    BirthDate = new DateTime(1987, 03, 13), Height = 1.80f, Weight = 74 },

                new Player { FullName = "Luiz Rhodolfo", Image = "luizrhodolfo.jpg", Country = "Brazil.png",
                    Position = Position.Defence,
                    BirthDate = new DateTime(1986, 08, 11), Height = 1.93f, Weight = 84 },

                new Player { FullName = "Necip Uysal", Image = "necipuysal.jpg", Country = "Turkey.png",
                    Position = Position.Midfield,
                    BirthDate = new DateTime(1991, 01, 24), Height = 1.80f, Weight = 72 },

                new Player { FullName = "Veli Kavlak", Image = "velikavlak.jpg", Country = "Austria.png",
                    Position = Position.Midfield,
                    BirthDate = new DateTime(1988, 11, 03), Height = 1.78f, Weight = 68 },

                new Player { FullName = "Oğuzhan Özyakup", Image = "oguzhanozyakup.jpg", Country = "Turkey.png",
                    Position = Position.Midfield,
                    BirthDate = new DateTime(1992, 09, 23), Height = 1.80f, Weight = 75 },

                new Player { FullName = "Olcay Şahan", Image = "olcaysahan.jpg", Country = "Turkey.png",
                    Position = Position.Midfield,
                    BirthDate = new DateTime(1987, 05, 26), Height = 1.79f, Weight = 71 },

                new Player { FullName = "Atiba Hutchinson", Image = "atibahutchinson.jpg", Country = "Canada.png",
                    Position = Position.Midfield,
                    BirthDate = new DateTime(1983, 02, 08), Height = 1.87f, Weight = 83 },

                new Player { FullName = "Kerim Frei", Image = "kerimfrei.jpg", Country = "Turkey.png",
                    Position = Position.Midfield,
                    BirthDate = new DateTime(1993, 11, 19), Height = 1.71f, Weight = 70 },

                new Player { FullName = "Gökhan Töre", Image = "gokhantore.jpg", Country = "Turkey.png",
                    Position = Position.Midfield,
                    BirthDate = new DateTime(1992, 01, 20), Height = 1.76f, Weight = 70 },

                new Player { FullName = "Gökhan Gönül", Image = "gokhangonul.jpg", Country = "Turkey.png",
                    Position = Position.Defence,
                    BirthDate = new DateTime(1985, 01, 04), Height = 1.75f, Weight = 75 },

                new Player { FullName = "Jose Ernesto Sosa", Image = "josesosa.jpg", Country = "Argentina.png",
                    Position = Position.Midfield,
                    BirthDate = new DateTime(1985, 06, 19), Height = 1.79f, Weight = 72 },

                new Player { FullName = "Tolgay Arslan", Image = "tolgayarslan.jpg", Country = "Turkey.png",
                    Position = Position.Midfield,
                    BirthDate = new DateTime(1990, 08, 16), Height = 1.80f, Weight = 77 },

                new Player { FullName = "Ricardo Quaresma", Image = "ricardoquaresma.jpg", Country = "Portugal.png",
                    Position = Position.Midfield,
                    BirthDate = new DateTime(1983, 09, 26), Height = 1.75f, Weight = 67 },

                new Player { FullName = "Mustafa Pektemek", Image = "mustafapektemek.jpg", Country = "Turkey.png",
                    Position = Position.Striker,
                    BirthDate = new DateTime(1988, 08, 11), Height = 1.82f, Weight = 72 },

                new Player { FullName = "Cenk Tosun", Image = "cenktosun.jpg", Country = "Turkey.png",
                    Position = Position.Striker,
                    BirthDate = new DateTime(1991, 06, 07), Height = 1.83f, Weight = 78 },

                new Player { FullName = "Mario Gomez Garcia", Image = "mariogomez.jpg", Country = "Germany.png",
                    Position = Position.Striker,
                    BirthDate = new DateTime(1985, 07, 10), Height = 1.89f, Weight = 83 },
            };
        }

        public static ObservableCollection<Grouping<string, Player>> GetPlayersWithGrouping(string playerFullName = null)
        {
            var result = Players;

            if (!String.IsNullOrEmpty(playerFullName) && playerFullName.Length > 2)
                result = Players.Where(x => x.FullName.ToLower().Contains(playerFullName)).ToList();

            var list = new ObservableCollection<Grouping<string, Player>>(
            result
            .OrderBy(c => refreshCount % 2 == 0 ? c.Country : c.FullName)
            .GroupBy(c => refreshCount % 2 == 0 ? c.Country[0].ToString() : c.FullName[0].ToString(), c => c)
            .Select(g => new Grouping<string, Player>(g.Key, g)));

            return list;
        }
    }
}