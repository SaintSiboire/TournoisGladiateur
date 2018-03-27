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

				var round = new Round()
				{
				};

				foreach (var duel in duels)
				{
					var gladiator1Id = duel.FirstGladiatorId;
					var gladiator2Id = duel.SecondGladiatorId;

					var gladiator1 = context.Gladiators.Where(g => g.Id == gladiator1Id).SingleOrDefault();
					var gladiator2 = context.Gladiators.Where(g => g.Id == gladiator2Id).SingleOrDefault();

					var fight = Fights.Fight(gladiator1, gladiator2);
					var winner = context.Gladiators.FirstOrDefault(g => g.Id == fight);

					Console.ReadLine();


					round.AddDuel(duel, winner);

				}
				context.Rounds.Add(round);
				context.SaveChanges();
			}
				DuelsCreation.Duels();

			using (var context = new Context())
			{
				var lastDuel = context.Participations.Select(p => p.DuelId).ToList();
				var duelId = lastDuel.LastOrDefault();
				var duels = context.Duels.Where(d => d.Id > duelId );

				var round = new Round()
				{
				};

				foreach (var duel in duels)
				{
					var gladiator1Id = duel.FirstGladiatorId;
					var gladiator2Id = duel.SecondGladiatorId;

					var gladiator1 = context.Gladiators.Where(g => g.Id == gladiator1Id).SingleOrDefault();
					var gladiator2 = context.Gladiators.Where(g => g.Id == gladiator2Id).SingleOrDefault();

					var fight = Fights.Fight(gladiator1, gladiator2);
					var winner = context.Gladiators.FirstOrDefault(g => g.Id == fight);

					Console.ReadLine();


					round.AddDuel(duel, winner);

				}
				context.Rounds.Add(round);
				context.SaveChanges();
			}
			
		}

	}
}
