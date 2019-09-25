namespace AliasLibrary
{
    public class Team : ITeam
    {
        // public string Name { get; set; }
        public int Scour { get; set; }
        // public ushort CountOfMembers { get; set; }
        // public string[] ListOfWords { get; set; }
        public Team()
        {
            Scour = 0;
        }

        // Добавление балов
        public void AddPoit()
        {
            Scour += 2;
        }
        // Отнятие балов
        public void WithdrawPoint()
        {
            if (Scour >= 2)
                Scour -= 2;
        }
    }
}
