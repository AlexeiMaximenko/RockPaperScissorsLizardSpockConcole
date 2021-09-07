using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTransitionTask3
    {
    class Move
        {
        byte[] Key;
        int ActionCode;
        string name;
        public Move(string name, int actionCode)
            {
            ActionCode = actionCode;
            this.name = name;
            }

        public string GetName()
            {
            return name;
            }
        public int GetActionCode()
            {
            return ActionCode;
            }
        public byte[] GetKey()
            {
            return Key;
            }
        public void SetKey(byte[] key)
            {
            Key = key;
            }
        }
    }
