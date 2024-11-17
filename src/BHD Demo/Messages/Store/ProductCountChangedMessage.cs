using CommunityToolkit.Mvvm.Messaging.Messages;

namespace BHD_Demo.Messages.Store;
public class ProductCountChangedMessage(int count) : ValueChangedMessage<int>(count);