using BHD_Demo.Animations.Store.Base;

namespace BHD_Demo.Triggers.Store;

public class BeginAnimation : TriggerAction<VisualElement>
{
    public AnimationBase Animation { get; set; }

    protected override async void Invoke(VisualElement sender)
    {
        if (Animation != null)
        {
            await Animation.Begin();
        }
    }
}