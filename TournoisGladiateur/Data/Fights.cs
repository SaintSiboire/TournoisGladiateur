using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournoisGladiateur.Models;

namespace TournoisGladiateur.Data
{
	public static class Fights
	{
		public static int Fight(Gladiator gladiator1, Gladiator gladiator2)
		{
			while (true)
			{
				if(FightResult(gladiator1,gladiator2) == 1)
				{
					Console.WriteLine("Fin du duel!");
					Console.WriteLine($"Le vainceur est {gladiator1.FirstName} {gladiator1.LastName}");
					return gladiator1.Id;
				}
				if (FightResult(gladiator2, gladiator1) == 1)
				{
					Console.WriteLine("Fin du duel!");
					Console.WriteLine($"Le vainceur est {gladiator2.FirstName} {gladiator2.LastName}");
					return gladiator2.Id;
				}
			}
		}
		private static int FightResult(Gladiator attacker, Gladiator defender)
		{
			int attackerHit = attacker.Weapon;
			int defense = defender.Shield;

			int dommage = attackerHit - defense;
			string point = "point";

			if(dommage > 0)
			{
				defender.Health -= dommage;
			}
			else
			{
				dommage = 0;
			}
			if(dommage > 1)
			{
				point = "points";
			}
			Console.WriteLine($"{attacker.FirstName} attaque de {attackerHit} sur {defender.FirstName}");
			Console.WriteLine($"{defender.FirstName} perd {dommage} {point} de vie");
			Console.WriteLine($"Points de vie restant : {defender.Health}");

			if (defender.Health <= 0)
			{
				Console.WriteLine($"{attacker.FirstName} remporte le duel face à {defender.FirstName}");
				attacker.Health = 100;
				defender.Health = 100;
				return 1;
			}
			else
			{
				return 0;
			}
		}
	}
}
