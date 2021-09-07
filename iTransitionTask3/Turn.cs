namespace iTransitionTask3
    {
    class Turn
        {
        string turnCode;
        int actionCode;
        string name;

        public Turn(string name, int actionCode)
            {
            this.actionCode = actionCode;
            this.name = name;
            }

        public string GetName()
            {
            return name;
            }

        public int GetActionCode()
            {
            return actionCode;
            }

        public string GetTurnCode()
            {
            return turnCode;
            }

        public void SetTurnCode(string code)
            {
            turnCode = code;
            }
        }
    }
