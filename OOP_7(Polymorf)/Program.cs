using OOP_7_Polymorf_;

Person person = new Person("Зубенко Михаил Петрович", DateOnly.Parse("1995-12-01"), "+7922222222");
person.TakeBook(3);
person.TakeBook("Энциклопедия", "Словарь", "Карты");
person.TakeBook(new Book() { Author = "Есенин", Title = "Стихи" }, new Book() { Author = "Пушкин", Title = "Сочинения" }, new Book() { Author = "Толстой", Title = "Война и мир" });

Reader reader = new Reader("Зубенко Михаил Петрович", DateOnly.Parse("1995-12-01"), "+7922222222", 432986532, "Лингвист");
reader.TakeBook(3);
reader.TakeBook("Энциклопедия", "Словарь", "Карты");
reader.TakeBook(new Book() { Author = "Есенин", Title = "Стихи" }, new Book() { Author = "Пушкин", Title = "Сочинения" }, new Book() { Author = "Толстой", Title = "Война и мир" });


