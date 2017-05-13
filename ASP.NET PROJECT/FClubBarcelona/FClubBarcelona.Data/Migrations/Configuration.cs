namespace FClubBarcelona.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models.IdentityModels;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    internal sealed class Configuration : DbMigrationsConfiguration<FClubBarcelona.Data.FClubBarcelonaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(FClubBarcelonaContext context)
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));


            if (!context.Roles.Any(role => role.Name == "Admin"))
            {
                roleManager.Create(new IdentityRole("Admin"));
            }

            if (!context.Roles.Any(role => role.Name == "BlogAuthor"))
            {
                roleManager.Create(new IdentityRole("BlogAuthor"));
            }

            //context.Players.AddOrUpdate(x => new { x.FirstName, x.LastName }, new Player
            //{
            //    FirstName = "Lionel",
            //    LastName = "Messi",
            //    Age = DateTime.Now.Year - new DateTime(1987, 6, 24).Year,
            //    DateOfBirth = new DateTime(1987, 6, 24),
            //    Description = "Lionel Andres \"Leo\" Messi (Spanish pronunciation: [lionel andres mesi]; born 24 June 1987) is an Argentine professional footballer who plays as a forward for Spanish club FC Barcelona and the Argentina national team. Often considered the best player in the world and rated by many in the sport as the greatest of all time, Messi is the only player in history to win five FIFA Ballon d\'Or awards, four of which he won consecutively, and the first to win three European Golden Shoes.",
            //    Position = "Attacker",
            //    AdminAuthor = context.Users.First(x => x.FirstName == "Deniz"),
            //    ImageUrl = "https://media-public.fcbarcelona.com/20157/0/document_thumbnail/20197/130/192/18/34783362/1.0/34783362.jpg?t=1478605462000",
            //    VideoUrl = "https://www.youtube.com/embed/7AjtoXugGbk",
            //    Number = 10,
            //    Nationality = "Argentina"

            //},
            //new Player
            //{
            //    FirstName = "Neymar",
            //    LastName = "Junior",
            //    Age = DateTime.Now.Year - new DateTime(1992, 2, 25).Year,
            //    DateOfBirth = new DateTime(1992, 2, 25),
            //    Description = "Neymar da Silva Santos Junior, commonly known as Neymar or Neymar Jr., is a Brazilian professional footballer who plays as a forward for Spanish club FC Barcelona and the Brazil national team.",
            //    Position = "Attacker",
            //    ImageUrl = "https://media-public.fcbarcelona.com/20157/0/document_thumbnail/20197/136/192/18/34783368/1.0/34783368.jpg?t=1478605467000",
            //    VideoUrl = "https://www.youtube.com/embed/ZGEE7y6C7ZU",
            //    Number = 11,
            //    AdminAuthor = context.Users.First(x => x.FirstName == "Deniz"),
            //    Nationality = "Brazil"
            //}, new Player
            //{
            //    FirstName = "Luis",
            //    LastName = "Suarez",
            //    Age = DateTime.Now.Year - new DateTime(1987, 1, 24).Year,
            //    DateOfBirth = new DateTime(1987, 1, 24),
            //    Description = "Luis Alberto Suarez Diaz is a Uruguayan professional footballer who plays as a striker for Spanish club FC Barcelona and the Uruguay national team.",
            //    Position = "Attacker",
            //    AdminAuthor = context.Users.First(x => x.FirstName == "Deniz"),
            //    ImageUrl = "https://media-public.fcbarcelona.com/20157/0/document_thumbnail/20197/16/193/18/34783504/1.0/34783504.jpg?t=1478605478000",
            //    VideoUrl = "https://www.youtube.com/embed/YIHPmHBxxuM",
            //    Number = 9,
            //    Nationality = "Uruguay"
            //},
            //new Player
            //{
            //    FirstName = "Marc - Andre",
            //    LastName = "ter Stegen",
            //    DateOfBirth = new DateTime(1992, 4, 30),
            //    Age = DateTime.Now.Year - new DateTime(1992, 4, 30).Year,
            //    Description = "Marc-Andre ter Stegen is a German professional footballer who plays as a goalkeeper for Spanish club Barcelona.",
            //    Position = "Goalkeeper",
            //    AdminAuthor = context.Users.First(x => x.FirstName == "Deniz"),
            //    ImageUrl = "https://media-public.fcbarcelona.com/20157/0/document_thumbnail/20197/22/193/18/34783510/1.0/34783510.jpg?t=1478605480000",
            //    VideoUrl = "https://www.youtube.com/embed/Ew_h1H-3pNo",
            //    Number = 1,
            //    Nationality = "Germany"
            //},
            //new Player
            //{
            //    FirstName = "Jasper",
            //    LastName = "Cillessen",
            //    Age = DateTime.Now.Year - new DateTime(1989, 4, 22).Year,
            //    DateOfBirth = new DateTime(1989, 4, 22),
            //    Description = "Jacobus Antonius Peter Cillessen is a Dutch professional footballer who plays as a goalkeeper for Spanish club FC Barcelona and the Netherlands national team.",
            //    Position = "Goalkeeper",
            //    AdminAuthor = context.Users.First(x => x.FirstName == "Deniz"),
            //    ImageUrl = "https://media-public.fcbarcelona.com/20157/0/document_thumbnail/20197/77/192/18/34783309/1.0/34783309.jpg?t=1478605472000",
            //    VideoUrl = "https://www.youtube.com/embed/MWuPijELFys",
            //    Number = 13,
            //    Nationality = "Netherlands"
            //},
            //new Player
            //{
            //    FirstName = "Jordi ",
            //    LastName = "Masip",
            //    Age = DateTime.Now.Year - new DateTime(1989, 1, 3).Year,
            //    DateOfBirth = new DateTime(1989, 1, 3),
            //    Description = "Jordi Masip Lopez is a Spanish professional footballer who plays as a goalkeeper for FC Barcelona.",
            //    Position = "Goalkeeper",
            //    AdminAuthor = context.Users.First(x => x.FirstName == "Deniz"),
            //    ImageUrl = "https://media-public.fcbarcelona.com/20157/0/document_thumbnail/20197/118/192/18/34783350/1.0/34783350.jpg?t=1478605483000",
            //    VideoUrl = "https://www.youtube.com/embed/7xBKYrzVGrs",
            //    Number = 25,
            //    Nationality = "Spain"
            //},
            //new Player
            //{
            //    FirstName = "Samuel ",
            //    LastName = "Umtiti",
            //    Age = DateTime.Now.Year - new DateTime(1993, 11, 14).Year,
            //    DateOfBirth = new DateTime(1993, 11, 14),
            //    Description = "Samuel Yves Umtiti is a French professional footballer who plays as a centre-back for Spanish club FC Barcelona and the France national team.",
            //    Position = "Defender",
            //    AdminAuthor = context.Users.First(x => x.FirstName == "Deniz"),
            //    ImageUrl = "https://media-public.fcbarcelona.com/20157/0/document_thumbnail/20197/28/193/18/34783516/1.0/34783516.jpg?t=1478605480000",
            //    VideoUrl = "https://www.youtube.com/embed/w7igaYsnPC4",
            //    Number = 43,
            //    Nationality = "Cameroon"
            //},
            //new Player
            //{
            //    FirstName = "Lucas",
            //    LastName = "Digne",
            //    Age = DateTime.Now.Year - new DateTime(1993, 7, 20).Year,
            //    DateOfBirth = new DateTime(1993, 7, 20),
            //    Description = "Lucas Digne is a French professional footballer who plays as a left-back for Spanish club FC Barcelona and the France national team.",
            //    Position = "Defender",
            //    AdminAuthor = context.Users.First(x => x.FirstName == "Deniz"),
            //    ImageUrl = "https://media-public.fcbarcelona.com/20157/0/document_thumbnail/20197/89/192/18/34783321/1.0/34783321.jpg?t=1478605466000",
            //    VideoUrl = "https://www.youtube.com/embed/2ezEzp8Dlw4",
            //    Number = 3,
            //    Nationality = "France"
            //},
            //new Player
            //{
            //    FirstName = "Jordi",
            //    LastName = "Alba",
            //    Age = DateTime.Now.Year - new DateTime(1989, 3, 21).Year,
            //    DateOfBirth = new DateTime(1989, 3, 21),
            //    Description = "Jordi Alba Ramos; born 21 March 1989 is a Spanish professional footballer who plays for FC Barcelona and the Spain national team. Mainly a left-back and a player of great speed, he can also operate as a left winger.",
            //    Position = "Defender",
            //    AdminAuthor = context.Users.First(x => x.FirstName == "Deniz"),
            //    ImageUrl = "https://media-public.fcbarcelona.com/20157/0/document_thumbnail/20197/106/192/18/34783338/1.0/34783338.jpg?t=1478605457000",
            //    VideoUrl = "https://www.youtube.com/embed/dNnU3n9-Wa8",
            //    Number = 18,
            //    Nationality = "Spain"
            //},
            //new Player
            //{
            //    FirstName = "Javier",
            //    LastName = "Mascherano",
            //    Age = DateTime.Now.Year - new DateTime(1993, 7, 20).Year,
            //    DateOfBirth = new DateTime(1984, 1, 8),
            //    Description = "Javier Alejandro Mascherano is an Argentine professional footballer who plays as a defensive midfielder or centre-back for Spanish club FC Barcelona and the Argentina national team.",
            //    Position = "Midfielder",
            //    AdminAuthor = context.Users.First(x => x.FirstName == "Deniz"),
            //    ImageUrl = "https://media-public.fcbarcelona.com/20157/0/document_thumbnail/20197/112/192/18/34783344/1.0/34783344.jpg?t=1478605476000",
            //    VideoUrl = "https://www.youtube.com/embed/r3i2qCyBT4c",
            //    Number = 14,
            //    Nationality = "Argentina"
            //},
            //new Player
            //{
            //    FirstName = "Jeremyy",
            //    LastName = "Mathieu",
            //    Age = DateTime.Now.Year - new DateTime(1983, 10, 29).Year,
            //    DateOfBirth = new DateTime(1983, 10, 29),
            //    Description = "Jeremy Mathieu is a French professional footballer who plays as a centre-back or a left-back for Spanish club FC Barcelona and the France national team.",
            //    Position = "Defender",
            //    AdminAuthor = context.Users.First(x => x.FirstName == "Deniz"),
            //    ImageUrl = "https://media-public.fcbarcelona.com/20157/0/document_thumbnail/20197/124/192/18/34783356/1.0/34783356.jpg?t=1478605488000",
            //    VideoUrl = "https://www.youtube.com/embed/9vLUknOmOAQ",
            //    Number = 24,
            //    Nationality = "France"
            //},
            //new Player
            //{
            //    FirstName = "Gerard",
            //    LastName = "Pique",
            //    Age = DateTime.Now.Year - new DateTime(1987, 2, 2).Year,
            //    DateOfBirth = new DateTime(1987, 2, 2),
            //    Description = "Gerard Pique Bernabeu is a Spanish professional footballer who plays as a centre-back for FC Barcelona and the Spain national team.",
            //    Position = "Defender",
            //    AdminAuthor = context.Users.First(x => x.FirstName == "Deniz"),
            //    ImageUrl = "https://media-public.fcbarcelona.com/20157/0/document_thumbnail/20197/142/192/18/34783374/1.0/34783374.jpg?t=1478605463000",
            //    VideoUrl = "https://www.youtube.com/embed/1ku6yxiDh48",
            //    Number = 3,
            //    Nationality = "Spain"
            //},
            //new Player
            //{
            //    FirstName = "Denis",
            //    LastName = "Suarez",
            //    Age = DateTime.Now.Year - new DateTime(1994, 1, 6).Year,
            //    DateOfBirth = new DateTime(1994, 1, 6),
            //    Description = "Denis Suarez Fernadez is a Spanish professional footballer who plays as a central midfielder for FC Barcelona.",
            //    Position = "Midfielder",
            //    AdminAuthor = context.Users.First(x => x.FirstName == "Deniz"),
            //    ImageUrl = "https://media-public.fcbarcelona.com/20157/0/document_thumbnail/20197/83/192/18/34783315/1.0/34783315.jpg?t=1478605466000",
            //    VideoUrl = "https://www.youtube.com/embed/RsvRjd61i5c",
            //    Number = 6,
            //    Nationality = "Spain"
            //},
            //new Player
            //{
            //    FirstName = "Andre",
            //    LastName = "Gomes",
            //    Age = DateTime.Now.Year - new DateTime(1993, 7, 30).Year,
            //    DateOfBirth = new DateTime(1993, 7, 30),
            //    Description = "Andre Filipe Tavares Gomes is a Portuguese professional footballer who plays as a central midfielder for Spanish club FC Barcelona and the Portugal national team.",
            //    Position = "Midfielder",
            //    AdminAuthor = context.Users.First(x => x.FirstName == "Deniz"),
            //    ImageUrl = "https://media-public.fcbarcelona.com/20157/0/document_thumbnail/20197/221/191/18/34783197/1.0/34783197.jpg?t=1478605458000",
            //    VideoUrl = "https://www.youtube.com/embed/XNrbwy6tJxA",
            //    Number = 21,
            //    Nationality = "Portugal"
            //},
            //new Player
            //{
            //    FirstName = "Rafinha",
            //    LastName = "Alcantara",
            //    Age = DateTime.Now.Year - new DateTime(1993, 2, 12).Year,
            //    DateOfBirth = new DateTime(1993, 2, 12),
            //    Description = "Rafael Alcantara do Nascimento, commonly known as Rafinha, is a Brazilian professional footballer who plays as a central midfielder for Spanish club FC Barcelona and the Brazil national team.",
            //    Position = "Midfielder",
            //    AdminAuthor = context.Users.First(x => x.FirstName == "Deniz"),
            //    ImageUrl = "https://media-public.fcbarcelona.com/20157/0/document_thumbnail/20197/148/192/18/34783380/1.0/34783380.jpg?t=1478605476000",
            //    VideoUrl = "https://www.youtube.com/embed/E0y-0nOp7x0",
            //    Number = 12,
            //    Nationality = "Brazil"
            //},
            //new Player
            //{
            //    FirstName = "Aleix",
            //    LastName = "Vidal",
            //    Age = DateTime.Now.Year - new DateTime(1989, 8, 21).Year,
            //    DateOfBirth = new DateTime(1989, 8, 21),
            //    Description = "Aleix Vidal Parreu is a Spanish professional footballer who plays for FC Barcelona. Mainly a right-back and a player of great speed, he can also operate as a right winger.",
            //    Position = "Midfielder",
            //    AdminAuthor = context.Users.First(x => x.FirstName == "Deniz"),
            //    ImageUrl = "https://media-public.fcbarcelona.com/20157/0/document_thumbnail/20197/215/191/18/34783191/1.0/34783191.jpg?t=1478605466000",
            //    VideoUrl = "https://www.youtube.com/embed/BbJ_4TLVRY4",
            //    Number = 22,
            //    Nationality = "Spain"
            //},
            //new Player
            //{
            //    FirstName = "Arda",
            //    LastName = "Turan",
            //    Age = DateTime.Now.Year - new DateTime(1989, 8, 21).Year,
            //    DateOfBirth = new DateTime(1987, 1, 30),
            //    Description = "Arda Turan is a Turkish professional footballer who plays as an attacking midfielder for Spanish club FC Barcelona and captains the Turkey national team. He is mostly known for his ball control, dribbling skills, and vision.",
            //    Position = "Midfielder",
            //    AdminAuthor = context.Users.First(x => x.FirstName == "Deniz"),
            //    ImageUrl = "https://media-public.fcbarcelona.com/20157/0/document_thumbnail/20197/71/192/18/34783303/1.0/34783303.jpg?t=1478605447000",
            //    VideoUrl = "https://www.youtube.com/embed/k3AA05X2BUk",
            //    Number = 7,
            //    Nationality = "Turkey"
            //},
            //new Player
            //{
            //    FirstName = "Andres",
            //    LastName = "Iniesta",
            //    Age = DateTime.Now.Year - new DateTime(1989, 8, 21).Year,
            //    DateOfBirth = new DateTime(1984, 5, 11),
            //    Description = "Andres Iniesta Luján is a Spanish professional footballer who plays as a central midfielder for FC Barcelona and the Spain national team. He serves as the captain for Barcelona.",
            //    Position = "Midfielder",
            //    AdminAuthor = context.Users.First(x => x.FirstName == "Deniz"),
            //    ImageUrl = "https://media-public.fcbarcelona.com/20157/0/document_thumbnail/20197/96/192/18/34783328/1.0/34783328.jpg?t=1478605476000",
            //    VideoUrl = "https://www.youtube.com/embed/IEdlw5Lao2M",
            //    Number = 8,
            //    Nationality = "Spain"
            //},
            //new Player
            //{
            //    FirstName = "Sergi",
            //    LastName = "Roberto",
            //    Age = DateTime.Now.Year - new DateTime(1992, 2, 7).Year,
            //    DateOfBirth = new DateTime(1992, 2, 7),
            //    Description = "Sergi Roberto Carnicer is a Spanish professional footballer who plays for FC Barcelona. Mainly a central midfielder, he can also operate as a defensive midfielder, full-back or winger.",
            //    Position = "Midfielder",
            //    AdminAuthor = context.Users.First(x => x.FirstName == "Deniz"),
            //    ImageUrl = "https://media-public.fcbarcelona.com/20157/0/document_thumbnail/20197/160/192/18/34783392/1.0/34783392.jpg?t=1478605476000",
            //    VideoUrl = "https://www.youtube.com/embed/KK_J6RfktxA",
            //    Number = 20,
            //    Nationality = "Spain"
            //},
            //new Player
            //{
            //    FirstName = "Ivan",
            //    LastName = "Rakitic",
            //    Age = DateTime.Now.Year - new DateTime(1988, 3, 10).Year,
            //    DateOfBirth = new DateTime(1988, 3, 10),
            //    Description = "Ivan Rakitić is a Croatian professional footballer who plays as a central or attacking midfielder for Spanish club FC Barcelona and the Croatia national team.",
            //    Position = "Midfielder",
            //    AdminAuthor = context.Users.First(x => x.FirstName == "Deniz"),
            //    ImageUrl = "https://media-public.fcbarcelona.com/20157/0/document_thumbnail/20197/154/192/18/34783386/1.0/34783386.jpg?t=1478605475000",
            //    VideoUrl = "https://www.youtube.com/embed/w-MbHq1oWig",
            //    Number = 4,
            //    Nationality = "Croatia"
            //},
            //new Player
            //{
            //    FirstName = "Sergio",
            //    LastName = "Busquets",
            //    Age = DateTime.Now.Year - new DateTime(1988, 7, 16).Year,
            //    DateOfBirth = new DateTime(1988, 7, 16),
            //    Description = "Sergio Busquets Burgos is a Spanish professional footballer who plays as a defensive midfielder for FC Barcelona and the Spain national team.",
            //    Position = "Midfielder",
            //    AdminAuthor = context.Users.First(x => x.FirstName == "Deniz"),
            //    ImageUrl = "https://media-public.fcbarcelona.com/20157/0/document_thumbnail/20197/166/192/18/34783398/1.0/34783398.jpg?t=1478605476000",
            //    VideoUrl = "https://www.youtube.com/embed/9IZzjD4kyug",
            //    Number = 5,
            //    Nationality = "Spain"
            //},
            //new Player
            //{
            //    FirstName = "Paco",
            //    LastName = "Alcacer",
            //    Age = DateTime.Now.Year - new DateTime(1993, 8, 30).Year,
            //    DateOfBirth = new DateTime(1993, 8, 30),
            //    Description = "Francisco Paco Alcacer García is a Spanish professional footballer who plays as a striker for FC Barcelona and the Spain national team.",
            //    Position = "Attacker",
            //    AdminAuthor = context.Users.First(x => x.FirstName == "Deniz"),
            //    ImageUrl = "https://media-public.fcbarcelona.com/20157/0/document_thumbnail/20197/209/191/18/34783185/1.0/34783185.jpg?t=1478605466000",
            //    VideoUrl = "https://www.youtube.com/embed/AFm3Dj53sN8",
            //    Number = 17,
            //    Nationality = "Spain"
            //});

            //context.Articles.AddOrUpdate(x => x.Id, new Article
            //{
            //    Title = "Iniesta refuses to confirm Barcelona future",
            //    YouTubeUrl = "https://www.youtube.com/embed/KK_J6RfktxA",
            //    Author = context.Users.First(x => x.FirstName == "Deniz"),
            //    Content = "Barcelona legend Andres Iniesta declined to say whether he would continue at Camp Nou as he remains focused on overcoming the odds in the Champions League. \r\n\r\nThe midfielder, 32, came up through the ranks at La Masia and has been a crucial part of the Catalans\' incredible success story over the last decade. \r\n\r\nBut his contract expires in June 2018 and when asked if he would end his career at his boyhood club, Iniesta preferred not to answer. \r\n\r\nHazard ahead in Player of the Year race\r\n\r\n\"You have caught me out with that question right now,\" he told reporters ahead of Wednesday\'s crunch quarter-final return clash against Juventus. \r\n\r\n\"Tomorrow we are putting everything on the line collectively and individually, and nothing has changed from what I said last time. \r\n\r\n\"At the end of the season I will weigh up a lot of things and we will see. My hopes and wishes have not changed, but this is not the best time to be talking about it.\" \r\n\r\nHaving gone down 3-0 to Juventus last week in Turin, Barcelona must repeat their comeback heroics against Paris Saint-Germain to keep alive their European hopes. \r\n\r\nAccording to Iniesta, the key for Barcelona wiil be scoring early and piling pressure on their opponents. \r\n\r\n\"In a way there is a similarity there in the need to score goals and also give away few or no chances for the opponent,\" he considered. ",
            //    ImageTitle = "http://images.performgroup.com/di/library/GOAL/1/10/andres-iniesta-fc-barcelona_uy4fm7nyv86g11vqa4nf6s61q.jpg?t=-2133013333&amp;w=620&amp;h=430",
            //    PublishDate = DateTime.Today,
            //    StartArticle = "The Spain international's current deal is up next year, but he was not drawn on questions over his future ahead of Wednesday's Juve clash"
            //},
            //new Article
            //{
            //    Title = "Iniesta refuses to confirm Barcelona future",
            //    YouTubeUrl = "https://www.youtube.com/embed/KK_J6RfktxA",
            //    Author = context.Users.First(x => x.FirstName == "Deniz"),
            //    Content = "Barcelona legend Andres Iniesta declined to say whether he would continue at Camp Nou as he remains focused on overcoming the odds in the Champions League. \r\n\r\nThe midfielder, 32, came up through the ranks at La Masia and has been a crucial part of the Catalans\' incredible success story over the last decade. \r\n\r\nBut his contract expires in June 2018 and when asked if he would end his career at his boyhood club, Iniesta preferred not to answer. \r\n\r\nHazard ahead in Player of the Year race\r\n\r\n\"You have caught me out with that question right now,\" he told reporters ahead of Wednesday\'s crunch quarter-final return clash against Juventus. \r\n\r\n\"Tomorrow we are putting everything on the line collectively and individually, and nothing has changed from what I said last time. \r\n\r\n\"At the end of the season I will weigh up a lot of things and we will see. My hopes and wishes have not changed, but this is not the best time to be talking about it.\" \r\n\r\nHaving gone down 3-0 to Juventus last week in Turin, Barcelona must repeat their comeback heroics against Paris Saint-Germain to keep alive their European hopes. \r\n\r\nAccording to Iniesta, the key for Barcelona wiil be scoring early and piling pressure on their opponents. \r\n\r\n\"In a way there is a similarity there in the need to score goals and also give away few or no chances for the opponent,\" he considered. ",
            //    ImageTitle = "http://images.performgroup.com/di/library/GOAL/1/10/andres-iniesta-fc-barcelona_uy4fm7nyv86g11vqa4nf6s61q.jpg?t=-2133013333&amp;w=620&amp;h=430",
            //    PublishDate = DateTime.Today,
            //    StartArticle = "The Spain international's current deal is up next year, but he was not drawn on questions over his future ahead of Wednesday's Juve clash"

            //});

            //context.Galeries.AddOrUpdate(x => new { x.ImageUrl, x.ImageTitle, x.Id }, new Galery
            //{
            //    ImageTitle = "Lionel Messi",
            //    ImageUrl = "http://image.ondacero.es/clipping/cmsimages02/2017/04/23/8F5C2552-8C0A-4FE3-A574-012E69E176F6/33.jpg"
            //}, new Galery
            //{
            //    ImageTitle = "Camp Now",
            //    ImageUrl = "https://wuermtalsuckers.de/wp-content/uploads/2015/05/CL-Halbfinale-FCB-FCB-06052015.jpg"
            //}, new Galery
            //{
            //    ImageTitle = "MSN",
            //    ImageUrl = "https://pbs.twimg.com/media/CsjospoXgAAdR7L.jpg"
            //}, new Galery
            //{
            //    ImageTitle = "Camp Now",
            //    ImageUrl = "https://pianetagay.com/wp-content/uploads/2015/07/camp-nou.jpg"
            //}, new Galery
            //{
            //    ImageTitle = "Lionel Messi",
            //    ImageUrl = "http://image.ondacero.es/clipping/cmsimages02/2017/04/23/8F5C2552-8C0A-4FE3-A574-012E69E176F6/33.jpg"
            //}, new Galery
            //{
            //    ImageTitle = "Camp Now",
            //    ImageUrl = "https://wuermtalsuckers.de/wp-content/uploads/2015/05/CL-Halbfinale-FCB-FCB-06052015.jpg"
            //}, new Galery
            //{
            //    ImageTitle = "MSN",
            //    ImageUrl = "https://pbs.twimg.com/media/CsjospoXgAAdR7L.jpg"
            //}, new Galery
            //{
            //    ImageTitle = "Camp Now",
            //    ImageUrl = "https://pianetagay.com/wp-content/uploads/2015/07/camp-nou.jpg"
            //}, new Galery
            //{
            //    ImageTitle = "Lionel Messi",
            //    ImageUrl = "http://image.ondacero.es/clipping/cmsimages02/2017/04/23/8F5C2552-8C0A-4FE3-A574-012E69E176F6/33.jpg"
            //}, new Galery
            //{
            //    ImageTitle = "Camp Now",
            //    ImageUrl = "https://wuermtalsuckers.de/wp-content/uploads/2015/05/CL-Halbfinale-FCB-FCB-06052015.jpg"
            //}, new Galery
            //{
            //    ImageTitle = "MSN",
            //    ImageUrl = "https://pbs.twimg.com/media/CsjospoXgAAdR7L.jpg"
            //}, new Galery
            //{
            //    ImageTitle = "Camp Now",
            //    ImageUrl = "https://pianetagay.com/wp-content/uploads/2015/07/camp-nou.jpg"
            //});

            //context.Coaches.AddOrUpdate(x => new { x.FirstName, x.LastName, x.CoachYears }, new Coach
            //{
            //    FirstName = "Johan",
            //    LastName = "Cruyff",
            //    Nationality = "Holand",
            //    CoachYears = "1988-1996",
            //    ImageUrl = "https://static.independent.co.uk/s3fs-public/thumbnails/image/2015/10/22/10/Johan-Cruyff.jpg",
            //    VideoUrl = "https://www.youtube.com/embed/30ArQkG8ZCY",
            //    Description = "Johan Cruyff, or Cruijff as the name is actualy spelt, was the star of the exciting 1974 Dutch \"Total Football\" World Cup team and the Ajax Amsterdam team that won a hat-trick of European Cups in the early Seventies. Three times European footballer of the year, Cruyff was the most gifted European player of his generation, and probably of all time. His supreme technical skills, speed and acceleration, and his tactical insights made Cruyff virtually impossible to defend against. Wearing his trademark Nr.14 jersey, he usually played the centre forward position, but would often drop deep or move to the wing to confuse and draw out his markers. The tremendous tactical insight he had displayed as a player, enabled Cruyff to go on to become a world class coach after hanging up his boots in 1984. Building on the legacy of his mentor Rinus Michels, Cruyff proved himself the most unrelenting apostle of attacking football in the history of the game. Possession of the ball played a crucial part in his football philosophy. Cruyff abhorred the overly physical game that was dominant in the 1980\'s. He instructed his players not to go running mindlessly up and down the pitch, but to concentrate on combination play and let the ball do the work instead. He began his coaching career at Ajax, but it was at Barcelona that his revolutionary vision of a free flowing attacking style of football came to real fruition when he assembled a team that included Michael Laudrup, Hristo Stoichkov, Ronald Koeman and Josep Guardiola. Fondly remembered by Catalonians as the \'Dream Team\', they succeeded in winning a host of domestic trophies as well as the 1992 European Cup."
            //}, new Coach
            //{
            //    FirstName = "Bobby",
            //    LastName = "Robson",
            //    Nationality = "England",
            //    CoachYears = "1996-1997",
            //    ImageUrl = "http://media.minutemediacdn.com/process?url=http%3A%2F%2Fftbpro-post-images.s3-eu-west-1.amazonaws.com%2Fproduction%2F955358&filters%5Bcrop%5D%5Bw%5D=0.8995093795093795&filters%5Bcrop%5D%5Bh%5D=0.7826785714285714&filters%5Bcrop%5D%5Bo_x%5D=0.09974025974025974&filters%5Bcrop%5D%5Bo_y%5D=0.008571428571428572&filters%5Bresize%5D%5Bw%5D=912&filters%5Bresize%5D%5Bh%5D=516&filters%5Bresize%5D%5Bgravity%5D=Center&filters%5Bquality%5D%5Btarget%5D=80&type=.jpg",
            //    VideoUrl = "https://www.youtube.com/embed/B07BXA9LF1k",
            //    Description = "Sir Bobby Robson (Sir Robert William Robson), (born Feb. 18, 1933, Sacriston, Durham county, Eng.—died July 31, 2009, Durham county), British association football (soccer) player and manager who was one of England’s most respected players and managers. At the height of his professional career, Robson played 20 matches with the national team, including appearances in the 1958 and 1962 World Cup finals; later, serving as the England manager (1982–90), he steered the national team to two World Cup finals tournaments (1986, 1990). Robson was the son of a coal miner and was training as an apprentice electrician when he got his chance in 1950 to play football with Fulham. He spent most of his career on the field with Fulham (1950–56, 1962–67), where he scored a total of 77 goals in 345 games, and West Bromwich Albion (1956–62), scoring 56 goals in 239 games. He coached for one brief season (1967–68) in North America with the Vancouver Royals before returning home as Fulham’s manager (1968). The next season he took charge of Ipswich Town. After leading the previously little-known Ipswich club to the FA Cup (1978) and the Union des Associations Européennes de Football (UEFA) Cup (1981) titles, he was appointed (1982) England’s manager. Four years later he guided England to the World Cup finals in Mexico, where the team lost to Argentina in a highly controversial quarterfinal match noted for Diego Maradona’s “Hand of God” goal. In 1990, despite having been notified that his contract was unlikely to be renewed, Robson took England to the World Cup finals in Italy, where the side lost to West Germany in its semifinal match. He left England to manage PSV Eindhoven (1991–92), leading that club to the Dutch league championship for two straight years. Thereafter he worked in Portugal at Sporting Lisbon (1992–93) and FC Porto (1994–96), where he secured the Portuguese Cup (1994) and league (1995, 1996) championships, and in Barcelona (1996–98), where in 1997 the club captured both the Spanish Cup and the UEFA Cup Winners’ Cup. After a brief stint (1998) back with PSV Eindhoven, he returned to England in 1999 to manage Newcastle United; he was forced to retire in 2004. Robson was first diagnosed with cancer in 1992. He struggled for 17 years with recurring bouts of cancer, and in March 2008, after malignant tumours had been found in his lungs the previous year, he launched the Sir Bobby Robson Foundation for cancer research. He also wrote several books, including Time on the Grass (1982), My Autobiography: An Englishman Abroad (1998), and Farewell but Not Goodbye (2005). Robson was knighted in 2002 and was inducted into the English Football Hall of Fame in 2003."
            //}, new Coach
            //{
            //    FirstName = "Louis",
            //    LastName = "Van Gal",
            //    Nationality = "Holand",
            //    CoachYears = "1997-2000, 2002-2003",
            //    ImageUrl = "http://strettynews.com/wp-content/uploads/2016/04/louis-van-gaal-manager_3221493.jpg",
            //    VideoUrl = "https://www.youtube.com/embed/9G4iMRwNuTM",
            //    Description = "“I am who I am and I have my own ways. I\'m not going to change and I have no desire to.”\r\n\r\nLouis van Gaal, ladies and gentleman. Blunt with the media, as stubborn as a mule, but also one of the best modern day coaches, and promoter of Total Football.\r\n\r\nVan Gaal oversaw the development of Patrick Kluivert, the De Boer brothers, Clarence Seedorf, Edgar Davids and Edwin van der Sar after taking over as Ajax coach in 1991.\r\n\r\nThose players all went on to have magnificent careers, and after winning the Eredivisie title and Champions League with them, he would go on to coach them for the national team between 2000 and 2002.\r\n\r\nDuring his two spells with Barcelona (the first far more successful than the second) Van Gaal struggled to win over players and supporters, regularly clashing with the media. His rows with the team’s star player Rivaldo were frequent but it is to his credit that he enjoyed such success in the late 90s despite the turbulent atmosphere.\r\n\r\nHis title win at AZ Alkmaar ranks alongside his proudest achievements, while trophies came quickly at Bayern Munich where he won the league and cup double and reached the Champions League final in his first season.\r\n\r\nLeading an unexceptionable Netherlands side to third place at the 2014 World Cup, prior to taking over at Manchester United, should rank alongside his greatest achievements.\r\n\r\nIn his latter years, Van Gaal\'s style of play has visibly slowed down. This was a criticism at Bayern and and at United the knives have been out at a club whose fanbase is used to the free-flowing soccer of the Sir Alex Ferguson years. If Van Gaal\'s style of play has changed, his remarkable self belief, verging on downright stubbornness, has most certainly not, and he continues to do things his own way."
            //}, new Coach
            //{
            //    FirstName = "Franklin",
            //    LastName = "Rijkaard",
            //    Nationality = "Holand",
            //    CoachYears = "2003-2008",
            //    ImageUrl = "http://www.thefamouspeople.com/profiles/images/frank-rijkaard-2.jpg",
            //    VideoUrl = "https://www.youtube.com/embed/bR5o__J0XmQ&vl=en",
            //    Description = "Frank Rijkaard is a retired Dutch footballer often regarded as one of the greatest defensive midfielders to have ever played the game. Following his successful playing career he became a successful manager as well. Frank started showing interest in the game from an early age. He first played for the Netherlands’ biggest club Ajax Amsterdam and made his debut for the national team at the age of only 17, however he became a regular in the team within a short span of time. He helped the team win several trophies before going off to AC Milan after a short loan spell at Real Zaragoza in Spain and it was at Milan that he became the world beater with his authoritative style of play that set the tone for the modern defensive midfielders of the present day. Rijkaard went back to Ajax and played as a central defender as he helped the club win the UEFA Champions League in his last professional season. He was also a part of the European Championship winning Dutch side. He coached the Dutch national team in his first full-fledged job as a manager and then went on to manage Barcelona, which also achieved great success under him."
            //}, new Coach
            //{
            //    FirstName = "Josep",
            //    LastName = "Guardiola",
            //    Nationality = "Spain",
            //    CoachYears = "2008-2012",
            //    ImageUrl = "https://s-media-cache-ak0.pinimg.com/originals/45/cf/30/45cf30f32ab723b00909dab47192fba7.jpg",
            //    VideoUrl = "https://www.youtube.com/embed/pk1DQBruwnQ",
            //    Description = "Known as \'Pep\', he came up through Barcelona\'s youth ranks to win six Spanish Liga titles, one European Champion Clubs\' Cup, a UEFA Cup Winners\' Cup and two Copa del Rey trophies from 1990 to 2001. Also had spells with Brescia, Roma, al-Ahly in Doha and Mexico\'s Dorados de Sinola before ending his playing career in 2006. Won 40 caps and Olympic footballing gold with Spain in 1992, but missed the 1998 and 2002 FIFA World Cups through injury.\r\n\r\n• Having coached Barcelona\'s B team, he took charge of the senior side in 2008 and won the UEFA Champions League, Spanish Liga and Copa del Rey in his first season. In the process he became the sixth man to have lifted the European Cup as player and coach.\r\n\r\n• That was just the beginning of a glorious four-season spell which yielded 14 trophies. In his second campaign, Guardiola steered Barcelona to a second Liga title as well as the Spanish and UEFA Super Cups and the FIFA Club World Cup. Even more sucess followed in 2010/11 as Barcelona completed a hat-trick of Spanish titles and, for the second time under Guardiola, got the better of Manchester United FC in the UEFA Champions League final.\r\n\r\n• In his final season, 2011/12, Guardiola\'s team won the UEFA Super Cup and FIFA Club World Cup once more before he signed off his reign with a second Copa del Rey triumph.\r\n\r\n• After a year\'s break, Guardiola took charge of Bayern in June 2013, replacing Jupp Heynckes. In his first campaign he collected the UEFA Super Cup, FIFA Club World Cup, German Cup and, with a record seven games to spare, the Bundesliga title. He secured his second successive Bundesliga title by ten points the following season, and Bayern again dominated domestically in 2015/16, but all three of Guardiola\'s UEFA Champions League campaigns in Bavaria ended in the semi-finals. Opted for a new challenge at Manchester City in summer 2016."
            //}, new Coach
            //{
            //    FirstName = "Tito",
            //    LastName = "Vilanova",
            //    Nationality = "Spain",
            //    CoachYears = "2012-2013",
            //    ImageUrl = "https://img.vvlcdn.com/pp/http://news.bbcimg.co.uk/media/images/68852000/jpg/_68852990_tito_vilanova_afp.jpg",
            //    VideoUrl = "https://www.youtube.com/embed/RkOdVs9LIi0",
            //    Description = "Francesc ‘Tito’ Vilanova i Bayó is a Spanish football coach, former footballer. In 2012, he was appointed head coach of FC Barcelona after working as an assistant coach. The Spaniard was born on September 17, 1969 in Bellcaire d\'Empordà, Catalonia, Spain.\r\n\r\nTito began his football career as a player of the FC Barcelona youth team and eventually failed to join the first team. Later, in 1991, Vilanova joined UE Figueres and became a part of the team where he played the best season ever in the club history.\r\n\r\nIn 1992, the club reached the playoffs for a place in La Liga. In 1992, the Spaniard concluded a contract with Celta de Vigo to play for them in La Liga. After 1995 Tito played a series of matches for such football cubs as RCD Mallorca, CD Badajoz, UE Lleida and Elche CF.\r\n\r\nIn 2002, the Spaniard finished his career as a footballer at UDA Gramenet.\r\n\r\nAfter a short period as technical director of Terrassa FC, in 2007, Tito became assistant coach in Barcelona B.\r\n\r\nIn 2008, Tito was offered to join the coaching staff of FC Barcelona after a winning season with Barcelona B (promotion to La Segunda B).\r\n\r\nThe first season was successful with regard to titles when the team set a new record in the club history. In the first 2 seasons the club won eight trophies out of possible nine and after the 2011/2012 season the Spaniard got the position of FC Barcelona head coach.\r\n\r\nHis only season at the helm of the club was a contrast one. Barcelona claimed the La Liga title with incredible 100 points but crashed to Bayern Munich 0-7 on aggregate in the Champions League semifinals. Tito Vilanova was haunted by cancer and had to take a treatment leave in the mid-season. His disease seemed to be over by the end of the season but several weeks to the start of the seaon 2013/2014 the manager was forced to resign and dedicate himself to struggling for his life."
            //}, new Coach
            //{
            //    FirstName = "Gerardo",
            //    LastName = "Martino",
            //    Nationality = "Argentina",
            //    CoachYears = "2013-2014",
            //    ImageUrl = "http://www.dafabetsports.com/en/wp-content/uploads/2014/03/Gerardo-Martino-Barcelona-Manager.jpg",
            //    VideoUrl = "https://www.youtube.com/embed/Lz4eSGchFdw",
            //    Description = "Gerardo Daniel \"Tata\" Martino (born 20 November 1962) is a former Argentine footballer who is the manager of Atlanta United FC.\r\nMartino played mostly for Newell\'s Old Boys in his native Rosario. He holds the record of appearances with the team playing a total of 505 matches in all official competitions. He was also selected in a fan\'s poll as Newell\'s best player throughout the club\'s history.\r\nMartino was chosen to replace Tito Vilanova as manager of FC Barcelona at the start of the 2013–14 season, but announced his resignation on 17 May 2014, though his side finished runner-up in both the Copa del Rey and La Liga that season. In 2015, he led Argentina to the Copa América Final, only to be defeated by hosts Chile on penalties. His team also finished as runners-up in the Copa América Centenario, again losing to the defending champion Chile on penalties.On 5 July 2016, Martino resigned from the Argentine national team."
            //}, new Coach
            //{
            //    FirstName = "Luis  ",
            //    LastName = "Enrique",
            //    Nationality = "Spain",
            //    CoachYears = "2014-2017",
            //    ImageUrl = "http://www.weloba.com/sites/default/files/images/general/luis-enrique-012.jpg",
            //    VideoUrl = "https://www.youtube.com/embed/s8aaxfYFdJI",
            //    Description = "At 36 years of age, he took a football coaching course alongside such illustrious names as Josep Guardiola, Guillermo Amor, Albert Ferrer, and Sergi Barjuán, amongst others. In June 2008 he took charge of Barça Athletic, former name of Barca B, a team that had been promoted the previous season from the Third Division to Second Division B. He took over from Pep Guardiola, who was to take charge of the first team alongside Tito Vilanova.\r\nLucho had a lot of success coaching the Barça B. In the 2008/09 season they finished in fifth place in their group in Second Division B, although they didn’t gain the desired promotion, something they did achieve a season later thanks to a great generation of players like Sergi Roberto, Marc Bartra, Martín Montoya, Thiago Alcántara, and Jonathan Soriano. With these players the team cames second in the regular season, and then gained promotion to Second Division A, beating Jaén and Sant Andreu in  the play-offs.\r\nThe icing on the cake came in the 2010/11 season, when Luis Enrique achieved the highest position in the history of Barça reserves in the second division of Spanish football, with 71 points (20 wins, 11 draws, and 11 defeats) coming third in the championship behind Betis and Rayo Vallecano, who both won direct promotion to the top flight, and ahead of Granada, who also gained promotion that season\r\nAfter this milestone, Luis Enrique decided to try his luck outside of Spain and made the leap to become coach of AS Roma, one of the most important teams in the \'calcio\', where he had Bojan Krkic in his team, on loan from FC Barcelona. He finished the season in seventh place in the League, and was knocked-out in the semi-finals of the Italian Cup, and the qualifying rounds of the Europa League 2011/12.\r\nAfter a season out of football, in the 2013/14 season Luis Enrique returned to Spanish football to manage Celta Vigo, where he coincided with Rafinha, on loan from FC Barcelona, and Nolito and Fontàs, both former Barça players. Lucho’s season was pretty impressive: Celta ended La Liga season in a dignified ninth place and he received praise from everyone for his strong methodical and winning character.\r\nThe season 2014/15, his first as FC Barcelona coach, was the sporting highlight. The competitive spirit of the Asturian infected the blaugrana squad who recorded the domestic treble for the second time in the Club’s history. Barça claimed the league title by two points from second placed Real Madrid; in the  Copa del Rey they defeated Athletic Club 3-1 in the final at Camp Nou and in the Champions League they saw off Juventus in the final also by a 3-1 scoreline."
            //});

            //context.Videos.AddOrUpdate(x => x.Title, new Video
            //{
            //    Title = "Lionel Messi - All 36 Goals & Assists vs Real Madrid (HD)",
            //    VideoUrl = "https://www.youtube.com/embed/D5aM8EUnm3w",
            //    Duration = "8:17"
            //}, new Video
            //{
            //    Title = "Lionel Messi - All 500 Goals for Barcelona (2004-2017) ||HD||",
            //    VideoUrl = "https://www.youtube.com/embed/O6LnqORIXfk",
            //    Duration = "41:23"
            //}, new Video
            //{
            //    Title = "Lionel Messi Destroying Great Players ● No One Can Do It Better |HD",
            //    VideoUrl = "https://www.youtube.com/embed/_g-dyXWUov8",
            //    Duration = "10:01"
            //}, new Video
            //{
            //    Title = "Real Madrid vs Barcelona 2-3 2017 - Highlights & Goals - HD",
            //    VideoUrl = "https://www.youtube.com/embed/FTPxORAlT0Y",
            //    Duration = "6:44"
            //}, new Video
            //{
            //    Title = "[BEHIND THE SCENES] FC Barcelona's day in Madrid",
            //    VideoUrl = "https://www.youtube.com/embed/iDrUflPclwo",
            //    Duration = "6:29"
            //}, new Video
            //{
            //    Title = "An El Clásico to remember, in the coach's box & on the bench",
            //    VideoUrl = "https://www.youtube.com/embed/zkqdd6doxXU",
            //    Duration = "1:22"
            //}, new Video
            //{
            //    Title = "[INSIDE VIEW] Celebration at Bernabeu locker room",
            //    VideoUrl = "https://www.youtube.com/embed/yOfUls9ZtsM",
            //    Duration = "1:13"
            //}, new Video
            //{
            //    Title = "#Messi500 Las felicitaciones más emotivas de sus amigos",
            //    VideoUrl = "https://www.youtube.com/embed/c_2M91Dlsuk",
            //    Duration = "3:19"
            //}, new Video
            //{
            //    Title = "Messi & Ronaldinho: Un regalo de 10",
            //    VideoUrl = "https://www.youtube.com/embed/BfDtiiVyNMU",
            //    Duration = "13:05"
            //}, new Video
            //{
            //    Title = "Luis Suarez - All 100 Goals for FC Barcelona ||HD||",
            //    VideoUrl = "https://www.youtube.com/embed/VkrScjileaE",
            //    Duration = "9:35"
            //}, new Video
            //{
            //    Title = "Neymar Jr - All 100 Goals for FC Barcelona (HD)",
            //    VideoUrl = "https://www.youtube.com/embed/ftGJxKhFFUc",
            //    Duration = "9:25"
            //}, new Video
            //{
            //    Title = "MSN ● All 302 Goals ● Messi Suarez Neymar ||HD||",
            //    VideoUrl = "https://www.youtube.com/embed/TgfNGJVJkZA&t=1221s",
            //    Duration = "25:41"
            //}, new Video
            //{
            //    Title = "Top 35 Legendary Goals In Football History",
            //    VideoUrl = "https://www.youtube.com/embed/UlFHdsQq9J8",
            //    Duration = "12:06"
            //}, new Video
            //{
            //    Title = "NEW* Lionel Messi Top 10 Destructive Goals vs Real Madrid",
            //    VideoUrl = "https://www.youtube.com/embed/Gov9hZn6ZE4",
            //    Duration = "4:12"
            //}, new Video
            //{
            //    Title = "FC Barcelona - PSG (6-1): Final celebrations at Camp Nou",
            //    VideoUrl = "https://www.youtube.com/embed/SoOHFUh5Dus&t=41s",
            //    Duration = "5:43"
            //});


        }    
    }
}
