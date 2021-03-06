﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TournoisGladiateur.Models;

namespace TournoisGladiateur.Data
{
	internal class DatabaseInitializer : DropCreateDatabaseIfModelChanges<Context>
	{
		protected override void Seed(Context context)
		{
			var gladiator1 = new Gladiator()
			{
				FirstName = "Elvis",
				LastName = "Graton",
				Health = 100,
				Weapon = 20,
				Shield = 15
			};
			context.Gladiators.Add(gladiator1);

			var gladiator2 = new Gladiator()
			{
				FirstName = "Pepa",
				LastName = "Pig",
				Health = 100,
				Weapon = 20,
				Shield = 5
			};
			context.Gladiators.Add(gladiator2);

			var gladiator3 = new Gladiator()
			{
				FirstName = "Bob",
				LastName = "Marley",
				Health = 100,
				Weapon = 20,
				Shield = 15
			};
			context.Gladiators.Add(gladiator3);

			var gladiator4 = new Gladiator()
			{
				FirstName = "Donald",
				LastName = "Trump",
				Health = 100,
				Weapon = 20,
				Shield = 5
			};
			context.Gladiators.Add(gladiator4);

			var gladiator5 = new Gladiator()
			{
				FirstName = "Jean",
				LastName = "Chrétien",
				Health = 100,
				Weapon = 20,
				Shield = 15
			};
			context.Gladiators.Add(gladiator5);

			var gladiator6 = new Gladiator()
			{
				FirstName = "Jackie",
				LastName = "Chang",
				Health = 100,
				Weapon = 20,
				Shield = 5
			};
			context.Gladiators.Add(gladiator6);

			var gladiator7 = new Gladiator()
			{
				FirstName = "Bob",
				LastName = "L'Éponge",
				Health = 100,
				Weapon = 20,
				Shield = 15
			};
			context.Gladiators.Add(gladiator7);

			var gladiator8 = new Gladiator()
			{
				FirstName = "Donald",
				LastName = "Duck",
				Health = 100,
				Weapon = 20,
				Shield = 5
			};
			context.Gladiators.Add(gladiator8);

			context.SaveChanges();
		}
	}
}
