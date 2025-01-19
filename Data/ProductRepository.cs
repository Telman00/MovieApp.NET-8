using System;
using System.Collections.Generic;
using System.Linq;
using MovieApp.Models;

namespace MovieApp.Data
{
    public static class ProductRepository
    {
        private static List<Movie> _movies = new List<Movie>();

        static ProductRepository()
        {
            _movies = new List<Movie>()
{
    new Movie 
    { 
        Id = 1, 
        Name = "Inception", 
        Title = "Action Movie",
        Description = "<p>Inception is a revolutionary sci-fi thriller directed by Christopher Nolan that delves into the human subconscious. The plot centers around Dom Cobb, a skilled thief who specializes in the art of extraction—stealing valuable secrets from within the subconscious during the dream state. Cobb and his team are offered a seemingly impossible task: to plant an idea into a target's mind. This high-stakes mission takes them on a mind-bending journey through dream layers filled with stunning visuals, intricate storylines, and philosophical questions about reality and identity. Inception is a cinematic masterpiece that challenges perceptions and captivates audiences with its complex narrative and breathtaking action sequences.</p>", 
        ShortDescription = "A sci-fi movie", 
        ImageUrl = "1.jpg" 
    },
    new Movie 
    { 
        Id = 2, 
        Name = "Interstellar", 
        Title = "Action Movie",
        Description = "<p>Interstellar, directed by Christopher Nolan, is an epic tale of space exploration and human survival. Set in a dystopian future where Earth's resources are depleting, the film follows a team of astronauts who embark on a daring mission to find a new home for humanity. Led by former pilot Cooper, the crew travels through a mysterious wormhole near Saturn, encountering alien worlds and facing the challenges of time dilation, black holes, and emotional separation. Interstellar combines visually stunning effects, an emotional score by Hans Zimmer, and profound themes about love, sacrifice, and the future of humanity. It is a monumental achievement in both storytelling and visual artistry.</p>", 
        ShortDescription = "A space exploration movie", 
        ImageUrl = "2.jpg" 
    },
    new Movie 
    { 
        Id = 3, 
        Name = "The Dark Knight", 
        Title = "Action Movie",
        Description = "<p>The Dark Knight is a gripping and intense superhero film that redefined the genre with its mature storytelling and complex characters. Directed by Christopher Nolan, the film follows Batman as he battles his most dangerous adversary, the Joker, a criminal mastermind whose anarchic philosophy pushes Gotham City into chaos. Featuring a legendary performance by Heath Ledger as the Joker, The Dark Knight explores themes of morality, justice, and the fine line between heroism and vigilantism. With its dark tone, thrilling action sequences, and a morally ambiguous narrative, The Dark Knight stands as one of the greatest superhero movies ever made.</p>", 
        ShortDescription = "A superhero movie", 
        ImageUrl = "3.jpg" 
    },
    new Movie 
    { 
        Id = 4, 
        Name = "Avatar",
        Title = "Action Movie",
        Description = "<p>Avatar, directed by James Cameron, is a groundbreaking fantasy adventure set on the alien moon of Pandora. The story follows Jake Sully, a paraplegic ex-Marine who becomes part of the Na'vi culture through an avatar. As Jake learns the ways of the Na'vi and grows close to their community, he faces a moral dilemma when he discovers humanity's plans to exploit Pandora's resources. With breathtaking visuals, pioneering 3D technology, and a compelling environmental message, Avatar transports audiences to a stunning world filled with vibrant creatures, lush landscapes, and an epic struggle for survival. It remains a landmark in cinematic innovation and storytelling.</p>", 
        ShortDescription = "A fantasy adventure movie", 
        ImageUrl = "4.jpg" 
    },
    new Movie 
    { 
        Id = 5, 
        Name = "Titanic",
        Title = "Action Movie", 
        Description = "<p>Titanic, directed by James Cameron, is an unforgettable historical romance that captures the tragic tale of the ill-fated RMS Titanic. The film centers on the love story of Jack Dawson, a free-spirited artist, and Rose DeWitt Bukater, a young aristocratic woman trapped in a loveless engagement. As their love blossoms amidst the luxurious yet doomed voyage, the ship's collision with an iceberg seals their fate. With breathtaking visuals, emotionally charged performances, and a hauntingly beautiful score, Titanic masterfully portrays themes of love, class struggle, and human resilience against overwhelming odds. The film remains one of the most celebrated cinematic achievements of all time.</p>", 
        ShortDescription = "A historical romance movie", 
        ImageUrl = "5.jpg" 
    },
    new Movie 
    { 
        Id = 6, 
        Name = "Joker",
        Title = "Action Movie",
        Description = "<p>Joker, directed by Todd Phillips, is a haunting psychological thriller that explores the descent into madness of Arthur Fleck, a failed comedian living in a bleak and unforgiving Gotham City. Isolated and disregarded by society, Arthur's mental health deteriorates as he struggles to find meaning and connection. The film presents a harrowing portrait of societal neglect, mental illness, and the dark paths that desperation can lead to. Featuring a transformative performance by Joaquin Phoenix, Joker delves into the origins of the iconic villain, offering a raw and unsettling perspective on his transformation into the Clown Prince of Crime. The film is a chilling exploration of human fragility and the consequences of alienation.</p>", 
        ShortDescription = "A psychological thriller movie", 
        ImageUrl = "6.jpg" 
    }
};

        }

        public static List<Movie> Movies()
        {
            return _movies;
        }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }

        public static Movie? GetById(int id)
{
    return _movies.FirstOrDefault(i => i.Id == id);
}
    }
}
