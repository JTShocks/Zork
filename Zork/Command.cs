using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zork
{
    public class Command : IEquatable<Command>
    {

        public string Name { get; set; }
        public string[] Verbs { get; }
        public Action<Game, CommandContext> Action { get; }
        public bool Equals(Command other)
        {
            throw new NotImplementedException();
        }
    }
}
