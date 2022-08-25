using UnityEngine;
using Zenject;

public class ReverseInputInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container
            .Bind<IInputProbider>()//IInputProvider������Ƃ�
            .To<UniqueInputProvider>()//InputProvider�𒍓�����
            .AsCached();            //�����ς݂Ȃ�g���܂킷
    }
}