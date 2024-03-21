using System;
using System.Collections;

public class SimpleHotUpdateKitInitializer : IAssemblyInitializer
{
    public IEnumerator Initialize()
    {
        AAResInitializer.InitConfig();
        yield break;
    }
}
