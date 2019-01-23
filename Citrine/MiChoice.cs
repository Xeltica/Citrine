﻿using Citrine.Core.Api;
using Disboard.Misskey.Models;

namespace Citrine.Misskey
{
	public class MiChoice : IChoice
	{
		readonly Choice choice;
		public MiChoice(Choice c)
		{
			choice = c;
			Id = c.Id;
			Text = c.Text;
			Count = c.Votes;
		}

		public int Id { get; }

		public string Text { get; }

		public long Count { get; }
	}


}
