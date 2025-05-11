namespace JWT_Token.Model
{
    public static class CollageRepostry
    {
        public static List<Student> Student { get; set; } = new List<Student>()
        {
            new Student
             {
                 Id = 1,
                 Name = "ALjohara",
                 Email = "Aljohara1@gmail.com",
                 Address ="Alhzem,Jeedah"
             },

             new Student
             {
                 Id = 2,
                 Name = "Sara",
                 Email = "Sara@gmail.com",
                 Address ="Alyasmeen,Ryaidh"
             },

             new Student
             {
                 Id = 3,
                 Name = "Noura",
                 Email = "Noura@gmail.com",
                 Address ="Hiteen,Ryaidh"

             }
        };
    }
}
