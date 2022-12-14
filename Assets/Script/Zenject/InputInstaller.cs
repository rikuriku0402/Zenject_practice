using UnityEngine;
using Zenject;

public class InputInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container
            .Bind<IInputProbider>()//IInputProviderがあるとき
            .To<NormalInputProvider>()//InputProviderを注入する
            .AsCached();            //生成済みなら使いまわす
    }
}