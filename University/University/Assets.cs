namespace MyApplication;

public abstract class Assets
{
    public string NameAssets { get; set;}
    public Assets(string nameAssets)
    { 
        NameAssets = nameAssets;
    }
    
}
