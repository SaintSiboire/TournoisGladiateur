﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TournoisGladiateur.Models;

namespace TournoisGladiateur.Data
{
	public class Context : DbContext
	{
		public DbSet<Duel> Duels { get; set; }
		public DbSet<Gladiator> Gladiators { get; set; }
		public DbSet<Round>	Rounds { get; set; }
		public DbSet<Participation> Participations { get; set; }

		public Context()
		{
			Database.SetInitializer(new DatabaseInitializer());
		}

	}
}
