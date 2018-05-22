namespace BL.Spisok
{
    public class NodeCharacter
    {
        public string FIO { get; set; }
        public string Prof { get; set; }
        public NodeCharacter Next { get; set; }

        public NodeCharacter(string fio, string prof)
        {
            FIO = fio;
            Prof = prof;
        }
    }
}
