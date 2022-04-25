using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DokaModInterface
{
	internal class Ini
	{
		private readonly Dictionary<string, Dictionary<string, string>> dict;

		public Dictionary<string, string> this[string key]
		{
			get
			{
				if (!dict.ContainsKey(key))
				{
					dict[key] = new();
				}
				return dict[key];
			}
			set
			{
				if (!dict.ContainsKey(key))
				{
					dict[key] = new();
				}
			}
		}

		public string this[string key1, string key2]
		{
			get
			{
				if (!this[key1].ContainsKey(key2))
				{
					return null;
				}
				return this[key1][key2];
			}
			set
			{
				this[key1][key2] = value;
			}
		}

		private Ini() { this.dict = new(); }

		public static Ini Load(string file)
		{
			if (!File.Exists(file))
			{
				File.Create(file).Close();
			}
			Ini ret = new();

			string? section = null;
			string[] line_split;
			foreach (string line in File.ReadAllLines(file))
			{
				if (line.StartsWith('#') || string.IsNullOrEmpty(line) || string.IsNullOrWhiteSpace(line))
				{
					continue;
				}
				if (line.Contains('[') && line.Contains(']'))
				{
					section = line[1..^1].Trim();
				}
				if (section == null)
				{
					section = "";
				}
				line_split = line.Split('=');
				if (line_split.Length != 2)
				{
					continue;
				}
				ret[section][line_split[0].Trim()] = line_split[1].Trim();
			}

			return ret;
		}

		public void Save(string file)
		{
			StreamWriter writer = new(File.Create(file));
			KeyValuePair<string, Dictionary<string, string>> current_dict;
			for (int i = 0; i < dict.Count; i++)
			{
				current_dict = dict.ElementAt(i);
				writer.WriteLine($"[{current_dict.Key}]");
				foreach ((string key, string value) in current_dict.Value)
				{
					writer.WriteLine($"{key} = {value}");
				}
				writer.WriteLine();
			}
			writer.Flush();
			writer.Close();
		}
	}
}
