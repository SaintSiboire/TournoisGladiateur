using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournoisGladiateur.Models;
using TournoisGladiateur.Data;

namespace TournoisGladiateur
{
	class Program
	{
		static void Main(string[] args)
		{
			//using (var context = new Context())
			//{
			//	var gladiator1 = context.Gladiators.Where(g => g.Id == 1).SingleOrDefault();
			//	var gladiator2 = context.Gladiators.Where(g => g.Id == 2).SingleOrDefault();

			//	Fights.Fight(gladiator1, gladiator2);

			//	Console.ReadLine();

			//}

			DuelsCreation.Duels();





			using (var context = new Context())
			{
				var duels = context.Duels;

				foreach(var duel in duels)
				{
					var gladiator1Id = duel.FirstGladiatorId;
					var gladiator2Id = duel.SecondGladiatorId;

					var gladiator1 = context.Gladiators.Where(g => g.Id == gladiator1Id).SingleOrDefault();
					var gladiator2 = context.Gladiators.Where(g => g.Id == gladiator2Id).SingleOrDefault();

					Fights.Fight(gladiator1, gladiator2);

					Console.ReadLine();
				}

				

				

			}
		}

	}
}
