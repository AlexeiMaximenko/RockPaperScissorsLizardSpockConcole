namespace iTransitionTask3
    {
    public class Turn
        {
        public string TurnId { get; set; }
        public string Name { get; set; }
        public int ActionCode { get; set; }

        public Turn(string name, int actionCode)
            {
            ActionCode = actionCode;
            Name = name;
            }
        }
    }
