using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public  class clsStateEventArgs
    {
        public enum enStatus { Resume, NewGame }
        public enStatus State { get; set; }
        public clsStateEventArgs(enStatus State) 
        {
           this.State = State;
        }
    }
}
