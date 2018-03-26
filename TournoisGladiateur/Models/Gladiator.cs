using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournoisGladiateur.Models
{
	public class Gladiator
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Health { get; set; }
		public int Weapon { get; set; }	
		public int Shield { get; set; }
		
	}
}
