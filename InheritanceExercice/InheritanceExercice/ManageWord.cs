using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercice
{
	public class ManageWord : IDisposable
	{
		public int animalId { get; set; }
		public int legs { get; set; }
		public string species { get; set; }
		public string habitat { get; set; }

		// Flag to checj if the object has been disposed.
		private bool disposed = false;

		StreamReader sr;
		StreamWriter outputFile;

		public void ReadDetails(string fileName)
		{
			sr = new StreamReader(fileName);

			try
			{
				using (sr)
				{
					//Read the stream to a string, and write the string to the console.
					string line = sr.ReadToEnd();
					Console.WriteLine(line);
				}

			}
			catch (Exception e)
			{
				Console.WriteLine("The file could not be read:");
				Console.WriteLine(e.Message);
				
			}
			finally
			{
				sr.Close();
				sr = null;
			}
		}

		public bool WriteDetails(string fileName)
		{
			bool result = false;
			outputFile = new StreamWriter(fileName);

			//Create a string array with the lines of text
			string[] lines = { this.animalId.ToString(), this.legs.ToString(), this.species, this.habitat };

			try
			{
				//write the string array to a new file
				using (outputFile)
				{
					foreach (string line in lines)
					{
						outputFile.WriteLine(line);
					}
					result = true;
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("This file could not be written");
				Console.WriteLine(e.Message);
				result = false;
			}
			finally
			{
				outputFile.Close();
				outputFile = null;
			}
			return result;

		}


		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposed)
			{
				if (disposing)
				{
					if (sr != null)
					{
						sr.Close();
					}

					if (outputFile != null)
					{
						outputFile.Close();
					}
				}
			}
			disposed = true;
		}

	}
}
