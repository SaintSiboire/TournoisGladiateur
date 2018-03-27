using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournoisGladiateur.Data;

namespace TournoisGladiateur.Models
{
	public class Participation
	{
		public int Id { get; set; }
		public int RoundId { get; set; }
		public int DuelId { get; set; }
		public Gladiator Winners { get; set; }

		public Round Round { get; set; }
		public Duel Duel { get; set; }

	}
}
