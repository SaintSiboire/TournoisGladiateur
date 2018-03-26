using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournoisGladiateur.Models;

namespace TournoisGladiateur.Data
{
	public static class DuelsCreation
	{
		public static void Duels()
		{
			using (var context = new Context())
			{
				var gladiators = context.Gladiators;
				int count = 0;
				Gladiator g1, g2;
				int g1Id = 0;


				foreach (var g in gladiators)
				{					
					
					if (count == 0)
					{
						g1 = g;
						g1Id= g.Id;
						count++;

					}					
					else
					{
						g2 = g;
						count = 0;

						var duel = new Duel()
						{
							FirstGladiatorId = g1Id,
							SecondGladiatorId = g2.Id
						};
						context.Duels.Add(duel);
						
					}
				}
				context.SaveChanges();
			}
		}
	}
}
