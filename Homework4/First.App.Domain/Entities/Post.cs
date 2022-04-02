using System;
using System.Collections.Generic;
using System.Text;

namespace First.App.Domain.Entities
{
    //Post diye tablo oluşturulacak migration ile user, id, title, body postun kolonları olacak.
    public class Post
    {
        public User User { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
