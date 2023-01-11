namespace MyApplication;

internal abstract class Assets
{
    public string NameAssets { get; set;}
    public Assets(string nameAssets)
    { 
        NameAssets = nameAssets;
    }

}
