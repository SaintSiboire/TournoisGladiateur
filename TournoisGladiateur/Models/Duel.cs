﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournoisGladiateur.Models
{
	public class Duel
	{
		public int Id { get; set; }
		public int FirstGladiatorId { get; set; }
		public int SecondGladiatorId { get; set; }

	}
}
