using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournoisGladiateur.Data;

namespace TournoisGladiateur.Models
{
	public class DuelsResults
	{
		public int Id { get; set; }
		public int RoundId { get; set; }
		public List<int> WinnersId { get; set; }

	}
}
