using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TextRPG;

namespace TextRPG
{

	public class Enemy : TextRPG.Character
	{
		public string Description { get; set; }

		public override void TakeDamage(int amount)
		{
			base.TakeDamage(amount);
			UIController.OnEnemyUpdate(this);
			Debug.Log("This also happens");
		}

		public override void Die()
		{
			Encounter.OnEnemyDie();
			Energy = MaxEnergy;
			Debug.Log("Character died, was enemy");
		}
	}
}

