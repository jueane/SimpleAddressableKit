using UnityEngine.AddressableAssets;

public static class AAResInitializer
{
    public static void InitConfig(string loadPath)
    {
        Addressables.LoadContentCatalogAsync($"{loadPath}/{AAResConst.aa_config_file}");
        Addressables.InternalIdTransformFunc = location =>
        {
            var key = location.InternalId;
            if (key.EndsWith(".bundle"))
            {
                key = key.Replace(AAResConst.aa_placeholder, loadPath);
                return key;
            }

            return location.InternalId;
        };
    }
}
