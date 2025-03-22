namespace System.Reflection
{
	[AttributeUsage(AttributeTargets.Assembly,AllowMultiple=false)]
	class AssemblyCompileInformationAttribute : Attribute
	{
		public string CompileDate {get{return "2025-03-22";}}
		public string CompileTime {get{return "13:08:55";}}
	}
}
