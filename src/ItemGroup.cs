namespace MadsKristensen.AddAnyFile
{

    [System.Diagnostics.DebuggerDisplay("{Name, nq}")]
    public class ItemGroup
    {
        public string Name { get; set; }

        public string[] FileList { get; set; }
    }
}