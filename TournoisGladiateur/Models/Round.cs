using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournoisGladiateur.Models
{
	public class Round
	{
		public Round()
		{
			Duels = new List<Participation>();
		}

		public int Id { get; set; }
		public ICollection<Participation> Duels { get; set; }
		
		public void AddDuel(Duel duel, Gladiator winner)
		{
			Duels.Add(new Participation()
			{
				Duel = duel,
				Winners = winner
			});
		}

	}
}
