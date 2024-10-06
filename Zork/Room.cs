﻿
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Zork
{
	public class Room
	{
		public string Name { get; }
		public string Description { get; set; }
		public Room(string name, string description = "")
		{
			Name = name;
			Description = description;
		}
	}
}
