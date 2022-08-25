using UnityEngine;
using Zenject;

public class ReverseInputInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container
            .Bind<IInputProbider>()//IInputProvider‚ª‚ ‚é‚Æ‚«
            .To<UniqueInputProvider>()//InputProvider‚ğ’“ü‚·‚é
            .AsCached();            //¶¬Ï‚İ‚È‚çg‚¢‚Ü‚í‚·
    }
}