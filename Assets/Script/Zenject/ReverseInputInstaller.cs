using UnityEngine;
using Zenject;

public class ReverseInputInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container
            .Bind<IInputProbider>()//IInputProviderがあるとき
            .To<UniqueInputProvider>()//InputProviderを注入する
            .AsCached();            //生成済みなら使いまわす
    }
}