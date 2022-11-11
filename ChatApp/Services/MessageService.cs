using ChatApp.Models;

namespace ChatApp.Services
{
    public class MessageService
    {
        static MessageService _instance;

        public static MessageService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MessageService();

                return _instance;
            }
        }

        readonly User user1 = new User
        {
            Name = "Alapa Segnou",
            Image = "emoji1.png",
            Color = Color.FromArgb("#FFE0EC")
        };
        readonly User user2 = new()
        {
            Name = "Atebede Mengue",
            Image = "emoji2.png",
            Color = Color.FromArgb("#BFE9F2")
        };
        readonly User user3 = new()
        {
            Name = "Russel Franck",
            Image = "emoji3.png",
            Color = Color.FromArgb("#FFD6C4")
        };
        readonly User user4 = new()
        {
            Name = "Onomo Jean",
            Image = "emoji4.png",
            Color = Color.FromArgb("#C3C1E6")
        };
        readonly User user5 = new()
        {
            Name = "Laurence Nguimeta",
            Image = "emoji5.png",
            Color = Color.FromArgb("#FFE0EC")
        };
        readonly User user6 = new()
        {
            Name = "Okokbatonmanioc",
            Image = "emoji6.png",
            Color = Color.FromArgb("#FFE5A6")
        };
        readonly User user7 = new()
        {
            Name = "Jane Foster",
            Image = "emoji7.png",
            Color = Color.FromArgb("#FFE0EC")
        };
        readonly User user8 = new()
        {
            Name = "Orience Etame",
            Image = "emoji8.png",
            Color = Color.FromArgb("#FFE0EC")
        };
        readonly User user9 = new()
        {
            Name = "Olivier",
            Image = "emoji9.png",
            Color = Color.FromArgb("#C3C1E6")
        };
        readonly User user10 = new()
        {
            Name = "Sharonne Ewane",
            Image = "emoji10.png",
            Color = Color.FromArgb("#FF95A2")
        };

        public List<User> GetUsers()
        {
            return new List<User>
            {
                user1, user2, user3, user4, user5, user6, user7, user8, user9, user10
            };
        }
        public List<Message> GetChats()
        {
            return new List<Message>
            {
                new Message
                {
                  Sender = user6,
                  Time = "18:32",
                  Text = "YO Odk ? l\'okok est à quel niveau ?",
                },
              new Message
              {
                Sender = user1,
                Time = "14:05",
                Text = "Je peux t\'appeler après ? je suis en réunion",
              },
              new Message
              {
                Sender = user3,
                Time = "14:00",
                Text = "Bonjour, je voulais une recommandation",
              },
              new Message
              {
                Sender = user2,
                Time = "13:35",
                Text = "Tu ne reponds pas pourquoi ?",
              },
              new Message
              {
                Sender = user4,
                Time= "12:11",
                Text= "Je vais passer d'ici peu",
              },
            };
        }

        public List<Message> GetMessages(User sender)
        {
            return new List<Message> {
              new Message
              {
                Sender = null,
                Time = "18:42",
                Text = "Je t\'assure. On lap seuleument 😂",
              },
              new Message
              {
                Sender = sender,
                Time = "18:39",
                Text = "mince la vie sans l\'okok c'est high 😞",
              },
              new Message
              {
                Sender = sender,
                Time = "18:39",
                Text =
                    "Garrrrrr, moi même heun😅",
              },
              new Message
              {
                Sender = null,
                Time = "18:36",
                Text = "Rien, J\'ai juste envie de tchop l'okok",
              },
              new Message
              {
                Sender= sender,
                Time = "18:35",
                Text= "Hello, Quoi de neuf ?",
              },
            };
        }
    }
}