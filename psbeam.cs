using System.Management.Automation;

namespace psbeam
{
	[Cmdlet(VerbsCommunications.Send,"Greeting")]
	public class PsBeam:Cmdlet
	{
		[Parameter(Mandatory=true)]
		public string Name {get; set;}

		protected override void ProcessRecord()
		{
			WriteObject($"Hello {Name}!");
		}
	}
}